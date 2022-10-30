using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1MIDDEMO1 {
    public partial class Q2 : System.Web.UI.Page {
        string[] s_City = new string[2] { "台北市", "新北市" };
        string[,] s_Area = new string[2, 3] {
            {"中正區", "文山區", "大安區"},
            {"淡水區", "石碇區", "土城區"}
        };

        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack)
            {
                for (int i_x = 0; i_x < s_City.Length; i_x++)
                {
                    ListItem l_t = new ListItem();
                    l_t.Text = l_t.Value = s_City[i_x];

                    dpl_City.Items.Add(l_t);
                }
                set_City();
            }
        }

        protected void dpl_City_TextChanged(object sender, EventArgs e)
        {
            set_City();
        }
        
        void set_City()
        {
            dpl_Area.Items.Clear();
            int C_idx = dpl_City.SelectedIndex;
            for (int i_y = 0; i_y < s_Area.GetLength(1); i_y ++)
            {
                ListItem l_t = new ListItem();
                l_t.Text = l_t.Value = s_Area[C_idx, i_y];

                dpl_Area.Items.Add(l_t);
            }
        }
    }
}