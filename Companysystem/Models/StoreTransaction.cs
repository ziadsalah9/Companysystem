using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companysystem.Models
{
    public class StoreTransaction
    {


        public int Id { get; set; }

        [ForeignKey("Store")]
        public int storessId { get; set; }

        public Store Store { get; set; }



        [ForeignKey("Purchases")]
        public int purchasessId { get; set; }

        public Purchases Purchases { get; set; }

        [ForeignKey("Sales")]

        public int salessId { get; set; }

        public Sales Sales{ get; set; }


        public int quantity { get; set; }
    }
}
