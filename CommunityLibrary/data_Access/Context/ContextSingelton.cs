using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace data_Access.Context
{
    public class ContextSingelton
    {
        static DataContext dataContext = null;
        public static DataContext Context
        {
            get
            {
                if (dataContext == null)
                {
                    dataContext = new DataContext();
                    return dataContext;
                }
                return dataContext;
            }
        }
        private ContextSingelton() { }
    }
}