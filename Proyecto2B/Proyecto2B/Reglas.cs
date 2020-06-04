using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2B
{
    public class Reglas
    {
        //Atributos
        int id;
        int marcadorExactoAcertado, ganadorAcertado, golAcertado;
        int bonoOctavos, bonoCuartos, bonoSemi, bonoFinal;
        decimal valorApuesta;
        decimal primerLugar, segundoLuar, tercerLugar;
        private int idReglas;

        //Constructores
        public Reglas()
        {
        }

        public Reglas(int id, int marcadorExactoAcertado, int ganadorAcertado, int golAcertado,int bonoOctavos, int bonoCuartos, int bonoSemi, int bonoFinal,decimal valor, decimal primer, decimal segundo, decimal tercero)
        {
            this.id = id;
            this.marcadorExactoAcertado = marcadorExactoAcertado;
            this.ganadorAcertado = ganadorAcertado;
            this.golAcertado = golAcertado;
            this.bonoCuartos = bonoCuartos;
            this.bonoOctavos = bonoOctavos;
            this.bonoSemi = bonoSemi;
            this.bonoFinal = bonoFinal;
            this.valorApuesta = valor;
            this.primerLugar = primer;
            this.segundoLuar = segundo;
            this.tercerLugar = tercero;
        }

        public Reglas(int idReglas)
        {
            this.idReglas = idReglas;
        }


        //Override

        public override string ToString()
        {
            return "Marcador exacto: " + marcadorExactoAcertado
            + "\nGanador Acertado: " + ganadorAcertado
            + "\nGol Acertado: " + golAcertado
            + "\nBono Clasificación a Octavos: " + bonoOctavos
            + "\nBono Clasificación a Cuartos: " + bonoCuartos
            + "\nBono Clasificación a Semifinales: " + bonoSemi
            + "\nBono Clasificación a Final: " + bonoFinal
            + "\nValor apuesta: " + valorApuesta
            + "\nPrimer Lugar: " + primerLugar * 100 + "%"
            + "\nSegundo Lugar: " + segundoLuar * 100 + "%"
            + "\nTercer Lugar: " + tercerLugar * 100 + "%" ; 
        }

        //Set y Gets
        public int MarcadorExactoAcertado { get => marcadorExactoAcertado; set => marcadorExactoAcertado = value; }
        public int GanadorAcertado { get => ganadorAcertado; set => ganadorAcertado = value; }
        public int GolAcertado { get => golAcertado; set => golAcertado = value; }
        public int BonoOctavos { get => bonoOctavos; set => bonoOctavos = value; }
        public int BonoCuartos { get => bonoCuartos; set => bonoCuartos = value; }
        public int BonoSemi { get => bonoSemi; set => bonoSemi = value; }
        public int Bonofinal { get => bonoFinal; set => bonoFinal = value; }
        public decimal ValorApuesta { get => valorApuesta; set => valorApuesta = value; }
        public decimal PrimerLugar { get => primerLugar; set => primerLugar = value; }
        public decimal SegundoLuar { get => segundoLuar; set => segundoLuar = value; }
        public decimal TercerLugar { get => tercerLugar; set => tercerLugar = value; }
        public int Id { get => id; set => id = value; }
    }
}
