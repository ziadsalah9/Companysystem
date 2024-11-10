using Companysystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companysystem.Dtos
{
    public class PurchaseDto
    {

        public int Id { get; set; }
        public string month { get; set; }

        public DateTime Date { get; set; }


        [ForeignKey(nameof(Supplier))]
        public int SupplierId { get; set; }
        public string Supplier { get; set; }


        [ForeignKey(nameof(Item))]
        public int ItemId { get; set; }

        public string Item { get; set; }

        public decimal quantity { get; set; }

        public decimal Price { get; set; }

        public decimal PriceValue { get; set; }

        public decimal deduct { get; set; }

        public decimal TransportAndShipping { get; set; }


        public decimal Customs { get; set; }

        public decimal others { get; set; }

        public decimal NetPriceValue { get; set; }

        public decimal priceUnit { get; set; }




        [Display(Name ="مسترجعه")]
        public bool isRetirved { get; set; }
    }
}
