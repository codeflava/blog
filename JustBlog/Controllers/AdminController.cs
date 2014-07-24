using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using JustBlog.DataAccess;
using JustBlog.Models;
using MongoDB.Bson;

namespace JustBlog.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
		public ActionResult Index(Post post)
		{
			var repository = new PostRepository();
			if (!string.IsNullOrEmpty(post.Title))
			{
				repository.Insert(post);
				return new RedirectResult("/Home/Index");
			}
			
			return View();
		}

	    public ActionResult Create(Post post)
		{
			
		    return View();

		}

	    public ActionResult Edit()
	    {
		    return View();
	    }

	   


    }
}