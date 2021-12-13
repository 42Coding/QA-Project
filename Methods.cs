using System;
using System.Linq;
using System.Collections.Generic;

namespace QA_Project
{
    class Memory
    {
        private List<QA42> memory = new List<QA42>();
        private static String NoMatchMessage = "The answer to life, universe and everything is 42";
        private static String WarningMessage = "max. 255 characters length";
        private char[] separators = new char[] { '?', '"' };
        private Boolean IsValid(String value)
        {
            if (value is null) { return false; }
            return value.Length < 256 && value.Length > 0;
        }
        public void Add(String Line)
        {
            if (Line is null) { Console.WriteLine("[NullException] Question."); return; }
            String Question = Line.Split(separators[0], StringSplitOptions.None)[0].Trim();
            if (IsValid(Question)) // No Question No Awnser
            {
                Question += separators[0];
                String[] Parse = Line.Remove(0, Question.Length).Split(separators[1], StringSplitOptions.None);
                QA42 QA = new QA42();
                QA.Question = Question;
                foreach(var Answers in Parse.Select((value, index) => new { value, index }))
                {
                    string answers = Answers.value.Trim();
                    int index = Answers.index + 1;
                    if (IsValid(answers))
                    {
                        QA.Answers.Add(answers);
                    }
                    else if(index % 2 == 0) // Check index is odd
                    {
                        Console.WriteLine("Awnser ("+index.ToString()+"): " + WarningMessage);
                    }
                }
                memory.Add(QA);
            }
            else
            {
                Console.WriteLine("Question: " + WarningMessage);
            }
        }
        public List<String> Search(String Question)
        {
            if (IsValid(Question))
            {
                foreach (QA42 QA in memory)
                {
                    return QA.Match(Question);
                }
            }
            return new List<String> { NoMatchMessage };
        }
    }
}
