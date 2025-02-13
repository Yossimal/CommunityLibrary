﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using data_Access.Models;

namespace data_Access.Context.Config
{
    public class BooksConfig:EntityTypeConfiguration<Book>
    {
        public BooksConfig()
        {
            Property(b => b.Author)
                .IsRequired();
            Property(b => b.BarCode)
                .IsRequired();
            Property(b => b.Name)
                .IsRequired();
            /*
            HasMany(b => b.OffersList)
                .WithRequired(o => o.Book)
                .HasForeignKey(o => o.BookId);
            */

        }
    }
}