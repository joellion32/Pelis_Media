using Pelis_Media.Models;
using Pelis_Media.Views.Actors;
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
	public partial class Actor : Form
	{
		ActorModel actorModel = new ActorModel();
		public Actor()
		{
			InitializeComponent();
		}

		private void Actors_Load(object sender, EventArgs e)
		{
			Load_Data();
		}


		private void Load_Data()
		{
			dataGActors.DataSource = actorModel.get_actors();
		}
		// search actors by textbox
		private void btnSearch_Click(object sender, EventArgs e)
		{
			dataGActors.DataSource = actorModel.search_actors(tbxSearch.Text);
		}

		// search actors by combobox
		private void comboGenres_SelectedIndexChanged(object sender, EventArgs e)
		{
			actorModel.Gender = comboSex.Text;
			dataGActors.DataSource = actorModel.search_actors_gender();
		}

		// view all data
		private void btnall_Click(object sender, EventArgs e)
		{
			Load_Data();
		}

		private void dataGActors_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dataGActors.SelectedCells.Count > 0)
			{
				int id = Convert.ToInt32(dataGActors.CurrentRow.Cells["id_actor"].Value);
				Detail_Actor form_detail = new Detail_Actor(id);
				form_detail.ShowDialog();

			}
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			Create_Actor create_form = new Create_Actor();
			create_form.ShowDialog();
		}
	}
}
