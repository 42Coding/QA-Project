using System;
using System.Collections.Generic;
using System.Text;

namespace QA_Project
{
    class Memory
    {
        private List<QA42> memory = new List<QA42>();
        private static String NoMatchMessage = "The answer to life, universe and everything is 42";
        public void Add(String Line)
        {
            String[] Parse = Line.Split(new char[] { '?', '"' }, StringSplitOptions.None);
            String Question = Parse[0];
            if (!Question.Equals(String.Empty)) // No Question No Awnser
            {
                QA42 QA = new QA42();
                QA.Question = Question+"?";
                int i; for(i=1;i<Parse.Length; i++)
                {
                    String Awnser = Parse[i];
                    if (!Awnser.Equals(String.Empty))
                    {
                        QA.Awnsers.Add(Awnser);
                    }
                }
                memory.Add(QA);
            }
        }
        public void Search(String Question)
        {
            foreach (QA42 QA in memory)
            {
                if (QA.Match(Question))
                {
                    return;
                }
            }
            Console.WriteLine(NoMatchMessage);
        }
    }
}
