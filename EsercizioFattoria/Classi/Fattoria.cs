using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioFattoria.Classi
{
    class Fattoria
    {
        public List<ISuonoFattoria> ComponentiCheSuonano { get; set; }

        public Fattoria()
        {
            ComponentiCheSuonano = new List<ISuonoFattoria>();
            ComponentiCheSuonano.Add(new Fattore
            {
                Nome = "Valerio",
                Età = 30,
                Mansione = "Su meri"
            });
        }

        public void StampaSuoni()
        {
            foreach (var componente in ComponentiCheSuonano)
            {
                Console.WriteLine(componente.Suona());
            }
        }

    }


}
