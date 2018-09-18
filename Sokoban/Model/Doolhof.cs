using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sokoban
{
    class Doolhof
    {
        /// <summary></summary>
        /// <remarks></remarks>
        private Vorkheftruck vorkHefTruck;
        private List<Kist> kisten;
        private List<Muur> muren;
        private List<Bestemming> bestemmingen;
        private List<Vloer> vloeren;

        public Doolhof()
        {
            loadLevel();
            vorkHefTruck = new Vorkheftruck();
        }

        public void loadLevel()
        {
            string[] lines = System.IO.File.ReadAllLines(@"Levels\LEVEL1.txt");
            Console.WriteLine(lines[0]);
        }
    }
}
