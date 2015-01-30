using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCalculator.Models
{
    public class HexadecimalToBase
    {
        string hex;

        //Constructor
        public HexadecimalToBase(string hex)
        {
            this.hex = hex;
        }

        //Hexadecimal to Decimal
        public string getHexadecimalToDecimal()
        {

            return Convert.ToInt32(hex, 16).ToString();
        }

        //Hexadecimal to Binary
        public string getHexadecimalToBinary()
        {
           return Convert.ToString(Convert.ToInt32(hex.ToString(), 16), 2);
        }

        //Hexadecimal to Octal
        public string getHexadecimalToOctal()
        {
            //Hexadecimal to Decimal
            string hexD = getHexadecimalToDecimal();

            DecimalToBase decT = new DecimalToBase(int.Parse(hexD));

            return decT.getDecimalToOctal();
        }
    }
}
