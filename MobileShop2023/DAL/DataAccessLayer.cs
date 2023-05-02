using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MobileShop2023.DAL
{
    class DataAccessLayer
    {
        // إنشاء كائن إتصال
        SqlConnection sqlconnection;
        public DataAccessLayer()
        {
            // نص ذاتي
            //sqlconnection = new SqlConnection(@"Data Source=.\SQLEXPRESS; AttachDbFilename=|DataDirectory|\Professional_Sales.mdf;Integrated Security=True;User Instance=True");

            // لاتنسى نص الاتصل الأول لابد أن يكون بالأسود
            sqlconnection = new SqlConnection(@"Data Source =" + Properties.Settings.Default.SERVERNAME + " ;Initial Catalog = " + Properties.Settings.Default.DATABASENAME + " ;Integrated Security = False; USER ID =" + Properties.Settings.Default.DATABASESUSERNAME + " ; Password = " + Properties.Settings.Default.DATABASEPASSWORD + "");

        }

        // إجراء فتح الإتصال //
        public void open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }
        //  إجراء إغلاق الإتصال //
        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }
        // قراءة البيانات من قاعدة البيانات

        public DataTable SelectData(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            // هنا يتم استدعاء كلمة المرور واسم المستخدم
            sqlcmd.Connection = sqlconnection;
            // إنشاء الإجراء المخزن
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;

            // التحقق من البارامترات وهي (الاسم وكلمة المرور) فقط على سبيل المثال
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {

                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            // قراءة البيانات

            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // عملية الإدخال والحذف والتحديث من قاعدة البيانات
        public void ExecuteCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;

            if (param != null)
            {

                // هذه الدالة أفضل من دلة لوب السابقة وتختصر وجميعها تؤدي نفس الغرض
                sqlcmd.Parameters.AddRange(param);
            }
            sqlcmd.Connection = sqlconnection;

            sqlcmd.ExecuteNonQuery();
        }
    }
}
