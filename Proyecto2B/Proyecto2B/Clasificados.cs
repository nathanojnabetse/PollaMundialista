using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2B
{
    class Clasificados
    {
        string idGrupoEquipos;
        string Equipo1;
        int puntosEQ1;
        string Equipo2;
        int puntosEQ2;
        string Equipo3;
        int puntosEQ3;
        string Equipo4;
        int puntosEQ4;



        public Clasificados()
        {

        }

        public Clasificados(string idGrupoEquipos, string equipo1, int puntosEQ1, string equipo2, int puntosEQ2, string equipo3, int puntosEQ3, string equipo4, int puntosEQ4)
        {
            this.IdGrupoEquipos = idGrupoEquipos;
            Equipo11 = equipo1;
            this.PuntosEQ1 = puntosEQ1;
            Equipo21 = equipo2;
            this.PuntosEQ2 = puntosEQ2;
            Equipo31 = equipo3;
            this.PuntosEQ3 = puntosEQ3;
            Equipo41 = equipo4;
            this.PuntosEQ4 = puntosEQ4;
        }

        public string IdGrupoEquipos { get => idGrupoEquipos; set => idGrupoEquipos = value; }
        public string Equipo11 { get => Equipo1; set => Equipo1 = value; }
        public int PuntosEQ1 { get => puntosEQ1; set => puntosEQ1 = value; }
        public string Equipo21 { get => Equipo2; set => Equipo2 = value; }
        public int PuntosEQ2 { get => puntosEQ2; set => puntosEQ2 = value; }
        public string Equipo31 { get => Equipo3; set => Equipo3 = value; }
        public int PuntosEQ3 { get => puntosEQ3; set => puntosEQ3 = value; }
        public string Equipo41 { get => Equipo4; set => Equipo4 = value; }
        public int PuntosEQ4 { get => puntosEQ4; set => puntosEQ4 = value; }

        public override string ToString()
        {
            return IdGrupoEquipos + " " + Equipo11 + " " + PuntosEQ1 + " " + Equipo21 + " " + PuntosEQ2 + " " + Equipo31 + " " + PuntosEQ3 + " " + Equipo41 + " " + PuntosEQ4;
        }
    }
}
