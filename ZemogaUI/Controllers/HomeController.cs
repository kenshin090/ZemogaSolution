using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Common.Entities;
using Common.Interfaces.Bll;
using Microsoft.AspNetCore.Mvc;
using ZemogaUI.Models;

namespace ZemogaUI.Controllers
{
    /// <summary>
    /// Controller for home page
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Mananger for post
        /// </summary>
        private IPostMananger Mananger;

        /// <summary>
        /// builder for injection
        /// </summary>
        /// <param name="postMananger"></param>
        public HomeController(IPostMananger postMananger)
        {
            Mananger = postMananger;
        }

        /// <summary>
        /// management of index page
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            List<Post> posts = Mananger.GetAllPost(User.Identity.IsAuthenticated);
            return View(posts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        /// <summary>
        /// initial of create post view
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View("CreatePost", new Common.Entities.Post());
        }

        /// <summary>
        /// error page management
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /// <summary>
        /// method for create a new post
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(Common.Entities.Post model)
        {
            Mananger.Create(model);
            return Redirect("/");
        }

        /// <summary>
        /// return the currents post
        /// </summary>
        /// <returns></returns>
        public IActionResult Details()
        {
            var posts = Mananger.Search(true);
            return View("Details", posts);
        }

        /// <summary>
        /// Method for delete a post
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var post = Mananger.Get(id);
            return View("Edit", post);
        }

        /// <summary>
        /// Method for publish a post
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Publish(int id)
        {
            var post = Mananger.Get(id);
            post.Status = true;
            Mananger.Update(post.Id, post);
            return Redirect("/");
        }

        /// <summary>
        /// Method for delete a post
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Delete(int id)
        {
            var post = Mananger.Delete(id);
            return this.Details(); ;
        }

        /// <summary>
        /// Method for edit a post
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Edit(Common.Entities.Post model)
        {
            var post = Mananger.Update(model.Id, model);
            return this.Details();
        }
    }
}