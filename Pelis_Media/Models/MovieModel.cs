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
	class MovieModel
	{
		public int id_movie;
		public int actor_id;
		public int genre_id;
		public string genre;
		public string title;
		public decimal qualification;
		public DateTime date;
		public string description;
		public string premiere;
		public PictureBox picture;
		public Image image;


		// getters and setters

		public int Id_Movie
		{
			get { return id_movie; }
			set { this.id_movie = value; }
		}

		public int Actor_Id
		{
			get { return actor_id; }
			set { this.actor_id = value; }
		}

		public int Genre_Id
		{
			get { return genre_id; }
			set { this.genre_id = value; }
		}


		public string Genre
		{
			get { return genre; }
			set { this.genre = value; }
		}

		public string Title
		{
			get { return title; }
			set { this.title = value; }
		}


		public decimal Qualification
		{
			get { return qualification; }
			set { this.qualification = value; }
		}

		public DateTime Date
		{
			get { return date; }
			set { this.date = value; }
		}

		public string Description
		{
			get { return description; }
			set { this.description = value; }
		}

		public string Premiere
		{
			get { return premiere; }
			set { this.premiere = value; }
		}

		public PictureBox Picture
		{
			get { return picture; }
			set { this.picture = value; }
		}

		public Image ImageD
		{
			get { return image; }
			set { this.image = value; }
		}

		/*------------------------------------- functions------------------------------------------------*/
		// count movies
		public string count_movies()
		{
			string count_movies;
			using (SqlConnection cn = ConnectionDB.getSqlConnection())
			{
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = cn;

				// create query
				cmd.CommandText = "SELECT COUNT(*) FROM movies";
				cmd.CommandType = CommandType.Text;
				cmd.ExecuteNonQuery();

				count_movies = cmd.ExecuteScalar().ToString();
				return count_movies;
			}

		}


		// count movies in premiere
		public string count_movies_premire()
		{
			string count_movies_premiere;
			using (SqlConnection cn = ConnectionDB.getSqlConnection())
			{
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = cn;

				// create query
				cmd.CommandText = "SELECT COUNT(*) FROM movies WHERE premiere = 'S'";
				cmd.CommandType = CommandType.Text;
				cmd.ExecuteNonQuery();

				count_movies_premiere = cmd.ExecuteScalar().ToString();
				return count_movies_premiere;
			}

		}

		// get movies
		public DataTable get_movies()
		{
			SqlDataReader reader;
			DataTable table = new DataTable();

			using (SqlConnection cn = ConnectionDB.getSqlConnection())
			{
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = cn;

				// create query
				cmd.CommandText = "SELECT id_movie, title, qualification, date, description FROM movies";
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

		// get movies in premiere
		public DataTable get_movies_premiere()
		{
			SqlDataReader reader;
			DataTable table = new DataTable();

			using (SqlConnection cn = ConnectionDB.getSqlConnection())
			{
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = cn;

				// create query
				cmd.CommandText = "SELECT id_movie, title, qualification, date, description FROM movies WHERE premiere = 'S'";
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

		// get detail movie
		public void detail_movie()
		{
			SqlDataReader reader;

			using (SqlConnection cn = ConnectionDB.getSqlConnection())
			{
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = cn;

				// create query
				cmd.Parameters.AddWithValue("@id", Id_Movie);
				cmd.CommandText = "SELECT movies.*, genres.* FROM movies INNER JOIN genres ON movies.genre_id = genres.id_genre WHERE id_movie = @id";
				cmd.CommandType = CommandType.Text;
				reader = cmd.ExecuteReader();
				if (reader.HasRows)
				{
					if (reader.Read())
					{
						Title = reader.GetString(2);
						Qualification = reader.GetDecimal(3);
						Date = reader.GetDateTime(4);
						Description = reader.GetString(5);
						Premiere = reader.GetString(6);
						Genre = reader.GetString(9);
					}
				}

				cn.Close();
			}

		}


		// view image by movie id
		public void view_image(int id, PictureBox image_movie)
		{

			try
			{
				using (SqlConnection cn = ConnectionDB.getSqlConnection())
				{
					SqlCommand cmd = new SqlCommand("SELECT image FROM movies WHERE id_movie =" + id, cn);
					SqlDataAdapter dp = new SqlDataAdapter(cmd);
					DataSet ds = new DataSet("movies");
					byte[] MyData = new byte[0];
					dp.Fill(ds, "movies");

					DataRow myRow = ds.Tables["movies"].Rows[0];
					MyData = (byte[])myRow["image"];

					//memory flow
					MemoryStream ms = new MemoryStream(MyData);
					image_movie.Image = Image.FromStream(ms);
					cn.Close();
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("No se pudo consultar la imagen" + ex.ToString());
			}
		}


		// filter movies by genre
		public DataTable get_movies_by_genre()
		{
			SqlDataReader reader;
			DataTable table = new DataTable();

			using (SqlConnection cn = ConnectionDB.getSqlConnection())
			{
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = cn;

				// create query
				cmd.Parameters.AddWithValue("@genre_id", Genre_Id);
				cmd.CommandText = "SELECT id_movie, title, qualification, date, description FROM movies WHERE genre_id = @genre_id";
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


		// search movies
		public DataTable search_movies(string value)
		{
			SqlDataReader reader;
			DataTable table = new DataTable();

			using (SqlConnection cn = ConnectionDB.getSqlConnection())
			{
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = cn;

				// create query
				cmd.CommandText = "SELECT id_movie, title, qualification, date, description FROM movies WHERE title LIKE '%" + value + "%'";
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


		// save movie
		public void Save_Movie()
		{
			using (SqlConnection cn = ConnectionDB.getSqlConnection())
			{
				try
				{
					SqlCommand cmd = new SqlCommand();
					cmd.Connection = cn;

					// initialized variables
					cmd = new SqlCommand("INSERT INTO movies VALUES(@genre_id, @title, @qualification, @date, @description, @premiere, @image)", cn);
					cmd.Parameters.Add("@genre_id", SqlDbType.Int);
					cmd.Parameters.Add("@title", SqlDbType.NVarChar);
					cmd.Parameters.Add("@qualification", SqlDbType.Decimal);
					cmd.Parameters.Add("@date", SqlDbType.Date);
					cmd.Parameters.Add("@description", SqlDbType.Text);
					cmd.Parameters.Add("@premiere", SqlDbType.Char);
					cmd.Parameters.Add("@image", SqlDbType.Image);

					// declared variables
					cmd.Parameters["@genre_id"].Value = Genre_Id;
					cmd.Parameters["@title"].Value = Title;
					cmd.Parameters["@qualification"].Value = Qualification;
					cmd.Parameters["@date"].Value = Date;
					cmd.Parameters["@description"].Value = Description;
					cmd.Parameters["@premiere"].Value = Premiere;

					// convert image
					System.IO.MemoryStream ms = new System.IO.MemoryStream();
					Picture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
					cmd.Parameters["@image"].Value = ms.GetBuffer();

					cmd.ExecuteNonQuery();
					MessageBox.Show("Película registrada correctamente");
				}
				catch(Exception ex)
				{
					MessageBox.Show("Ha ocurrido un error" + ex.ToString());
				}
			}
		}

		// update movie
		public void update_movie()
		{
			
			using (SqlConnection cn = ConnectionDB.getSqlConnection())
			{
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = cn;

				//create parameters
				cmd.Parameters.AddWithValue("@id_movie", Id_Movie);
				cmd.Parameters.AddWithValue("@genre_id", Genre_Id);
				cmd.Parameters.AddWithValue("@title", Title);
				cmd.Parameters.AddWithValue("@qualification", Qualification);
				cmd.Parameters.AddWithValue("@date", Date);
				cmd.Parameters.AddWithValue("@description", Description);
				cmd.Parameters.AddWithValue("@premiere", Premiere);

				// create query
				cmd.CommandText = "UPDATE movies SET genre_id = @genre_id, title = @title, qualification = @qualification, date = @date, description = @description, premiere = @premiere WHERE id_movie = @id_movie";
				cmd.CommandType = CommandType.Text;

				var update = cmd.ExecuteNonQuery();

				if(update > 0)
				{
					MessageBox.Show("Pelicula Actualizada Correctamente");
				}
				else
				{
					MessageBox.Show("Error al actualizar pelicula");
				}

			}
		}
	}
}
