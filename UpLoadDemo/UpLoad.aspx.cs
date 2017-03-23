using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpLoadDemo
{
    public partial class UpLoad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string fileName = "公共免仓期内测试.docx";
            if (FileUpload1.HasFile)
            {
                string fileNameUpload = FileUpload1.FileName;
                if (fileName == fileNameUpload)
                {

                    var a = Server.MapPath("");
                    var b = Server.MapPath(@"./");
                    var c = Server.MapPath(@"~/");
                    string path = Server.MapPath(@"~\UpFiles\ServiceRoute\pdf\" + fileName);
                    FileUpload1.SaveAs(path);
                }                    
                else
                    Response.Write("<script>alert('文件名称有误');</script>");
            }
            else
                Response.Write("<script>alert('请选择文件');</script>");

        }
    }
}