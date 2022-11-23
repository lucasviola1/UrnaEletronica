using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace UrnaEletronica
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void b1_Click(object sender, EventArgs e)
        {
            try
            {
                string novo = PreencherCandidato(FirstNumber.Text, SecondNumber.Text);
                var candidatos = new List<Candidato>();
                candidatos.Add(new Candidato() { Id = "35", urlImg = "../img/AmigoJimmyNeutron1.png", Nome = "Sheen", Partido = "SSS" });
                candidatos.Add(new Candidato() { Id = "25", urlImg = "../img/AmigoJimmyNeutron2.png", Nome = "Caio", Partido = "CCC" });
                candidatos.Add(new Candidato() { Id = "45", urlImg = "../img/JimmyNeutron.png", Nome = "Jimmy Neutron", Partido = "JJJ" });

                var candidato = candidatos.FirstOrDefault(m => m.Id == novo);
                if (candidato == null)
                {
                    Console.WriteLine("Error");

                }
                else
                {
                    foto.ImageUrl = candidato.urlImg;
                    lblNome.Text = candidato.Nome;
                    lblPartido.Text = candidato.Partido;
                }

            }
            catch
            {

            }
        }

        public static string PreencherCandidato(string d1, string d2)
        {
            string NumCandidato;

            NumCandidato = d1 + d2;

            return NumCandidato;
        }

        public class Candidato
        {
            public string Id { get; set; }
            public string Nome { get; set; }
            public string Partido { get; set; }
            public string urlImg { get; set; }
        }


        public class Contagem
        {
            public int idEleitor { get; set; }

            public int CandidatoJimmy { get; set; }

            public int CandidatoCaio { get; set; }

            public int CandidatoSheen { get; set; }
        }
        protected void btnVotar_Click(object sender, EventArgs e)
        {
            Contagem contagem = new Contagem();

            string path = "C:/Users/NESS/Videos/Text.txt";

            var guid = Guid.NewGuid();

            if (PreencherCandidato(FirstNumber.Text, SecondNumber.Text) == "35")
            {
                contagem.CandidatoSheen++;
                lblTexto.Text = "Voto efetuado";
                FirstNumber.Text = "";
                SecondNumber.Text = "";

                if (File.Exists(path))
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine("Voto em Sheen | " + guid);
                        sw.WriteLine(" ----------- ");
                        sw.Close();
                    }
                }

                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("Voto em Sheen| " + guid);
                        sw.WriteLine(" ----------- ");
                        sw.Close();
                    }
                }

            }

            if (PreencherCandidato(FirstNumber.Text, SecondNumber.Text) == "45")
            {
                contagem.CandidatoJimmy++;
                lblTexto.Text = "Voto efetuado";
                FirstNumber.Text = "";
                SecondNumber.Text = "";

                if (File.Exists(path))
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine("Voto em Jimmy | " + guid);
                        sw.WriteLine(" ----------- ");
                        sw.Close();
                    }
                }

                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("Voto em Jimmy| " + guid);
                        sw.WriteLine(" ----------- ");
                        sw.Close();
                    }
                }
            }
            if (PreencherCandidato(FirstNumber.Text, SecondNumber.Text) == "25")
            {
                contagem.CandidatoCaio++;
                lblTexto.Text = "Voto efetuado";
                FirstNumber.Text = "";
                SecondNumber.Text = "";

                if (File.Exists(path))
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine("Voto em Caio | " + guid);
                        sw.WriteLine(" ----------- ");
                        sw.Close();
                    }
                }

                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("Voto em Caio | " + guid);
                        sw.WriteLine(" ----------- ");
                        sw.Close();
                    }
                }
            }

            Response.Redirect("~/");
        }

    }
}