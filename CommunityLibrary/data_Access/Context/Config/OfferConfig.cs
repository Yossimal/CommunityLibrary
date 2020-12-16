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
            Property(o => o.CreateDate)
                .IsRequired();
            Property(o => o.DaysForGive)
                .IsRequired();
            Property(o => o.DaysForReturn)
                .IsRequired();
            Property(o => o.StatusDescription)
                .IsOptional();
            
            
            /*
            HasMany(o => o.Orders)
                .WithRequired(o => o.Offer)
                .HasForeignKey(o => o.OfferId);

            HasMany(o => o.Comments)
                .WithOptional(c => c.Offer)
                .HasForeignKey(c => c.OfferId);
            */
        }
    }
}