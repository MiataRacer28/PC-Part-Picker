using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCPartPicker.Forms
{
//Custom exception to be thrown when socket types are a mismatch
    internal class InvalidSocketError : Exception
    {
        private const string errorMessage= "Invalid configuration, socket types do not match between selected CPU and Motherboard!";
        public InvalidSocketError():base(errorMessage){}
    }
}
