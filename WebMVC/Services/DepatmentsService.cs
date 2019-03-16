using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMVC.Models;

namespace WebMVC.Services
{
    public class DepatmentsService
    {
        private readonly WebMVCContext _context;

        public DepatmentsService(WebMVCContext context)
        {
            _context = context;
        }

        public List<Departments> FindAll()
        {
            return _context.Departments.OrderBy(x => x.name).ToList();
        }
    }
}
