using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi_PUB_PV.Controllers
{
    public class ClientePreferencialController : Controller
    {
        // GET: ClientePreferencialController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ClientePreferencialController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientePreferencialController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientePreferencialController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientePreferencialController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientePreferencialController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientePreferencialController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientePreferencialController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
