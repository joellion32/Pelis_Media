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


namespace Pelis_Media.Views.Movies
{
	public partial class Detail_Movie : Form
	{
		private int id_movie;

		MovieModel movie = new MovieModel();
		ActorModel actorModel = new ActorModel();

		public Detail_Movie(int id)
		{
			InitializeComponent();
			id_movie = id;

		}

		private void Detail_Movie_Load(object sender, EventArgs e)
		{
			movie.Id_Movie = id_movie;
			actorModel.Movie_Id = id_movie;

			movie.detail_movie();
			movie.view_image(id_movie, pictureBox1);
			dataGactors.DataSource = actorModel.get_cast();

			lbtitle.Text = movie.Title;
			lbqualification.Text = movie.Qualification.ToString();
			lbyear.Text = movie.Date.ToShortDateString();
			lbgenre.Text = movie.Genre;
			tbxdescription.Text = movie.Description;
			
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			Edit_Movie form_edit = new Edit_Movie(id_movie);
			form_edit.ShowDialog();
			this.Close();

		}
	}
}
