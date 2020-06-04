using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2B
{
    public class Grupo
    {
        //Atributos
        int id;
        string nombre;
        string codigo;
        int idReglas;

        Reglas reglas;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public int IdReglas { get => idReglas; set => idReglas = value; }
        public Reglas Reglas { get => reglas; set => reglas = value; }



        //Constructores
        public Grupo()
        {
        }

        public Grupo(int id, string nombre, List<Usuario> listaUsurios, string codigo, Reglas reglas)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Codigo = codigo;
            this.Reglas = reglas;
        }

        public Grupo(string nombre, string codigo )
        {
            this.Nombre = nombre;
            this.Codigo = codigo;

        }

        public Grupo(int id, string nombre, string codigo, int idReglas)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Codigo = codigo;
            this.IdReglas = idReglas;
        }



        //Override
        public override string ToString()
        {
            return  " Nombre: "+Nombre ;
        }

        //Get y Sets

    }
}
