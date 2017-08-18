using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EstudoTrab.Model
{
    [Table("alunos")]
    public class Aluno
    {
   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long AlunoId { get; set; }

        [Column("nome")]
        [MaxLength(30)]
        public string Nome { get; set; }
       
    }
}