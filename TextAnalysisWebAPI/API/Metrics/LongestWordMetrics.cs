using API.Extensions;
using API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Metrics
{
    public class LongestWordMetrics : IMetrics
    {
        public string MetricsName { get; set; }
        public string MetricsValue { get; set; }

        public LongestWordMetrics(string textToProcess)
        {
            MetricsName = "Longest Word";
            MetricsValue = ProcessText(textToProcess);
        }

        public string ProcessText(string text)
        {
            string[] words = text.SplitOnWordsArray();
            
            return (from w in words.AsParallel() orderby w.Length descending select w).FirstOrDefault();
        }
    }
}
