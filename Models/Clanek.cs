using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KlubPrátelTaborovychOhnu.Models
{
    public class Clanek
    {        
        public int Id { get; set; }
        public string Textik { get; set; }
        public string Nazev { get; set; }

       /*[ForeignKey(nameof(Osoba))]
        public int IdAutora { get; set; } */      
        public Clanek() 
        {
            
        }
    }
}
