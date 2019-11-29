using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaEquipo
    {
    public partial class Principal : Form
        {
        public Principal()
            {
            InitializeComponent();
            }

        TextBox TxtUsuario;
        Label LabUsuario;
        Button BtnAcceder;

        List<IUsuario> listaUsuario = new List<IUsuario>();


        private void Form1_Load(object sender, EventArgs e)
            {

            //La hacemos Clase padre
            IsMdiContainer=true;
            //Maximizamos su tamaño al abrirla
            WindowState=FormWindowState.Maximized;

            }

        private void Form1_Paint(object sender, PaintEventArgs e)
            {
            Form f = new Form();

            TxtUsuario=new TextBox();
            LabUsuario=new Label();
            BtnAcceder=new Button();


            //Textos de labels
            LabUsuario.Text="Nombre de Usuario";
            BtnAcceder.Text="Acceder";

            //Nombre de coontroles
            LabUsuario.Name="LabUsuario";

            TxtUsuario.Name="TxtUsuario";

            BtnAcceder.Name="BtnAcceder";

            BtnAcceder.Location=new Point(123, 207);

            LabUsuario.Location=new Point(148, 74);
            TxtUsuario.Location=new Point(29, 127);

            BtnAcceder.Size=new Size(165, 62);

            LabUsuario.Size=new Size(241, 29);
            TxtUsuario.Size=new Size(384, 62);

            f.Size=new System.Drawing.Size(451, 342);

            f.Controls.Add(LabUsuario);
            f.Controls.Add(TxtUsuario);
            f.Controls.Add(BtnAcceder);

            f.FormBorderStyle=FormBorderStyle.FixedToolWindow;
            f.Show();

            f.BringToFront();

            }

        private void AltaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
            {
            Boolean encontrado = false;
            foreach (Form f in MdiChildren)
                {

                if (f.GetType().ToString().Contains("AltaUsuario"))
                    {
                    f.BringToFront();
                    encontrado=true;
                    }
                }

            if (!encontrado)
                {
                //Creamos un objeto de tipo Alta
                AltaUsuario objetoAltaUsuario = new AltaUsuario();
                //Si ya hay una abierta no abre más

                //Le indicamos que este es el padre
                objetoAltaUsuario.MdiParent=this;
                //Lo mostramos
                objetoAltaUsuario.Show();
                //Maximizamos su tamaño al abrirla
                objetoAltaUsuario.WindowState=FormWindowState.Maximized;
                }

            }

        private void LibrosToolStripMenuItem1_Click(object sender, EventArgs e)
            {

            Boolean encontrado = false;
            foreach (Form f in MdiChildren)
                {

                if (f.GetType().ToString().Contains("AltaLibro"))
                    {
                    f.BringToFront();
                    encontrado=true;
                    }
                }

            if (!encontrado)
                {
                //Creamos un objeto de tipo Alta
                AltaLibro objetoAltaLibro = new AltaLibro();
                //Si ya hay una abierta no abre más

                //Le indicamos que este es el padre
                objetoAltaLibro.MdiParent=this;
                //Lo mostramos
                objetoAltaLibro.Show();
                //Maximizamos su tamaño al abrirla
                objetoAltaLibro.WindowState=FormWindowState.Maximized;
                }
            }
        }
    }
