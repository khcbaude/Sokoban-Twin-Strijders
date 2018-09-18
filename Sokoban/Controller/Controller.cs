using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Controller
    {
        private Doolhof doolhof;
        private View.MainView mainView;

        public Controller()
        {
            doolhof = new Doolhof();
            mainView = new View.MainView();
        }

        public void start()
        {
            throw new NotImplementedException();
        }
    }
}