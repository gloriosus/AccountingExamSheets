using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountingExamSheets
{
    class Parser
    {
        private List<int> DelimeterCount(string content, string key)
        {
            List<int> places = new List<int>();
            int count = 0;

            for (int i = 0; i < content.Length; i++)
            {
                string carriage = "";

                for (int v = 0; v < key.Length; v++)
                {
                    if (i <= content.Length - key.Length - 1)
                        carriage = carriage + content[i + v];
                    else carriage = content.Substring(i, content.Length - i);
                }

                if (carriage == key)
                {
                    places.Add(i);
                    count++;
                }
            }

            return places;
        }

        public string[] Split(string content, string key)
        {
            List<int> places = DelimeterCount(content, key);
            string[] lines = new string[places.Count + 1];

            for (int i = 0; i < lines.Length; i++)
            {
                if(i == 0) lines[i] = content.Substring(i, places[i]);
                else if(i == lines.Length - 1) lines[i] = content.Substring(places[i - 1] + key.Length, content.Length - (places[i - 1] + key.Length));
                else lines[i] = content.Substring(places[i - 1] + key.Length, places[i] - (places[i - 1] + key.Length));
            }

            return lines;
        }

        public string Replace(string content, string old, string mint)
        {
            string[] parts = Split(content, old);
            return parts[0] + mint + parts[1];
        }
    }
}
