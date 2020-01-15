using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lib.Models
{
    interface IQuestionsSetter
    {
        IQueryable<Book> Questions { get; }
    }
}
