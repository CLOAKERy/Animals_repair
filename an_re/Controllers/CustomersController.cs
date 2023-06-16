using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using an_re;
using an_re.Models;


namespace an_re.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly DbA9ae8dDbanimalreContext _context;

        public CustomersController(DbA9ae8dDbanimalreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
            var users = await _context.Customers.ToListAsync();
            return Ok(users);
        }

        // GET: api/customers/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomer(int id)
        {
            var customer = await _context.Customers.FindAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }

        [HttpPost]
        public async Task<ActionResult<Customer>> CreateUser(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCustomer), new { id = customer.Id }, customer);
        }

        // 
        /*
        // GET: Customers
        public async Task<IActionResult> Index()
        {
            var dbA9ae8dDbanimalreContext = _context.Customers.Include(c => c.IdLoginNavigation).Include(c => c.IdRoleNavigation);
            return View(await dbA9ae8dDbanimalreContext.ToListAsync());
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Customers == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .Include(c => c.IdLoginNavigation)
                .Include(c => c.IdRoleNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            ViewData["IdLogin"] = new SelectList(_context.Logins, "Id", "Id");
            ViewData["IdRole"] = new SelectList(_context.UserRoles, "Id", "Id");
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdRole,IdLogin,Name,Adress,PhoneNumber")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdLogin"] = new SelectList(_context.Logins, "Id", "Id", customer.IdLogin);
            ViewData["IdRole"] = new SelectList(_context.UserRoles, "Id", "Id", customer.IdRole);
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Customers == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            ViewData["IdLogin"] = new SelectList(_context.Logins, "Id", "Id", customer.IdLogin);
            ViewData["IdRole"] = new SelectList(_context.UserRoles, "Id", "Id", customer.IdRole);
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdRole,IdLogin,Name,Adress,PhoneNumber")] Customer customer)
        {
            if (id != customer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdLogin"] = new SelectList(_context.Logins, "Id", "Id", customer.IdLogin);
            ViewData["IdRole"] = new SelectList(_context.UserRoles, "Id", "Id", customer.IdRole);
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Customers == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .Include(c => c.IdLoginNavigation)
                .Include(c => c.IdRoleNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Customers == null)
            {
                return Problem("Entity set 'DbA9ae8dDbanimalreContext.Customers'  is null.");
            }
            var customer = await _context.Customers.FindAsync(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
          return (_context.Customers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
        */
    }
}
