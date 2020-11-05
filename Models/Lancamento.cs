using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinanCWebMaster.Models
{
    [Table("Lancamentos")]
    public class Lancamento : BaseModel
    {

        [ForeignKey("Categoria")]
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

        [ForeignKey("Conta")]
        public int ContaId { get; set; }
        public virtual Conta Conta { get; set; }

        [Required(ErrorMessage = "Campo valor vazio")]
        [DataType(DataType.Currency)]
        public double Valor { get; set; }

        [DataType(DataType.Text)]
        public string Description { get; set; }

        //TODO
        public override String ToString() => $" Id:{ this.Id } | Titular da conta:{ Conta.FirstName } | Sobrenome do Titular da conta:{ Conta.SecondName } | Categoria:{ Categoria.Nome } | Valor:{ this.Valor } | Data de criação:{ this.CreationDate } ";

    }
}
