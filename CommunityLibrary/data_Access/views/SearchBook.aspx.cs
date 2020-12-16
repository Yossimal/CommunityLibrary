using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using data_Access.Models;
using data_Access.Context;

namespace data_Access.views
{
    public partial class SearchBook : System.Web.UI.Page
    {
        public string html="";
        Functions.Functions func=new Functions.Functions();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Search_OnClick(object sender, EventArgs e)
        {
            List<Offer> offers = ContextSingelton.Context.Offers.Include(o=>o.Book).Include(o=>o.OfferUser.Address).Where(o => o.Book.Name.Contains(BookToSearch.Text)).ToList();
            foreach (Offer offer in offers)
            {
                html+= $@"<tr><td>{offer.Book.Name}</td>
                    <td>{offer.OfferUser.Address.City}</td>
                    <td>{offer.OfferUser.Address.StreatAddress}</td>
                    <td>{offer.OfferUser.Address.HouseNumber}</td>
                    <td>{offer.OfferUser.Address.Apartment}</td>
                    <td>{offer.OfferUser.PhoneNumber}</td>
                    <td>{offer.OfferUser.EmailAddress}</td>
                    </tr>";
            }

            tableBody.InnerHtml = html;
        }
    }
}