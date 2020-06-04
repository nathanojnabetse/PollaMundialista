using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2B
{
    public class Equipo
    {
        //Atributos
        int id, posicion;
        string pais;
        int partidosJugados, partidosGanados, partidosPerdidos, partidosEmpatados;
        int golesFavor, golesContra;
        int puntos; 
        

        //Constructores 
        public Equipo()
        {
        }

        public Equipo(int id, string pais, int posicion, int partidosJugados, int partidosGanados, int partidosPerdidos, int partidosEmpatados, int golesFavor, int golesContra,int puntos)
        {
            this.id = id;
            this.pais = pais;
            this.posicion = posicion;
            this.PartidosJugados = partidosJugados;
            this.partidosGanados = partidosGanados;
            this.partidosPerdidos = partidosPerdidos;
            this.partidosEmpatados = partidosEmpatados;
            this.golesFavor = golesFavor;
            this.golesContra = golesContra;
            this.puntos = puntos;

        }

        //Override
        public override string ToString()
        {
          

            if (((pais == "Costa Rica") || (pais == "Arabia Saudi") || (pais == "Dinamarca") || (pais == "Corea del Sur") || (pais == "Marruecos")) )
            {
                return pais + "\t" + partidosJugados + "\t" + "\t" + partidosGanados + "\t" + "\t" + partidosPerdidos + "\t" + "\t" + partidosEmpatados + "\t" + "\t" + golesFavor + "\t" + "\t" + golesContra + "\t" + "\t" + puntos;
            }
     
            else
            {
                return pais + "\t\t" + partidosJugados + "\t" + "\t" + partidosGanados + "\t" + "\t" + partidosPerdidos + "\t" + "\t" + partidosEmpatados + "\t" + "\t" + golesFavor + "\t" + "\t" + golesContra + "\t" + "\t" + puntos;
            }
        }

         

        //Set y Gets
        public int Id { get => id; set => id = value; }
        public int Posicion { get => posicion; set => posicion = value; }
        public int PartidosJugados { get => partidosJugados; set => partidosJugados = value; }
        public int PartidosGanados { get => partidosGanados; set => partidosGanados = value; }
        public int PartidosPerdidos { get => partidosPerdidos; set => partidosPerdidos = value; }
        public int PartidosEmpatados { get => partidosEmpatados; set => partidosEmpatados = value; }
        public int GolesFavor { get => golesFavor; set => golesFavor = value; }
        public int GolesContra { get => golesContra; set => golesContra = value; }
        public int Puntos { get => puntos; set => puntos = value; }
        public string Pais { get => pais; set => pais = value; }
    }
}
