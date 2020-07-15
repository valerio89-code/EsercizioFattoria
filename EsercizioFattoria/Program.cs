using EsercizioFattoria.Classi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioFattoria
{
    class Program
    {
        static void Main(string[] args)
        {
            var fattoria = new Fattoria();
            fattoria.ComponentiCheSuonano.Add(new Cavallo());
            fattoria.ComponentiCheSuonano.Add(new Cavallo());
            fattoria.ComponentiCheSuonano.Add(new Mucca());
            fattoria.ComponentiCheSuonano.Add(new Asino());
            fattoria.StampaSuoni();
        }
    }
}
