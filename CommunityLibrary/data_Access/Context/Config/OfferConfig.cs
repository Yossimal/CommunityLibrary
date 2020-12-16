using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using data_Access.Models;

namespace data_Access.Context.Config
{
    public class OfferConfig:EntityTypeConfiguration<Offer>
    {
        public OfferConfig()
        {
            Property(o => o.BookId)
                .IsRequired();
        }
    }
}