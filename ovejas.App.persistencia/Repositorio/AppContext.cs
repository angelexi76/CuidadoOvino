/*Esta clase esta ligada directamente al DbContex ,realizara las trasaciones con referenta a la database,para ello debe heredar de dbcontext llamamos al Dbcontex que es un Objecto propio y el DbSet que hara elmapeo de las entidades .Para usar las entidades que se encuentran en otra capa realizamos una referencia en la terminal PS C:\CuidadoOvino\Ovejas.App.persistencia> dotnet add reference ../Ovejas.App.dominio/dotnet*/
using Microsoft.EntityFrameworkCore;
using ovejas.App.dominio;

using System;
namespace ovejas.App.persistencia
{
     public class AppContext:DbContext
     {
       public DbSet <cuidadoOvino> cuidadoOvinos{get;set; }

     
       public DbSet <dueñoOveja> dueñoOveja{get;set; }
       public DbSet <historiaClinica> historiasClinicas{get;set; }
       public DbSet <medicoVeterinario> medicosVeterinarios{get;set; }
       public DbSet <oveja> ovejas{get;set; }
       public DbSet <visitaDomiciliaria> visitasDomiciliarias{get;set; }

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {

         if(!optionsBuilder.IsConfigured)//*configuracion de la data base*/

         {
          optionsBuilder
          .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=ovinosData");//*el nombre de la base de datos*/
         }
       }  
    }

}    
