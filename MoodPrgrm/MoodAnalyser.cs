﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoodPrgrm
{
    public class MoodAnalyser
    {
        string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            if (this.message.Contains("Sad"))
            {
                return "SAD";
            }
            else

                return "HAPPY";

        }
    }
}