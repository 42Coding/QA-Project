using System;
//using System.Linq;
using System.Collections.Generic;
//using System.Text.RegularExpressions;

namespace QA_Project
{
    class Memory
    {
        private List<QA42> memory = new List<QA42>();
        private static String NoMatchMessage = "The answer to life, universe and everything is 42";
        private static String WarningMessage = "is invalid (max. 255 characters length).";
        private char[] separators = new char[] { '?', '"' };
        private Boolean IsValid(String value)
        {
            if (String.IsNullOrEmpty(value)) { return false; }
            return value.Length < 256;
        }
        private String[] GetSubStringsBetween(String s, char c)
        {
            String[] SubStringsBetween = new String[0];
            for (int i = s.IndexOf(c); i > -1; i = s.IndexOf(c, i + 1))
            {
                int x = i + 1;
                int next = s.IndexOf(c, x);
                if (next == -1) { return SubStringsBetween; }
                int end = next - x;
                Array.Resize(ref SubStringsBetween, SubStringsBetween.Length + 1);
                SubStringsBetween[SubStringsBetween.Length -1] = s.Substring(x, end);
                i = next;
            }
            return SubStringsBetween;
        }
        public void Add(String Line)
        {
            if (Line is null) { Console.WriteLine("Line is null!"); return; }
            int q = Line.IndexOf(separators[0]);
            if (q == -1) { Console.WriteLine("Please enter a Question."); return;  }
            String Question = Line.Substring(0, q + 1).Trim();
            if (IsValid(Question))
            {
                String[] SubStrings = GetSubStringsBetween(Line.Remove(0, Question.Length), separators[1]);
                QA42 QA = new QA42();
                QA.Question = Question;
                //foreach(var Answers in SubStrings.Select((value, index) => new { value, index }))
                for(int i = 0;i<SubStrings.Length;i++)
                {
                    int index = i + 1;
                    string answers = SubStrings[i].Trim();
                    if (IsValid(answers))
                    {
                        QA.Answers.Add(answers);
                    }
                    else if(index % 2 == 0)
                    {
                        Console.WriteLine("Awnser ("+ index.ToString()+"): " + WarningMessage);
                    }
                }

                if (QA.Answers.Count > 0)
                {
                    memory.Add(QA);
                }
            }
            else
            {
                Console.WriteLine("Question: " + WarningMessage);
            }
        }
        public void Search(String Question)
        {
            if (IsValid(Question))
            {
                foreach (QA42 QA in memory)
                {
                    List<String> Answers = QA.Match(Question);
                    if(Answers.Count>0)
                    {
                        Answers.ForEach(Console.WriteLine); return;
                    }
                }
            }
            Console.WriteLine(NoMatchMessage);
        }
    }
}
