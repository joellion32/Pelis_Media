using Pelis_Media.Models;
using Pelis_Media.Views.Movie;
using Pelis_Media.Views.Movies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pelis_Media.Views
{
	public partial class Movies_s : Form
	{
		MovieModel movieModel = new MovieModel();
		GenreModel genreModel = new GenreModel();
		public Movies_s()
		{
			InitializeComponent();
		}

		// load data
		private void Movie_Load(object sender, EventArgs e)
		{
			Load_Data();
		}

		// load all data
		private void Load_Data()
		{
			dataGMovies.DataSource = movieModel.get_movies();
		}

		// view form detail movie 
		private void dataGMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dataGMovies.SelectedCells.Count > 0)
			{
				int id = Convert.ToInt32(dataGMovies.CurrentRow.Cells["id_movie"].Value);
				Detail_Movie form_detail = new Detail_Movie(id);
				form_detail.ShowDialog();

			}
		}

		// load list in combobox when clicked
		private void comboGenres_MouseClick(object sender, MouseEventArgs e)
		{
			comboGenres.DataSource = genreModel.get_genres();
			comboGenres.DisplayMember = "Genre";
			comboGenres.ValueMember = "Id_Genre";
		}

		private void comboGenres_SelectionChangeCommitted(object sender, EventArgs e)
		{
			movieModel.Genre_Id = Convert.ToInt32(comboGenres.SelectedValue);
			dataGMovies.DataSource = movieModel.get_movies_by_genre();
		}

		// get all movies 
		private void btnall_Click(object sender, EventArgs e)
		{
			Load_Data();
		}


		// search movies by searchbox
		private void buttonS_Click(object sender, EventArgs e)
		{
			string value = tbxSearch.Text;
			dataGMovies.DataSource =  movieModel.search_movies(value);
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			Create_Movie movie_form = new Create_Movie();
			movie_form.ShowDialog();
		}
	}
}
