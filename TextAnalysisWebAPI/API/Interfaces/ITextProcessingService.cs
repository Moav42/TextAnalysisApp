using API.Metrics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface ITextProcessingService
    {
        public List<IMetrics> HandleMetrics(string text);
    }
}
