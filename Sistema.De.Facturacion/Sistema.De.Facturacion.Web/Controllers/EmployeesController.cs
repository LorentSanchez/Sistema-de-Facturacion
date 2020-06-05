﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sistema.De.Facturacion.Web.Data;
using Sistema.De.Facturacion.Web.Models;

namespace Sistema.De.Facturacion.Web.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly DataContext _context;

        public EmployeesController(DataContext context)
        {
            _context = context;
        }

        // GET: Employees
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.Employee.Include(e => e.Documents).Include(e => e.position);
            return View(await dataContext.ToListAsync());
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .Include(e => e.Documents)
                .Include(e => e.position)
                .FirstOrDefaultAsync(m => m.Employe_Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employees/Create
        public IActionResult Create()
        {
            ViewData["ID_Doc"] = new SelectList(_context.Document, "ID_Doc", "Documento");
            ViewData["Position_Id"] = new SelectList(_context.Set<Position>(), "Position_Id", "Position_Name");
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Employe_Id,Codigo_Empleado,Employee_Name,Employee_Lastname,ID_Doc,Document,Phone,Cellphone,Extension,Email,Status,Position_Id,Fecha_Ingreso")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ID_Doc"] = new SelectList(_context.Document, "ID_Doc", "Documento", employee.ID_Doc);
            ViewData["Position_Id"] = new SelectList(_context.Set<Position>(), "Position_Id", "Position_Name", employee.Position_Id);
            return View(employee);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            ViewData["ID_Doc"] = new SelectList(_context.Document, "ID_Doc", "Documento", employee.ID_Doc);
            ViewData["Position_Id"] = new SelectList(_context.Set<Position>(), "Position_Id", "Position_Name", employee.Position_Id);
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Employe_Id,Codigo_Empleado,Employee_Name,Employee_Lastname,ID_Doc,Document,Phone,Cellphone,Extension,Email,Status,Position_Id,Fecha_Ingreso")] Employee employee)
        {
            if (id != employee.Employe_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.Employe_Id))
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
            ViewData["ID_Doc"] = new SelectList(_context.Document, "ID_Doc", "Documento", employee.ID_Doc);
            ViewData["Position_Id"] = new SelectList(_context.Set<Position>(), "Position_Id", "Position_Name", employee.Position_Id);
            return View(employee);
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .Include(e => e.Documents)
                .Include(e => e.position)
                .FirstOrDefaultAsync(m => m.Employe_Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employee.FindAsync(id);
            _context.Employee.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employee.Any(e => e.Employe_Id == id);
        }
    }
}
