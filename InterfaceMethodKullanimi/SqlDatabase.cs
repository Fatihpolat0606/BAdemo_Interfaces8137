using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceMethodKullanimi
{
    public class SqlDatabase : IDatabase
    {
        public string DatabaseName { get; set; }
        public string Company { get; set; }

        public void Create()
        {
            Console.WriteLine("Create by SQL");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted by SQL");
        }

        public void Read()
        {
            Console.WriteLine("Read by SQL");
        }

        public void Update()
        {
            Console.WriteLine("Updated by SQL");
        }
    }
}
