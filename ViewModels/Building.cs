using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SC2Unit.ViewModels
{
    
    public class Building
    {
        public Building()
        {
            Require = new List<Building>();
            GrantAccessTo = new List<Building>();
            CanProduce = new List<Unit>();
            CanResearch = new List<Upgrade>();
            Abilities = new List<Ability>();
            Upgrades = new List<Upgrade>();
        }
         
        public int ID { get; set; }
        public string Title { get; set; }
        public string ImgPath { get; set; }
        public int Minerai { get; set; }
        public int Vespene { get; set; }
        public int Ravitaillement { get; set; }
        public int Construction_Time { get; set; }
        public int Vie { get; set; }
        public int Energie { get; set; }
        public int Armure { get; set; }
        public int Bouclier { get; set; }

        public List<Building> Require { get; set; }
        public List<Building> GrantAccessTo { get; set; }
        public List<Unit> CanProduce { get; set; }
        public List<Upgrade> CanResearch { get; set; }
        public List<Ability> Abilities { get; set; }
        public List<Upgrade> Upgrades { get; set; }
        
    }
}
