using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  using System.Xml.Linq;
  using SC2Unit.ViewModels;
  
  namespace SC2Unit
  {
      public class XMLparser
      {
  
          string URL { get; set; }
          XDocument Doc { get; set; }
  
          public XMLparser()
          {
            
          }
      
  
 
         public void Load(Race race)
         {
             this.LoadRaceBO(race);
             this.LoadRaceBuilding(race);
             this.LoadRaceUnit(race);
         }
 
         private void LoadRaceBO(Race race)
         {
             try
             {
 
                 Doc = XDocument.Load("Assets/Data/buildOrders.xml");
                 XElement generalElement = Doc.Element("Race");
 
                 race.BuildOrders = (from c in generalElement.Element(race.Title).Elements("BuildOrder")
                                     select new BuildOrder()
                                   {
                                       Title = c.Attribute("Title").Value,
                                   
                                   }).ToList<BuildOrder>();
 
             }
             catch (Exception e)
             {
                 System.Diagnostics.Debug.WriteLine(e);
             }
         }
 
         
          public void LoadRaceBuilding(Race race)
          {
              
              try
              {
  
                  Doc = XDocument.Load("Assets/Data/building.xml");            
                  XElement generalElement = Doc.Element("Race");
  
                  race.Buildings = (from c in generalElement.Element(race.Title).Elements("Building")
                                select new Building()
                                {
                                    ID = Convert.ToInt32(c.Attribute("ID").Value),
                                    Title = c.Attribute("Title").Value,
                                    ImgPath = c.Attribute("ImgPath").Value
                                    
  
                                }).ToList<Building>();
                  
              }
              catch (Exception e)
              {
                  System.Diagnostics.Debug.WriteLine(e);
              }
  
              
          }
  
  
          public void LoadRaceUnit(Race race)
          {
             
  
              try
              {
                  
                  Doc = XDocument.Load("Assets/Data/unit.xml");
                  XElement generalElement = Doc.Element("Race");
                  
  
                  race.Unites = (from c in generalElement.Element(race.Title).Elements("unit")
                                    select new Unit()
                                    {
                                        ID = Convert.ToInt32(c.Attribute("ID").Value),
                                        Title = c.Attribute("Title").Value,
                                        ImgPath = c.Attribute("ImgPath").Value
                                        
  
  
                                     }).ToList<Unit>();
  
  
              }
              catch (Exception e)
              {
                  System.Diagnostics.Debug.WriteLine(e);
              }
  
  
          }
  
  
          public Upgrade LoadUpgrade(string selectedItem)
          {
              Doc = XDocument.Load("Assets/Data/UpgradeAndAbility.xml");            
              XElement generalElement = Doc.Element("Race");
              Upgrade upgrade = new Upgrade();
  
              XElement c = generalElement.Elements().Elements("Upgrades").Elements("Upgrade").Where(d => d.Attribute("Title").Value == selectedItem).First();
  
              upgrade = new Upgrade()
              {
                  ImgPath = c.Attribute("ImgPath").Value,
                  Title = c.Attribute("Title").Value
  
              };
  
               return upgrade;
  
          }
  
          public Ability LoadAbility(string selectedItem)
          {
              Doc = XDocument.Load("Assets/Data/UpgradeAndAbility.xml");
              XElement generalElement = Doc.Element("Race");
              Ability ability = new Ability();
  
              XElement c = generalElement.Elements().Elements("Abilities").Elements("Ability").Where(d => d.Attribute("Title").Value == selectedItem).First();
  
              ability = new Ability()
              {
                  ImgPath = c.Attribute("ImgPath").Value,
                  Title = c.Attribute("Title").Value
  
              };
  
              return ability;
          }
  
          public Unit LoadUnit(string selectedItem)
          {
              Unit unit ;
              Doc = XDocument.Load("Assets/Data/unit.xml");
              XElement generalElement = Doc.Element("Race");
              
              XElement c = generalElement.Elements().Elements("unit").Where(d => d.Attribute("Title").Value == selectedItem).First();
  
              //System.Diagnostics.Debug.WriteLine(c);
  
              unit = new Unit()
              {
                  ID = Convert.ToInt32(c.Attribute("ID").Value),
                  Title = c.Attribute("Title").Value,
                  ImgPath = c.Attribute("ImgPath").Value,
                  Minerai = Convert.ToInt32(c.Attribute("Minerai").Value),
                  Vespene = Convert.ToInt32(c.Attribute("Vespene").Value),
                  Ravitaillement = Convert.ToInt32(c.Attribute("Ravitaillement").Value),
                  Construction_Time = Convert.ToInt32(c.Attribute("Construction_Time").Value),
                  Vie = Convert.ToInt32(c.Attribute("Vie").Value),
                  Energie = Convert.ToInt32(c.Attribute("Energie").Value),
                  Armure = Convert.ToInt32(c.Attribute("Armure").Value),
                  Bouclier = Convert.ToInt32(c.Attribute("Bouclier").Value),
                  BuildIn = c.Attribute("BuildIn").Value,
  
                  UnitWeapon = new Weapon()
                  {
                      Title = c.Element("Weapon").Attribute("Title").Value,
                      ImgPath = c.Element("Weapon").Attribute("ImgPath").Value,
                      Range = Convert.ToInt32(c.Element("Weapon").Attribute("Range").Value),
                      Damage = Convert.ToInt32(c.Element("Weapon").Attribute("Damage").Value)
                  },
  
                  StrongAgainst = (from d in c.Descendants("StrongAgainst").Elements("unit")
                                   select new Unit()
                                   {
                                       Title = d.Attribute("Title").Value,
                                       ImgPath = d.Attribute("ImgPath").Value
                                   }).ToList<Unit>(),
  
                  WeakAgainst = (from f in c.Descendants("WeakAgainst").Elements("unit")
                                 select new Unit()
                                 {
                                     Title = f.Attribute("Title").Value,
                                     ImgPath = f.Attribute("ImgPath").Value
                                 }).ToList<Unit>(),
  
                  Abilities = (from f in c.Descendants("Abilities").Elements("Ability")
                               select new Ability()
                               {
                                   Title = f.Attribute("Title").Value,
                                   ImgPath = f.Attribute("ImgPath").Value
                               }).ToList<Ability>(),
  
                  Upgrades = (from f in c.Descendants("Upgrades").Elements("Upgrade")
                              select new Upgrade()
                              {
                                  Title = f.Attribute("Title").Value,
                                  ImgPath = f.Attribute("ImgPath").Value
                              }).ToList<Upgrade>()
  
              };
  
              return unit;
          }
  
  
  
          public Building LoadBuilding(string selectedItem)
          {
  
              try
              {
                  Building building ;
                  Doc = XDocument.Load("Assets/Data/building.xml");
                  XElement generalElement = Doc.Element("Race");
  
  
  
                  XElement c = generalElement.Elements().Elements("Building").Where(d => d.Attribute("Title").Value == selectedItem).First();
  
                   building = new Building()
                                    {
                                        ID = Convert.ToInt32(c.Attribute("ID").Value),
                                        Title = c.Attribute("Title").Value,
                                        ImgPath = c.Attribute("ImgPath").Value,
                                        Minerai = Convert.ToInt32(c.Attribute("Minerai").Value),
                                        Vespene = Convert.ToInt32(c.Attribute("Vespene").Value),
                                        Ravitaillement = Convert.ToInt32(c.Attribute("Ravitaillement").Value),
                                        Construction_Time = Convert.ToInt32(c.Attribute("Construction_Time").Value),
                                        Vie = Convert.ToInt32(c.Attribute("Vie").Value),
                                        Energie = Convert.ToInt32(c.Attribute("Energie").Value),
                                        Armure = Convert.ToInt32(c.Attribute("Armure").Value),
                                        Bouclier = Convert.ToInt32(c.Attribute("Bouclier").Value),
                                        Require = (from d in c.Descendants("Require").Elements("Building")
                                                   select new Building()
                                                   {
                                                       Title = d.Attribute("Title").Value,
                                                       ImgPath = d.Attribute("ImgPath").Value
                                                   }).ToList<Building>(),
  
                                        GrantAccessTo = (from f in c.Descendants("GrantAccessTo").Elements("Building")
                                                         select new Building()
                                                         {
                                                             Title = f.Attribute("Title").Value,
                                                             ImgPath = f.Attribute("ImgPath").Value
                                                         }).ToList<Building>(),
  
                                        Abilities = (from f in c.Descendants("Abilities").Elements("Ability")
                                                     select new Ability()
                                                     {
                                                         Title = f.Attribute("Title").Value,
                                                         ImgPath = f.Attribute("ImgPath").Value
                                                     }).ToList<Ability>(),
  
                                        Upgrades = (from f in c.Descendants("Upgrades").Elements("Upgrade")
                                                    select new Upgrade()
                                                    {
                                                        Title = f.Attribute("Title").Value,
                                                        ImgPath = f.Attribute("ImgPath").Value
                                                    }).ToList<Upgrade>(),
  
                                        CanProduce = (from f in c.Descendants("CanProduce").Elements("Unit")
                                                      select new Unit()
                                                      {
                                                          Title = f.Attribute("Title").Value,
                                                          ImgPath = f.Attribute("ImgPath").Value

                                                      }).ToList<Unit>(),
  
                                     
                                       CanResearch = (from f in c.Descendants("CanResearch").Elements("Upgrade")
                                                       select new Upgrade()
                                                       {
                                                           Title = f.Attribute("Title").Value,
                                                           ImgPath = f.Attribute("ImgPath").Value
                                                       }).ToList<Upgrade>()
  
                                    };
                  return building;
  
              }
              catch (Exception e)
              {
                  System.Diagnostics.Debug.WriteLine(e);
                  return null;
              }
  
              
          }
 
         public BuildOrder LoadBO(string selectedItem)
         {
 
 
             Doc = XDocument.Load("Assets/Data/buildOrders.xml");
             XElement generalElement = Doc.Element("Race");
             BuildOrder buildOrder;
 
             XElement c = generalElement.Elements().Elements("BuildOrder").Where(d => d.Attribute("Title").Value == selectedItem).First();
 
             buildOrder = new BuildOrder()
             {
                 Title = c.Attribute("Title").Value,
                 Orders = (from d in c.Descendants("Order")
                  select new Order()
                  {
                     Timing = Convert.ToInt32(d.Attribute("Timing").Value),
                     Content = (string)d.Attribute("Content").Value
 
 
                  }).ToList<Order>(),
 
             };
 
             
 
             return buildOrder;
         }
      }
  }


