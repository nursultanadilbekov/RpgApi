using Microsoft.AspNetCore.Mvc;
using RPGApi.DTOs;
using RPGApi.Services.Interfaces;

namespace RPGApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public async Task<ActionResult<string>> Register(RegisterDto request)
    {
        var token = await _authService.RegisterAsync(request);
        return Ok(token);
    }

    [HttpPost("login")]
    public async Task<ActionResult<string>> Login(LoginDto request)
    {
        var token = await _authService.LoginAsync(request);
        return Ok(token);
    }
}