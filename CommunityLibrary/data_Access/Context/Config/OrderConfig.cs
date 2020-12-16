using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using data_Access.Models;

namespace data_Access.Context.Config
{
    public class OrderConfig:EntityTypeConfiguration<Order>
    {
        public OrderConfig()
        {
            Property(o => o.ReciveTime)
                .IsOptional();
            Property(o => o.ReturnTime)
                .IsOptional();
            Property(o => o.StartTime)
                .IsRequired();
            Property(o => o.OfferId);

            /*
            HasMany(o => o.Comments)
                .WithOptional(c => c.Order)
                .HasForeignKey(c => c.OrderId);
            */
        }
    }
}