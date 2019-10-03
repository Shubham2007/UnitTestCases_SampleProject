using System;
using System.Collections.Generic;
using System.Text;

namespace BankOperation
{
    public abstract class Manage
    {
        private string _message;
        public string SetMessage(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                return "Not Valid";

            this._message = message;
            return this._message;
        }
    }
}
