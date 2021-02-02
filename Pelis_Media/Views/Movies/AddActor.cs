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
	public partial class AddActor : Form
	{
		ActorModel actorModel = new ActorModel();
		int id_movie;

		public AddActor(int id)
		{
			InitializeComponent();
			id_movie = id;
		}

		private void AddActor_Load(object sender, EventArgs e)
		{
			Load_Data();
		}

		// load Data
		private void Load_Data()
		{
			dataGActors.DataSource = actorModel.get_actors();
		}

		// add actors from datagriview
		private void btnAdd_Click(object sender, EventArgs e)
		{
			// created variables
			int id_actor = Convert.ToInt32(dataGActors.CurrentRow.Cells[0].Value);
			string actor_name = dataGActors.CurrentRow.Cells[1].Value.ToString();
			string surname = dataGActors.CurrentRow.Cells[2].Value.ToString();



			if (ExistsInList(id_actor.ToString()))
			{

			}
			else
			{
				dataGListActors.Rows.Add(id_actor, actor_name, surname);
			}

		}


		// check that the information is not repeated in datagridview
		private bool ExistsInList(string role)
		{
			bool exist = false;

			foreach (DataGridViewRow row in dataGListActors.Rows)
			{
				string validating = Convert.ToString(row.Cells["id"].Value);
				if (role == validating)
				{
					MessageBox.Show("No se puede agregar el actor 2 veces en la misma pelicula");
					exist = true;
				}
			}

			return exist;
		}


		// save actors to BD
		private void btnSaveActors_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dataGListActors.Rows)
			{
				actorModel.Movie_Id = id_movie;
				actorModel.Id_Actor = Convert.ToInt32(row.Cells["id"].Value);
				if (actorModel.ExistActor(actorModel.Id_Actor, id_movie))
				{

				}
				else
				{
					actorModel.save_cast();
					lbAlert.Visible = true;
				}
			}
		}

	}
}
