﻿using System;
using Microsoft.AspNetCore.Mvc;

namespace firstmvc.Modulos.Vendas.Controllers
{
	[Area("Vendas")]
	public class PedidosController : Controller
	{
        public IActionResult Index()
        {
            return View();
        }
    }
}

