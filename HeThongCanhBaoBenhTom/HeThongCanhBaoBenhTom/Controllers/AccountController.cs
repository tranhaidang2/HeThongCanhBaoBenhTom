using HeThongCanhBaoBenhTom.Data;
using HeThongCanhBaoBenhTom.Helper;
using HeThongCanhBaoBenhTom.Models;
using HeThongCanhBaoBenhTom.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HeThongCanhBaoBenhTom.Controllers
{
    public class AccountController : Controller
    {
        private readonly HeThongCanhBaoBenhTomContext _context;

        public AccountController(HeThongCanhBaoBenhTomContext context)
        {
            _context = context;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel _info)
        {
            if (ModelState.IsValid)
            { 
                var hashedPassword = PasswordHelper.HashPassword(_info.Password);

                var user = new User
                {
                    UserId = Guid.NewGuid(),
                    Username = _info.Username,
                    Email = _info.Email,
                    PasswordHash = hashedPassword,
                    CreatedAt = DateTime.Now,
                    RoleId = 1 
                };

                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                return Json(new { success = true, message = "Đăng ký thành công!" });
            }

            return Json(new { success = false, message = "Đăng ký thất bại" });
        }
    }
}
