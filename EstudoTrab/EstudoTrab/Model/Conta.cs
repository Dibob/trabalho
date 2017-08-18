using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EstudoTrab.Model
{
    [Table("contas")]
    public class Conta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ContaId { get; set; }

        [Column("numero")]
        [Required]

        public Int16 Numero { get; set; }

        [Column("saldo")]
        [Required]
        [Range(18.2, Double.MaxValue)]

        public double Saldo { get; set; }

        [Column("limite")]
        [Required]
        [Range(18.2, Double.MaxValue)]
        public double  Limite { get; set; }

    }
}