using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Helpers.Extension;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WebApplication1.DAL;
using Microsoft.AspNetCore.Hosting;

namespace WebApplication1.Areas.AdminPanel.Controllers
{
    public class WorkerController : Controller
    {
        private AppDbContext _context { get; }
        private IWebHostEnvironment _env { get; }
        public WorkerController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        // GET: WorkerController
        public ActionResult Index()
        {
            return View(_context.Workers);
        }

        // GET: WorkerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WorkerController/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: WorkerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Worker worker)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (!worker.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("Photo", "File size is must be smaller than 200kb");
                return View();
            }
            if (!worker.Photo.CheckFileType("/image"))
            {
                ModelState.AddModelError("Photo", "type of file must be image");
                return View();
            }
            worker.Image=await worker.Photo.savefileasync
        }

        // GET: WorkerController/Edit/5
        public ActionResult Update(int id)
        {
            return View();
        }

        // POST: WorkerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int id, IFormCollection collection)
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

        // GET: WorkerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WorkerController/Delete/5
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
