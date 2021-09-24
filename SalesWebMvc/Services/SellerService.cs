using System.Collections.Generic;
using System.Linq;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class SellerService
    {

        private readonly SalesWebMvcContext _context; //readonly PREVINE QUE ESSA DEPENDENCIA NAO POSSA SER ALTERADA

        public SellerService (SalesWebMvcContext context) 
        {
            _context = context;   //AQUI REALIZAMOS A INJECAO DE DEPENDENCIA
        }
        
        public List<Seller> FindAll() //ESS OPERACAO RETORNA DO BD OS VENDEDORES
        {
            return _context.Seller.ToList(); //ISSO ACESSA FONTE DE DADOS REALACIONADA A TABELA DE VENDEDORES E CONVERTE PARA MINHA LISTA
        }

        public void Insert(Seller obj) //ADICIONA UM NOVO VENDEDOR NO BD
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
        public Seller FindById(int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id); //AQUI ELE INCLUI NOS DETALHES O DEPARTAMENTO
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
    }
}
