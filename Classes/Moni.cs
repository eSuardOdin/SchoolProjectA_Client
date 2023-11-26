using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProjectA_Client.Classes
{
    internal class Moni
    {
        public int MoniId { get; set; }
        public string MoniLogin { get; set; } = null!;
        public string MoniPassword { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
    }
}
