using Logica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Libro libro1 = new Libro();

            libro1.Name = "Las mil y una noche";
            libro1.Isbn = "978-2-17-23420-0";
            libro1.Year = 1996;
            libro1.Tematica = "Novela Literaria";
            libro1.NumberPages = 328;


            LblMsj1.Text = libro1.showInfo();
            LblMsj2.Text = libro1.isModern();

            Libro libro2 = new Libro();

            libro2.Name = "Don Quijote de la Mancha";
            libro2.Isbn = "977-1-24-42089-0";
            libro2.Year = 1989;
            libro2.Tematica = "Novela Literaria";
            libro2.NumberPages = 1040;

            LblMsj3.Text = libro2.showInfo();
            LblMsj4.Text = libro2.isModern();

            Libro libro3 = new Libro();

            libro3.Name = "Crimen y castigo";
            libro3.Isbn = "968-7-43-42891-0";
            libro3.Year = 2023;
            libro3.Tematica = "Novela Literaria";
            libro3.NumberPages = 768;

            LblMsj5.Text = libro3.showInfo();
            LblMsj6.Text = libro3.isModern();
        }
    }
}