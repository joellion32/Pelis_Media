using Pelis_Media.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pelis_Media.Views.Actors
{
	public partial class Create_Actor : Form
	{
		ActorModel actorModel = new ActorModel();
		public Create_Actor()
		{
			InitializeComponent();
		}

		// load image into PictureBox

		private void btnUpload_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();

			try
			{
				openFileDialog.ShowDialog();

				if (openFileDialog.FileName.Equals("") == false)
				{
					pictureBox1.Load(openFileDialog.FileName);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se pudo cargar la imagen" + ex.ToString());
			}
		}

		// save data to DB
		private void btnSave_Click(object sender, EventArgs e)
		{
			actorModel.Name = tbxName.Text;
			actorModel.SurName = textSurname.Text;
			actorModel.Gender = comboG.Text;
			actorModel.Birth = dateBirth.Value;
			actorModel.Photo = pictureBox1;
			actorModel.Save_Actor();
		}

		private void btnClean_Click(object sender, EventArgs e)
		{
			tbxName.Text = "";
			textSurname.Text = "";
		}
	}
}
