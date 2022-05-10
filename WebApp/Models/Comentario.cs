using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    [Table("Comentario")]
    public class Comentario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Column(TypeName = "varchar(1000)")]
        [MaxLength(1000, ErrorMessage = "Tamanho máximo {1}")]
        public string Descricao { get; set; }

        public DateTime DataCriacao { get; private set; }

        public int TarefaId { get; set; }
        public virtual Tarefa Tarefa { get; set; }

        public Comentario()
        {
            DataCriacao = DateTime.Now;
        }
    }
}
