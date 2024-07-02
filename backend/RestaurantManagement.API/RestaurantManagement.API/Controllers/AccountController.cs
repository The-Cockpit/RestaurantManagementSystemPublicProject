using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Google.Apis.Auth;
using RestaurantManagement.API.Models;
using System;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using RestaurantManagement.API.Enums;
using Microsoft.AspNetCore.Authentication.Google;
using RestaurantManagement.API.Data;
using System.Web.Http.Cors;
using RestaurantManagement.API.Dtos;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;



[Route("api/[controller]")]
[ApiController]

public class AccountController : ControllerBase
{
    private readonly UserManager<Employee> _userManager;
    private readonly SignInManager<Employee> _signInManager;
    private readonly IConfiguration _configuration;
    private readonly ILogger<AccountController> _logger;
    private readonly DataContext _context;

    public AccountController(UserManager<Employee> userManager, SignInManager<Employee> signInManager, IConfiguration configuration, ILogger<AccountController> logger, DataContext context)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _configuration = configuration;
        _logger = logger;
        _context = context;
    }

    [HttpGet("signin-callback")]
    public async Task<IActionResult> GoogleCallback()
    {
        _logger.LogInformation("Google callback init");
        var result = await HttpContext.AuthenticateAsync(GoogleDefaults.AuthenticationScheme);
        if (!result.Succeeded)
            return BadRequest("google auth failed");

        var googleUser = result.Principal;
        var email = googleUser.FindFirstValue(ClaimTypes.Email);
        var user = await _userManager.FindByNameAsync(email);

        if (user == null)
        {
            user = new Employee()
            {
                Id = googleUser.FindFirstValue(ClaimTypes.NameIdentifier),
                FullName = googleUser.FindFirstValue(ClaimTypes.Name),
                Email = email,
                NormalizedEmail = email.ToUpperInvariant(),
                EmailConfirmed = true,
                Type = EmployeeType.None,
                IsManager = false,
                UserName = email,
                NormalizedUserName = email.ToUpperInvariant()
            };

            var createResult = await _userManager.CreateAsync(user);
            if (!createResult.Succeeded)
            {
                return BadRequest("Failed to create user");
            }

            var infoUser = new UserLoginInfo("google", googleUser.FindFirstValue(ClaimTypes.NameIdentifier), "Google");
            var addLoginResult = await _userManager.AddLoginAsync(user, infoUser);
            if (!addLoginResult.Succeeded)
            {
                return BadRequest("Failed to add external login");
            }
        }

        await _signInManager.SignInAsync(user, isPersistent: true);
        return Redirect("http://localhost:5173/");
    }

    [HttpGet("signin-google")]
    public IActionResult SignInWithGoogle()
    {
        return Challenge(new AuthenticationProperties
        {
            RedirectUri = Url.Action(nameof(GoogleCallback))
        }, GoogleDefaults.AuthenticationScheme);
    }


    [Authorize]
    [HttpPost("logout")]
    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        return Ok(new { message = "Logged out successfully" });
    }

    [AllowAnonymous]
    [HttpPost("user/{token}")]
    public async Task<ActionResult<UserDtoTemp>> GetUser([FromRoute] string token)
    {
        UserDtoTemp employeeInfo;
        try
        {
            var googleUser = await GoogleJsonWebSignature.ValidateAsync(token, new GoogleJsonWebSignature.ValidationSettings
            {
                Audience = new[] { _configuration["Authentication:Google:ClientId"] }
            });

            var user = await _userManager.FindByIdAsync(googleUser.Subject);
            if (user == null)
            {
                user = new Employee()
                {
                    Id = googleUser.Subject,
                    FullName = googleUser.Name,
                    Email = googleUser.Email,
                    NormalizedEmail = googleUser.Email.ToUpperInvariant(),
                    EmailConfirmed = true,
                    Type = EmployeeType.None,
                    IsManager = false,
                    UserName = googleUser.Email,
                    NormalizedUserName = googleUser.Email.ToUpperInvariant()
                };

                var createResult = await _userManager.CreateAsync(user);
                if (!createResult.Succeeded)
                {
                    return BadRequest("Failed to create user");
                }
            }

            employeeInfo = new UserDtoTemp()
            {
                EmployeeId = googleUser.Subject,
                FirstName = googleUser.GivenName,
                LastName = googleUser.FamilyName,
                EmployeeType = user.Type,
                EmployeeManagerOn = user.IsManager

                //TODO: ADD MANAGER ON WHO
            };

            return Ok(employeeInfo);

        }
        catch (Exception ex)
        {
            return BadRequest("\nBad Token\n");
        }
    }
}
