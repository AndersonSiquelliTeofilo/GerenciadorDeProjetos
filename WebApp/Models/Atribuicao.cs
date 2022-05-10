using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    [Table("Atribuicao")]
    public class Atribuicao
    {
        public int TarefaId { get; set; }
        public virtual Tarefa Tarefa { get; set; }

        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
