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

namespace Pelis_Media.Views.Movies
{
	public partial class Edit_Movie : Form
	{
		private int id_movie;
		MovieModel movie = new MovieModel();
		GenreModel genreModel = new GenreModel();


		public Edit_Movie(int id)
		{
			InitializeComponent();
			id_movie = id;
		}

		private void Edit_Movie_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		// load data into Form
		private void LoadData()
		{
			movie.Id_Movie = id_movie;
			movie.detail_movie();
			movie.view_image(id_movie, pictureBox1);
			tbxTitle.Text = movie.Title;
			tbxQualification.Text = movie.Qualification.ToString();
			dateDate.Value = movie.Date;
			tbxDescription.Text = movie.Description;


			// combobox genres
			comboG.DataSource = genreModel.get_genres();
			comboG.DisplayMember = "Genre";
			comboG.ValueMember = "Id_Genre";


			// combobox premiere
			if (movie.Premiere == "S")
			{
				comboPremiere.Text = "SI";
			}
			else
			{
				comboPremiere.Text = "NO";
			}
		}

	
		//reset data
		private void btnReset_Click(object sender, EventArgs e)
		{
			LoadData();
		}

		// show form add actors
		private void btnActors_Click(object sender, EventArgs e)
		{
			AddActor form_actor = new AddActor(id_movie);
			form_actor.ShowDialog();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string premiere;
			movie.Id_Movie = id_movie;
			movie.Genre_Id = Convert.ToInt32(comboG.SelectedValue);
			movie.Title = tbxTitle.Text;
			movie.Qualification = Convert.ToDecimal(tbxQualification.Text);
			movie.Date = dateDate.Value;
			movie.Description = tbxDescription.Text;

			if (movie.Premiere == "SI")
			{
				premiere = "S";
			}
			else
			{
				premiere = "N";
			}

			movie.Premiere = premiere;

			movie.update_movie();
		}
	}
}
