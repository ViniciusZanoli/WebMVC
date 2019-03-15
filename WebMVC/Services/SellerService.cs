using System.Collections.Generic;
using System.Linq;
using WebMVC.Models;

namespace WebMVC.Services
{
    public class SellerService
    {
        // readonly SIGNIFICA QUE NÃO PODE SER ALTERADO
        private readonly WebMVCContext _context;

        public SellerService(WebMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
