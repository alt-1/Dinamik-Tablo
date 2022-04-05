using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Header
    {
        public int HeaderID { get; set; }
        public string HeaderName { get; set; }

        public ICollection<Data> Data { get; }
    }
}
