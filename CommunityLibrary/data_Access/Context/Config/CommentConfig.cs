using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using data_Access.Models;

namespace data_Access.Context.Config
{
    public class CommentConfig:EntityTypeConfiguration<Comment>
    {
        public CommentConfig()
        {
            Property(c => c.Content)
                .IsRequired();
            Property(c => c.Reference)
                .IsRequired();
            Property(c => c.UserId)
                .IsRequired();
            Property(c => c.Rating)
                .IsRequired();

            

        }
    }
}