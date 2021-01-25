using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PastaBar.Models
{
    public class Pasta
    {
        public int Id { get; set; }
        public Soortpasta Soort { get; set; }
        public GrottePasta Grotte { get; set; }
        public SausPasta Saus { get; set; }

    }
}
