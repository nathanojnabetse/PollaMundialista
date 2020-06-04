using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2B
{
    public class Marcador
    {
        //Atributos
        int id, puntosE1, puntosE2;
        private int idMarcador;

        //cosntructores
        public Marcador()
        {
          }

        public Marcador(int id, int puntosE1, int puntosE2)
        {
            this.id = id;
            this.puntosE1 = puntosE1;
            this.puntosE2 = puntosE2;
        }

        public Marcador(int idMarcador, int puntosE2)
        {
            this.idMarcador = idMarcador;
            this.puntosE2 = puntosE2;
        }


        //Override
        public override string ToString()
        {
            return puntosE1 + "-" + puntosE2;
        }

        //Set y Gets
        public int Id { get => id; set => id = value; }
        public int PuntosE1 { get => puntosE1; set => puntosE1 = value; }
        public int PuntosE2 { get => puntosE2; set => puntosE2 = value; }
    }
}
