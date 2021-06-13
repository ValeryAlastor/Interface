using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Interface.DAL
{
    class SQLiteHelper
    {
        internal static List<Films> GetFilms()
        {
            try
            {//юзинг необходим, чтобы при выходе из конструкции включился мдот despose() который закроет все соединения
                using (var connection = new SQLiteConnection(@"Data Source = db.sqlite;Vesion=3;"))//получили соединение
                {
                    connection.Open();//открыли соединение
               
                    using (var cmd = new SQLiteCommand(@"SELECT DISTINCT title, description, date_created, age, time, country, Name_A, Name_C, Name_D, Name_G
                                                        FROM films, actors, composers, directors, genres
                                                        WHERE films.id_actors = actors.id_actors
                                                        AND films.id_composer = composers.id_composer
                                                        AND films.id_director = directors.id_director
                                                        AND films.id_genre = genres.id_genre", connection))//получить команду
  
                    {
                       
                        using (var rdr = cmd.ExecuteReader())
                        {
                            List<Films> films = new List<Films>();
                            while (rdr.Read())//Отправляет CommandText в Connection и строит SqlDataReader.
                            {
                                films.Add(new Films
                                {
                                    title = rdr.GetString(0),
                                    Description = rdr.GetString(1),
                                    Date = rdr.GetDateTime(2),
                                    Age = rdr.GetString(3),
                                    Time = rdr.GetInt32(4),
                                    Country = rdr.GetString(5),
                                    Actor = rdr.GetString(6),
                                    Composer = rdr.GetString(7),
                                    Director = rdr.GetString(8),
                                    Genre = rdr.GetString(9)
                                });
                            }
                            return films;

                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            return null;
        }
        internal static List<Genres> GetGenre()
        {
            try
            {//юзинг необходим, чтобы при выходе из конструкции включился мдот despose() который закроет все соединения
                using (var connection = new SQLiteConnection(@"Data Source = db.sqlite;Vesion=3;"))//получили соединение
                {
                    connection.Open();//открыли соединение

                    using (var cmd = new SQLiteCommand(@"SELECT  Name_G FROM genres ", connection))//получить команду
                    {
                        using (var rdr = cmd.ExecuteReader())
                        {
                            List<Genres> genres = new List<Genres>();
                            while (rdr.Read())//Отправляет CommandText в Connection и строит SqlDataReader.
                            {
                                genres.Add(new Genres
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
