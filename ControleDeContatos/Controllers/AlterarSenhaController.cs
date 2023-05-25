using ControleDeContatos.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ControleDeContatos.Controllers
{
    public class AlterarSenhaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Alterar(AlterarSenhaModel alterarSenhaModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TempData["MensagemSucesso"] = "Senha alterada com sucesso!";
                }

                return View("Index", alterarSenhaModel);
            }
            catch (Exception e)
            {
                return View("Index", alterarSenhaModel);
            }
        }
    }
}
