using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Nop.Core.Domain.Blogs;
using Nop.Web.Factories;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Misc.BlogExtra.Components
{
    [ViewComponent(Name = "HomepageBlogs")]

    public class HomepageBlogsViewComponent : NopViewComponent
    {
        private readonly IBlogModelFactory _blogModelFactory;
        private readonly BlogSettings _blogSettings;

        public HomepageBlogsViewComponent(IBlogModelFactory blogsModelFactory, BlogSettings blogSettings)
        {
            _blogModelFactory = blogsModelFactory;
            // _newsSettings = newsSettings;
            _blogSettings = blogSettings;
        }

        public IViewComponentResult Invoke()
        {

            if (_blogSettings.MainPageBlogPostsCount < 1)
                return Content("");

            var model = _blogModelFactory.PrepareHomepageBlogPostsModel();
            return View("~/Plugins/Misc.BlogExtra/Views/HomepageBlogs.cshtml", model);
        }
    }
}
