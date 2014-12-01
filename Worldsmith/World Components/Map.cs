using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worldsmith
{
    public class Map
    {
        public string Name { get; set; }
        public Dictionary<string, Landmark> Landmarks;
        public Dictionary<string, string> Images;

        public Map(string name)
        {
            Name = name;
            Landmarks = new Dictionary<string, Landmark>();
            Images = new Dictionary<string, string>();
        }

        public void AddLandmark(Landmark landmark)
        {
            if (Landmarks.ContainsKey(landmark.Name)) return;
            Landmarks.Add(landmark.Name, landmark);
        }

        /// <summary>
        /// Adds a new image to this Map.
        /// </summary>
        /// <param name="title">Title of the new image.</param>
        /// <param name="resourcesPath">Path to the image from the Resources directory.</param>
        public void AddImage(string title, string resourcesPath)
        {
            if (Images.ContainsKey(title))
            {
                Images[title] = resourcesPath;
            }
            else
            {
                Images.Add(title, resourcesPath);
            }
        }
    }
}
