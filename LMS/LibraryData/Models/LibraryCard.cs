using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryData.Models
{
    public class LibraryCard
    {
        public int Id { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Fees { get; set; }

        public DateTime Created { get; set; }

        public virtual IEnumerable<Checkout> Checkouts { get; set; }
    }
}
