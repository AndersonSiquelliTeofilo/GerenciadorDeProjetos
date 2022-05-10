using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    [Table("Tarefa")]
    public class Tarefa
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(1000)")]
        [MaxLength(1000, ErrorMessage = "Tamanho máximo {1}")]
        public string Descricao { get; set; }

        public Prioridade Prioridade { get; set; }

        public StatusTarefa Status { get; set; }

        public DateTime DataCriacao { get; private set; }

        public DateTime? DataVencimento { get; set; }

        public DateTime? DataFim { get; private set; }

        public int ProjetoId { get; set; }
        public virtual Projeto Projeto { get; set; }

        public virtual ICollection<Atribuicao> Atribuicoes { get; set; }

        public virtual ICollection<Tempo> Tempos { get; set; }

        public virtual ICollection<Comentario> Comentarios { get; set; }

        public Tarefa()
        {
            DataCriacao = DateTime.Now;
        }

        public void Finalizar()
        {
            DataFim = DateTime.Now;
            Status = StatusTarefa.Completo;
        }
    }

    public enum Prioridade
    {
        Baixo,
        Medio,
        Alto
    }

    public enum StatusTarefa
    {
        ParaFazer,
        AguardandoCliente,
        EmAndamento,
        AplicarEmHomolog,
        AplicarEmProducao,
        Testar,
        Completo
    }
}
