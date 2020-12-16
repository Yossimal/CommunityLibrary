using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using data_Access.Models;
using  data_Access.Context;

namespace data_Access.views
{
    public partial class OfferBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user-id"] == null)
            {
                Response.Redirect("Welcome.aspx?msg=1");
            }
        }

        protected void OnClick(object sender, EventArgs e)
        {
            Offer toAdd=new Offer();
            Book offeredBook = ContextSingelton.Context.Books.FirstOrDefault(b => b.BarCode == bookCode.Value);
            if (offeredBook == null)
            {
                offeredBook=new Book();
                offeredBook.BarCode = bookCode.Value;
                offeredBook.Name = bookName.Value;
                offeredBook.Author = bookAuthor.Value;
                ContextSingelton.Context.Books.Add(offeredBook);
            }

            toAdd.Book = offeredBook;
            toAdd.CreateDate=DateTime.Now;
            toAdd.OfferUser = ContextSingelton.Context.Users.Find(Session["user-id"].ToString());
            toAdd.DaysForGive = int.Parse(timeToProvide.Value);
            toAdd.DaysForReturn = int.Parse(timeToReturn.Value);
            ContextSingelton.Context.Offers.Add(toAdd);
            ContextSingelton.Context.SaveChanges();

        }
    }
}