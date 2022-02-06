using PipesInPool.Models;
using PipesInPool.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesInPool.Controllers
{
    public class PoolActionController
    {
        private Display display;
        private Pool pool;
        public PoolActionController()
        {
            display = new Display();
            pool = new Pool(display.V, display.P1, display.P2, display.N);
            display.Rez = pool.Fill();
            display.GetRez();
        }
    }
}
