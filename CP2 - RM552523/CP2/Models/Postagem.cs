using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CP2.Models
{
    [Table("tb_postagem")]
    public class Postagem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; }

        [Required]
        public string Conteudo { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataPublicacao { get; set; }

    }
}
