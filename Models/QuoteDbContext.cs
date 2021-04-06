﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2.Models
{
    public class QuoteDbContext : DbContext
    {
        public QuoteDbContext (DbContextOptions<QuoteDbContext> options) : base (options)
        {

        }

        public DbSet<Quote> Quotes { get; set; }
    }
}
