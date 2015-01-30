using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCalculator.Models
{
    public class OctalToBase
    {
        int oct;

        //Constructor 
        public OctalToBase(int oct)
        {
            this.oct = oct;
        }

        //Octal to Decimal
        public string getOctalToDecimal()
        {
            return Convert.ToInt32(oct.ToString(), 8).ToString();
        }

        //Octal to Binary
        public string getOctalToBinary()
        {
            //Octal to Decimal
            string decNum = getOctalToDecimal();

            //Decimal to Binary
            DecimalToBase decT = new DecimalToBase(int.Parse(decNum));

            return decT.getDecimalToBinary();

        }

        //Octal to Hexadecimal
        public string getOctalToHexadecimal()
        {
            //Octal to Decimal
            string decNum = getOctalToDecimal();

            //Decimal to Hexadecimal
            DecimalToBase decT = new DecimalToBase(int.Parse(decNum));

            return decT.getDecimalToHexadecimal();
        }
    }
}
