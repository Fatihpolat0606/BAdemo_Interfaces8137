using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceMethodKullanimi
{
    public class OracleDatabase : IDatabase
    {
        public string DatabaseName { get; set; }
        public string Company { get; set; }

        public void Create()
        {
            Console.WriteLine("Create by Oracle");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }

        public void Read()
        {
            Console.WriteLine("Read by Oracle");
        }

        public void Update()
        {
            Console.WriteLine("Updated by Oracle");
        }
    }
}
