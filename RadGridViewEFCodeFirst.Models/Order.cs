using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadGridViewEFCodeFirst.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public int OrderTypeId { get; set; }

        public virtual OrderType OrderType { get; set; }

        public string Description  { get; set; }

        public bool IsFinished { get; set; }
    }
}
