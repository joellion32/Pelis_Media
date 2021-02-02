using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pelis_Media.Config;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Pelis_Media.Models
{
	class ActorModel
	{
		public int id_actor;
		public int movie_id;
		public string name;
		public string surname;
		public string gender;
		public DateTime birth;
		public PictureBox photo;


		// getters and setters 
		public int Id_Actor 
		{
			get { return id_actor; }
			set { this.id_actor = value; }
		}

		public int Movie_Id
		{
			get { return movie_id; }
			set { this.movie_id = value; }
		}


		public string Name
		{
			get { return name; }
			set { this.name = value; }
		}

		public string SurName
		{
			get { return surname; }
			set { this.surname = value; }
		}

		public string Gender
		{
			get { return gender; }
			set { this.gender = value; }
		}

		public DateTime Birth
		{
			get { return birth; }
			set { this.birth = value; }
		}

		public PictureBox Photo
		{
			get { return photo; }
			set { this.photo = value; }
		}


		/*****************************FUNCTIONS*************************************/

		// count actors
		public string count_actors()
		{
			string count_actors;
			using (SqlConnection cn = ConnectionDB.getSqlConnection())
			{
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = cn;

				// create query
				cmd.CommandText = "SELECT COUNT(*) FROM actors";
				cmd.CommandType = CommandType.Text;
				cmd.ExecuteNonQuery();

				count_actors = cmd.ExecuteScalar().ToString();
				return count_actors;
			}

		}


		//Get all actors
		public DataTable get_actors()
		{
			SqlDataReader reader;
			DataTable table = new DataTable();

			using (SqlConnection cn = ConnectionDB.getSqlConnection())
			{
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = cn;

				// create query
				cmd.CommandText = "SELECT id_actor, name, surname, gender, birth FROM actors";
				cmd.CommandType = CommandType.Text;
				reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					table.Load(reader);
				}

				cn.Close();
			}

			return table;
		}


		//validate that the actors do not repeat themselves
		public bool ExistActor(int id_actor, int id_movie)
		{
			bool exist = false;
			SqlDataReader reader;

			using (SqlConnection cn = ConnectionDB.getSqlConnection())
			{
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = cn;

				//create query
				cmd.Parameters.AddWithValue("@id_actor", id_actor);
				cmd.Parameters.AddWithValue("@id_movie", id_movie);

				cmd.CommandText = "SELECT * FROM cast WHERE actor_id = @id_actor AND movie_id = @id_movie";
				reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					MessageBox.Show("El actor con el id: " + id_actor + " Ya existe en esta pelicula");
					exist = true;
				}
			}

			return exist;
		}

		// save cast
		public void save_cast()
		{
			using (SqlConnection cn = ConnectionDB.getSqlConnection())
			{
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = cn;

				// create query
				cmd.Parameters.AddWithValue("@movie_id", Movie_Id);
				cmd.Parameters.AddWithValue("@actor_id", Id_Actor);
				cmd.CommandText = "INSERT INTO cast VALUES(@movie_id, @actor_id)";
				cmd.CommandType = CommandType.Text;
				var save = cmd.ExecuteNonQuery();

				cn.Close();
			}
		}


		// get cast
		public DataTable get_cast()
		{
			SqlDataReader reader;
			DataTable table = new DataTable();

			using (SqlConnection cn = ConnectionDB.getSqlConnection())
			{
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = cn;

				// create query
				cmd.Parameters.AddWithValue("@movie_id", Movie_Id);
				cmd.CommandText = "SELECT actors.name, actors.surname, actors.gender, actors.birth FROM cast INNER JOIN actors ON cast.actor_id = actors.id_actor WHERE cast.movie_id = @movie_id";
				cmd.CommandType = CommandType.Text;
				reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					table.Load(reader);
				}

				cn.Close();
			}

			return table;
		}


		// get movies by actor
		public DataTable get_movie_actor()
		{
			SqlDataReader reader;
			DataTable table = new DataTable();

			using (SqlConnection cn = ConnectionDB.getSqlConnection())
			{
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = cn;
				cmd.Parameters.AddWithValue("@id_actor", Id_Actor);
				cmd.CommandText = "SELECT movies.title FROM cast INNER JOIN movies ON cast.movie_id = movies.id_movie WHERE actor_id = @id_actor";
				cmd.CommandType = CommandType.Text;
				reader = cmd.ExecuteReader();

				if (reader.HasRows)
				{
					table.Load(reader);
					cn.Close();
				}
			}


			return table;
		}

		// search movies
		public DataTable search_actors(string value)
		{
			SqlDataReader reader;
			DataTable table = new DataTable();

			using (SqlConnection cn = ConnectionDB.getSqlConnection())
			{
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = cn;

				// create query
				cmd.CommandText = "SELECT id_actor, name, surname, gender, birth FROM actors WHERE name LIKE '%" + value + "%'";
				cmd.CommandType = CommandType.Text;
				reader = cmd.ExecuteReader();

				if (reader.HasRows)
				{
					table.Load(reader);
				}
				else
				{
					MessageBox.Show("No hay registros");
				}

				cn.Close();
			}

			return table;
		}


		// search by gender
		public DataTable search_actors_gender()
		{
			SqlDataReader reader;
			DataTable table = new DataTable();

			using (SqlConnection cn = ConnectionDB.getSqlConnection())
			{
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = cn;

				// create query
				cmd.Parameters.AddWithValue("@gender", Gender);
				cmd.CommandText = "SELECT id_actor, name, surname, gender, birth FROM actors WHERE gender = @gender";
				cmd.CommandType = CommandType.Text;
				reader = cmd.ExecuteReader();

				if (reader.HasRows)
				{
					table.Load(reader);
				}
				else
				{
					MessageBox.Show("No hay registros");
				}

				cn.Close();
			}

			return table;
		}

		// get detail actor
		public void detail_actor()
		{
			SqlDataReader reader;

			using (SqlConnection cn = ConnectionDB.getSqlConnection())
			{
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = cn;

				// create query
				cmd.Parameters.AddWithValue("@id", Id_Actor);
				cmd.CommandText = "SELECT * FROM actors WHERE id_actor = @id";
				cmd.CommandType = CommandType.Text;
				reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					if (reader.Read())
					{
						Name = reader.GetString(1);
						SurName = reader.GetString(2);
						Gender = reader.GetString(3);
						Birth = reader.GetDateTime(4);
					}
				}

				cn.Close();
			}

		}


		// view image by actor id
		public void view_image(int id, PictureBox image_actor)
		{

			try
			{
				using (SqlConnection cn = ConnectionDB.getSqlConnection())
				{
					SqlCommand cmd = new SqlCommand("SELECT photo FROM actors WHERE id_actor =" + id, cn);
					SqlDataAdapter dp = new SqlDataAdapter(cmd);
					DataSet ds = new DataSet("actors");
					byte[] MyData = new byte[0];
					dp.Fill(ds, "actors");

					DataRow myRow = ds.Tables["actors"].Rows[0];
					MyData = (byte[])myRow["photo"];

					//memory flow
					MemoryStream ms = new MemoryStream(MyData);
					image_actor.Image = Image.FromStream(ms);
					cn.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("No se pudo consultar la imagen" + ex.ToString());
			}
		}


		// save actor
		public void Save_Actor()
		{
			using (SqlConnection cn = ConnectionDB.getSqlConnection())
			{
				try
				{
					SqlCommand cmd = new SqlCommand();
					cmd.Connection = cn;

					// initialized variables
					cmd = new SqlCommand("INSERT INTO actors VALUES(@name, @surname, @gender, @birth, @photo)", cn);
					cmd.Parameters.Add("@name", SqlDbType.NVarChar);
					cmd.Parameters.Add("@surname", SqlDbType.NVarChar);
					cmd.Parameters.Add("@gender", SqlDbType.NVarChar);
					cmd.Parameters.Add("@birth", SqlDbType.Date);
					cmd.Parameters.Add("@photo", SqlDbType.Image);

					// declared variables
					cmd.Parameters["@name"].Value = Name;
					cmd.Parameters["@surname"].Value = SurName;
					cmd.Parameters["@gender"].Value = Gender;
					cmd.Parameters["@birth"].Value = Birth;
					cmd.Parameters["@photo"].Value = Photo;

					// convert image
					System.IO.MemoryStream ms = new System.IO.MemoryStream();
					Photo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
					cmd.Parameters["@photo"].Value = ms.GetBuffer();

					cmd.ExecuteNonQuery();
					MessageBox.Show("Actor registrado correctamente");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Ha ocurrido un error" + ex.ToString());
				}
			}
		}


		// update actor
		// update movie
		public void update_actor()
		{

			using (SqlConnection cn = ConnectionDB.getSqlConnection())
			{
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = cn;

				//create parameters
				cmd.Parameters.AddWithValue("@id_actor", Id_Actor);
				cmd.Parameters.AddWithValue("@name", Name);
				cmd.Parameters.AddWithValue("@surname", SurName);
				cmd.Parameters.AddWithValue("@birth", Birth);

				// create query
				cmd.CommandText = "UPDATE actors SET name = @name, surname = @surname, birth = @birth WHERE id_actor = @id_actor";
				cmd.CommandType = CommandType.Text;

				var update = cmd.ExecuteNonQuery();

				if (update > 0)
				{
					MessageBox.Show("Datos actualizados correctamente");
				}
				else
				{
					MessageBox.Show("Error al actualizar pelicula");
				}

			}
		}

	}
}
