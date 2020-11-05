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

        //Uma conta tem varios lançamentos, então
        public virtual ICollection<Lancamento> Lancamentos { get; set; }

        //TODO
        public override string ToString() => $" Id:{ this.Id } | Nome:{ this.FirstName } | Sobrenome:{ this.SecondName } | CPF:{ this.Cpf } | Numero de lancamentos:{ this.Lancamentos.Count } | Data de criação:{ this.CreationDate } ";

    }

}
