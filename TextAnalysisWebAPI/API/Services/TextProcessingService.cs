using API.Metrics;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Interfaces;

namespace API.Services
{
    public class TextProcessingService : ITextProcessingService
    {
        public List<IMetrics> HandleMetrics(string text)
        {
            var metricsNames = GetAllMetricsNames();

            List<IMetrics> metrics = new List<IMetrics>();

            foreach (var metricsName in metricsNames)
            {
                metrics.Add(Activator.CreateInstance(Type.GetType(metricsName), text) as IMetrics);
            }

            return metrics;
        }

        private List<string> GetAllMetricsNames()
        {
            return  AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
                 .Where(x => typeof(IMetrics).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                 .Select(x => x.FullName).ToList();
        }
    }
}
