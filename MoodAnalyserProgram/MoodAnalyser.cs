using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProgram
{
    public class MoodAnalyser
    {
        string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public MoodAnalyser()
        {

        }
<<<<<<< HEAD

=======
>>>>>>> UC5ParameterizedConst
        public string AnalyzeMood()
        {
            try
            {
<<<<<<< HEAD
                if(message == null)
=======
                if (message == null)
>>>>>>> UC5ParameterizedConst
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_EXCEPTION, "Mood should not be null");
                }
                if (message.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_EXCEPTION, "Mood should not be empty");
                }
                if (this.message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch (Exception ex)
            {
<<<<<<< HEAD
                return ex.Message;
=======
                return ex.Message ;
>>>>>>> UC5ParameterizedConst
            }




        }
    }
}
