using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EstudoTrab.Model
{

    [Table("clientes")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public long IdCliente { get; set; }

        [Column("nome")]
        [MaxLength(50)]
        public string Nome { get; set; }

        [Column("idade")]
        public Int16 Idade { get; set; }

        [Column("cpf")]
        public string   CPF { get; set; }
    }
}