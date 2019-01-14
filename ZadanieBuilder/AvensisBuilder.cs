using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieBuilder
{
    public class AvensisBuilder : IToyotaBuilder
    {
        private Toyota avensis = new Toyota();

        public void BuildBody()
        {
            avensis.Body = "Nadwozie Avensis";
        }
        public void BuildChassis()
        {
            avensis.Chassis = "Podwozie Avensis";
        }
        public void BuildEngine()
        {
            avensis.Engine = "Silnik Avensis";
        }
        public Toyota GetToyota()
        {
            return avensis;
        }
    }
}
