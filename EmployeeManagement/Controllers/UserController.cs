using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Repositories.IRepository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagement.Controllers
{
    public class UserController : Controller
    {
        IUnitOfWork _uow;
        public UserController(IUnitOfWork uow) {
            _uow = uow;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            //_uow.User.GetAllAsync();
            return View();
        }
    }
}
