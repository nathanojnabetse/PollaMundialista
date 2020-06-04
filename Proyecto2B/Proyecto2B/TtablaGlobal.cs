using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2B
{
    class TtablaGlobal
    {
        string pais;
        int partidosJugados;
        int partidosGanados;
        int partidosPerdidos;
        int partidosEmpatados;
        int golesFavor;
        int golContra;
        int golDiferencia;
        int puntos;

        public TtablaGlobal(string pais, int partidosJugados, int partidosGanados, int partidosPerdidos, int partidosEmpatados, int golesFavor, int golContra, int golDiferencia, int puntos)
        {
            this.Pais = pais;
            this.PartidosJugados = partidosJugados;
            this.PartidosGanados = partidosGanados;
            this.PartidosPerdidos = partidosPerdidos;
            this.PartidosEmpatados = partidosEmpatados;
            this.GolesFavor = golesFavor;
            this.GolContra = golContra;
            this.GolDiferencia = golDiferencia;
            this.Puntos = puntos;
        }

        public string Pais { get => pais; set => pais = value; }
        public int PartidosJugados { get => partidosJugados; set => partidosJugados = value; }
        public int PartidosGanados { get => partidosGanados; set => partidosGanados = value; }
        public int PartidosPerdidos { get => partidosPerdidos; set => partidosPerdidos = value; }
        public int PartidosEmpatados { get => partidosEmpatados; set => partidosEmpatados = value; }
        public int GolesFavor { get => golesFavor; set => golesFavor = value; }
        public int GolContra { get => golContra; set => golContra = value; }
        public int GolDiferencia { get => golDiferencia; set => golDiferencia = value; }
        public int Puntos { get => puntos; set => puntos = value; }

        public override string ToString()
        {
            if(pais == "Costa Rica")
            {
                return Pais + "\t" + PartidosJugados + "\t" + PartidosGanados + "\t"+ PartidosPerdidos + "\t" + partidosEmpatados + "\t" + golesFavor + "\t" + GolContra + "\t" + golDiferencia + "\t" + puntos;
            }
            else if(pais == "Arabia Saudi")
            {
                return Pais + "\t" + PartidosJugados + "\t" + PartidosGanados + "\t"+ PartidosPerdidos+ "\t" + partidosEmpatados + "\t" + golesFavor + "\t" + GolContra + "\t" + golDiferencia + "\t" + puntos;
            }
            else if (pais == "Dinamarca")
            {
                return Pais + "\t" + PartidosJugados + "\t" + PartidosGanados + "\t" + PartidosPerdidos + "\t" + partidosEmpatados + "\t" + golesFavor + "\t" + GolContra + "\t" + golDiferencia + "\t" + puntos;
            }
            else if (pais == "Marruecos")
            {
                return Pais + "\t" + PartidosJugados + "\t" + PartidosGanados + "\t" + PartidosPerdidos + "\t" + partidosEmpatados + "\t" + golesFavor + "\t" + GolContra + "\t" + golDiferencia + "\t" + puntos;
            }
            else if (pais == "Corea del Sur")
            {
                return Pais + "\t" + PartidosJugados + "\t" + PartidosGanados + "\t" + PartidosPerdidos + "\t" + partidosEmpatados + "\t" + golesFavor + "\t" + GolContra + "\t" + golDiferencia + "\t" + puntos;
            }
            else
            {
                return Pais + "\t\t" + PartidosJugados + "\t" + PartidosGanados + "\t" + PartidosPerdidos + "\t" + partidosEmpatados + "\t" + golesFavor + "\t" + GolContra + "\t" + golDiferencia + "\t" + puntos;
            }
            
        }
    }
}
