#region Using Statements
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Threading;
#endregion Using Statements

namespace Worldsmith
{
    public partial class ApplicationForm : Form
    {
        private string projectRoot;

        private string ResourcesDirectory { get { return projectRoot + "\\Resources\\"; } }

        public World World { get; set; }

        private List<Map> openMaps = new List<Map>();

        private Map CurrentOpenMap { get { return openMaps[mapTabControl.SelectedIndex]; } }

        private Point prevMousePos = Point.Empty;

        #region Forms Initialization

        public ApplicationForm()
        {
            InitializeComponent();
        }

        private void newWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewWorldForm newWorldForm = new NewWorldForm();
            newWorldForm.ShowDialog();
            
            CreateNewWorld(newWorldForm);
        }

        private void openWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Browse for project directory.
            projectFolderBrowserDialog.ShowDialog();
            AssignProjectFolder(projectFolderBrowserDialog.SelectedPath);

            if (projectRoot == null) return;

            StreamReader reader = new StreamReader(projectRoot + "/Test World.json");
            string input = reader.ReadToEnd();
            reader.Close();
            reader.Dispose();

            World = JsonConvert.DeserializeObject<World>(input);

            mapTabControl.TabPages.Clear();
            openMaps.Clear();
            OpenMapInNewTab(World.Maps[World.WorldMapName]);
        }

        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveWorld();
        }

        private void addImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openImageDialogue.ShowDialog();
        }

        private void openImageDialogue_FileOk(object sender, CancelEventArgs e)
        {
            string path = openImageDialogue.FileName;
            string saveName = ResourcesDirectory + "TestImage.jpg";
            File.Copy(path, saveName, true);
            CurrentOpenMap.AddImage("Main", "TestImage.jpg");
            string imagePath = ResourcesDirectory + CurrentOpenMap.Images["Main"];
            mapTabControl.SelectedTab.BackgroundImage = Image.FromFile(imagePath);
        }

        #endregion Forms Initialization

        #region Public Methods

        public void OpenMapInNewTab(Map map)
        {
            TabPage newMapPage = new TabPage(map.Name);
            PictureBox tabPictureBox = new PictureBox();
            newMapPage.Controls.Add(tabPictureBox);
            mapTabControl.TabPages.Add(newMapPage);
            openMaps.Add(map);

            if (map.Images.Count > 0)
            {
                tabPictureBox.Image = Image.FromFile(ResourcesDirectory + map.Images["Main"]);
                tabPictureBox.Size = tabPictureBox.Image.Size;
                /*
                tabPictureBox.MouseDown += tabPictureBox_MouseDown;
                tabPictureBox.MouseUp += tabPictureBox_MouseUp;
                 */

                tabPictureBox.MouseMove += tabPictureBox_MouseMove;
            }
        }

        void tabPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            if ((Control.MouseButtons & MouseButtons.Left) != 0)
            {
                int deltaX = MousePosition.X - prevMousePos.X;
                int deltaY = MousePosition.Y - prevMousePos.Y;
                Point newLocation = new Point(pic.Location.X + deltaX, pic.Location.Y + deltaY);

                Rectangle bounds = pic.Parent.Bounds;

                // Clamp y properly
                if (pic.Height > bounds.Height)
                {
                    if (newLocation.Y > 0)
                    {
                        newLocation.Y = 0;
                    }
                    if (newLocation.Y < bounds.Height - pic.Height)
                    {
                        newLocation.Y = bounds.Height - pic.Height;
                    }
                }
                else
                {
                    if (newLocation.Y < 0)
                    {
                        newLocation.Y = 0;
                    }
                    if (newLocation.Y > bounds.Height - pic.Height)
                    {
                        newLocation.Y = bounds.Height - pic.Height;
                    }
                }

                // Clamp x properly
                if (pic.Width > bounds.Width)
                {
                    if (newLocation.X > 0)
                    {
                        newLocation.X = 0;
                    }
                    if (newLocation.X < bounds.Width - pic.Width)
                    {
                        newLocation.X = bounds.Width - pic.Width;
                    }
                }
                else
                {
                    if (newLocation.X < 0)
                    {
                        newLocation.X = 0;
                    }
                    if (newLocation.X > bounds.Width - pic.Width)
                    {
                        newLocation.X = bounds.Width - pic.Width;
                    }
                }

                pic.Location = newLocation;
            }
            prevMousePos = MousePosition;
        }

        public void CreateNewWorld(NewWorldForm form)
        {
            // Make sure the form is valid before proceeding.
            if (form.Valid)
            {

                // TODO: Check for unsaved changes and prompt a save.

                // Instantiate new world.
                World = new World(form.WorldName);
                World.Description = form.WorldDescription;
                World.WorldMapName = form.WorldMapName;
                AssignProjectFolder(form.WorldDirectory);

                // Clear map controls.
                mapTabControl.TabPages.Clear();
                openMaps.Clear();

                // Create the world map for the user.
                Map worldMap = new Map(World.WorldMapName);
                World.AddMap(worldMap);

                // Open the world map in the tab control.
                OpenMapInNewTab(worldMap);

                // Save the new world.
                SaveWorld();
            }
        }

        public void AssignProjectFolder(string filepath)
        {
            if (filepath == null || filepath.Length == 0)
            {
                return;
            }
            else
            {
                projectRoot = filepath;
            }
        }

        public void SaveWorld()
        {
            if (projectRoot == null)
            {
                return;
            }
            // World doesn't exist.
            if (World == null)
            {
                // TODO: Handle issue that world does not exist.
                throw new Exception("World does not exist.");
            }
            // Success!
            else
            {
                string output = World.ToString();
                StreamWriter writer = new StreamWriter(projectRoot + "\\" + World.Name + ".json");
                writer.Write(output);
                writer.Close();
                writer.Dispose();

                // Check for automatically generated directories.
                if (!Directory.Exists(ResourcesDirectory))
                {
                    Directory.CreateDirectory(ResourcesDirectory);
                }
            }
        }

        #endregion Public Methods
    }
}
