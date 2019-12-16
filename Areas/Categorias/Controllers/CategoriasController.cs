using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.Areas.Categorias.Models;
using ProyectoWeb.Controllers;
using ProyectoWeb.Library;
using ProyectoWeb.Models;
using SistemasWeb.Data;

namespace ProyectoWeb.Areas.Categorias.Controllers
{
    [Area("Categorias")]
    public class CategoriasController : Controller
    {
        private TCategoria _categoria;
        private LCategorias _lcategorias;
        private SignInManager<IdentityUser> _signInManager;
        private static DataPaginador<TCategoria> models;

        public CategoriasController(ApplicationDbContext context, SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
            _lcategorias = new LCategorias(context);
        }


        public IActionResult Categoria()
        {
            if (_signInManager.IsSignedIn(User))
            {
                models = new DataPaginador<TCategoria>
                {
                    Input = new TCategoria()
                };
                return View(models);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }

        }
    }

}