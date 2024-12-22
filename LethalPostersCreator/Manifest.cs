using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;

namespace LethalPostersCreator
{
    internal class Manifest
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Version { get; set; }
        public string Description { get; set; }
        public string[] Dependencies { get; set; }
        public Manifest()
        {
            Name = "LethalPostersAddon";
            Author = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            Version = "1.0.0";
            Description = "A mod that adds custom posters in the game";
            Dependencies = new string[] { "femboytv-LethalPosters-1.2.3", "femboytv-LethalPaintings-1.2.3" };
        }
    }
}
