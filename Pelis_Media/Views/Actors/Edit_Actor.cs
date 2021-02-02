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
	public partial class Edit_Actor : Form
	{
		int id_actor;
		ActorModel actorModel = new ActorModel();
		public Edit_Actor(int id)
		{
			InitializeComponent();
			id_actor = id;
		}

		private void Edit_Actor_Load(object sender, EventArgs e)
		{
			actorModel.Id_Actor = id_actor;
			actorModel.detail_actor();
			tbxName.Text = actorModel.Name;
			tbxSurname.Text = actorModel.SurName;
			dateBirth.Value = actorModel.Birth;
			actorModel.view_image(id_actor, pictureBox1);
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			id_actor = actorModel.Id_Actor;
			actorModel.Name = tbxName.Text;
			actorModel.SurName = tbxSurname.Text;
			actorModel.Birth = dateBirth.Value;
			actorModel.update_actor();
		}
	}
}
