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
        internal static List<Film> GetFilms()
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
                            List<Film> films = new List<Film>();
                            while(rdr.Read())//Отправляет CommandText в Connection и строит SqlDataReader.
                            {
                                films.Add(new Film
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

      
    }
}
