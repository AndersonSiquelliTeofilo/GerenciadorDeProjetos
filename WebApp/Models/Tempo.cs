using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    [Table("Tempo")]
    public class Tempo
    {
        public int Id { get; set; }

        public DateTime DataHoraInicio { get; private set; }
        
        public DateTime? DataHoraFim { get; private set; }

        public int? Minutos { get; private set; }

        public int TarefaId { get; set; }
        public virtual Tarefa Tarefa { get; set; }

        public Tempo()
        {
            DataHoraFim = DateTime.Now;
        }

        public void Finalizar()
        {
            DataHoraFim = DateTime.Now;
        }
    }
}
