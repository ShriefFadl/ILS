using Fury.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fury.Controllers
{
    public class ProductionFormController : Controller
    {/*
        private ApplicationDbContext _Context;
        public ProductionFormController()
        {
            _Context = new ApplicationDbContext();

        }
        protected override void Dispose(bool disposing)
        {
            _Context.Dispose();
        }*/
        // GET: ProductionForm
        ProContext objdatacotext = new ProContext();
        public ActionResult ProDetails()
        {

            return View(objdatacotext.production_form.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
      [HttpPost]
        public ActionResult Create(Production p)

        {
            objdatacotext.production_form.Add(p);
            objdatacotext.SaveChanges();
            return View();
        }
        public ActionResult Details(string id)
        {
            var emp = objdatacotext.production_form.Find(id);
            return View(emp);
        }
        public ActionResult Edit(string id)
        {
            
            var emp = objdatacotext.production_form.Find(id);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(Production objEmp)
        {
            var data = objdatacotext.production_form.Find(objEmp.FSCM);
            if (data != null)
            {
                data.FSCM = objEmp.FSCM;
                data.Serial_Num = objEmp.Serial_Num;
                data.NiiN = objEmp.NiiN;
                data.Part_num = objEmp.Part_num;
            }
            objdatacotext.SaveChanges();
            return View();
        }

        public ActionResult Delete(string id)
        {
            
            var emp = objdatacotext.production_form.Find(id);
            return View(emp);
        }
        
    }
}
        /*
        public ActionResult CreateProForm()
        {
           
            
            return View();
        }
       
        [HttpPost]
        public ActionResult SubmitProductionForm(Production p)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new Production
                {
                    NiiN = p.NiiN,
                    Serial_Num = p.Serial_Num,
                    FSCM = p.FSCM,
                    Part_num=p.Part_num,
                    
                   // workshops=p.workshops.ToList()

                };
                return View("CreateProForm", viewModel);
            }
            var fscm = p.FSCM;
            var p_num = p.Part_num;
            var serial = p.Serial_Num;
            var niin = p.NiiN;
           // var Work_shp = p.workshop.ID.ToString();//return null value
            var time = p.Date_submit;
            _Context.production.Add(p);
            _Context.SaveChanges();
           return RedirectToAction ("CreateProForm");
        }
    }
}
*/