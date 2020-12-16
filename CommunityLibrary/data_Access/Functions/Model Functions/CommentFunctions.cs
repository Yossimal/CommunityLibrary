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
        public void AddComment(Comment comment)
        {
            Validator.TrimObject(comment);
            try
            {
                Validator.ValidateComment(comment);
                ContextSingelton.Context.Comments.Add(comment);
                ContextSingelton.Context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("error - Couldn't add the comment");
            }
        }
        public Comment SearchComment(long id)
        {
            var Find = ContextSingelton.Context.Comments.First(comment => comment.Id == id);
            if (Find != null)
                return Find;
            else
                throw new Exception("error comment doesn't exist");
        }
        public void UpdateComment(Comment comment)
        {
            try
            {
                Validator.ValidateComment(comment);
                ContextSingelton.Context.Entry(comment).CurrentValues.SetValues(comment);
                ContextSingelton.Context.SaveChanges();
            }
            catch
            {
                throw new Exception("error - Couldn't update the comment");
            }
        }
        public void DeleteComment(long id)
        {
            var Del = ContextSingelton.Context.Comments.First(comment => comment.Id == id);
            if (Del != null)
            {
                ContextSingelton.Context.Comments.Remove(Del);
                ContextSingelton.Context.SaveChanges();
            }
            else
                throw new Exception("error -  comment doesn't exist");
        }
        public ICollection<Comment> GetAllComments(Func<Comment, bool> predicate = null)
        {
            if (predicate == null)
                return ContextSingelton.Context.Comments.ToList();
            return ContextSingelton.Context.Comments.Where(predicate).ToList();
        }

    }
}