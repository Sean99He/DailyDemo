using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForUpload
{
    public partial class UpLoad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach(string f in Request.Files.AllKeys)
            {
                HttpPostedFile file = Request.Files[f];
                file.SaveAs(@"g:\" + file.FileName);
            }
        }
    }
}