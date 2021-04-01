using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KlubPrátelTaborovychOhnu.Models;

namespace KlubPrátelTaborovychOhnu.ViewModels
{
    public class AhojViewModel
    {
        public Clanek Bonus { get; set; }
        public string Jmeno { get; set; }
        public int Vstup { get; set; }  
        public int Id { get; set; }
        public AhojViewModel() 
        {

        }
    }
}
