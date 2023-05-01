using Business_Layer.Concrete;
using Business_Layer.FluentValidation;
using DataAccess_Layer.EntityFramework;
using Entity_Layer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Project_OOP_.Net_7.Controllers
{
    public class JobController : Controller
    {
        JobManager jobManager = new JobManager(new EfJobDal());
        public IActionResult Index()
        {
            var values = jobManager.TGetList();
            return View(values);
        }

        [HttpGet]

        public IActionResult AddJob()
        {
            return View();
        }

        [HttpPost]

        public IActionResult AddJob(Job p)
        {
            jobManager.TInsert(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteJob(int id)
        {
            var value = jobManager.GetById(id);
            jobManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult UpdateJob(int id)
        {
            var value = jobManager.GetById(id);
            return View(value);
        }

        [HttpPost]

        public IActionResult UpdateJob(Job p)
        {
            jobManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
