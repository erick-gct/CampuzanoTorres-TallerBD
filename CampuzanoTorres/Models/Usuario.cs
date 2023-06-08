using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CampuzanoTorres.Models
{
    public class Usuario
    {


        public int Id { get; set; }

     //   [Column (TypeName ="varchar(10)")]
        public String NombreUsuario { get; set; }
        
      //  [Column(TypeName = "varchar(10)")]
        public String clave { get; set; }

        public Boolean estado { get; set; }
        public int GeneroId { get; set; }
        public Genero Genero { get; set; }


    }
}
