using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companysystem.Dtos
{
    public class StoreDto
    {

        public int Id { get; set; }
        public string month { get; set; }

        public DateTime Date { get; set; }

        public int BillNumber { get; set; }

        public string Supplier { get; set; }

        public string Item { get; set; }

        public decimal PricefromBill { get; set; }  
        public decimal Price { get; set; }

        public int BeginingStore { get; set; }
        public int incoming { get; set; }
        public int outgoing { get; set; }
        public int EndingStore { get; set; }

        public decimal InventoryCost { get; set; }

      
    }
}
