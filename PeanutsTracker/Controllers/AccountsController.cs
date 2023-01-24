using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeanutsTracker.DbContexts;
using PeanutsTracker.Models;

namespace PeanutsTracker.Controllers
{
    public class AccountsController : Controller
    {
        private readonly PeanutsTrackerDbContext _dbContext;
        public AccountsController(PeanutsTrackerDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: AccountsController
        public async Task<IActionResult> Index()
        {
            var accounts = _dbContext.Accounts.ToList();
            return View(accounts);
        }

        // GET: AccountsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AccountsController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: AccountsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormCollection collection)
        {
            if (ModelState.IsValid)
            {
                var account = new Account
                {
                    AccountName = collection["AccountName"],
                    AccountNumber = collection["AccountNumber"],
                    Balance = Convert.ToDecimal(collection["Balance"])
                };
                _dbContext.Accounts.Add(account);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        // GET: AccountsController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            return View();
        }

        // POST: AccountsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            var account = _dbContext.Accounts.Find(id);

            if (account == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                account.AccountName = collection["AccountName"];
                account.AccountNumber = collection["AccountNumber"];
                account.Balance = Convert.ToDecimal(collection["Balance"]);
                _dbContext.Accounts.Update(account);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            
            return View();
        }

        // GET: AccountsController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var account = _dbContext.Accounts.Find(id);

            if (account == null)
            {
                return NotFound();
            }
            return View();
        }

        // POST: AccountsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, IFormCollection collection)
        {
            var account = _dbContext.Accounts.Find(id);

            if (account == null)
            {
                return NotFound();
            }

            _dbContext.Accounts.Remove(account);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
    }
}
