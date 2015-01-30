using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCalculator.Models
{
    public class BinaryToBase
    {
        int bin;

        //Constructor
        public BinaryToBase(int bin)
        {
            this.bin = bin;
        }

        //Binary to Decimal
        public string getBinaryToDecimal()
        {
            return Convert.ToInt32(bin.ToString(), 2).ToString();
        }

        //Binary to Octal
        public string getBinaryToOctal()
        {
            int integer = Convert.ToInt32(bin.ToString(), 2);
            
            return Convert.ToString(integer, 8);
        }

        //Binary to Decimal
        public string getBinaryToHexadecimal()
        {
            return Convert.ToInt32(bin.ToString(), 2).ToString("X");
        }
    }
}
