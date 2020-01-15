using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lib.Models
{
    public class SampleRepository : IQuestionsSetter
    {
        public IQueryable<Book> Questions=>new List<>

    }
}
