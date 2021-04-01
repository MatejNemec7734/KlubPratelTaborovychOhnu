using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KlubPrátelTaborovychOhnu.Models;

namespace KlubPrátelTaborovychOhnu.ViewModels
{
    public class Hledani
    {
        public string NazevClanku { get; set; }
        public int PocetClanku { get; set; }
        public List<Clanek> CLanky { get; set; }
    }
}
