using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arseni_Teodora_Madalina_Lab8.Models
{
    public class BookData
    {
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<BookCategory> BookCategories { get; set; }

    }
}
