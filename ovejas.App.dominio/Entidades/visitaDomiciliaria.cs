using System;
using System.ComponentModel.DataAnnotations;
namespace ovejas.App.dominio
{
    public class visitaDomiciliaria
    {     
        [Key]
        public int visitasDomiciliariasId{get;set;}
        public float Temperatura{get;set;}
        public float Peso{get;set;}
        public float FrecuenciaRespiratoria{get;set;}
        public float FrecuenciaCardiaca{get;set;}
        public string EstadoAnimo{get;set;}
        public string FechaVisita{get;set;}
        public string DocumentoVeterinario{get;set;}
        public string MedicinasFormuladas{get;set;}

         public medicoVeterinario medicoVeterinario {get;set;}

    }
}