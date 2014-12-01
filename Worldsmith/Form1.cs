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
        private Point cachedMousePos = Point.Empty;

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
            try
            {
                // Browse for project directory.
                projectFolderBrowserDialog.ShowDialog();
                AssignProjectFolder(projectFolderBrowserDialog.SelectedPath);

                if (projectRoot == null) return;

                StreamReader reader = new StreamReader(projectRoot + "/" + "Test World" + ".json");
                string input = reader.ReadToEnd();
                reader.Close();
                reader.Dispose();

                World = JsonConvert.DeserializeObject<World>(input);

                mapTabControl.TabPages.Clear();
                openMaps.Clear();
                OpenMapInNewTab(World.Maps[World.WorldMapName]);
            }
            catch
            {
                MessageBox.Show("Error loading World. Exited process early.");
            }
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
            SetActiveMapImage(mapTabControl.SelectedTab, CurrentOpenMap, "Main");
        }

        private void tabPictureBox_MouseMove(object sender, MouseEventArgs e)
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

        private void mapContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            cachedMousePos = Cursor.Position;
        }

        private void createLandmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Props to Cody Gray on Stack Overflow
            // Try to cast the sender to a ToolStripItem
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                // Retrieve the ContextMenuStrip that owns this ToolStripItem
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    // Get the control that is displaying this context menu
                    Control sourceControl = owner.SourceControl;
                    Point controlPoint = sourceControl.PointToClient(cachedMousePos);
                    CreateLandmarkForm form = new CreateLandmarkForm(CurrentOpenMap);
                    form.ShowDialog();
                    if (form.Valid)
                    {
                        Landmark landmark = CreateNewLandmark(form);
                        ConstructLandmarkButton(landmark, sourceControl, landmark.Position);
                    }
                }
            }
            cachedMousePos = Point.Empty;
        }

        #endregion Forms Initialization

        #region Public Methods

        public void OpenMapInNewTab(Map map)
        {
            TabPage newMapPage = new TabPage(map.Name);
            mapTabControl.TabPages.Add(newMapPage);
            openMaps.Add(map);
            SetActiveMapImage(mapTabControl.SelectedTab, CurrentOpenMap, "Main");
        }

        public World CreateNewWorld(NewWorldForm form)
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

                // Return reference to new World.
                return World;
            }

            // Failure, return null.
            return null;
        }

        public Landmark CreateNewLandmark(CreateLandmarkForm form)
        {
            // Make sure the form is valid before proceeding.
            if (form.Valid)
            {

                // TODO: Check for unsaved changes and prompt a save.

                // Instantiate new landmark.
                Landmark landmark = new Landmark(form.Name, cachedMousePos);

                // Apply changes to map.
                CurrentOpenMap.AddLandmark(landmark);

                // Return reference to the new landmark.
                return landmark;
            }

            // Failure, return null.
            return null;
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

        public void SetActiveMapImage(TabPage tab, Map map, string imageKey)
        {
            tab.Controls.Clear();
            PictureBox tabPictureBox = new PictureBox();
            tabPictureBox.ContextMenuStrip = mapContextMenuStrip;
            tab.Controls.Add(tabPictureBox);

            if (map.Images.Count > 0)
            {
                tabPictureBox.Image = Image.FromFile(ResourcesDirectory + map.Images[imageKey]);
                tabPictureBox.Size = tabPictureBox.Image.Size;

                tabPictureBox.MouseMove += tabPictureBox_MouseMove;
            }

            foreach (Landmark l in map.Landmarks.Values)
            {
                ConstructLandmarkButton(l, tabPictureBox, l.Position);
            }
        }

        public void ConstructLandmarkButton(Landmark landmark, Control container, Point position)
        {
            Button btn = new Button();
            container.Controls.Add(btn);
            btn.Name = "btn" + landmark.Name;
            btn.Tag = landmark.Name;
            btn.Width = 30;
            btn.Height = 30;
            btn.Location = new Point(position.X - btn.Width / 2, position.Y - btn.Height / 2);
        }

        #endregion Public Methods
    }
}