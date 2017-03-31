using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
//using System.Tripmvc.Models;

namespace Tripmvc.Models
{
    public class Registration
    {
        static void Main(string args[])
        { Console.Write("Successfull Registration!!"); }
        
    }
    protected string register-form(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@  "Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd = new SqlCommand("sp_insert", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("name", TextBox.name);
        cmd.Parameters.AddWithValue("familyid", TextBox.familyid);
        cmd.Parameters.AddWithValue("emailid",TextBox.emailid);
        cmd.Parameters.AddWithValue("gender", RadioButton.gender);
        cmd.Parameters.AddWithValue("age", DropDownList.age);
        cmd.Parameters.AddWithValue("password", TextBox.password);
        cmd.Parameters.AddWithValue("confpassword", TextBox.confpassword);
        con.Open();
        int i = cmd.ExecuteNonQuery();
        con.Close();
    }
}



