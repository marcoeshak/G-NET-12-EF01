using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_EF01
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public int YearPublished { get; set; }
        public bool IsInStock { get; set; }
    }
}
