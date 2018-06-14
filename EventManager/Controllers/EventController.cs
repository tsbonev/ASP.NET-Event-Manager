using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventManager.Models;
using DataAccess;
using Repositories;

namespace EventManager.Controllers
{
    public class EventController : Controller
    {
        UnitOfWork uow = new UnitOfWork();

        // GET: Event
        public ActionResult Index()
        {
            List<Event> list = uow.EventRepository.GetAll();

            EventsViewModel model = new EventsViewModel(list);

            return View(model);
        }

        public ActionResult View(int id)
        {

            Event e = uow.EventRepository.GetByID(id);

            if(null == e)
            {
                TempData["ErrorMessage"] = "No such event found!";
                return RedirectToAction("Index");
            }

            EventViewModel model = new EventViewModel(e);

            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id = 0)
        {

            Event e = uow.EventRepository.GetByID(id);

            if (null == e) e = new Event();

            EventViewModel model = new EventViewModel(e);

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(EventViewModel model)
        {

            Event e = new Event();

            e.ID = model.ID;
            e.Name = model.Name;
            e.Location = model.Location;
            e.StartDate = model.StartDate;
            e.EndDate = model.EndDate;

            uow.EventRepository.Save(e);

            uow.Save();

            TempData["Message"] = "Event successfully saved!";

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {

            Event e = uow.EventRepository.GetByID(id);

            if(null == e)
            {
                TempData["ErrorMessage"] = "No such event found!";
                return RedirectToAction("Index");
            }

            uow.EventRepository.DeleteByID(id);

            uow.Save();

            TempData["Message"] = "Event successfully deleted!";

            return RedirectToAction("Index");
        }

    }
}