﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDAutomation.Test_Framework.Core
{
    class MissingElementException : Exception
    {
        public MissingElementException(string message) : base(message)
        {

        }

        public MissingElementException(string message, Exception cause) : base(message, cause)
        {

        }
    }
}
