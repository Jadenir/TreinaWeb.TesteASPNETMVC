using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace TreinaWeb.TesteASPNETMVC.Web.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        [DisplayName("Nome da pessoa")]
        [MaxLength(50, ErrorMessage = "O nome pode ter no máximo 50 caracteres")]
        [MinLength(5, ErrorMessage = "O nome deve ter no mínimo 5 caracteres")]
        public string Nome { get; set; }

        [DisplayName("Idade da pessoa")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "O endereço é obrigatório")]
        [DisplayName("Endereço da pessoa")]
        [MaxLength(100, ErrorMessage = "O endereço pode ter no máximo 100 caracteres")]
        [MinLength(5, ErrorMessage = "O endereço deve ter no mínimo 5 caracteres")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório")]
        [DisplayName("E-mail da pessoa")]
        [MaxLength(20, ErrorMessage = "O e-mail pode ter no máximo 20 caracteres")]
        [MinLength(5, ErrorMessage = "O e-mail deve ter no mínimo 5 caracteres")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}