using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feb27_2024_csharp_review
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region   #-1
            // todo #-1  執行此 App 暗黃色按鈕 會去執行的程式碼 已寫好如下
            #endregion
            MessageBox.Show("msit c sharp 複習 #0 " );
            System.Data.SqlClient.SqlConnection conn = null;
            try
            {
                #region  todo #0
                // todo #0 產生 System.Data.SqlClient 命名空間下的 SqlConnection 類別的物件
                //  並將此 產生的物件的參考存到上行宣告的 conn 變數
                #endregion



                conn.ConnectionString = "server=.;initial catalog=northwind;integrated security=true";
                #region    #1
                // todo #1 以上面產生的 SqlConnection 類別的物件
                //    來呼叫執行個體方法 Open 此方法沒設計引數(或稱呼為參數)
                #endregion
                
                System.Data.SqlClient.SqlCommand sqlCmd = null;
                #region  #2
                // todo #2 以上面產生的 SqlConnection 類別的物件
                //    來呼叫執行個體方法 CreateCommand 此方法沒設計引數(或稱呼為參數)
                //    並將呼叫 此方法的傳回值 存到上行宣告的 sqlCmd 變數
                #endregion
                conn.Open();

                #region   #5 
                // todo #5 執行此 App 去按黃色按鈕 看會如何?
                #endregion
                #region   #6 
                // todo #6
                //  將下行 select  top 3 * from products 改成 select  top 3 * from product
                //  再執行此 App 去按黃色按鈕 看會如何?
                #endregion
                sqlCmd.CommandText = "select  top 3 * from products";
                System.Data.SqlClient.SqlDataReader sdr =  sqlCmd.ExecuteReader();
                #region  #3 以上面產生的 SqlDataReader 類別的物件
                //    todo #3 來呼叫執行個體方法 Read 此方法沒設計引數(或稱呼為參數)
                //    並以呼叫 此方法 當作 while 迴圈的條件
                #endregion
                sdr.Read();
                #region   #4  
                // todo #4  觀察 while 迴圈的重複動作的 { } 區段已寫好如下五行
                #endregion
                {
                    string pn = $"{sdr["ProductName"]}".PadRight(50);
                    pn = pn + $" {sdr["unitPrice"]:c2}".PadLeft(20);
                    listBoxInTabCreateObjects.Items.Add( pn  );
                }// end of while
            }
            catch ( Exception exp)
            {
                MessageBox.Show("msit exception: " + exp.Message);
            }
            finally
            {
                #region   #7 
                // todo #7
                //  觀察下行 conn != null && conn.State == ConnectionState.Open
                #endregion
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    try
                    {
                        conn.Close();
                    }
                    catch (Exception deepExp)
                    {

                        MessageBox.Show(" conn.Close() exception: " + deepExp.Message);
                    }
                }// end of if
            }// end of finally


        }
    }
}
