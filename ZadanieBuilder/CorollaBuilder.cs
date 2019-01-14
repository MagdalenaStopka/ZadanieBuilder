using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieBuilder
{
    class CorollaBuilder : IToyotaBuilder
    {
        private Toyota corolla = new Toyota();

        public void BuildBody()
        {
            corolla.Body = "Nadwozie Corolla";
        }
        public void BuildChassis()
        {
            corolla.Chassis = "Podwozie Corolla";
        }
        public void BuildEngine()
        {
            corolla.Engine = "Silnik Corolla";
        }
        public Toyota GetToyota()
        {
            return corolla;
        }
    }
}
