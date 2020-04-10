using API.Extensions;
using API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Metrics
{
    public class MostCommonWordsMetrics : IMetrics
    {
        public string MetricsName { get; set; }
        public string MetricsValue { get; set; }

        public MostCommonWordsMetrics(string textToProcess) 
        {
            MetricsName = "Five Most comman words";
            MetricsValue = ProcessText(textToProcess);          
        }

        public string ProcessText(string text)
        {
            string[] words = text.SplitOnWordsArray();

            var frequencyOrder = from word in words.AsParallel()
                                 where word.Length > 6
                                 group word by word into g
                                 orderby g.Count() descending
                                 select g.Key;


            StringBuilder commonWords = new StringBuilder();

            foreach (string s in frequencyOrder.Take(5).ToArray())
            {
                commonWords.AppendLine(s);
            }

            return commonWords.ToString();
        }
    }
}
