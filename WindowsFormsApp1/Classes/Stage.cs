using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Stage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User Performer { get; set; }
        public Order OrderId { get; set; }
        public int Duration { get; set; }
        public int Priсe { get; set; }

        public override string ToString()
        {
            return Name + " " + Performer;
        }
    }
}
