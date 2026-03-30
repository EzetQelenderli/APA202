using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Acces_Modifires_Encupsulation.Models
{
    public class Car
    {
        private int _horsePower;
        public int HorsePower
        {
            get
            {
                return _horsePower;
            }

            set
            {
                _horsePower = value;
            }
        
        }
    }
}
