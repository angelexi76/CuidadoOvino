using System;
using System.ComponentModel.DataAnnotations;
namespace ovejas.App.dominio
{
    public class oveja
    {   
        [Key] 
        public int    ovejasId{get;set;}
        public string Nombre{get;set;}
        public string Color{get;set;}
        public string Especie{get;set;}
        public string Raza{get;set;}
        public string NombreMedicoVeterinario{get;set;}
        
        

    }
}