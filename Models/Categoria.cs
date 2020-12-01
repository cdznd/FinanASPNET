using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinanCWebMaster.Models
{   
    [Table("Categorias")]
    public class Categoria : BaseModel
    {

        [Required(ErrorMessage = "Campo nome vazio")]
        public string Nome { get; set; }

        public virtual ICollection<Lancamento> Lancamentos { get; set; }

        //TODO
        public override string ToString() => $" Id:{ this.Id } | Nome:{ this.Nome } | Numero de lancamentos:{ Lancamentos.Count } | Data de criação:{ this.CreationDate } ";

    }
}
