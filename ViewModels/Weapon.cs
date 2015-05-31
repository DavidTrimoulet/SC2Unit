using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC2Unit.ViewModels
{
    public class Weapon
    {
        public Weapon()
        {
           // System.Diagnostics.Debug.WriteLine("Weapon Built");
        }

        public string Title { get; set; }
        public string ImgPath { get; set; }
        public int Range { get; set; }
        public int Damage { get; set; }
    }
}
