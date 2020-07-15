using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioFattoria.Classi
{
    class Persona
    {
        public string Nome { get; set; }
        public string Mansione { get; set; }
        public int Età { get; set; }

        public string Parla()
        {
            return "bla bla bla";
        }
    }
}
