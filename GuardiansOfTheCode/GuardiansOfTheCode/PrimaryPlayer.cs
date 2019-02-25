using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardiansOfTheCode
{
    public sealed class PrimaryPlayer
    {
        private static readonly PrimaryPlayer _instance;
        private static readonly PrimaryPlayer _instance2;

        private PrimaryPlayer() { }

        static PrimaryPlayer()
        {
            _instance = new PrimaryPlayer()
            {
                Name = "Raptor",
                Level = 1
            };

            _instance2 = new PrimaryPlayer()
            {
                Name = "rutha",
                Level = 2
            };

        }

        public static PrimaryPlayer Instance
        {
            get
            {
                return _instance;
            }
            
        }

        public static PrimaryPlayer Instance2
        {
            get
            {
                return _instance2;
            }

        }


        public string Name { get; set; }
        public int Level { get; set; }
    }
}
