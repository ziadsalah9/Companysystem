using Companysystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companysystem.Dtos
{
    public class SalesDto
    {

        public int Id { get; set; }
        public int month { get; set; }

        public DateTime Date { get; set; }



        [ForeignKey(nameof(clientID))]
        public string Client { get; set; }
        public int clientID { get; set; }
        //public string clientName {  get; set; }


        [ForeignKey(nameof(ItemfkId))]
        public string Item { get; set; }
        public int ItemfkId { get; set; }
        

        public int quantity { get; set; }

        public decimal Price { get; set; }

        public decimal priceValue { get; set; }

        public decimal deduct { get; set; }
        public decimal Commissions { get; set; }

        public decimal NetPriceValue { get; set; }
        public string? Notes { get; set; }
    }
}
