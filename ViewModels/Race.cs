using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC2Unit.ViewModels
{
    public class Race
    {
        public Race()
        {
            Unites = new List<Unit>();
            Buildings = new List<Building>();
            Upgrades = new List<Upgrade>();
            BuildOrders = new List<BuildOrder>();
        }

        public string Icon { get; set; }
        public string Title { get; set; }
        public List<Unit> Unites { get; set; }
        public List<Building> Buildings { get; set; }
        public List<Upgrade> Upgrades { get; set; }
        public List<BuildOrder> BuildOrders { get; set; }    
    }
}
