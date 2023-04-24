﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace firstmvc.Areas.Produtos.Controllers
{
    [Area("Produtos")]
    [Route("produtos")]
    public class CadastroController : Controller
    {
        // GET: /<controller>/
        [Route("lista")]
        public IActionResult Index()
        {
            return View();
        }


        // GET: /<controller>/
        [Route("busca")]
        public IActionResult Busca()
        {
            return View();
        }
    }
}

