using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StudentManagementBusiness;
using StudentManagementBusiness.Models;
using StudentManagementDAL;

namespace StudentManagementUI.Controllers
{
    public class StudentRegistrationController : Controller
    {
        // GET: StudentRegistration
        private StudentRegistrationBL db = new StudentRegistrationBL();
        private CourseManagerBL dbCourse = new CourseManagerBL();
        private HostelManagerBL dbHostel = new HostelManagerBL();

        [Authorize(Roles = "Admin,User")]
        public ActionResult Index()
        {
            var students = new StudentManager().FindAll();            
            return View(students);
        }

        // GET: StudentRegistration/Details/5
        [Authorize(Roles = "Admin,User")]
        public ActionResult Details(int id)
        {
            Student student = new StudentManager().Find(id);
            List<StudentEnrollment> studentEnrollments = new StudentCourseManager().FindAllByStudentID(id).ToList();
            StudentRegistrationModel studentRegistration = new StudentRegistrationModel()
            {
                student = student,
                selectedCourses = studentEnrollments.Select(p=>p.Cours).ToList()
            };

            if (student == null)
            {
                return HttpNotFound();
            }
            return View(studentRegistration);
        }

        // GET: StudentRegistration/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {            
            StudentRegistrationModel model = new StudentRegistrationModel();
            model.AllCourses = dbCourse.List();
            model.AllHostels = new HostelManager().FindAll().ToList();
            return View(model);
        }

        // POST: StudentRegistration/Create
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentRegistrationModel model)
        {
            try
            {
                // TODO: Add insert logic here
                db.Save(model.student);
                db.AddCourses(model.student.ID, model.selectedCourseIDs);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ex.Message.Trim();
                return View(model);
            }
        }

        // GET: StudentRegistration/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id)
        {
            StudentRegistrationModel model = new StudentRegistrationModel()
            {
                student = db.Find(id),
                AllCourses = dbCourse.List(),
                AllHostels = dbHostel.List(),
                selectedCourses = db.ListAllStudentRegistrations(id).Select(p => p.Cours).ToList()
            };
            model.student.Gender = model.student.Gender.Trim();
            model.selectedCourseIDs = model.selectedCourses.Select(p => p.ID).ToList();            
            return View(model);
        }

        // POST: StudentRegistration/Edit/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, StudentRegistrationModel model)
        {
            try
            {
                // TODO: Add update logic here
                if(model.selectedCourseIDs !=null)
                    db.EditCourses(id, model.selectedCourseIDs);
                db.Modify(model.student);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: StudentRegistration/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            Student student = new StudentManager().Find(id);
            List<StudentEnrollment> studentEnrollments = new StudentCourseManager().FindAllByStudentID(id).ToList();
            StudentRegistrationModel studentRegistration = new StudentRegistrationModel()
            {
                student = student,
                selectedCourses = studentEnrollments.Select(p => p.Cours).ToList()
            };

            if (student == null)
            {
                return HttpNotFound();
            }
            return View(studentRegistration);
        }

        // POST: StudentRegistration/Delete/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                db.DeleteAllCourses(id);
                db.Delete(id);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }
    }
}
