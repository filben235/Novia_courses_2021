using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example3
{
    //En vanlig klass med vilken vi demonstrerar arv av typen has-a dvs. en bil har en motor
    class Engine
    {
        public Engine(string enginetype)
        {
            EngineType = enginetype;
        }

        public string EngineType
        {
            get; set;
        }

        public string Start()
        {
            return "Bruuuuuuummmmmm, engine of type " + EngineType + " started";
        }

        public string Stop()
        {
            return "Engine of type " + EngineType + " stopped!!!!";
        }


    }
}
