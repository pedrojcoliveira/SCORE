using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;

namespace SCORE.Areas.Identity.Pages.Account
{
    public class ConfirmEmailModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public ConfirmEmailModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> OnGetAsync(string userId, string code)
        {
            if (userId == null || code == null)
            {
                // Se o ID do usuário ou o código estiverem ausentes, redirecionar para a página de erro ou tratamento apropriada.
                return RedirectToAction("Error");
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                // Se o usuário não for encontrado, redirecionar para a página de erro ou tratamento apropriada.
                return RedirectToAction("Error");
            }

            code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
            var result = await _userManager.ConfirmEmailAsync(user, code);

            if (result.Succeeded)
            {
                // Realiza o login automático através do método SignInAsync sem persistência
                await _signInManager.SignInAsync(user, isPersistent: false);

                // Redireciona o usuário para a página desejada
                return RedirectToAction("Home/Index");
            }
            else
            {
                // Se a confirmação do e-mail falhar, redirecionar para a página de erro ou tratamento apropriada.
                return RedirectToAction("Error");
            }
        }

    }
}
