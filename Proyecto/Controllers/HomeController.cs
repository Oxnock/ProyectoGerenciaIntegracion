using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using SampleMvcApp.Data;

namespace SampleMvcApp.Controllers
{
    public class HomeController : Controller
    {

        public static bool FormInicialFlag = true;



        public async Task<IActionResult> Index()
        {
            // If the user is authenticated, then this is how you can get the access_token and id_token
            if (User.Identity.IsAuthenticated)
            {
                string accessToken = await HttpContext.GetTokenAsync("access_token");

                // if you need to check the access token expiration time, use this value
                // provided on the authorization response and stored.
                // do not attempt to inspect/decode the access token
                DateTime accessTokenExpiresAt = DateTime.Parse(
                    await HttpContext.GetTokenAsync("expires_at"),
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.RoundtripKind);

                string idToken = await HttpContext.GetTokenAsync("id_token");

                // Now you can use them. For more info on when and how to use the
                // access_token and id_token, see https://auth0.com/docs/tokens

                
                // HECHO POR MACHO


                sql3283190Context context = HttpContext.RequestServices.GetService(typeof(sql3283190Context)) as sql3283190Context;

                // aqui lo que hago es asegurarme que si el usuario audentificado esta en la base sino para meterlo 
                if (context.BuscarPersonaCorreoValidar(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value) == false)
                {
                    //  amodar esta verga abajo
                   // context.InsertarUsuarioPrimeraVez(User.Identity.Name, User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value, User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.MobilePhone)?.Value); // este metodo lo que hace es insertar por primera ves en la base
                    FormInicialFlag = false;

                    return RedirectToAction("FORMINICIAL", "Profile");

                    // no borrar
                }
            }
            FormInicialFlag = true;
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
