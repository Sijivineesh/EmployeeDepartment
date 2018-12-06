using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;


namespace EmployeeDepartment.Controllers
{
    public class MainController : Controller
    {
        //EmployeeDepartmentDB db = new EmployeeDepartmentDB();
        // GET: Main
        //Home
       
        public ActionResult HomePage()
        {
            
            return View();
           
        }

       
        public ActionResult EmployeeReg()

		{

			IEnumerable<SelectListItem> DepartmentList = new[]

			{

		new SelectListItem { Value = "1", Text = "Production" },

		new SelectListItem { Value = "2", Text = "Management" },

		new SelectListItem { Value = "3", Text = "Development" },

			};



			ViewBag.List = DepartmentList;
          

            // ViewBag.List = db.Department;

            return View();

		}



		//[HttpPost]

		//public ActionResult EmployeeReg(EmployeeModel objModel)

		//{

		//	if (ModelState.IsValid)

		//	{
		//	 DepartmentModel objDepartmentModel = new DepartmentModel();



		//		//var Pk_ID = db.Employee.Max(a => a.pk_ID);

		//		//objModel.Pk_ID = Pk_ID + 10;

		//		//db.Employee.Add(objModel);

		//		//db.SaveChanges();

		//		objModel = null;

		//		ModelState.Clear();

		//		Response.Write("<script>alert('Sucessfully Inserted.')</script>");

		//	}



		//	//ViewBag.List = db.Department;

		//	return View(objModel);

		//}

		public ActionResult DepartmentReg()

		{

			return View();

		}



  //      [HttpPost]

  //      public ActionResult DepartmentReg(DepartmentModel objModel)

  //      {

  //          var ex = db.Department.Where(m => m.DeptName == obj.DeptName).Count();



  //          if (ex != 0)

  //          {

  //              TempData["notice"] = "Department Exist";

  //              return RedirectToAction("DepartmentReg");

  //          }

  //          if (ModelState.IsValid)

		//	{



		//		DepartmentModel objDepartmentModel = new DepartmentModel();



		//		//var Pk_ID = db.Department.Max(a => a.pk_ID);

		//		//objModel.Pk_ID = Pk_ID + 1;

		//		//db.Department.Add(objModel);

		//		//db.SaveChanges();

		//		objModel = null;

		//		ModelState.Clear();

		//		Response.Write("<script>alert('Sucessfully Inserted.')</script>");

		//	}

		//	return View();

		//}



		public ActionResult EmpSearch()

		{

            List<EmployeeModel> Emp_list = new List<EmployeeModel>();
            EmployeeModel Emp = new EmployeeModel();



            Emp.Pk_ID = 10;

            Emp.FirstName = "Vineesh";

            Emp.Designation = "Accounting";

            Emp.EmailID = "Sijipoulo@gmail.com";

            Emp_list.Add(Emp);

            ViewBag.list = Emp_list;


            //var Emp_list = (from e in db.Employee

            //				join d in db.Department on e.DepartmentID equals d.Pk_ID

            //				select new

            //				{

            //					Pk_ID = e.Pk_ID,

            //					Name = e.FirstName,

            //					DeptName = d.DeptName,

            //					Designation = e.Designation,

            //					EmailID = e.EmailID

            //				}).ToList();

            //ViewBag.list = Emp_list;



            return View();

		}



		[HttpPost]

		public ActionResult EmpSearch(string Employee, int? page)

		{

			//if (ModelState.IsValid)

			//{



			//	int EmpSearch = db.Employee.Where(m => m.FirstName.Contains(Employee)).Count();

			//	if (EmpSearch != 0)

			//	{



			//		People = db.Employee.Where(m => m.FirstName.Contains(Employee)).ToList();

			//		ModelState.Clear();

			//	}

			//	else

			//	{

			//		TempData["notice"] = "No Records";

			//		return RedirectToAction("EmpSearch");

			//	}

			//}
			//return View(People);
			return View();

		}

		public ActionResult DeptSearch()

