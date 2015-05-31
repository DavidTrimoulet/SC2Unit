using System;
using System.Collections.Generic;
using System.Text;


namespace SC2Unit.ViewModels
{
    public class BuildOrder
    {
        public BuildOrder()
        {
            Orders = new List<Order>();
            
        }

        public string Title { get; set; }
        public MatchUp MatchUp { get; set; }
        public List<Order> Orders { get; set; }


      
    }
}
