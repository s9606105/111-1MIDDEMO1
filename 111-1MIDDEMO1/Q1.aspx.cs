using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1MIDDEMO1 {
    public partial class Q1 : System.Web.UI.Page {
        string[] s_IdSet = new string[3] { "A123456789", "P123456789", "YD321" };

        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void tb_Account_TextChanged(object sender, EventArgs e)
        {
            string check_text = tb_Account.Text;
            int index = Array.IndexOf(s_IdSet, check_text); // 檢視是否於陣列中
            if (index >= 0) lb_Type.Text = "複診";
            else lb_Type.Text = "初診";
            if (check_text != "") btn_Submit.Visible = true;
            else btn_Submit.Visible = false;

            pl_Msg.Visible = false; // 當用戶重新填入不顯示
        }

        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            pl_Msg.Visible = true;
            lb_Msg.Text = 
                lb_Type.Text + "<br />" +
                tb_Account.Text + "先生小姐，已完成掛號。" + "<br />";
            if (tb_Email.Text != "") 
               lb_Msg.Text += "已寄信至信箱" + tb_Email.Text + "<br />";
        }
    }
}