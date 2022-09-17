using System;
using System.ComponentModel.DataAnnotations;
namespace ovejas.App.dominio
{
    public class cuidadoOvino
    {   
        [Key]
        public int cuidadoOvinoId{get;set;}
        public string Nit{get;set;}
        public string  Nombre{get;set;}
       
       

    }
}