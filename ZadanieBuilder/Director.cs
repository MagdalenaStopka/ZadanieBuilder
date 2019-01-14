using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieBuilder
{
    class Director
    {
        private IToyotaBuilder toyotaBuilder;
        public Director(IToyotaBuilder toyotaBuilder)
        {
            ///////////////
        }
        public void Construct()
        {
            toyotaBuilder.BuildChassis();
            toyotaBuilder.BuildBody();
            toyotaBuilder.BuildEngine();
        }
        GetBuildedParts()
        {
            
        }
    }
}
