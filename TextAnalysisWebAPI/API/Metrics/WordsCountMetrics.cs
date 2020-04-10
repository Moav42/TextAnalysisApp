using API.Extensions;
using API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Metrics
{
    public class WordsCountMetrics : IMetrics
    {
        public string MetricsName { get; set; }
        public string MetricsValue { get; set; }

        public WordsCountMetrics(string textToProcess)
        {
            MetricsName = "Words Count";
            MetricsValue = ProcessText(textToProcess);
        }

        public string ProcessText(string text)
        {
            return text.SplitOnWordsArray().Length.ToString();
        }
    }
}
