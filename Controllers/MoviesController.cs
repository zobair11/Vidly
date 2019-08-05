using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using Vidly.Controllers;
public class MoviesController : Controller
{
    // GET: Movies
    //public ActionResult Random()
    //{
    //    var movie = new Movies() { Name = "Sherk" };
    //    var customers = new List<Customer>
    //    {
    //        new Customer { Name ="Kane Williamson" },
    //        new Customer {Name = "Ben Stokes"}


    //    };
    //var viewModel = new RandomMovieViewModel
    //{
    //    Movie = movie,
    //    Customers = customers

    //    };
    //    return View(viewModel);
    //}

    //public ActionResult Edit(int id) {
    //    return Content("id=" + id);
    //}

    public ViewResult Index()
    {
        var movies = GetMovies();
        return View(movies);
    }

    private IEnumerable<Movies> GetMovies()
        {
        return new List<Movies>
            {
                new Movies { Id =1, Name="Sherk"},
                new Movies { Id =2, Name= "Terminator"}
            };

        }
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";
        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}
        //[Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        //public ActionResult ByReleasedate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}
          
    }