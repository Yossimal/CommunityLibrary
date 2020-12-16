using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using data_Access.Models;

namespace data_Access.Context.Config
{
    public class UserConfig:EntityTypeConfiguration<User>
    {
        public UserConfig()
        {
            Property(c => c.UserName)
                .IsRequired();

            Property(c => c.FirstName)
                .IsRequired();
            Property(c => c.LastName)
                .IsRequired();
            Property(c => c.AddressId)
                .IsRequired();
            Property(c => c.EmailAddress)
                .IsRequired();

            Property(u => u.BirthDate)
                .IsRequired();

            Property(u => u.Role)
                .IsRequired();
                

            HasMany(u => u.Comments)
                .WithRequired(c => c.User)
                .HasForeignKey(c => c.UserId)
                .WillCascadeOnDelete(false);

            
        }
    }
}