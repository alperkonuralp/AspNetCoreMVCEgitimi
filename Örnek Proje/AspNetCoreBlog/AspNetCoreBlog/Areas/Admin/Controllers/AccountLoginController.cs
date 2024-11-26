using AspNetCoreBlog.Areas.Admin.Models;
using AspNetCoreBlog.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]")]
    public class AccountLoginController : Controller
    {
        private readonly SignInManager<BlogUser> _signInManager;
        private readonly ILogger<AccountLoginController> _logger;

        public AccountLoginController(SignInManager<BlogUser> signInManager, ILogger<AccountLoginController> logger)
        {
            _signInManager = signInManager;
            _logger = logger;
        }

        [HttpGet("Login")]
        public async Task<IActionResult> LoginAsync(string returnUrl = null)
        {
            var model = new LoginViewModel();

            returnUrl ??= Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            model.ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            model.ReturnUrl = returnUrl;

            return View(model);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> LoginAsync([FromForm] LoginViewModel model)
        {
            model.ReturnUrl ??= Url.Content("~/");

            model.ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(model.Input.Email, model.Input.Password, model.Input.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User logged in.");
                    return LocalRedirect(model.ReturnUrl);
                }
                if (result.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = model.ReturnUrl, RememberMe = model.Input.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    _logger.LogWarning("User account locked out.");
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View(model);
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }
    }
}