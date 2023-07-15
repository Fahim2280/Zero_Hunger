using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zero_Hunger.DB;

namespace Zero_Hunger.Controllers
{
    public class EmploveeController : Controller
    {
        ZeroContext obj = new ZeroContext();
        // GET: Emplovee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult addEmplovee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult addEmplovee(Employee model)
        {
            Employee employee = new Employee();
            employee.EmployeeID = model.EmployeeID;
            employee.EmployeeName = model.EmployeeName;
            employee.EmployeeCont = model.EmployeeCont;
            employee.EmployeeEmail = model.EmployeeEmail;
            employee.EmployeeGender = model.EmployeeGender;
            employee.EmployeeAddress = model.EmployeeAddress;

            obj.Employees.Add(employee);
            obj.SaveChanges();

            ModelState.Clear();

            return View("addEmplovee");
        }

        public ActionResult ShowEmplovee()
        {
            var show = obj.Employees.ToList();
            return View(show);
        }

        public ActionResult DeleteEmplovee(int id)
        {
            var delete = obj.Employees.Where(x=>x.EmployeeID == id).First();
            Employee employee = new Employee();
            obj.Employees.Remove(delete);
            obj.SaveChanges();


            return RedirectToAction("ShowEmplovee");
        }

        public ActionResult EditEmplovee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditEmplovee(Employee model)
        {
            Employee employee = new Employee();
            if (ModelState.IsValid)
            {
                var edit = obj.Employees.Find(employee.EmployeeID);
                if (edit != null)
                {
                    employee.EmployeeID = edit.EmployeeID;
                    employee.EmployeeName = edit.EmployeeName;
                    employee.EmployeeCont = edit.EmployeeCont;
                    employee.EmployeeEmail = edit.EmployeeEmail;
                    employee.EmployeeGender = edit.EmployeeGender;
                    employee.EmployeeAddress = edit.EmployeeAddress;
                    //obj.Employees.Add(employee);
                    obj.SaveChanges();

                    //ModelState.Clear();
                    //return RedirectToAction("ShowEmplovee");
                }
            }
            return View("Edit");
        }

        public ActionResult Eidt(int Id)
        {
            var model = obj.Employees.Where(x => x.EmployeeID == Id).FirstOrDefault();
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Employee model)
        {
            Employee employee = new Employee();
            var edit = obj.Employees.Where(x => x.EmployeeID == model.EmployeeID).FirstOrDefault();
            obj.Employees.Remove(edit);
            obj.Employees.Add(model);
            return RedirectToAction("ShowEmplovee");
        }
    }
}