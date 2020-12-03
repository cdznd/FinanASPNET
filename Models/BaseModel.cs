using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinanCWebMaster.Models
{
    public class BaseModel
    {

        //public BaseModel() => CreationDate = DateTime.Now;

        public BaseModel()
        {

            CreationDate = DateTime.Now;

        }

        [Key]
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
