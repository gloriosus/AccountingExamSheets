using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AccountingExamSheets
{
    class DBConnection
    {
        private OleDbConnection OleCon;
        private OleDbCommand OleCommand;

        public DBConnection()
        {
            OleCon = new OleDbConnection();
            OleCon.ConnectionString = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\Resources\database.accdb";
            OleCommand = new OleDbCommand();
            OleCommand.Connection = OleCon;
        }


        //Метод Query и его перегрузка предназначены для обработки запроса SELECT с возвращением массива значений
        public List<string> Query(string query)
        {
            List<string> records = new List<string>();

            OleCon.Open();
            OleCommand.CommandText = query;
            OleDbDataReader Reader = OleCommand.ExecuteReader();

            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    records.Add(Reader[0].ToString());
                }
            }

            OleCon.Close();

            return records;
        }

        public List<string> Query(string query, int from, int to)
        {
            List<string> records = new List<string>();

            OleCon.Open();
            OleCommand.CommandText = query;
            OleDbDataReader Reader = OleCommand.ExecuteReader();

            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    string line = "";

                    for (int i = from; i <= to; i++)
                    {
                        if (i == 0)
                        {
                            line = Reader[i].ToString();
                        }
                        else
                        {
                            line = line + " " + Reader[i].ToString();
                        }
                    }

                    records.Add(line);
                }
            }

            OleCon.Close();

            return records;
        }

        public string[,] ExtraQuery(string query)
        {
            int rows = Length(query);

            OleCon.Open();
            OleCommand.CommandText = query;
            OleDbDataReader Reader = OleCommand.ExecuteReader();

            int columns = Reader.FieldCount;
            string[,] records = new string[rows, columns];

            if (Reader.HasRows)
            {
                for (int i = 0; i < rows; i++)
                {
                    Reader.Read();

                    for (int v = 0; v < columns; v++)
                    {
                        records[i, v] = Reader[v].ToString();
                    }
                }
            }

            OleCon.Close();

            return records;
        }


        //Метод ActionQuery предназначен для обработка запросов INSERT, DELETE, UPDATE
        public int ActionQuery(string query)
        {
            OleCon.Open();
            OleCommand.CommandText = query;
            OleCommand.ExecuteNonQuery();
            OleCommand.CommandText = "SELECT @@IDENTITY";
            int result = (int)OleCommand.ExecuteScalar();
            OleCon.Close();
            return result;
        }


        //Подсчет количества записей в таблице по запросу
        private int Length(string query)
        {
            OleCon.Open();
            OleCommand.CommandText = query;
            OleDbDataReader Reader = OleCommand.ExecuteReader();

            int count = 0;

            while (Reader.Read())
            {
                count++;
            }

            OleCon.Close();

            return count;
        }
    }
}
