using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface IMetrics
    {
        public string MetricsName { get; set; }
        public string MetricsValue { get; set; }
        public string ProcessText(string text);

    }
}
