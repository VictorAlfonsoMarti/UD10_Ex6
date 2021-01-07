using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Ex6
{
    class Libro
    {
        // ATRIBUTOS 
        private int isbn;
        private string titulo;
        private string autor;
        private int numPaginas;

        // GETTERS Y SETTERS
        public int _Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public string _Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string _Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public int _NumPaginas
        {
            get { return numPaginas; }
            set { numPaginas = value; }
        }

        // CONSTRUCTOR
        public Libro(int isbn, string titulo, string autor, int numPaginas)
        {
            _Isbn = isbn;
            _Titulo = titulo;
            _Autor = autor;
            _NumPaginas = numPaginas;
        }

        // METODOS
        public override string ToString()
        {
            Console.WriteLine("El libro {0} con ISBN {1} creador por el autor {2} tiene {3} paginas.", this.titulo, this.isbn, this.autor, this.numPaginas );
            return "";
        }

        public static void MasPaginas(Libro l1, Libro l2)
        {
            if (l1._NumPaginas > l2._NumPaginas)
            {
                Console.WriteLine("El libro {0} con {1} paginas, tiene más paginas que el libro {2} con {3} paginas", l1._Titulo, l1._NumPaginas, l2._Titulo, l2._NumPaginas);
            }
            else if (l1._NumPaginas == l2._NumPaginas)
            {
                Console.WriteLine("El libro {0} y el libro {1} tienen las mismas paginas: {2}", l1._Titulo, l2._Titulo, l2._NumPaginas);
            }
            else
            {
                Console.WriteLine("El libro {0} con {1} paginas, tiene más paginas que el libro {2} con {3} paginas", l2._Titulo, l2._NumPaginas, l1._Titulo, l1._NumPaginas);
            }
        }

    }
}
