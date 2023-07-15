using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zero_Hunger.DB;

namespace Zero_Hunger.Controllers
{
    public class EmployeeAssingnController : Controller
    {
        ZeroContext obj = new ZeroContext();

        // GET: EmployeeAssingn
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult addEmployeeAssingn() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult addEmployeeAssingn(EmployeeAssingn model)
        {
            EmployeeAssingn emp = new EmployeeAssingn();
            emp.EmployeeID = model.EmployeeID;
            emp.RestaurantID = model.RestaurantID;
            emp.Status = model.Status;

            obj.EmployeesAssingn.Add(emp);
            obj.SaveChanges();

            ModelState.Clear();
                
            return View("addEmployeeAssingn");
        }

        public ActionResult ShowEmployeeAssingn()
        {
            var show = obj.EmployeesAssingn.ToList();
            return View(show);
        }

        public ActionResult Delete(int id)
        {
            EmployeeAssingn emp = new EmployeeAssingn();
            var delete = obj.EmployeesAssingn.Where(x => x.Id == id).First();
            obj.EmployeesAssingn.Remove(delete);
            obj.SaveChanges();
            return RedirectToAction("ShowEmployeeAssingn");
        }

        public ActionResult Done(int id)
        {
            EmployeeAssingn emp = new EmployeeAssingn();
            var change = (
                from pr in obj.EmployeesAssingn
                where pr.Id == id
                select pr).SingleOrDefault();
            change.Status = "Completed";
            obj.SaveChanges();

            return RedirectToAction("ShowEmployeeAssingn");
        }
    }
}
