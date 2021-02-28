using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAssistant.EF
{
    class AppData
    {
        public static FitnessAssistantEntities Context { get; } = new FitnessAssistantEntities();

        public static Users userData;
    }
}
