using System;
using System.Collections.Generic;
using System.Text;

namespace MoodPrgrm
{
    public class MoodAnalyser
    {
        string message;
        
        public string AnalyseMood(string message)
        {
            if (this.message.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }

        }
    }
}
