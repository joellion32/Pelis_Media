using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Pelis_Media.Config;
using System.Data;


namespace Pelis_Media.Models
{
	class GenreModel
	{
		public int id_genre;
		public string genre;

		// getters and setters

		public int Id_Genre
		{
			get { return id_genre; }
			set { this.id_genre = value; }
		}


		public string Genre
		{
			get { return genre; }
			set { this.genre = value; }
		}

		/**************************************FUNCTIONS**********************************/


		// get genres listed
		public List<GenreModel> get_genres()
		{
			List<GenreModel> list = new List<GenreModel>();
			SqlDataReader reader;
			using (SqlConnection cn = ConnectionDB.getSqlConnection())
			{
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = cn;

				// create query
				cmd.CommandText = "SELECT * FROM genres";
				cmd.CommandType = CommandType.Text;
				reader = cmd.ExecuteReader();

				if (reader.HasRows)
				{
					while (reader.Read())
					{
						GenreModel genre = new GenreModel();
						genre.Id_Genre = reader.GetInt32(0);
						genre.Genre = reader.GetString(1);
						list.Add(genre);
					}

					cn.Close();
				}

				// return data
				return list;
			}
		}

	}
}
