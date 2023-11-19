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
        private static readonly string conn_string = @"Data source = ..\..\..\..\..\..\..\db\music.db;";
        public bool AddMusic(Music music)
        {
            MessageBox.Show("Dao1");
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

            MessageBox.Show("Dao2");

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return false;
            }
            conn.Close();
            MessageBox.Show("Dao3");
            return true;
        }

        public Music GetMusic(string title)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Music> GetMusic()
        {
            throw new NotImplementedException();
        }

        public bool ModifyMusic(Music music)
        {
            throw new NotImplementedException();
        }
    }
}
