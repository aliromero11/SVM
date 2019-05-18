using System;
using System.ComponentModel.DataAnnotations;
namespace SVM.Models
{
    public class ProductosModel
    {
        public int ID {get; set;}

        public string NomPolo {get; set;} // polo cruzado

        [Required]
        public char Talla {get; set;} //  s,m, l , xl

        public int Stock {get; set; }

        public int CantSelec {get; set; }

        public string Modelo {get; set; }// manga corta, larga ,etc
        public string Coleccion {get; set;} // Hellen, UniChic, Casual
        public string Material {get; set;} // algodon, denin,sintetico, seda

        public double Precio {get; set;}

        public double Promo {get; set;}

        public string Color {get; set;} //Azul, amarillo, rojo, blanco, negro, gris, verde
        
}}