using System;
using System.Linq;
using WebMVC.Models;
using WebMVC.Models.Enums;

namespace WebMVC.Data
{
    public class SeedingService
    {
        private WebMVCContext _context;

        public SeedingService(WebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departments.Any() || _context.Seller.Any() || _context.SalesRecords.Any())
            {
                return; // DB já foi populado
            }

            Departments d1 = new Departments(1, "Computers");
            Departments d2 = new Departments(2, "Eletronics");
            Departments d3 = new Departments(3, "Fashion");

            Seller s1 = new Seller(1, "Bob", "bob@gmail.com", new DateTime(1992, 1, 10), 1000.00, d1);
            Seller s2 = new Seller(2, "Ana", "Ana@gmail.com", new DateTime(1993, 3, 21), 1000.00, d1);
            Seller s3 = new Seller(3, "Felipe", "Felipe@gmail.com", new DateTime(1991, 7, 11), 1000.00, d2);
            Seller s4 = new Seller(4, "Jackson", "Jackson@gmail.com", new DateTime(1990, 5, 24), 1000.00, d3);
            Seller s5 = new Seller(5, "Bruna", "Bruna@gmail.com", new DateTime(1987, 2, 13), 1000.00, d3);
            Seller s6 = new Seller(6, "Julia", "Julia@gmail.com", new DateTime(1967, 3, 16), 1000.00, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(1988, 1, 19), 800.00, SaleStatus.Biller, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(1988, 1, 13), 1200.00, SaleStatus.Pending, s1);
            SalesRecord r3 = new SalesRecord(3, new DateTime(1988, 2, 14), 300.00, SaleStatus.Caceled, s2);
            SalesRecord r4 = new SalesRecord(4, new DateTime(1988, 2, 17), 8000.00, SaleStatus.Biller, s6);
            SalesRecord r5 = new SalesRecord(5, new DateTime(1988, 2, 19), 2500.00, SaleStatus.Pending, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(1988, 2, 2), 350.00, SaleStatus.Pending, s3);
            SalesRecord r7 = new SalesRecord(7, new DateTime(1988, 3, 5), 870.00, SaleStatus.Biller, s3);
            SalesRecord r8 = new SalesRecord(8, new DateTime(1988, 3, 6), 785.00, SaleStatus.Biller, s5);
            SalesRecord r9 = new SalesRecord(9, new DateTime(1988, 4, 1), 2300.00, SaleStatus.Pending, s6);
            SalesRecord r10 = new SalesRecord(10, new DateTime(1988, 5, 8), 4580.00, SaleStatus.Caceled, s4);

            // POPULANDO TABELA DEPARTAMENTOS
            _context.Departments.AddRange(d1, d2, d3);

            // POPULANDO TABELA VENDEDORES
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            // POPULANDO TABELA VENDAS
            _context.SalesRecords.AddRange
            (
                r1, r2, r3, r4, r5,
                r6, r7, r8, r9, r10
            );

            // SALVA E CONFIRMA ALTERAÇÕES NO BANCO DE DADOS
            _context.SaveChanges();
        }
    }
}
