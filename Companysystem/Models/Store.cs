using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companysystem.Models
{
    public class Store
    {

        public int Id { get; set; }

        [ForeignKey(nameof(PurchasesBill))]        
        
        public int PurchasesBillId { get; set; }
        public Purchases PurchasesBill { get; set; }

        public decimal price { get; set; }


        public decimal BeginingStore { get; set; }
        public decimal incoming { get; set; }
        public decimal outgoing { get; set; }
        public decimal EndingStore { get; set; }

        public decimal InventoryCost { get; set; }


        
      

        public string item { get; set;}
        
        public decimal priceUnit { get; set; }
   


        



    }
}
