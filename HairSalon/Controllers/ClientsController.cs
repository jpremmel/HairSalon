using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HairSalon.Controllers
{
    public class ClientsController : Controller
    {
        private readonly HairSalonContext _db;

        public ClientsController(HairSalonContext db)
        {
            _db = db;
        }

        public ActionResult Create(int id)
        {
            ViewBag.StylistId = id;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Client client)
        {
            _db.Clients.Add(client);
            _db.SaveChanges();
            return RedirectToAction("Details", "Stylists", new { id = client.StylistId });
        }

        public ActionResult Details(int id)
        {
            Client client = _db.Clients.Include(c => c.Stylist).FirstOrDefault(s => s.ClientId == id);
            return View(client);
        }

        public ActionResult Delete(int id)
        {
            var thisClient = _db.Clients.FirstOrDefault(c => c.ClientId == id);
            return View(thisClient);
        }

         [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var thisClient = _db.Clients.FirstOrDefault(c => c.ClientId == id);
            _db.Clients.Remove(thisClient);
            _db.SaveChanges();
            return RedirectToAction("Details", "Stylists", new { id = thisClient.StylistId });
        }
    }
}