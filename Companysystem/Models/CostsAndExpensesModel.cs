using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companysystem.Models
{
    public class CostsAndExpensesModel
    {

        public int Id { get; set;}
        public DateTime Date { get; set;}

        public decimal Statment { get; set;}
        public decimal Salaries { get; set;}
        public decimal Rints { get; set; }

        public decimal PhoneandInternet { get; set;}

        public decimal WaterElectericityGas { get;set;}

        public decimal Insurance {  get; set;}

        public decimal Cars {  get; set;}
        public decimal Mails { get; set;}

        public decimal others { get; set;}

        public decimal Totalcost { get; set; }




    }
}
