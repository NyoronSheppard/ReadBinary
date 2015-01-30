using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCalculator.Models
{
    public class DecimalToBase
    {
        int dec;

        //Constructor
        public DecimalToBase(int dec)
        {
            this.dec = dec;
        }

        //To Binary
        public string getDecimalToBinary()
        {
            return Convert.ToString(dec, 2);
        }

        //To Octal
        public string getDecimalToOctal()
        {
            return Convert.ToString(dec, 8);
        }

        //To Hexadecimal
        public string getDecimalToHexadecimal()
        {
            return dec.ToString("X");
        }
    }
}
