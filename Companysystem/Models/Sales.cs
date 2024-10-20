using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companysystem.Models
{
    public class Sales
    {
        public int Id { get; set; }
        public int month { get; set; }

        public DateTime Date { get; set; }



        [ForeignKey(nameof(Client))]
        public int clientID { get; set; }

        public Client Client { get; set; }
        //public string clientName {  get; set; }


        [ForeignKey(nameof(Item))]
        public int ItemfkId { get; set; }

        public Item Item { get; set; }



        public int quantity {  get; set; }

        public decimal Price { get; set; }

        public decimal priceValue { get; set; }

        public decimal deduct { get; set; }
        public decimal Commissions { get; set; }

        public decimal NetPriceValue { get; set; }
        public string? Notes { get; set; }


    }
}
