using Microsoft.AspNetCore.Mvc;
using MoviesGenreWeb.Data;
using MoviesGenreWeb.Models;

namespace MoviesGenreWeb.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AccountController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Account> AccountobjList = _db.Accounts;
            return View(AccountobjList);
        }

        //GET
        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Account obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.ConfirmPassword == obj.Password.ToString())
                {
                    _db.Accounts.Add(obj);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("ConfirmPassword", "Password should match");
                }
            }
            return View(obj);
        }

        //GET
        public IActionResult Edit(int id)
        {
            var obj = _db.Accounts.Find(id);
            if (id == null || id == 0)
            {
                NotFound();
            }
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Account obj)
        {
            if (obj.ConfirmPassword == obj.Password.ToString())
            {
                _db.Accounts.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("ConfirmPassword", "Password should match");
            }
            if (ModelState.IsValid)
            {
                _db.Accounts.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            // If the model is not valid, return to the edit view with validation errors
            return View(obj);
        }

        //GET
        public IActionResult Delete(int id)
        {
            var obj = _db.Accounts.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int id)
        {
            var obj = _db.Accounts.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Accounts.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
