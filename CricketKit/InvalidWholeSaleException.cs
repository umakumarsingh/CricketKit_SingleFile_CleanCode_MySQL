using System;
using System.Collections.Generic;
using System.Text;

namespace CricketKit
{
    [Serializable]
    public class InvalidWholeSaleException : Exception 
    {
        public string PurchaseDetails { get; set; }
        public InvalidWholeSaleException() { }

        public InvalidWholeSaleException(string message)
            : base(message) { }

        public InvalidWholeSaleException(string message, Exception inner)
            : base(message, inner) { }

        public InvalidWholeSaleException(string message, string str)
        : this(message)
        {
            PurchaseDetails = str;
        }
    }
}
