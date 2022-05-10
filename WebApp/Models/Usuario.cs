using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Column(TypeName = "varchar(200)")]
        [MaxLength(200, ErrorMessage = "Tamanho máximo {1}")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Column(TypeName = "varchar(100)")]
        [MaxLength(100, ErrorMessage = "Tamanho máximo {1}")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Column(TypeName = "varchar(100)")]
        [MaxLength(100)]
        [DataType(DataType.Password, ErrorMessage = "Senha inválida")]
        public string Senha { get; set; }

        public StatusConta Status { get; private set; }

        public DateTime DataCriacao { get; private set; }

        public DateTime? DataBloqueio { get; private set; }

        public virtual ICollection<Atribuicao> Atribuicoes { get; set; }

        public Usuario()
        {
            DataCriacao = DateTime.Now;
            Status = StatusConta.Ativa;
        }

        public void Bloquear()
        {
            DataBloqueio = DateTime.Now;
            Status = StatusConta.Bloqueada;
        }
    }

    public enum StatusConta
    {
        Ativa,
        Bloqueada
    }
}
