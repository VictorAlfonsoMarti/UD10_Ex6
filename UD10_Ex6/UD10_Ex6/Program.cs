
using System;

namespace UD10_Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro(1111, "Libro 1", "Autor1", 100);
            Libro libro2 = new Libro(2222, "Libro 2", "Autor2", 200);

            libro1.ToString();
            libro2.ToString();

            Libro.MasPaginas(libro1, libro2);

        }
    }
}
