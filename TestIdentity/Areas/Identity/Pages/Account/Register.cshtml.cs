﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using TestIdentity.Data;
using TestIdentity.Models;

namespace TestIdentity.Areas.Identity.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IUserStore<IdentityUser> _userStore;
        private readonly IUserEmailStore<IdentityUser> _emailStore;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private ApplicationDbContext _applicationDbContext = null;

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            IUserStore<IdentityUser> userStore,
            SignInManager<IdentityUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            ApplicationDbContext applicationDbContext)
        {
            _userManager = userManager;
            _userStore = userStore;
            _roleManager = roleManager;
            _emailStore = GetEmailStore();
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _applicationDbContext = applicationDbContext;
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public List<Gender> Genders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
        
        public class InputModel
        {
            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required(ErrorMessage = "L'adresse mail est requise.")]
            [EmailAddress(ErrorMessage = "L'adresse mail n'est pas valide.")]
            [Display(Name = "Email")]
            public string Email { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required(ErrorMessage = "Le champ est requis")]
            [StringLength(100, ErrorMessage = "Le {0} doit contenir entre {2} et {1} caractères.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Mot de passe")]
            public string Password { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "Le mot de passe et la confirmation sont différents.")]
            public string ConfirmPassword { get; set; }


            [Required(ErrorMessage = "Le champ est requis")]
            [RegularExpression(@"^(?=.{1,40}$)[a-zA-Z]+(?:[-'\s][a-zA-Z]+)*$", ErrorMessage = "Les chiffres et caractères spéciaux ne sont pas autorisés.")]
            public string Name { get; set; }


            [Required(ErrorMessage = "Le champ est requis")]
            [RegularExpression(@"^(?=.{1,40}$)[a-zA-Z]+(?:[-'\s][a-zA-Z]+)*$", ErrorMessage = "Les chiffres et caractères spéciaux ne sont pas autorisés.")]
            public string FirstName { get; set; }
            public string Role { get; set; }
            public Gender Gender { get; set; }
        }


        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    
                    returnUrl ??= Url.Content("~/");
                    ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
                    if (ModelState.IsValid)
                    {

                        var user = CreateUser();
                        await _userStore.SetUserNameAsync(user, Input.Email, CancellationToken.None);
                        await _emailStore.SetEmailAsync(user, Input.Email, CancellationToken.None);
                        
                        var result = await _userManager.CreateAsync(user, Input.Password);
                        
                        
                        Member member = new();
                        member.FirstName = Input.FirstName;
                        member.Name = Input.Name;
                        member.User = user;
                        _applicationDbContext.Add(member);
                        var memberResult = await _applicationDbContext.SaveChangesAsync();

                        

                        if (result.Succeeded && memberResult > 0)
                        {
                            var resultRole = await _userManager.AddToRoleAsync(user, Input.Role);

                            if (resultRole.Succeeded)
                            {
                                scope.Complete();
                                _logger.LogInformation("User created a new account with password.");

                                var userId = await _userManager.GetUserIdAsync(user);
                                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                                var callbackUrl = Url.Page(
                                    "/Account/ConfirmEmail",
                                    pageHandler: null,
                                    values: new { area = "Identity", userId = userId, code = code, returnUrl = returnUrl },
                                    protocol: Request.Scheme);

                                await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                                    $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                                if (_userManager.Options.SignIn.RequireConfirmedAccount)
                                {
                                    return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                                }
                                else
                                {
                                    using (var scope2 = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                                    {
                                        await _signInManager.SignInAsync(user, isPersistent: false);
                                        scope2.Complete();
                                        return LocalRedirect(returnUrl);
                                    }
                                }
                            }
                            
                        }
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                            scope.Dispose();
                        }
                    }


                }
                catch (Exception ex)
                {
                    //return Page();
                    scope.Dispose();
                    throw;
                }
            }
           
            // If we got this far, something failed, redisplay form
            return Page();
        }

        private IdentityUser CreateUser()
        {
            try
            {
                return Activator.CreateInstance<IdentityUser>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(IdentityUser)}'. " +
                    $"Ensure that '{nameof(IdentityUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

        private IUserEmailStore<IdentityUser> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<IdentityUser>)_userStore;
        }
        


    }
}
