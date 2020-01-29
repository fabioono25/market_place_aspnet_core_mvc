﻿using MarketPlace.Models;
using MarketPlace.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            // ViewBag.CurrentCategory = "Cheese cakes";

            var piesListViewModel = new PiesListViewModel();
            piesListViewModel.Pies = _pieRepository.AllPies;
            piesListViewModel.CurrentCategory = "Cheese cakes";

            //return View(_pieRepository.Pies);
            return View(piesListViewModel);
        }

        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);

            if (pie == null)
            {
                return NotFound();
            }

            return View(pie);
        }
    }
}