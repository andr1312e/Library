using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lib.Models
{
    public class SampleRepository : IBookSetter
    {
        public IQueryable<Book> Books => new List<Book>
        {
            new Book{Name="Война и мир", Author="Лев Толстой", Genre=new List<string>{"Роман", "Приключения" }, Dectription="Кто ж войну и мир не знает", AbsolutePathToImage=null, NumberOfBooks=2  },
            new Book{Name="Метро 2033", Author="Дмитрий Глуховский", Genre= new List<string>{"Апокалипсис", "Приключения" }, Dectription="Жизнь в Московском метро", AbsolutePathToImage=null, NumberOfBooks=1 }
        }.AsQueryable<Book>();

    }
}
