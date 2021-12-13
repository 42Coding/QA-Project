using System;
using System.Collections.Generic;
using System.Text;

namespace QA_Project
{
    class QA42
    {
        private static String WarningMessage = "max. 255 characters length";
        
        private Boolean IsValid(String value)
        {
            return (value.Length < 256);
        }
        private String question = String.Empty;
        public String Question
        {
            get 
            {
                return question;
            }
            set 
            {
                string _value = value.ToString();
                if (IsValid(_value))
                {
                    this.question = _value;
                }
                else
                {
                    Console.WriteLine("Question "+ WarningMessage);
                }
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
                string _value = value.ToString();
                if (IsValid(_value))
                {
                    this.awnsers.Add(_value);
                }
                else
                {
                    Console.WriteLine("Awnser " + WarningMessage);
                }
            }
        }
        public List<String> Match(String value)
        {
            bool match = value.Equals(question);
            if(match)
            {
                return Awnsers;
            }
            return null;
        }
    }
}
