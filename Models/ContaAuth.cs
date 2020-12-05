using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinanCWebMaster.Models
{   

    public class ContaAuth : IdentityUser
    {
        
        public ContaAuth() => CreationDate = DateTime.Now;

        //public int ContaId { get; set; }

        public DateTime CreationDate { get; set; }

    }

}
