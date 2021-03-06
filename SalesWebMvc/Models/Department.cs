using System.Collections.Generic;
using System;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int  Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();


        public Department()
        {

        }

        public Department(string name)
        {        
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            //AQUI ESTAMOS REALIZANDO O TOTAL DE VENDAS DO DEPARTAMENTO PARA UM INTERVALO DE DATAS
            //ESTAMOS SELECIONANDO A LISTA DE VENDEDOR DESSE DEPARTAMENTO E SOMANDO AS VENDAS QUE FILTRAM DESSE PERIODO
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
