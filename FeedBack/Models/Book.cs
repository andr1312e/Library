using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lib.Models
{
    public class Book
    {
        public int ProudctId { get; set; }
        public string Name { get; set; }
        public int NumberOfBooks { get; set; }
        public string Dectription { get; set; }
        public string AbsolutePathToImage { get; set; }
        public List<string> Genre { get; set; }
    }
}
