using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEBooks.Models;
using MyEBooks.Core;

namespace MyEBooks.Controllers
{
    public class MyBaseController : Controller
    {
        public ViewModelBase ViewModelBaseObj;
        public IRepository _repository;
        public MyBaseController()
        {
            _repository = new DatabaseRepository();
            ViewModelBaseObj = new ViewModelBase(_repository);
        }

        //public IRepository _repository;
        //public MyBaseController(IRepository repository)
        //{
        //    _repository = repository;
        //    ViewModelBaseObj = new ViewModelBase(_repository);
        //}
    }
}
