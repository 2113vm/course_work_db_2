using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Contract
    {
        public int Id { get; set; }
        public Order Order {get;set;}
        public string Customer { get; set; }
        public string Performer { get; set; }
        public string Subject { get; set; }
        public DateTime Date { get; set; }
        public int ContractTime { get; set; }
        public int TotalCost { get; set; }
    }
}
