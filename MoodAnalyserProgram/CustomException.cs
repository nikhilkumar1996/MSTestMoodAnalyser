﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProgram
{
    public class CustomException:Exception
    {
        ExceptionType type;
        public enum ExceptionType 
        {
            NULL_EXCEPTION,EMPTY_EXCEPTION, CONSTRUCTOR_NOT_FOUND,CLASS_NOT_FOUND
        }
        public CustomException(ExceptionType type,string message) : base(message)
        {
            this.type = type;
        }

    }
}
