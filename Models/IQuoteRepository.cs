﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2.Models
{
    public class IQuoteRepository
    {
        IQueryable<Quote> Quotes { get; }
    }
}
