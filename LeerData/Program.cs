using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;

namespace LeerData {
    class Program{
        static void Main(string[] args)
        {
            using (var DbContext = new LibroDbContext())
            {
                var libros = DbContext.Libro.AsNoTracking();

                foreach (var libro in libros)
                {
                    Console.WriteLine(libro.Titulo);
                }
            }
        }
    }

}