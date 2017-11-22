using System.Collections.Generic;

namespace BasicNicoVariation
{
    public class Nico
    {
        private string variationValue;

        public Nico(string key, string message)
        {
            variationValue = message;
        }

        public string Variation()
        {
            return variationValue;
        }
    }
}