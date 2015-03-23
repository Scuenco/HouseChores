using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseChores.Model
{
    public class DB
    {
        private List<Kitchen> _kchores { get; set; }
        private List<Bedroom> _bchores { get; set; }
        public List<Kitchen> KitchenChores
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
        public List<Bedroom> BedroomChores
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
