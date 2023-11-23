using FWMDR8.Entity;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FWMDR8.Dao
{
    public class MusicDao : IMusicDao
    {
        private static readonly string conn_string = @"Data source = C:\Users\lszen\source\repos\FWMDR8\FWMDR8\db\music.db;";
        public bool AddMusic(Music music)
        {
            using SqliteConnection conn = new SqliteConnection(conn_string);
            conn.Open();
            SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO music " +
                "(title, performer, release_date, music_length, priority) VALUES " +
                "(@title, @performer, @release_date, @music_length, @priority);";

            cmd.Parameters.Add("title", (SqliteType)System.Data.DbType.String).Value = music.title;
            cmd.Parameters.Add("performer", (SqliteType)System.Data.DbType.String).Value = music.performer;
            cmd.Parameters.Add("release_date", (SqliteType)System.Data.DbType.Int32).Value = music.release_date;
            cmd.Parameters.Add("music_length", (SqliteType)System.Data.DbType.Int32).Value = music.music_length;
            cmd.Parameters.Add("priority", (SqliteType)System.Data.DbType.Int32).Value = music.priority;


            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return false;
            }
            conn.Close();
            return true;
        }

        public Music GetMusic(string title)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Music> GetMusic()
        {
            List<Music> music = new List<Music>();
            using SqliteConnection conn = new SqliteConnection(conn_string);
            conn.Open();
            SqliteCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM music";

            using SqliteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                music.Add(
                    new Music
                    {
                        ID = reader.GetInt32(reader.GetOrdinal("ID")),
                        title = reader.GetString(reader.GetOrdinal("Title")),
                        performer = reader.GetString(reader.GetOrdinal("Performer")),
                        release_date = reader.GetInt32(reader.GetOrdinal("Release_date")),
                        music_length = reader.GetInt32(reader.GetOrdinal("Music_length")),
                        priority = reader.GetInt32(reader.GetOrdinal("Priority"))
                    }
                );
            }

            music.Sort((p1, p2) => p1.priority.CompareTo(p2.priority));
            return music;
        }

        public bool ModifyMusic(Music music)
        {
            throw new NotImplementedException();
        }
    }
}
