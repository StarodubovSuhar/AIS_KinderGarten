using db_project;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace КП
{
    class GetReportDay
    {
        private readonly string FileName = Directory.GetCurrentDirectory() + @"\Resources\ReportDay.docx";

        public void getWord(string date, string group)
        {

            string newdate = "";
            string[] date1 = date.Split('.');
            string temp = date1[0];
            
            date1[0] = date1[2];
            date1[2] = temp;

            for (int i = 0; i < date1.Length; i++)
            {
                if (i == date1.Length - 1)
                {
                    newdate += date1[i];
                    break;
                }

                newdate += date1[i] + "-";
            }


            db_connect conn = new db_connect();
            conn.openConnection();

            string sql = "SELECT * FROM attendance WHERE groups LIKE " + "'" + group + "'" + " AND date = " + "'" + newdate + "'";
            string sql1 = "SELECT * FROM staff WHERE job_title LIKE 'Заведующий'";
            string sql2 = "SELECT * FROM staff WHERE fixed_group LIKE " + "'" + group + "'" + " AND job_title LIKE 'Воспитатель'";
            string FIO2 = "", FIO3 = "";

            MySqlCommand command = new MySqlCommand(sql, conn.GetConnection());
            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
            }

            reader.Close();

            MySqlCommand command2 = new MySqlCommand(sql1, conn.GetConnection());
            MySqlDataReader reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {
                FIO3 = reader2[1].ToString() + " " + reader2[2].ToString() + " " + reader2[3].ToString(); 
            }

            reader2.Close();

            MySqlCommand command3 = new MySqlCommand(sql2, conn.GetConnection());
            MySqlDataReader reader3 = command3.ExecuteReader();

            while (reader3.Read())
            {
                FIO2 = reader3[1].ToString() + " " + reader3[2].ToString() + " " + reader3[3].ToString();
            }

            reader3.Close();

            conn.closeConnection();

            #region Word

            var wordApp = new Word.Application();
            wordApp.Visible = false;
            var wordd = wordApp.Documents.Open(FileName);
            
            ReplaceWordStub("{DATE}", date, wordd);
            ReplaceWordStub("{GROUP}", group, wordd);

            foreach (string[] s in data)
            {
                wordd.Bookmarks["stroka"].Range.Text = s[1]+ " " + s[2] + " " + s[3] + " " + s[5] + " "+ s[4] + "\n";
            }

            ReplaceWordStub("{FIO2}", FIO2, wordd);
            ReplaceWordStub("{FIO3}", FIO3, wordd);

            wordApp.Visible = true;
            //wordd.Save();
            #endregion
        }
        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);

        }
    }
}
