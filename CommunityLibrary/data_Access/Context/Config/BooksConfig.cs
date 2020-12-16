using System;
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
           
        }
    }
}