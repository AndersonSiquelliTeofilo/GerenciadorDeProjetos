using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    [Table("Projeto")]
    public class Projeto
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(100)")]
        [MaxLength(100, ErrorMessage = "Tamanho máximo {1}")]
        public string Cliente { get; set; }

        [Column(TypeName = "varchar(500)")]
        [MaxLength(500, ErrorMessage = "Tamanho máximo {1}")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public StatusProjeto Status { get; set; }

        public DateTime DataCriacao { get; private set; }

        public DateTime? DataVencimento { get; set; }

        public DateTime? DataFim { get; private set; }

        public virtual ICollection<Tarefa> Tarefas { get; set; }

        public Projeto()
        {
            DataCriacao = DateTime.Now;
        }

        public void Finalizar()
        {
            DataFim = DateTime.Now;
        }
    }

    public enum StatusProjeto
    {
        NaoIniciado,
        EmAndamento,
        Teste,
        Completo
    }
}
