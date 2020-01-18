using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;


// Followed this tutorial on setting up the DB: https://www.youtube.com/watch?v=ayp3tHEkRc0

namespace WindowConfiguration
{
    public class SqLiteDataAccess
    {

        // Query the database and return all tuples
        public static List<WindowInfo> LoadWindow()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<WindowInfo>("select * from WindowHandler", new DynamicParameters());
                return output.ToList();
            }
        }


        // Insert window handler information into the DB
        public static void SaveWindow(WindowInfo window)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                int process_id = window.Process_ID;
                string process_title = "'" + window.Process_Title + "'";
                string process_name = "'" + window.Process_Name + "'";
                int left = window.Left;
                int right = window.Right;
                int top = window.Top;
                int bottom = window.Bottom;
                int width = window.Width;
                int height = window.Height;

                string Sql_Insert = "insert into WindowHandler (Process_ID, Process_Title, Process_Name, Left, Right, Top, Bottom, Width, Height) values (" + process_id + ", " +process_title + ", "+process_name+"," +left+ ", " + right + ", " + top + ", " + bottom + ", " + width + ", " + height + ")";
                //cnn.Execute("insert into WindowHandler (Process_Name, Left, Right, Top, Bottom, Width, Height) values (@Process_Name, @Left, @Right, @Top, @Bottom, @Width, @Height)", window);
                cnn.Execute(Sql_Insert, window);
            }
        }


        // Used to connect to the DB
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
