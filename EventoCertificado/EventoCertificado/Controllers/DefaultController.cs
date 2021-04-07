using Cadastro.Core.Application.Organizadores;
using Emissao.Core.Application.Certificados;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventoCertificado.Controllers
{
    public class DefaultController : Controller
    {
        IServicoEvento _servicoEvento;
        IServicoCertificado _servicoCertificado;

        public DefaultController(IServicoEvento servicoEvento, IServicoCertificado servicoCertificado)
        {
            _servicoEvento = servicoEvento;
            _servicoCertificado = servicoCertificado;

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
