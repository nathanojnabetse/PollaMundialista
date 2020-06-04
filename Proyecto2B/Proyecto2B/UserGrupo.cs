using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2B
{
    class UserGrupo
    {
        int idUSer_Grupo;
        int idUsuario;
        int idGrupo;

        public UserGrupo(int idUSer_Grupo, int idUsuario, int idGrupo)
        {
            this.idUSer_Grupo = idUSer_Grupo;
            this.idUsuario = idUsuario;
            this.idGrupo = idGrupo;
        }

        public int IdUSer_Grupo { get => idUSer_Grupo; set => idUSer_Grupo = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdGrupo { get => idGrupo; set => idGrupo = value; }

        public override string ToString()
        {
            return Convert.ToString(idGrupo); 
        }
    }
}
