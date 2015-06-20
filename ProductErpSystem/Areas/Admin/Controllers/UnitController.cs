using ProductErpSystem.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductErpSystem.Areas.Admin.Controllers
{
    public class UnitController : Controller
    {
        // GET: Admin/Unit
        private BusinessDbEntities db = new BusinessDbEntities();
        public ActionResult Index()
        {
            List<UnitViewModel> listUnit= new List<UnitViewModel>();
            foreach (var item in db.Units.ToList())
            {
                listUnit.Add(new UnitViewModel()
                {
                    UnitId = item.UnitId,
                    UnitName = item.UnitName,
                    IsDeleted =item.IsDeleted
                });
            }
            return View(listUnit);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new UnitViewModel());
        }
        [HttpPost]
        public ActionResult Create(UnitViewModel model)
        {
            if (ModelState.IsValid)
            {
                db.Units.Add(new Unit
                {
                    UnitName = model.UnitName,
                    IsDeleted = model.IsDeleted
                });
                db.SaveChanges();
                ModelState.Clear();
                return View(new UnitViewModel());
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult Edit(int ?Id)
        {
            if (Id!=null)
            {
                var searh=db.Units.Where(model=>model.UnitId==Id).FirstOrDefault();
                if (searh!=null)
                {
                    return View(new UnitViewModel()
                    {
                        UnitId = searh.UnitId,
                        UnitName = searh.UnitName,
                        IsDeleted = searh.IsDeleted
                    });
                }
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Edit(UnitViewModel model)
        {
            if (ModelState.IsValid)
            {
                var search = db.Units.Where(x=>x.UnitId==model.UnitId).FirstOrDefault();
                if (search!=null)
                {
                    search.UnitName = model.UnitName;
                    search.IsDeleted = model.IsDeleted;
                    db.SaveChanges();
                    ModelState.Clear();
                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }
    }
}