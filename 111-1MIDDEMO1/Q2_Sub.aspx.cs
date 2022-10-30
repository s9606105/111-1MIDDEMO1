using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1MIDDEMO1 {
    public partial class Q2_Sub : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            lb_Msg.Text =
            "保單號碼: " + Request.Form.Get("tb_Num") + "<br />" +
            "通訊種類: " + Request.Form.Get("rbl_Phone") + "<br />" +
            "通訊號碼: " + Request.Form.Get("txt_Phone") + "<br />" +
            "所在城市: " + Request.Form.Get("dpl_City") + "<br />" +
            "所在區域: " + Request.Form.Get("dpl_Area");

            //Response.Write(Request.Form.ToString()); // 將所有接收資料傳送過來
            //string[] sa_Tmp = Request.Form.AllKeys;

            //for (int i_x = 0; i_x < sa_Tmp.Length; i_x++)
            //{
            //    Response.Write("<br />");
            //    Response.Write(sa_Tmp[i_x] + "<br />");
            //}
        }
    }
}