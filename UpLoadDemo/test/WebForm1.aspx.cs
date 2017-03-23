using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpLoadDemo.test
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var a = Server.MapPath("");
            var b = Server.MapPath(@".\");
            var c = Server.MapPath(@"..\");
            var d= Server.MapPath(@"~\");
        }
    }
}