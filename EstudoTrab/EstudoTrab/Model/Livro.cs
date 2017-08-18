using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EstudoTrab.Model
{
    [Table("livros")]
    public class Livro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long LivroId { get; set; }

        [Column("titulo")]
        [MaxLength(50)]
        [Required]
        public string Titulo { get; set; }


        [Column("valor")]
        [Range(18.2, Double.MaxValue)]
        [Required]
        public double Valor { get; set; }
    }
}