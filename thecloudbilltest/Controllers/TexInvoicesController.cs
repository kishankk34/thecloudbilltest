using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using thecloudbilltest.Models;

namespace thecloudbilltest.Controllers
{
    public class TexInvoicesController : Controller
    {
        private readonly EmployeeContext _context;

        public TexInvoicesController(EmployeeContext context)
        {
            _context = context;
        }

        // GET: TexInvoices
        public async Task<IActionResult> Index()
        {
            return View(await _context.TexInvoices.ToListAsync());
        }

        // GET: TexInvoices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var texInvoice = await _context.TexInvoices
                .FirstOrDefaultAsync(m => m.InvoiceID == id);
            if (texInvoice == null)
            {
                return NotFound();
            }

            return View(texInvoice);
        }

        // GET: TexInvoices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TexInvoices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InvoiceID,FullName,Address,Location,City,ProductName,Qty,Price")] TexInvoice texInvoice)
        {
            if (ModelState.IsValid)
            {
                _context.Add(texInvoice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(texInvoice);
        }

        // GET: TexInvoices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var texInvoice = await _context.TexInvoices.FindAsync(id);
            if (texInvoice == null)
            {
                return NotFound();
            }
            return View(texInvoice);
        }

        // POST: TexInvoices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InvoiceID,FullName,Address,Location,City,ProductName,Qty,Price")] TexInvoice texInvoice)
        {
            if (id != texInvoice.InvoiceID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(texInvoice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TexInvoiceExists(texInvoice.InvoiceID))
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
            return View(texInvoice);
        }

        // GET: TexInvoices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var texInvoice = await _context.TexInvoices
                .FirstOrDefaultAsync(m => m.InvoiceID == id);
            if (texInvoice == null)
            {
                return NotFound();
            }

            return View(texInvoice);
        }

        // POST: TexInvoices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var texInvoice = await _context.TexInvoices.FindAsync(id);
            _context.TexInvoices.Remove(texInvoice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TexInvoiceExists(int id)
        {
            return _context.TexInvoices.Any(e => e.InvoiceID == id);
        }
    }
}
