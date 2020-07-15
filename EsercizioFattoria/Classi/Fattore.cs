using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioFattoria.Classi
{
    class Fattore : Persona, ISuonoFattoria
    {
        public string Suona()
        {
            return Parla();
        }
    }
}
