using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC2Unit.ViewModels
{
    public class Unit
    {

        public Unit()
        {
            StrongAgainst = new List<Unit>();
            WeakAgainst = new List<Unit>();
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
        public string BuildIn { get; set; }
        public int Vie { get; set; }
        public int Energie { get; set; }
        public int Armure { get; set; }
        public int Bouclier { get; set; }
        public Weapon UnitWeapon { get; set; }

        public List<Unit> StrongAgainst { get; set; }
        public List<Unit> WeakAgainst { get; set; }
        public List<Ability> Abilities { get; set; }
        public List<Upgrade> Upgrades { get; set; }

    }
}
