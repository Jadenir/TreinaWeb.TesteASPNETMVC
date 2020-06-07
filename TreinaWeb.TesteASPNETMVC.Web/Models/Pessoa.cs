using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TreinaWeb.TesteASPNETMVC.Web.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        [DisplayName("Nome da pessoa")]
        public string Nome { get; set; }

        [DisplayName("Idade da pessoa")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "O endereço é obrigatório")]
        [DisplayName("Endereço da pessoa")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório")]
        [DisplayName("E-mail da pessoa")]
        public string Email { get; set; }
    }
}