using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TallerAPI.Models
{
    public class ContactoAPI
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get;set;}
        public string NombresContratoAPI { get; set; }
        public string ApellidosContratoAPI { get; set; }
        public string EmailContratoAPI { get; set; }
        public string CelularContratoAPI { get; set; }
    }
}
