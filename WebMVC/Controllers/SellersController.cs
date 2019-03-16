using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;
using WebMVC.Models.ViewModels;
using WebMVC.Services;


namespace WebMVC.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;
        private readonly DepatmentsService _depatmentsService;


        public SellersController(SellerService sellerService, DepatmentsService depatmentsService)
        {
            _sellerService = sellerService;
            _depatmentsService = depatmentsService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var departments = _depatmentsService.FindAll();
            var viewModel = new SellerFormViewModel { Departments = departments };
            return View(viewModel);
        }

        [HttpPost]
        
        // EVITA QUE PESSOAS APROVEITEM SUA SESSÃO PARA ENVIAR DADOS MALICIOSOS
        [ValidateAntiForgeryToken] 
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
             
    }
}