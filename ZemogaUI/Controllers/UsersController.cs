using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Entities;
using Common.Interfaces.Bll;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ZemogaUI.Controllers
{
    public class UsersController : Controller
    {
        private IUserMananger Mananger;
        private UserManager<ApplicationUser> RolesMananger;

        public UsersController(IUserMananger userMananger, UserManager<ApplicationUser> rolesMananger)
        {
            Mananger = userMananger;
            RolesMananger = rolesMananger;
        }

        public IActionResult Index()
        {
            return View(Mananger.GetAllUsers());
        }

        public async Task<ActionResult> AssignWriter(ApplicationUser user)
        {
            var userPersisted = await RolesMananger.FindByIdAsync(user.Id);
            await RolesMananger.AddToRoleAsync(userPersisted, "writer");
            return Redirect("/");
        }

        public async Task<ActionResult> AssignEditor(ApplicationUser user)
        {
            var userPersisted = await RolesMananger.FindByIdAsync(user.Id);
            await RolesMananger.AddToRoleAsync(userPersisted, "editor");
            return Redirect("/");
        }
    }
}