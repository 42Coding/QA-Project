using System;
using System.Collections.Generic;
using System.Text;

namespace QA_Project
{
    class Memory
    {
        private List<QA42> memory = new List<QA42>();
        private static String NoMatchMessage = "The answer to life, universe and everything is 42";
        private const char ql = '?';
        public void Add(String Line)
        {
            String[] Parse = Line.Split(ql, StringSplitOptions.None);
            String Question = Parse[0] + ql;
            if (!Question.Equals(string.Empty)) // No Question No Awnser
            {
                Line = Line.Remove(0, Question.Length);
                Parse = Line.Split('"', StringSplitOptions.None);
                QA42 QA = new QA42();
                QA.Question = Question;
                foreach(String Awnser in Parse)
                {
                    if (!Awnser.Equals(String.Empty))
                    {
                        QA.Awnsers.Add(Awnser);
                    }
                }
                memory.Add(QA);
            }
        }
        public List<String> Search(String Question)
        {
            foreach (QA42 QA in memory)
            {
                return QA.Match(Question);
            }
            return new List<String> { NoMatchMessage };
        }
    }
}
