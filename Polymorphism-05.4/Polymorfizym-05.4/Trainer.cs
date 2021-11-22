using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfizym_05._4
{
    class Trainer
    {
        private IAnimal entity;

        public IAnimal Entity
        {
            get { return entity; }
            set { entity = value; }
        }

        public Trainer(IAnimal en)
        {
            Entity = en;
        }

        public string Make()
        {
            return entity.Perform();
        }
    }
}
