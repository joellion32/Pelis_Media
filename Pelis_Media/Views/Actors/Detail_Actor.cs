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
	public partial class Detail_Actor : Form
	{
		int id_actor;
		ActorModel actorModel = new ActorModel();
		public Detail_Actor(int id)
		{
			InitializeComponent();
			id_actor = id;
		}

		private void Detail_Actor_Load(object sender, EventArgs e)
		{
			actorModel.Id_Actor = id_actor;
			actorModel.detail_actor();
			lbNombre.Text = actorModel.Name + " " + actorModel.SurName;
			lbBirth.Text = actorModel.Birth.ToShortDateString();
			lbSex.Text = actorModel.Gender;

			actorModel.view_image(id_actor, pictureBox1);
			dataGridView1.DataSource = actorModel.get_movie_actor();
 		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			Edit_Actor form_edit = new Edit_Actor(id_actor);
			form_edit.ShowDialog();
			this.Close();
			

		}
	}
}
