﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Code_First_Approach_in_Entity_Framework.Models;

namespace Code_First_Approach_in_Entity_Framework.Controllers
{
    public class StudentController : Controller
    {
        private StudentContext db = new StudentContext();
     
        public ActionResult Index(){ 
            return View(db.Students.ToList());
        }   // GET: /Student/
        
        public ActionResult Details(int id = 0){
            Student student = db.Students.Find(id);
            if (student == null){
                return HttpNotFound();
            }
            return View(student);
        }// GET: /Student/Details/5
        public ActionResult Create(){
            return View();
        } // GET: /Student/Create
        [HttpPost]
        public ActionResult Create(Student student){
            if (ModelState.IsValid){
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        } // POST: /Student/Create
       

        public ActionResult Edit(int id = 0){
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        } // GET: /Student/Edit/5
      

        [HttpPost]
        public ActionResult Edit(Student student){
            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }  // POST: /Student/Edit/5
      

        public ActionResult Delete(int id = 0){
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }  // GET: /Student/Delete/5
        
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id){
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }// POST: /Student/Delete/5

        protected override void Dispose(bool disposing){
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}