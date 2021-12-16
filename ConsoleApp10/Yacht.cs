using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Yacht
    {
            internal int ID { get; set; }
            internal string Title { get; set; }
            internal string ProductionDate { get; set; }
            internal int NumberOfCabins { get; set;}
            internal bool Sail { get; set; }
        internal bool Status { get; set; }
            internal double Money { get; set; }
        public string Key { get; internal set; }

        internal Yacht(int id, string title, string productiondate, int numderofcabins, bool sail,  double money, bool status)
            {
                ID = id;
                Title = title;
                ProductionDate = productiondate;
                NumberOfCabins = numderofcabins;
                Sail = sail;
                Money = money;
            Status = status;
            }

            internal string GetInfo()
            {
                return $"ID: {ID}, Title:{Title}, ProductionDate: {ProductionDate}, NumberOfCabins:{NumberOfCabins}, Sail:{Sail} Money:{Money} rub.";
            }
        }
    }


