using System;
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
<<<<<<< HEAD
            NULL_EXCEPTION,EMPTY_EXCEPTION, CONSTRUCTOR_NOT_FOUND,CLASS_NOT_FOUND
=======
            NULL_EXCEPTION,EMPTY_EXCEPTION,
            CLASS_NOT_FOUND, CONSTRUCTOR_NOT_FOUND
>>>>>>> UC5ParameterizedConst
        }
        public CustomException(ExceptionType type,string message) : base(message)
        {
            this.type = type ;
        }

    }
}
