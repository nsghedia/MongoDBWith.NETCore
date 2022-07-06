using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core
{
    internal interface IBookServices
    {
        IEnumerable<Book> GetBooks();
    }
}
