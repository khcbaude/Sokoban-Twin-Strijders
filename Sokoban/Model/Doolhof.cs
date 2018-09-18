using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


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
            //string[] lines = System.IO.File.ReadAllLines(path: @"Levels\LEVEL1.txt");
            //Console.WriteLine(lines[0]);
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("TextFile1.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
