using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2B
{
    public class Usuario
    {
        //Atributos
        int id;
        string nombre;
        string apellido;
        string correo;
        string contrasena;
        string genero;
        string pais;
        DateTime fechaNacimiento;
        int puntoAcumulados;
        List<Grupo> gruposPertenence;
        private int idUsuario;
        private string nombreUsuario;
        private string apellidoUsuario;
        private int puntosAcumulados;


        //Cosnructores
        public Usuario()
        {
        }

        public Usuario(int id, string nombre, string apellido, string correo, string contrasena, string genero, string pais, DateTime fechaNacimiento, int puntoAcumulados, List<Grupo> gruposPertenence)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Correo = correo;
            this.Contrasena = contrasena;
            this.Genero = genero;
            this.Pais = pais;
            this.FechaNacimiento = fechaNacimiento; 
            this.PuntoAcumulados = puntoAcumulados;
            this.GruposPertenence = gruposPertenence;
        }


        public Usuario(int id, string nombre, string apellido, string correo, string contrasena, string genero, string pais, DateTime fechaNacimiento, int puntoAcumulados)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Correo = correo;
            this.Contrasena = contrasena;
            this.Genero = genero;
            this.Pais = pais;
            this.FechaNacimiento = fechaNacimiento;
            this.PuntoAcumulados = puntoAcumulados;

        }
        DateTime date1 = new DateTime(1995, 5, 1);
        public Usuario(int idUsuario, string nombreUsuario, string apellidoUsuario, string correo, string genero, string pais, DateTime fechaNacimiento, int puntosAcumulados)
        {
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.apellidoUsuario = apellidoUsuario;
            this.correo = correo;
            this.genero = genero;
            this.pais = pais;
            this.fechaNacimiento = date1;
            this.puntosAcumulados = puntosAcumulados;
        }

        public Usuario(int idUsuario)
        {
            this.idUsuario = idUsuario;
        }


        //Override
        public override string ToString()
        {
            return Nombre + " " + Apellido + "\t"  + "\t" + "\t" + PuntoAcumulados; 
        }

        //Set y Gets
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Pais { get => pais; set => pais = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int PuntoAcumulados { get => puntoAcumulados; set => puntoAcumulados = value; }
        public List<Grupo> GruposPertenence { get => gruposPertenence; set => gruposPertenence = value; }
    }
}
