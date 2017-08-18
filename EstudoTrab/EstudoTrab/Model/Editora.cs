using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EstudoTrab.Model
{

    [Table("editoras")]
    public class Editora
    {
           [Key]
           [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
           public long EditoraId { get; set; }


           [Column("nome")]
           [Required]
           [MaxLength(30)]

           public string Nome { get; set; }

           [Column("email")]
           [Required]
           public string Email { get; set; }
         
    }
}