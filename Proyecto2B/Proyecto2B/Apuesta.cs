using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2B
{
    public class Apuesta
    {
        //Atributos
        int idGrupo, idUsuario, puntos1, puntos2;
        private int field;

        //Cosntructores
        public Apuesta()
        {
        }

        public Apuesta(int idGrupo, int idUsuario, int puntos1, int puntos2)
        {
            this.idGrupo = idGrupo;
            this.idUsuario = idUsuario;
            this.puntos1 = puntos1;
            this.puntos2 = puntos2;
        }

        //Override
        public override string ToString()
        {
            return "Goles equipo 1: " + puntos1 + "Goles equipo 2:" + puntos2;
        }

        //Set y Gets
        // public int Id { get => id; set => id = value; }
        public int Puntos1 { get => puntos1; set => puntos1 = value; }
        public int Puntos2 { get => puntos2; set => puntos2 = value; }
        public int IdGrupo { get => idGrupo; set => idGrupo = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
    }
}
