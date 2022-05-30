using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Assignment2.Models;

namespace MVC_Assignment2.Controllers
{
    public class MovieTableController : Controller
    {
        MoviedbEntities mb = new MoviedbEntities();
        // GET: MovieTable
        public ActionResult Index()
        {
            return View();
        }
        //1. Getting the Movies details from scaffolded view
        public ActionResult GetMoviesScaffolded()
        {
            List<MovieTable> mvt = mb.MovieTables.ToList();
            return View(mvt);
        }
        //2.Crud Operations to create and post of create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(MovieTable mt)
        {
            mb.MovieTables.Add(mt);
            mb.SaveChanges();
            return RedirectToAction("GetMoviesScaffolded");
        }
        //3.get details of a particular movie
        public ActionResult Details(int id)
        {
            MovieTable mt = mb.MovieTables.Find(id);
            return View(mt);
        }
        //4.Edit records
        [HttpGet]
        public ActionResult Edit(int id)
        {
            MovieTable ms = mb.MovieTables.Find(id);
            return View(ms);
        }
        [HttpPost]
        public ActionResult Edit(MovieTable mt)
        {
            MovieTable m = mb.MovieTables.Find(mt.mid);
            m.moviename= mt.moviename;
            m.dateofrelease = mt.dateofrelease;
            mb.SaveChanges();
            return RedirectToAction("GetMoviesScaffolded");
        }
        //5.Delete a record
        public ActionResult Delete(int id)
        {
            MovieTable m = mb.MovieTables.Find(id);
            mb.MovieTables.Remove(m);
            mb.SaveChanges();
            return RedirectToAction("GetMoviesScaffolded");
        }
    }
}