using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Resources;
using System.Xml;



namespace SC2Unit.ViewModels
{
    public class RaceModel
    {
        private static String basePath = "/Assets/";
        public Race Terran { get; set; }
        public Race Protoss { get; set; }
        public Race Zerg { get; set; }
        public XMLparser Data;

        
        public bool IsDataLoaded { get; set; }
        public void LoadData()
        {
         Data = new XMLparser();

         Terran = CreateTeranUnits();

         Data.Load(Terran);

         Data.LoadRaceBuilding(Terran);
         Data.LoadRaceUnit(Terran);

         Protoss = CreateProtossUnits();
          Data.Load(Protoss);

         Zerg = CreateZergUnits();
         Data.Load(Zerg);

         IsDataLoaded = true;
        }

        

              
        private Race CreateZergUnits()
        {
            Race data = new Race();
            data.Title = "Zerg";
            data.Icon = basePath + data.Title + "/icon-title-zerg.png";
         
            return data;
        }

        private Race CreateProtossUnits()
        {
            Race data = new Race();
            data.Title = "Protoss";
            data.Icon = basePath + data.Title + "/icon-title-protoss.png";
           
            return data;
        }

        private Race CreateTeranUnits()
        {
            Race data = new Race();
            data.Title = "Terran";
            data.Icon = basePath + data.Title + "/icon-title-terran.png";
            
            return data;
        }

 

         public Upgrade FindUpgrade(string selectedItem)
          {
              Upgrade upgrade = new Upgrade();
              upgrade = Data.LoadUpgrade(selectedItem);
              return upgrade;
          }
  
          public Ability FindAbility(string selectedItem)
          {
              Ability ability = new Ability();
              ability = Data.LoadAbility(selectedItem);
              return ability;
          }
  
          public Unit FindUnit(string selectedItem)
          {
              Unit unit = new Unit();
              unit = Data.LoadUnit(selectedItem);
              return unit;
          }
  
  
          public Building FindBuilding(string selectedItem)
          {
              Building building = new Building();
              building = Data.LoadBuilding(selectedItem);
              return building;
          }
 
         public BuildOrder FindBuildOrder(string selectedItem)
         {
            BuildOrder buildOrder = new BuildOrder();
            buildOrder = Data.LoadBO(selectedItem);
            return buildOrder;
         }


    }
}
