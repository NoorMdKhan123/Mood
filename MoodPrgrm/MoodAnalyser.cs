﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoodPrgrm
{


    public class MoodAnalyser
    {
        public MoodAnalyser()
        {

        }
        private string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException
                        (MoodAnalyserCustomException.ExceptionType.Empty_Message,
                        "Mood should not be empty");
                }
                if(this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else

                {
                    return "HAPPY";
                }

            }
            catch (NullReferenceException)
            {

                throw new MoodAnalyserCustomException
                    (MoodAnalyserCustomException.
                    ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }

        }
    }
}