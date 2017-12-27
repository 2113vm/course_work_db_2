using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
  
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Number { get; set; }
 
        public string Organization { get; set; }
        public string SoftwareName { get; set; }
        public string Comment { get; set; }
        public string ClientBankInfo { get; set; }

        public User Client { get; set; }
        public User Performer { get; set; }
        public Status OrderStatus { get; set; }

        public override string ToString()
        {
            return "Заказ №" + Number + " " + SoftwareName;
        }
    }
}
