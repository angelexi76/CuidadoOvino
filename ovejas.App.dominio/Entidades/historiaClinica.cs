using System;
using System.ComponentModel.DataAnnotations;
namespace ovejas.App.dominio
{
    public class historiaClinica
    {    
        [Key]
        public int    historiaClinicaId{get;set;}
        public string FechaAperturaHistoría{get;set;}
        public string  NombreDueño{get;set;}
        public string  NombreMedico{get;set;}
        public string  Direccion{get;set;}
        
      
      


    }
    
}