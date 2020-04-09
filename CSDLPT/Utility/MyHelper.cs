using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace QLDSV.Utility
{
   public class MyHelper
   {
      public const string DatabaseName = "QLDSV";
      public static string RootServerName = Environment.MachineName;
      public static CultureInfo CiVNI = new CultureInfo("vi-VN", false);

      public const string RemoteLogin = "HTKN";
      public const string RemotePassword = "123456";
      public static string ConnectionString = null;
      public static string ServerName = null;
      public static string UserName = null; // Mã
      public static string CurrentLogin = null;
      public static string CurrentPassword = null;

      public static string BackupLogin = null;
      public static string BackupPassword = null;
      public static string CurrentGroup = null;
      public static string CurrentFullName = null;
      public static int CurrentDeployment = 0;

      public static BindingSource BdsDSPM = new BindingSource();  // giữ bdsPM khi đăng nhập

      public static DataTable ExecSqlDataTable(string cmdText, string connectionString)
      {
         DataTable dt = new DataTable();
         using (SqlConnection connection = new SqlConnection(connectionString))
         {
            try
            {
               connection.Open();
               SqlDataAdapter da = new SqlDataAdapter(cmdText, connection);
               da.Fill(dt);
            }
            catch (Exception ex)
            {
               ShowError(ex);
               dt = null;
            }
         }
         return dt;
      }

      /// <summary>
      /// Kiểm tra kết nối dùng username và password người dùng nhập
      /// </summary>
      /// <returns></returns>
      public static bool Connect()
      {
         try
         {
            MyHelper.ConnectionString = $"Data Source={MyHelper.ServerName};" +
                                $"Initial Catalog={MyHelper.DatabaseName};" +
                                $"User ID={MyHelper.CurrentLogin};" +
                                $"password={MyHelper.CurrentPassword}";
            using (SqlConnection connection = new SqlConnection(MyHelper.ConnectionString))
            {
               connection.Open();
            }
            return true;
         }
         catch (Exception ex)
         {
            XtraMessageBox.Show("Lỗi đăng nhập. Vui lòng kiểm tra lại.\n" + ex.Message);
         }

         return false;
      }

      public static void ShowError(Exception e)
      {
         //if (e is SqlException)
         //{
         //   Console.WriteLine("MsgNumber: {0}", ((SqlException)e).Number.ToString());
         //   Console.WriteLine((e as SqlException).Message);
         //}
         string message = e.Message + "\n";
         string source = "Source: " + e.Source + "\n";
         string targetSite = "Method: " + e.TargetSite + "\n";
         XtraMessageBox.Show(source + targetSite + message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
         Console.WriteLine(e.StackTrace);
      }

      public static DialogResult ShowErrorMsgBox(string text, MessageBoxButtons buttons = MessageBoxButtons.OK)
      {
         return XtraMessageBox.Show(text, "ERROR", buttons, MessageBoxIcon.Error);
      }

      public static DialogResult ShowWarningMsgBox(string text, MessageBoxButtons buttons = MessageBoxButtons.OK)
      {
         return XtraMessageBox.Show(text, "WARNING", buttons, MessageBoxIcon.Warning);
      }

      public static DialogResult ShowQuestionMsgBox(string text, MessageBoxButtons buttons = MessageBoxButtons.YesNo)
      {
         return XtraMessageBox.Show(text, "QUESTION", buttons, MessageBoxIcon.Question);
      }
   }
}
