using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using data_Access.Models;
using data_Access.Context;

namespace data_Access.Functions
{
    public partial class Functions : DalApi
    {
        public void AddOffer(Offer offer)
        {
            Validator.TrimObject(offer);
            try
            {
                Validator.ValidateOffer(offer);
                ContextSingelton.Context.Offers.Add(offer);
                ContextSingelton.Context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("error - Couldn't add the offer");
            }
        }
        public Offer SearchOffer(long id)
        {
            var Find = ContextSingelton.Context.Offers.First(offer => offer.Id == id);
            if (Find != null)
                return Find;
            else
                throw new Exception("error offer doesn't exist");
        }
        public void UpdateOffer(Offer offer)
        {
            try
            {
                Validator.ValidateOffer(offer);
                ContextSingelton.Context.Entry(offer).CurrentValues.SetValues(offer);
                ContextSingelton.Context.SaveChanges();
            }
            catch
            {
                throw new Exception("error - Couldn't update the offer");
            }
        }
        public void DeleteOffer(long id)
        {
            var Del = ContextSingelton.Context.Offers.First(offer => offer.Id == id);
            if (Del != null)
            {
                ContextSingelton.Context.Offers.Remove(Del);
                ContextSingelton.Context.SaveChanges();
            }
            else
                throw new Exception("error -  offer doesn't exist");
        }
        public Book GetBookOffers(long id);

    }
}