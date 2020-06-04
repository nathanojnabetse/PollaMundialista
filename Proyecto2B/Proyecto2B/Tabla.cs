using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2B
{
    public class Tabla
    {
        //Atributos
        int id;
        List<Equipo> listaequipos; 

        //Cosntructores
        public Tabla()
        {
        }

        public Tabla(int id, List<Equipo> listaequipos)
        {
            this.id = id;
            this.listaequipos = listaequipos;
        }



        //Set y Gets
        public int Id { get => id; set => id = value; }
        public List<Equipo> Listaequipos { get => listaequipos; set => listaequipos = value; }
    }
}
