using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC2Unit.ViewModels
{
    public class Ability
    {
        public Ability()
        {
          // System.Diagnostics.Debug.WriteLine("Ability Built");
        }

        public string Title { get; set; }
        public string ImgPath { get; set; }
    }
}
