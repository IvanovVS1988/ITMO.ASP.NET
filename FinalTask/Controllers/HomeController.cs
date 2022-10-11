﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalTask.Models;

namespace FinalTask.Controllers
{
    public class HomeController : Controller
    {
        private StudentContext db = new StudentContext();
        public ActionResult Index()
        {
            ShowStudents();
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        private void ShowStudents()
        {
            var allStudents = db.Students.ToList<Student>();
            ViewBag.Students = allStudents;
        }

        [HttpGet]
        public ActionResult CreateStudent()
        {
            ShowStudents();
            return View();
        }

        [HttpPost]
        public string CreateStudent(Student newStudent)
        {
            db.Students.Add(newStudent);
            // Сохраняем в БД все изменения
            db.SaveChanges();
            return "Спасибо, данные о студенте добавлены в базу данных";
        }

        public ActionResult SummaBallov()
        {
            ShowStudents();
            return View();
        }

        public ActionResult BestStudents()
        {
            ShowStudents();
            return View();
        }

        public ActionResult WorseStudents()
        {
            ShowStudents();
            return View();
        }
    }
}