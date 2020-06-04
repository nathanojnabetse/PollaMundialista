using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2B
{
    public  class GrupoEquipos
    {
        //Atributos
        int id;
        List<Equipo> listaEquipos;

        //Constructores
        public GrupoEquipos()
        {
        }

        public GrupoEquipos(int id, List<Equipo> listaEquipos)
        {
            this.id = id;
            this.listaEquipos = listaEquipos;
        }

        //Set y Gets
        public int Id { get => id; set => id = value; }
        public List<Equipo> ListaEquipos { get => listaEquipos; set => listaEquipos = value; }
    }
}
