using System;
using System.ComponentModel.DataAnnotations;
namespace ovejas.App.dominio
{
    public class dueñoOveja
    {   
        [Key]
        public int    dueñoOvejaId{get;set;}
        public string Nombre{get;set;}
        public string Apellido{get;set;}
        public string Documento{get;set;}
        public string Direccion{get;set;}
        public string Telefono{get;set;}
        public string Correo{get;set;}
        
        public oveja oveja {get;set;}

        
    }
}