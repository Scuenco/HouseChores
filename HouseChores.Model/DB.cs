using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseChores.Model
{
    public static class DB
    {
        private static List<Kitchen> _kchores { get; set; }
        private static List<Bedroom> _bchores { get; set; }
        public static List<Kitchen> KitchenChores
        {
            get
            {
                if (_kchores == null)
                {
                    _kchores = new List<Kitchen>() {
                        new Kitchen("Cooking"),
                        new Kitchen("Washing the dishes"),
                        new Kitchen("Cleaning the floor"),
                    };
                }
                return _kchores;
            }
            set
            {
                _kchores = value;
            }
        }
        public static List<Bedroom> BedroomChores
        {
            get
            {
                if (_bchores == null)
                {
                    _bchores = new List<Bedroom>() {
                        new Bedroom("Change bedsheets"),
                        new Bedroom("Clean the closet"),
                        new Bedroom("Fold the blanket")
                    };
                }
                return _bchores;
            }
            set
            {
                _bchores = value;
            }
        }
    }
}
