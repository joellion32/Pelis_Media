using Pelis_Media.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;


namespace Pelis_Media.Views.Movie
{
	public partial class Create_Movie : Form
	{
		GenreModel genreModel = new GenreModel();
		MovieModel movieModel = new MovieModel();
		public Create_Movie()
		{
			InitializeComponent();
		}

		private void Create_Movie_Load(object sender, EventArgs e)
		{
			comboG.DataSource = genreModel.get_genres();
			comboG.DisplayMember = "Genre";
			comboG.ValueMember = "Id_Genre";
		}

		// load image into PictureBox
		private void btnUpload_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();

			try
			{
				openFileDialog.ShowDialog();

				if(openFileDialog.FileName.Equals("") == false)
				{
					pictureBox1.Load(openFileDialog.FileName);
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("No se pudo cargar la imagen" + ex.ToString());
			}
		}

		

		private void tbxQualification_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Char.IsLetter(e.KeyChar))
			{
				e.Handled = true;
				MessageBox.Show("Solo se pueden escribir numeros");
			}
			else if (Char.IsWhiteSpace(e.KeyChar))
			{
				e.Handled = true;
				MessageBox.Show("Solo se pueden escribir numeros");
			}

			else if (Char.IsSymbol(e.KeyChar))
			{
				e.Handled = true;
				MessageBox.Show("Solo se pueden escribir numeros");
			}
		}


		// save movie
		private void btnSave_Click(object sender, EventArgs e)
		{
			if (tbxTitle.Text == "" || tbxQualification.Text == "" || tbxDescription.Text == "")
			{
				MessageBox.Show("Hay campos vacíos por favor complete la información");
			}
			else
			{
				string premiere;

				if (comboPremiere.Text == "SI")
				{
					premiere = "S";
				}
				else
				{
					premiere = "N";
				}


				movieModel.Genre_Id = Convert.ToInt32(comboG.SelectedValue);
				movieModel.Title = tbxTitle.Text;
				movieModel.Qualification = Convert.ToDecimal(tbxQualification.Text);
				movieModel.Date = dateDate.Value;
				movieModel.Description = tbxDescription.Text;
				movieModel.Premiere = premiere;
				movieModel.Picture = pictureBox1;
				movieModel.Save_Movie();
			}


			
		}

		private void btnClean_Click(object sender, EventArgs e)
		{
			tbxTitle.Text = "";
			tbxQualification.Text = "";
			tbxDescription.Text = "";
		}
	}
}
