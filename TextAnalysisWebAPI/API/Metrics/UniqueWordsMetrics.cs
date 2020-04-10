using API.Extensions;
using API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Metrics
{
    public class UniqueWordsMetrics : IMetrics
    {
        public string MetricsName { get; set; }
        public string MetricsValue { get; set; }

        public UniqueWordsMetrics(string textToProcess)
        {
            MetricsName = "Count of unique words";
            MetricsValue = ProcessText(textToProcess);
        }

        public string ProcessText(string text)
        {
            return text.SplitOnWordsArray().Distinct().Count().ToString();
        }
    }
}

