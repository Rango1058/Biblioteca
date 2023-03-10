using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logica.Model
{
    public class Libro
    {
        private String name;
        private String isbn;
        private int year;
        private String tematica;
        private int numberPages;

        public string Name { get => name; set => name = value; }
        public int Year { get => year; set => year = value; }
        public string Tematica { get => tematica; set => tematica = value; }
        public int NumberPages { get => numberPages; set => numberPages = value; }
        public string Isbn { get => isbn; set => isbn = value; }

        public String showInfo()
        {
            return $"Libro: {name}, ISBN: {isbn}, Año: {year}, Tematica: {tematica}, Paginas: {numberPages}";
        }
        public String isModern()
        {
            string msj = year > 2015 ? "El libro es moderno" : "El libro no es moderno";
            return msj;
        }
    }
}