using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.DAL
{
    class SQLiteHelper
    {
        internal static List<Films> GetFilms()
        {
            try
            {//юзинг необходим, чтобы при выходе из конструкции включился мдот despose() который закроет все соединения
                using(var connection = new SQLiteConnection(@"Data Source = db.sqlite;Vesion=3;"))//получили соединение
                {
                    connection.Open();//открыли соединение

                    using(var cmd = new SQLiteCommand(@"SELECT id_film,
                                                               title,
                                                               description,
                                                               date_created,
                                                               age,
                                                               time,
                                                               country
                                                              FROM films  ", connection))//получить команду
                    {
                        using(var rdr = cmd.ExecuteReader())
                        {
                            List<Films> films = new List<Films>();
                            while(rdr.Read())//Отправляет CommandText в Connection и строит SqlDataReader.
                            {
                                films.Add(new Films
                                {
                                    Id = rdr.GetInt32(0),
                                    Title = rdr.GetString(1),
                                    Description = rdr.GetString(2),
                                    Date = rdr.GetDateTime(3),
                                    Age = rdr.GetInt32(4),
                                    Time = rdr.GetInt32(5),
                                    Country = rdr.GetString(6)
                                });
                            }
                            return films;
                        }
                    }
                }
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }

            return null;
        }
        internal static List<Genres> GetGenre()
        {
            try
            {//юзинг необходим, чтобы при выходе из конструкции включился мдот despose() который закроет все соединения
                using (var connection = new SQLiteConnection(@"Data Source = db.sqlite;Vesion=3;"))//получили соединение
                {
                    connection.Open();//открыли соединение

                    using (var cmd = new SQLiteCommand(@"SELECT Name FROM genre  ", connection))//получить команду
                    {
                        using (var rdr = cmd.ExecuteReader())
                        {
                            List<Genres> genres = new List<Genres>();
                            while (rdr.Read())//Отправляет CommandText в Connection и строит SqlDataReader.
                            {
                                genres.Add( new Genres
                                {
                                    Name = rdr.GetString(0)
                                });
                            }
                            return genres;
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            return null;
        }


    }
}
