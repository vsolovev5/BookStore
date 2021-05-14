using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class PurchaseWithBookName
    {
        public int PurchaseId { get; set; }
        public string Person { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }

    }
}
