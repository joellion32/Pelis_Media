using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Pelis_Media.Views;

namespace Pelis_Media
{

	public partial class Form1 : Form
	{
        private Form currentChildForm;


        public Form1()
		{
			InitializeComponent();

			
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            btnHome_Click(null, e);
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            primaryPanel.Controls.Add(childForm);
            primaryPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbNavigation.Text = childForm.Text;
        }

		private void btnMovies_Click(object sender, EventArgs e)
		{
            OpenChildForm(new Movies_s());
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
            OpenChildForm(new Home());
        }

		private void btnActors_Click(object sender, EventArgs e)
		{
            OpenChildForm(new Actor());
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
            Application.Exit();
		}
	}
}
