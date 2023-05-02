using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MobileShop2023.BL
{
    class ALLPrograms
    {
        //  عدم التكرار في اسم كود الصنف
        public DataTable Prevent_CodeCatg(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();

            // نصيف البارامتر الخاص بالتحقق
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 30);
            param[0].Value = ID;

            Dt = DAL.SelectData("Prevent_CodeCatg", param);
            DAL.Close();
            return Dt;
        }

       

        //  دالة لجلب صورة المنتج
        public DataTable GET_IMAGE(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            // هنا عملية الإجراء المخزن - طبعا لا تنسى عمله في سيكول
            Dt = DAL.SelectData("GET_IMAGE", param);
            DAL.Close();
            return Dt;
        }
    
      
        // عرض أسماء المستودعات
        public DataTable WarehouseName()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("WarehouseName", null);
            DAL.Close();
            return Dt;
        }

        // عرض أسماء الوحدات
        public DataTable UnitName()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("UnitName", null);
            DAL.Close();
            return Dt;
        }

        // عرض أسماء مواقع التخزين
        public DataTable StorageLccations()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("StorageLccations", null);
            DAL.Close();
            return Dt;
        }

        public DataTable Get_Last_Sale()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_Last_Sale", null);
            DAL.Close();
            return Dt;
        }

        public DataTable Sale_Ddetails(int Invoice)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Invoice", SqlDbType.Int);
            param[0].Value = Invoice;

            Dt = DAL.SelectData("Sale_Ddetails", param);
            DAL.Close();
            return Dt;
        }

    }
}
