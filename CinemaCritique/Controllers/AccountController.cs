﻿namespace CinemaCritique.Controllers
{
    using Microsoft.AspNetCore.Authentication.Cookies;
    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Mvc;
    using CinemaCritique.Core.Contracts;
    using CinemaCritique.Extensions;
    using Microsoft.AspNetCore.Authorization;

    [Authorize]
    [AutoValidateAntiforgeryToken]
    public class AccountController : Controller
    {
        private readonly IAccountService service;

        public AccountController(IAccountService service)
        {
            this.service = service;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            // Logout logic here
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index", "Home", new { area = "" });
        }

        public async Task<IActionResult> MyProfile()
        {
            var userId = this.User.GetId();
            var viewModel = await this.service.GetProfileViewModelAsync(userId);
            return View(viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> UploadPhoto(IFormFile photoData, string profileUserId)
        {
            string currentUserId = this.User.GetId();

            try
            {
                var result = await this.service.UpdateProfilePictureAsync(photoData, profileUserId, currentUserId);
                return Json(new { status = true, result = result});
            }
            catch (Exception e)
            {
                return Json(new { status = false, error = e.Message });
            }

            
        }
    }
}
