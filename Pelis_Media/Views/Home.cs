using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pelis_Media.Models;
using Pelis_Media.Views.Movies;

namespace Pelis_Media.Views
{
	public partial class Home : Form
	{
		// variables
		MovieModel moviesModel = new MovieModel();
		ActorModel actorModel = new ActorModel();
		public Home()
		{
			InitializeComponent();
		}

		// Load Data
		private void Home_Load(object sender, EventArgs e)
		{
			lbmovies.Text = moviesModel.count_movies();
			lbpremiere.Text = moviesModel.count_movies_premire();
			lbactors.Text = actorModel.count_actors();
			dataGPremiere.DataSource = moviesModel.get_movies_premiere();

		}

		// view form detail movie
		private void dataGPremiere_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dataGPremiere.SelectedCells.Count > 0)
			{
				int id = Convert.ToInt32(dataGPremiere.CurrentRow.Cells["id_movie"].Value);
				Detail_Movie form_detail = new Detail_Movie(id);
				form_detail.ShowDialog();
			 
			}
		}
	}
}
