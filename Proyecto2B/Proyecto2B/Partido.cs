using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2B
{
    public class Partido
    {
        //Atributos
        int idPartido;
        int idEquipo1;
        int idEquipo2;
        int idMarcador;
        DateTime hora;
        DateTime fecha;
        string estadio;
        string estado;

        public Partido(int idPartido, int idEquipo1, int idEquipo2, int idMarcador, string estadio, string estado)
        {
            this.idPartido = idPartido;
            this.idEquipo1 = idEquipo1;
            this.idEquipo2 = idEquipo2;
            this.idMarcador = idMarcador;
            this.estadio = estadio;
            this.estado = estado;
        }

        public Partido(int idPartido, int idEquipo1, int idEquipo2, int idMarcador, DateTime hora, DateTime fecha, string estadio, string estado)
        {
            this.IdPartido = idPartido;
            this.IdEquipo1 = idEquipo1;
            this.IdEquipo2 = idEquipo2;
            this.IdMarcador = idMarcador;
            this.Hora = hora;
            this.Fecha = fecha;
            this.Estadio = estadio;
            this.Estado = estado;
        }


        public override string ToString()
        {
            return hora + "    " + fecha + "      " + estadio; 
        }


        public int IdPartido { get => idPartido; set => idPartido = value; }
        public int IdEquipo1 { get => idEquipo1; set => idEquipo1 = value; }
        public int IdEquipo2 { get => idEquipo2; set => idEquipo2 = value; }
        public int IdMarcador { get => idMarcador; set => idMarcador = value; }
        public DateTime Hora { get => hora; set => hora = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Estadio { get => estadio; set => estadio = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