		{

            //ViewBag.list = db.Department.ToList();
            List<DepartmentModel> Dept_list = new List<DepartmentModel>();
            DepartmentModel Dept = new DepartmentModel();



            Dept.Pk_ID = 10;

            Dept.DeptName = "Accounting";

            Dept.Description = "Accounting Department";

            

            Dept_list.Add(Dept);

            ViewBag.list = Dept_list;


            return View();

		}



		[HttpPost]

		public ActionResult DeptSearch(string Deptname, int? page)

		{

			//List<Department> Dept = db.Department.ToList();

			if (ModelState.IsValid)

			{



				//int DeptNameNo = db.Department.Where(m => m.Department.Contains(Deptname)).Count();

				//if (DeptNameNo != 0)

				//{

				//	ViewBag.message = true;

					//Dept = db.Department.Where(m => m.Department.Contains(Deptname)).ToList();

				//	ModelState.Clear();

				//}

				//else

				//{

				//	TempData["notice"] = "No Records";

				//	return RedirectToAction("DeptSearch");

				//}

			}

			return View();

		}

		public ActionResult EmployeeEdit(int Pk_ID)

		{

			EmployeeModel obj = new EmployeeModel();

			if (Pk_ID != 0)

			{

				//obj = db.Employee.Find(Pk_ID);

			}
            obj.Pk_ID = 10;
            obj.FirstName = "Vineesh";
            obj.LastName = "Varghese";
            obj.Contact = "2244359014";
            obj.Address = "1210 N wheeling";
            obj.EmailID = "sijipoulo@gmail.com";
            obj.Designation = "Manager";


			return View(obj);

        }

        [HttpPost]

        public ActionResult EmployeeEdit(EmployeeModel obj)

        {

            //if (ModelState.IsValid)

            //{



            //db.Employee.Add(obj);

            //db.Entry(obj).State = System.Data.Entity.EntityState.Modified;

            //db.SaveChanges();

            //TempData["notice"] = "Updated";

            //return RedirectToAction("EmpSearch");

            //}

            return View();

    }

    public ActionResult DeptEdit(int Pk_ID)

		{

			DepartmentModel obj = new DepartmentModel();

			if (Pk_ID != 0)

			{

				//obj = db.Department.Find(Pk_ID);

			}
            obj.Pk_ID = 10;
            obj.DeptName = "Accounting";
            obj.Description = "Accounting department ";

			return View(obj);

		}

        [HttpPost]

        public ActionResult DeptEdit(DepartmentModel obj)

        {



            //	//var ex = db.Department.Where(m => m.DeptName == obj.DeptName && m.Pk_ID != obj.Pk_ID).Count();

            //	//if (ex != 0)

            //	//{

            //	//	TempData["notice"] = "Department Name Exist";

            //	//	return RedirectToAction("DeptEdit");

            //	//}

            //	if (ModelState.IsValid)

            //	{



            //		//db.Department.Add(obj);

            //		//db.Entry(obj).State = System.Data.Entity.EntityState.Modified;

            //		//db.SaveChanges();

            //		TempData["notice"] = "Updated";

            //		return RedirectToAction("DeptSearch");

            //	}

            return View();

        }

       
        
       

        public JsonResult DeptDelete(int Pk_ID)

        {

            //	//DepartmentModel obj = db.Department.Find(obj.Pk_ID);

            //	//db.Department.remove(obj);

            //	//db.SaveChanges();

            return Json(true, JsonRequestBehavior.AllowGet);

        }

        public JsonResult EmpDelete(int Pk_ID)

        {

            //	//DepartmentModel obj = db.Department.Find(obj.Pk_ID);

            //	//db.Department.remove(obj);

            //	//db.SaveChanges();

            return Json(true, JsonRequestBehavior.AllowGet);

        }


        // [HttpPost]

        // public ActionResult EmpDelete(EmployeeModel obj)

        // {

        //     EmployeeModel obj=db.Employee.Find(obj.Pk_ID);

        //     db.Employee.remove(obj);

        //     db.SaveChanges();

        //      TempData["notice"] = "Record Deleted";

        //     return view(EmpSearch);

        // }        



    }

}

 
    