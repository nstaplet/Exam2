using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2.Models
{
    public class Quote
    {
        [Key]
        public int QuoteId { get; set; }
        public string QuoteText { get; set; }
        public string Author { get; set; }
        public string Date { get; set; }
        public string Subject { get; set; }
        public string Citation { get; set; }

    }
}
