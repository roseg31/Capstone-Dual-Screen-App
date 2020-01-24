﻿using System;
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
        public static List<WindowInfo> LoadWindow(string load_win_config_name)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string query_window_config = "select * from " + load_win_config_name;
                var output = cnn.Query<WindowInfo>(query_window_config, new DynamicParameters());
                return output.ToList();
            }
        }

        // Query the database for the table names, each table will be the name of the custome window configuration
        public static List<string> LoadTable()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<string>("SELECT name FROM sqlite_master where type='table'", new DynamicParameters());
                return output.ToList();
            }
        }



        // Create a table for a window configuration name defined by the user
        public static void CreateWindowTable(string window_config_name)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                window_config_name = "'" + window_config_name + "'";
                string create_table =
                "CREATE TABLE" + window_config_name +
                "('ID'    INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE," +
                "'Process_ID'   INTEGER," +
                "'Process_Title' TEXT," +
                "'Process_Name'  TEXT NOT NULL," +
                "'Left'  INTEGER," +
                "'Right' INTEGER," +
                "'Top'  INTEGER," +
                "'Bottom'    INTEGER," +
                "'Width' INTEGER," +
                "'Height'    INTEGER)";

                cnn.Execute(create_table);
            }

        }


        // Insert window handler information into the DB
        public static void SaveWindow(WindowInfo window, string window_config_name)
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

                string Sql_Insert = "insert into " + window_config_name + "(Process_ID, Process_Title, Process_Name, Left, Right, Top, Bottom, Width, Height) values (" + process_id + ", " +process_title + ", "+process_name+"," +left+ ", " + right + ", " + top + ", " + bottom + ", " + width + ", " + height + ")";
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
