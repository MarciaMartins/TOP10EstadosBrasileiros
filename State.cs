using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Top10EstadosBrasileiros
{
    class State
    {
        public State(string name, string acronym)
        {
            this.Name = name;
            this.Acronym = acronym;
        }

        public State(string name, string acronym, double territory): this(name, acronym)
        {
            this.Territory = territory;
        }

        public string Name { get; set; }
        public string Acronym { get; set; }
        public double Territory { get; set; }



    }
}
