using API.Interfaces;

namespace API.Metrics
{
    public class CharactersCountMetrics : IMetrics
    {
        public string MetricsName { get; set; }
        public string MetricsValue { get; set; }

        public CharactersCountMetrics(string textToProcess)
        {
            MetricsName = "Characters Count";
            MetricsValue = ProcessText(textToProcess);
        }

        public string ProcessText(string text)
        {
            return text.Length.ToString();
        }
    }
}
