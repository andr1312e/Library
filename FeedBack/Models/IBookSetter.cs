using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lib.Models
{
    public interface IBookSetter
    {
        IQueryable<Book> Books { get; }
    }
}
