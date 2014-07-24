using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JustBlog.DataAccess;

namespace JustBlog.Controllers
{
	
    public class HomeController : Controller
    {
		// GET: Home
        public ActionResult Index()
        {
			var repository = new PostRepository();
	        var posts = repository.GetAll();
            return View(posts.OrderByDescending(item => item.CreatedDate).ToList());
        }

	    public ActionResult About()
	    {
		    return View();
	    }

	    public string TellMeDate()
	    {
		    return DateTime.Now.ToString("hh:mm:ss");
	    }
    }
}