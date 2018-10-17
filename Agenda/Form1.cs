using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Agenda
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Palestra = new List<Palestra>
        {
            new Palestra() { ID = 1, Tema ="Escrevendo testes rápidos", duracao =60},
            new Palestra() { ID = 2, Tema ="Uma visão sobre Python", duracao =45},
            new Palestra() { ID = 3, Tema ="Angular", duracao =30},
            new Palestra() { ID = 4, Tema ="Otimizando aplicações com o NodeJS", duracao =45},
            new Palestra() { ID = 5, Tema ="Erros comuns no desenvolvimento de software", duracao =45},
            new Palestra() { ID = 6, Tema ="Rails para Desenvolvedores Python", duracao =60},
            new Palestra() { ID = 7, Tema ="ASP.net MVC", duracao =60},
            new Palestra() { ID = 8, Tema ="TDD na prática", duracao =45},
            new Palestra() { ID = 9, Tema ="Woah", duracao =30},
            new Palestra() { ID = 10, Tema ="Sente e escreva", duracao =30},
            new Palestra() { ID = 11, Tema ="Pair Programming vs Noise", duracao =45},
            new Palestra() { ID = 12, Tema ="Mobilidade em desenvolvimento", duracao =60},
            new Palestra() { ID = 13, Tema ="Ruby on Rails: Por que devemos migrar para ele?", duracao =60},
            new Palestra() { ID = 14, Tema ="Otimizando aplicações .NET", duracao =45},
            new Palestra() { ID = 15, Tema ="Java e os novos paradigmas de programação", duracao =30},
            new Palestra() { ID = 16, Tema ="Rubi vs. Clojure para Back-End", duracao =30},
            new Palestra() { ID = 17, Tema ="Scrum para leigos", duracao =60},
            new Palestra() { ID = 18, Tema ="Um mundo sem stackoverflow", duracao =30},
            new Palestra() { ID = 19, Tema ="UX", duracao =30},
        };
            double Tempo = 0;
            DateTime time = new DateTime(2018,10,1,09,00,00);
            Trilha1.Items.Clear();
            Trilha2.Items.Clear();
            ///////////////////////////////////////////////////////////////////////////////////
            Random randNum2 = new Random();
            
            int index = randNum2.Next(Palestra.Count);  

            do
            {
                randNum2 = new Random();
                index = randNum2.Next(Palestra.Count);

                System.Threading.Thread.Sleep(0); //Makes the async thread sleep for 500 ms
                Application.DoEvents();

                if ((Palestra[index].duracao == 60 || Palestra[index].duracao == 30 || Palestra[index].duracao==45) && ((Tempo + Palestra[index].duracao) <= 180 && (Tempo + Palestra[index].duracao) != 165) && Tempo != 165)
                {
                    Trilha1.Items.Add(time.ToShortTimeString() + " " + Palestra[index].Tema + " " + Palestra[index].duracao + " min");
                    Tempo += Palestra[index].duracao;
                    time = time.AddMinutes(Palestra[index].duracao);

                    var itemToRemove = Palestra.Single(r => r.ID == Palestra[index].ID);
                    if (itemToRemove != null)
                        Palestra.Remove(itemToRemove);

                }
                    } while ( Tempo !=180);

            Trilha1.Items.Add(time.ToShortTimeString() + " Almoço ");
            Tempo += 60;
            time = time.AddMinutes(60);

            do
            {
                randNum2 = new Random();
                index = randNum2.Next(Palestra.Count);

                System.Threading.Thread.Sleep(0); //Makes the async thread sleep for 500 ms
                Application.DoEvents();


                if ((Palestra[index].duracao == 60 || Palestra[index].duracao == 30 || Palestra[index].duracao == 45) && ((Tempo + Palestra[index].duracao) <= 480 && (Tempo + Palestra[index].duracao) != 465) && Tempo != 465)
                {
                    Trilha1.Items.Add(time.ToShortTimeString() + " " + Palestra[index].Tema + " " + Palestra[index].duracao + " min");
                    Tempo += Palestra[index].duracao;
                    time = time.AddMinutes(Palestra[index].duracao);

                    var itemToRemove = Palestra.Single(r => r.ID == Palestra[index].ID);
                    if (itemToRemove != null)
                        Palestra.Remove(itemToRemove);

                }
            } while (Tempo != 480);

            Trilha1.Items.Add(time.ToShortTimeString() + " Evento de Networking ");
            Tempo += 60;
            time = time.AddMinutes(60);


            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            Tempo = 0;
            time = new DateTime(2018, 10, 1, 09, 00, 00);
            randNum2 = new Random();
            index = randNum2.Next(Palestra.Count);

            do
            {
                randNum2 = new Random();
                index = randNum2.Next(Palestra.Count);

                System.Threading.Thread.Sleep(0); //Makes the async thread sleep for 500 ms
                Application.DoEvents();

                if ((Palestra[index].duracao == 60 || Palestra[index].duracao == 30 || Palestra[index].duracao == 45) && ((Tempo + Palestra[index].duracao) <= 180 && (Tempo + Palestra[index].duracao) != 165) && Tempo != 165)
                {
                    Trilha2.Items.Add(time.ToShortTimeString() + " " + Palestra[index].Tema + " " + Palestra[index].duracao + " min");
                    Tempo += Palestra[index].duracao;
                    time = time.AddMinutes(Palestra[index].duracao);

                    var itemToRemove = Palestra.Single(r => r.ID == Palestra[index].ID);
                    if (itemToRemove != null)
                        Palestra.Remove(itemToRemove);

                }
            } while (Tempo != 180);

            Trilha2.Items.Add(time.ToShortTimeString() + " Almoço ");
            Tempo += 60;
            time = time.AddMinutes(60);

            do
            {
                randNum2 = new Random();
                index = randNum2.Next(Palestra.Count);

                System.Threading.Thread.Sleep(0); //Makes the async thread sleep for 500 ms
                Application.DoEvents();


                if ((Palestra[index].duracao == 60 || Palestra[index].duracao == 30 || Palestra[index].duracao == 45) && ((Tempo + Palestra[index].duracao) <= 480 && (Tempo + Palestra[index].duracao) != 465) && Tempo != 465)
                {
                    Trilha2.Items.Add(time.ToShortTimeString() + " " + Palestra[index].Tema + " " + Palestra[index].duracao + " min");
                    Tempo += Palestra[index].duracao;
                    time = time.AddMinutes(Palestra[index].duracao);

                    var itemToRemove = Palestra.Single(r => r.ID == Palestra[index].ID);
                    if (itemToRemove != null)
                        Palestra.Remove(itemToRemove);

                }
            } while (Tempo != 480);

            Trilha2.Items.Add(time.ToShortTimeString() + " Evento de Networking ");
            Tempo += 60;
            time = time.AddMinutes(60);
        }

        





        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
