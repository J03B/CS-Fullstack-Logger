using System; 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CS_Fullstack_Logger.Data;
using CS_Fullstack_Logger.Models;

namespace CS_Fullstack_Logger.Controllers {
    public class EntryController : Controller {
        private readonly ApplicationDbContext _context;

        public EntryController(ApplicationDbContext context) {
            _context = context;
        }

        // GET: Entries
        public async Task<ActionResult> Index() {
            return View(await _context.Entry.ToListAsync());
        }
    }
}