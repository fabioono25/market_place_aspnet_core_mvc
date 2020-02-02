﻿using MarketPlace.Models;
using MarketPlace.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

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

        //public ViewResult List()
        //{
        //    // ViewBag.CurrentCategory = "Cheese cakes";

        //    var piesListViewModel = new PiesListViewModel();
        //    piesListViewModel.Pies = _pieRepository.AllPies;
        //    piesListViewModel.CurrentCategory = "Cheese cakes";

        //    //return View(_pieRepository.Pies);
        //    return View(piesListViewModel);
        //}

        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);

            if (pie == null)
            {
                return NotFound();
            }

            return View(pie);
        }

        //[Route("AllPies")]
        //[Route("ListOfPies")]
        public ViewResult List(string category)
        {
            IEnumerable<Pie> pies;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                pies = _pieRepository.AllPies.OrderBy(p => p.PieId);
                currentCategory = "All pies";
            }
            else
            {
                pies = _pieRepository.AllPies.Where(p => p.Category.CategoryName == category)
                   .OrderBy(p => p.PieId);
                currentCategory = _categoryRepository.Categories.FirstOrDefault(c => c.CategoryName == category).CategoryName;
            }

            return View(new PiesListViewModel
            {
                Pies = pies,
                CurrentCategory = currentCategory
            });
        }
    }
}
