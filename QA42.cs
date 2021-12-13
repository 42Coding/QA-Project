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
        private List<String> answers = new List<String>();
        public List<String> Answers
        {
            get
            { 
                return answers; 
            }
            set 
            {
                this.answers.Add(value.ToString());
            }
        }
        public List<String> Match(String value)
        {
            if (value.Equals(question))
            {
                return Answers;
            }
            return new List<String>();
        }
    }
}
