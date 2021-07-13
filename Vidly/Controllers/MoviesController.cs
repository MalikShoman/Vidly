﻿
using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name="shark" };
            var customers = new List<Customer>
            {
                new Customer {Name = " Cust 1"},
                new Customer{ Name = "Cust 2"}

            };  

            var viewModel = new RandomMovieViewModel
            {
                Movie =movie,
                Customers = customers,
            };

            return View(viewModel);
           
            // return Content("Hello");
            //return HttpNotFound();
           // return RedirectToAction("Index","Home",new { page = 1, sortBy = "name" });
        }

        //public ActionResult Edit( int id)
        //{
        //    return Content("id=" + id);
                 

        //}

        //// movies
        
        //public ActionResult Index(int? pageIndex ,String sortBy)
        //{

        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "name";

        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}

        //[Route("movies/released/{year}/{month:regex(\\d{4})")]
        //public ActionResult ByReleaseDate(int year , int month)
        //{
        //    return Content(year+"/0"+month);
        //}

    }

    
}