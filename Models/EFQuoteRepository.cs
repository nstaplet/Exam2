using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2.Models
{
    public class EFQuoteRepository : IQuoteRepository
    {
        private QuoteDbContext _context;

        //Constructor
        public EFQuoteRepository(QuoteDbContext context)
        {
            _context = context;
        }

        public IQueryable<Quote> Movies => _context.Quotes;
    }
}

