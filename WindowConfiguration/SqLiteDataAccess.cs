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
        public static List<windowconfig.WindowInfo> LoadWindow(string load_win_config_name)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                if (load_win_config_name.Contains(" "))
                {
                    load_win_config_name = "[" + load_win_config_name + "]";
                }
                string query_window_config = "select * from " + load_win_config_name;
                var output = cnn.Query<windowconfig.WindowInfo>(query_window_config, new DynamicParameters());
                return output.ToList();
            }
        }

        public static bool check_table_exists(string config_name)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                config_name = "'" + config_name + "'";
                string query_config_info = "select * from Table_Description where Name=" + config_name;
                var output = cnn.Query<string>(query_config_info, new DynamicParameters());
                output.ToList();
                return output.Count() != 0;
            }
        }

        // Query the database for custom configuration information
        public static List<windowconfig.Config_Info> LoadConfigInfo()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string query_config_info = "select * from Table_Description;";
                var output = cnn.Query<windowconfig.Config_Info>(query_config_info, new DynamicParameters());
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

        // Remove a configuration and its associated data from the database
        public static void RemoveConfigData(string config_name)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                config_name = "'" + config_name + "'";
                var output = cnn.Query<string>("DELETE FROM Table_Description where Name=" + config_name, new DynamicParameters());
                output = cnn.Query<string>("DROP TABLE " + config_name, new DynamicParameters());
            }
        }

        // Add information about a custom config to the config_description table
        public static void AddConfigInfo(new_config.Config_Info cfg_info)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string name = "'" + cfg_info.Name + "'";
                string description = "'" + cfg_info.Description + "'";
                int num_apps = cfg_info.Num_apps;

                string Sql_Insert = "insert into Table_Description (Name, Num_apps, Description) values (" + name + ", " + num_apps + ", " + description + ")";
                cnn.Execute(Sql_Insert, cfg_info);
            }
        }



        // Create a table for a window configuration name defined by the user
        public static void CreateConfigTable(string window_config_name)
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
                "'Exe_Path' TEXT," +
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
        public static void SaveWindow(new_config.WindowInfo window, string window_config_name)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                int process_id = window.Process_ID;
                string process_title = "'" + window.Process_Title + "'";
                string process_name = "'" + window.Process_Name + "'";
                string exe_path = "'" + window.Exe_Path + "'";
                int left = window.Left;
                int right = window.Right;
                int top = window.Top;
                int bottom = window.Bottom;
                int width = window.Width;
                int height = window.Height;

                if(window_config_name.Contains(" "))
                {
                    window_config_name = "[" + window_config_name + "]";
                }

                string Sql_Insert = "insert into " + window_config_name + "(Process_ID, Process_Title, Process_Name, Exe_Path, Left, Right, Top, Bottom, Width, Height) values (" + process_id + ", " +process_title + ", "+process_name+","+exe_path+"," +left+ ", " + right + ", " + top + ", " + bottom + ", " + width + ", " + height + ")";
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
