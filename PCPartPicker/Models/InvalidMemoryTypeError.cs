using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCPartPicker.Forms
{
    //Custom exception to be thrown when memory types are a mismatch
    internal class InvalidMemoryTypeError : Exception
    {
        private const string errorMessage = "Invalid configuration, Memory types do not match between selected RAM and Motherboard!";
        public InvalidMemoryTypeError() : base(errorMessage) { }
    }
}
