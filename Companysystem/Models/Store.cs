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
        
        public int? PurchasesBillId { get; set; }
        public Purchases PurchasesBill { get; set; }

        public decimal price { get; set; }


        public int BeginingStore { get; set; }
        public int incoming { get; set; }
        public int outgoing { get; set; }
        public int EndingStore { get; set; }

        public decimal InventoryCost { get; set; }


        
        public int? salesid { get; set; }
        public Sales Sales { get; set; }

        public string item { get; set;}
        
   


        



    }
}
