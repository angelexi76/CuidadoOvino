# CuidadoOvino
DesarrolloSoftware
Grupo 4 Mintic se organizaron grupos ,debemos crear una solucion informatica a un problema integrantes del grupo y su rol
Angela Sánchez Barbosa Líder del equipo
edwin yamir quintero medina Tester Brayan Gonzalez Diseñador UI Adrian moreno lozano Diseñador de software German David Lozano Administrador configuración
las tareas se asignaron a cada integrante Ángela Sánchez realizo :entidades en visual studio code migraciones hacia azure data studio diseño de diagrama ER diseño en figma
Contexto del problema: En la actualidad en diferentes haciendas de nuestro país, el cuidado de los animales es prioridad para sus propietarios, garantizar la salud y el cuidado es fundamental para los propósitos económicos de las haciendas; el proyecto “Cuidado ovino remoto” tiene como objetivo el monitoreo del estado de salubridad de los animales ovinos (ovejas) afiliados, el modelo consiste en visitas domiciliarias periódicas de promoción de la salud y prevenciónde la enfermedad, las cuales son realizadas por un médico veterinario. Cuidado ovino remoto cuenta con un equipo de veterinarios que se encargan de realizar visitas a domicilio, durante las cuales se revisan los animales y se dan recomendaciones para prevenir enfermedades, mejorar la calidad de vida de las ovejas y en caso de ser necesario se realiza el diagnóstico y se formulan medicamentos. Debido a la buena acogida que ha tenido el servicio de visitas domiciliarias de promoción y prevención, el proyecto tiene la necesidad de llevar un registro de las mismas y los ha contratado a ustedes para que implementen una solución informática. Durante cada visita se deben registrar datos de las ovejas, tales como temperatura, peso, frecuencia respiratoria, frecuencia cardíaca, estado de ánimo, así como la fecha de la visita, la identificación del profesional que realiza la visita y recomendaciones dadas (incluyendo medicamentos formulados en caso de que se requiera). La suma de todas las visitas realizadas compone la historia clínica. La historia clínica deberá contener la fecha en la cual se abre la historia de la oveja. Se requiere tener además la información de los dueños de cada animal, tales como identificación, nombres, apellidos, dirección, teléfono y correo electrónico. Se debe tener la información de los veterinarios, identificación, nombres, apellidos, dirección, teléfono, tarjeta profesional. Los datos de cada oveja son nombre, color, especie y raza (si aplica). A cada oveja se le asigna un médico veterinario quien será encargado de realizar las visitas periódicas. Su trabajo consiste en desarrollar una solución que permita el adecuado manejo de la información mencionada
Se crearon las entidades basados en el diagrama de clases,para ello usamos el IDE Visual Studio Code.
En la persistencia y Esta clase está ligada directamente al Dbontex ,realizará las transacciones con referente a la database,para ello debe hereda de dbcontext llamamos al Dbcontex que es un Objecto propio y el DbSet que hará el mapeo de las entidades.
Para usar las entidades que se encuentran en otra capa realizamos una referencia en la terminal C:\CuidadoOvino\Ovejas.App.persistencia> dotnet add reference ../Ovejas.App.dominio/dotnet Observamos que hemos llamado las entidades que se mapearan using Microsoft.EntityFrameworkCore; using Ovejas.App.dominio;
using System; namespace Ovejas.App.persistencia { public class AppContext:DbContext { public DbSet cuidadoOvino{get;set; }
  public DbSet <duenoOveja> dueñoOveja{get;set; }
   public DbSet <historiaClinica> historiaClinica{get;set; }
   public DbSet <medicoVeterinario> medicoVeterinario{get;set; }
   public DbSet <ovejas> ovejas{get;set; }
   public DbSet <visitaDomiciliaria> visitaDomiciliaria{get;set; }

  }
 
}
Luego con el metodo OnConfiguring establecemos la conexión a la base de datos
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
Luego se creó la capa de presentación mediante consola
para el prototipo se escogio la herramienta Figma
Figma es una herramienta de prototipado web y editor de gráficos vectorial, que a diferencia de las otras herramientas, se aloja en la web. 
enlace al diseño https://www.figma.com/file/Dc7V0YUOAcbnZN17MrkbeL/CuidadoAnimalOvinos?node-id=2%3A2

