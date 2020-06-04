using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2B
{
    class CalendarioPartidos
    {
        int idPartido;
        string p1;
        int pt1;
        string p2;
        int pt2;
        DateTime fecha;
        string estadio;

        public CalendarioPartidos()
        {
        
        }

        public CalendarioPartidos(int idPartido, string p1, int pt1, string p2, int pt2, DateTime fecha, string estadio)
        {
            this.IdPartido = idPartido;
            this.P1 = p1;
            this.Pt1 = pt1;
            this.P2 = p2;
            this.Pt2 = pt2;
            this.Fecha = fecha;
            this.Estadio = estadio;
        }

        public int IdPartido { get => idPartido; set => idPartido = value; }
        public string P1 { get => p1; set => p1 = value; }
        public int Pt1 { get => pt1; set => pt1 = value; }
        public string P2 { get => p2; set => p2 = value; }
        public int Pt2 { get => pt2; set => pt2 = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Estadio { get => estadio; set => estadio = value; }

        public override string ToString()
        {

                if (((P1 == "Costa Rica") || (P1 == "Arabia Saudi") || (P1 == "Dinamarca") || (P1 == "Corea del Sur") || (P1 == "Marruecos") ) && ((P2 == "Costa Rica") || (P2 == "Arabia Saudi") || (P2 == "Dinamarca") || (P2 == "Corea del Sur") || (P2 == "Marruecos")))
                {
                    return IdPartido + "\t" + P1 + "\t" + Pt1 + "\t" + P2 + "\t" + Pt2 + "\t" + Fecha + "\t" + Estadio;
                }
                else if ((P1 == "Costa Rica") || (P1 == "Arabia Saudi") || (P1 == "Dinamarca") || (P1 == "Corea del Sur") || (P1 == "Marruecos"))
                {
                    return IdPartido + "\t" + P1 + "\t" + Pt1 + "\t" + P2 + "\t\t" + Pt2 +  "\t" + Fecha + "\t" + Estadio;
                }
                else if ((P2 == "Costa Rica") || (P2 == "Arabia Saudi") || (P2 == "Dinamarca") || (P2 == "Corea del Sur") || (P2 == "Marruecos"))
                {
                    return IdPartido + "\t" + P1 + "\t\t" + Pt1 + "\t" + P2 + "\t" + Pt2 +  "\t" + Fecha + "\t" + Estadio;
                }
                else
                {
                    return IdPartido + "\t" + P1 + "\t\t" + Pt1 + "\t" + P2 + "\t\t" + Pt2 +  "\t" + Fecha + "\t" + Estadio;
                }
            
            
        }
    }
}
            
