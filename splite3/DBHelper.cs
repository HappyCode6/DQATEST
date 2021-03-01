using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlite3 
{
    class DBHelper
    {
        public DBHelper()
        {
            
        }
        public void TestDB()
        {
            var path = Environment.CurrentDirectory;
            var fileName = path + "\\testDB.db";
            string databaseFileName = fileName;
            string connectionString = "data source = " + databaseFileName;

            //Sqlite使用事务批量操作 极大的提高速度
            DateTime starttime = DateTime.Now;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString, true))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    sh.BeginTransaction();

                    try
                    {
                        // INSERT.....
                        // INSERT.....
                        // UPDATE....
                        // ... skip for another 50,000 queries....
                        // DELETE....
                        // UPDATE...
                        // INSERT.....
                        // do something...
                        #region Select 
                        //var dic = new Dictionary<string, object>();
                        //dic["@aaa"] = "PM1825H10054030";
                        //DataTable dt = sh.Select("select * from SN where sn = @aaa", dic);

                        //string strName = string.Empty;
                        //for (int i = 0; i < dt.Rows.Count; i++)
                        //{
                        //    strName = dt.Rows[i]["sn"].ToString();
                        //    Control.LogHelper.WriteLog(strName);
                        //}
                        //sh.Commit();//提交事务  
                        //DateTime endtime = DateTime.Now;
                        //MessageBox.Show("Select成功，用时" + (endtime - starttime).TotalMilliseconds + strName);

                        #endregion

                        #region Insert 
                        //sn Table
                        //var dic = new Dictionary<string, object>();

                        //for (int i = 0; i < 100000; i++)
                        //{
                        //    dic["sn"] = "PM1825H10" + string.Format("{0:d6}", i);
                        //    dic["time"] = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        //    sh.Insert("SN", dic);
                        //}
                        //sh.Commit();//提交事务  
                        //DateTime endtime = DateTime.Now;
                        //MessageBox.Show("插入成功，用时" + (endtime - starttime).TotalMilliseconds);

                        //Edition Table
                        //var dic = new Dictionary<string, object>();

                        //for (int i = 0; i < 2; i++)
                        //{
                        //    dic["editionID"] = i;
                        //    dic["editionDesc"] = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        //    sh.Insert("Edition", dic);
                        //}
                        //sh.Commit();//提交事务  
                        //DateTime endtime = DateTime.Now;
                        //MessageBox.Show("插入成功，用时" + (endtime - starttime).TotalMilliseconds);
                        #endregion
                    }
                    catch
                    {
                        sh.Rollback();
                    }


                    conn.Close();
                }
            }

        }
    }
}
