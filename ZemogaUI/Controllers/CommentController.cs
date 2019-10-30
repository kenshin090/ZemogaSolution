using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Interfaces.Bll;
using Microsoft.AspNetCore.Mvc;

namespace ZemogaUI.Controllers
{
    /// <summary>
    /// Controller for management of comments
    /// </summary>
    public class CommentController : Controller
    {
        /// <summary>
        /// manager of comments
        /// </summary>
        private ICommentMananger Mananger;

        /// <summary>
        /// builder for DI
        /// </summary>
        /// <param name="postMananger"></param>
        public CommentController(ICommentMananger postMananger)
        {
            Mananger = postMananger;
        }

        /// <summary>
        /// Service to create a new comments
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(Common.Entities.Comment model)
        {
            model.Author = HttpContext.User.Identity.Name.ToString();
            Mananger.Create(model);
            return Redirect("/");
        }
    }
}