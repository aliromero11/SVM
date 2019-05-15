using System;
using System.ComponentModel.DataAnnotations; 



namespace SVM.Models
{
   
 
public class ProductosModel
    {
     

public int ID {get; set;}


public string NomPolo {get; set;} // polo sirena xD


[Required]
public char Talla {get; set;} // combo xs, x, xm, l , xl

public int Stock {get; set; }

public int CantSelec {get; set; }

public string Modelo {get; set; }// manga corta, larga ,etc


public string Material {get; set;}

public double Precio {get; set;}

public double Promo {get; set;}

public string Color {get; set;}


}