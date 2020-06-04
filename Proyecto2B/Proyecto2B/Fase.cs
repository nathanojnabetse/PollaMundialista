using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2B
{
    public class Fase
    {
        //Atributos
        int id;
        string nombre;
        List<Equipo> listaEquipos;

        //Constructores
        public Fase()
        {
        }

        public Fase(int id, string nombre, List<Equipo> listaEquipos)
        {
            this.id = id;
            this.nombre = nombre;
            this.listaEquipos = listaEquipos;
        }

        //Set y Gets
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public List<Equipo> ListaEquipos { get => listaEquipos; set => listaEquipos = value; }
    }
}
