﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorkPattern.Domain.Entity
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
