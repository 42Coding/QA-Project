using System;
using System.Collections.Generic;

namespace QA_Project
{
    class QA42
    {
        private String question = String.Empty;
        public String Question
        {
            get 
            {
                return question;
            }
            set 
            {
                this.question = value.ToString();
            }
        }
        private List<String> awnsers = new List<String>();
        public List<String> Awnsers
        {
            get 
            { 
                return awnsers; 
            }
            set 
            {
                this.awnsers.Add(value.ToString());
            }
        }
        public List<String> Match(String value)
        {
            bool match = value.Equals(question);
            if(match)
            {
                return Awnsers;
            }
            return new List<String>();
        }
    }
}
