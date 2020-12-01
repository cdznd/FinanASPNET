using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinanCWebMaster.Models
{

    [Table("Contas")]
    public class Conta : BaseModel
    {

        //Personal info

        [MaxLength(20, ErrorMessage = "No maximo 20 Caracteres")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Campo nome vazio")]
        public string FirstName { get; set; }

        [DataType(DataType.Text)]
        [MaxLength(20, ErrorMessage = "No maximo 20 Caracteres")]
        [Required(ErrorMessage = "Campo nome vazio")]
        public string SecondName { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Campo CPF vazio")]
        public string Cpf { get; set; }

        public string Image { get; set; }

        //Uma conta tem varios lançamentos, então
        public virtual ICollection<Lancamento> Lancamentos { get; set; }

        //Account info

        //Class for authenticate Conta values
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Campo obrigatorio")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Campo obrigatorio")]
        public string Password { get; set; }


        [Display(Name = "Validating")]
        [Required(ErrorMessage = "Campo obrigatorio")]
        [NotMapped]
        [Compare("Password", ErrorMessage = "Passwords not matching")]
        public string PasswordValidation { get; set; }

        //TODO
        //public override string ToString() => $" Id:{ this.Id } | Nome:{ this.FirstName } | Sobrenome:{ this.SecondName } | CPF:{ this.Cpf } | Numero de lancamentos:{ this.Lancamentos.Count } | Data de criação:{ this.CreationDate } ";

    }
}
