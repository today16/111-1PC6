using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1PC6
{
    public partial class Test : System.Web.UI.Page
    {
        string [] Str_school = new string[] {"台科","北科","亞東"};
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Str_school.Length; i++)
            {
                ListItem li_item = new ListItem();
                li_item.Text = Str_school[i];
                li_item.Value = Str_school[i];
                ddl_Test.Items.Add(li_item);
            }
        }
    }
}