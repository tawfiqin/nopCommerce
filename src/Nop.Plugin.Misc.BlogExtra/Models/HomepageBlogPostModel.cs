using System;
using System.Collections.Generic;
using System.Text;
using Nop.Web.Framework.Models;
using Nop.Web.Models.Blogs;

namespace Nop.Plugin.Misc.BlogExtra.Models
{
    public class HomepageBlogPostsModel : BaseNopModel, ICloneable
    {
        public HomepageBlogPostsModel()
        {
            BlogPosts = new List<BlogPostModel>();
        }

        public int WorkingLanguageId { get; set; }
        public IList<BlogPostModel> BlogPosts { get; set; }

        public object Clone()
        {
            //we use a shallow copy (deep clone is not required here)
            return MemberwiseClone();
        }
    }
}
