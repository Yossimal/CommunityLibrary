using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using data_Access.Models;

namespace data_Access.Context.Config
{
    public class AddressConfig:EntityTypeConfiguration<Address>
    {
        public AddressConfig()
        {
            Property(a => a.ZipCode)
                .IsRequired();
            Property(a => a.Country)
                .IsRequired();


            HasMany(a => a.UsersInAddress)
                .WithRequired(u => u.Address)
                .HasForeignKey(u => u.AddressId);
        }
    }
}