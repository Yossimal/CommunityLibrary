using data_Access.Context;
using data_Access.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace data_Access.views
{
    public partial class MyBooks : System.Web.UI.Page
    {
        public string html = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!long.TryParse(Session["user-id"]?.ToString(), out long userId))
            {
                Response.Redirect("Welcome.aspx?msg=1");
            }

            List<Offer> offers = ContextSingelton.Context.Offers
                .Include(o => o.Book)
                .Include(o => o.OfferUser)
                .Where(o => o.OfferUser.Id == userId)
                .ToList();

            foreach (Offer offer in offers)
            {
                html += $@"<tr><td>{offer.Book.Name}</td>
                    <td>{offer.StatusDescription}</td>
                    <td>{offer.CreateDate}</td>
                    <td>{offer.DaysForGive}</td>
                    <td>{offer.DaysForReturn}</td>
                    </tr>";
            }

            tableBody.InnerHtml = html;

            if (string.IsNullOrEmpty(html))
            {
                emptyPanel.Visible = true;
                tablePanel.Visible = false;
            }
        }
    }
}