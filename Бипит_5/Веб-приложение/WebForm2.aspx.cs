using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;

namespace Веб_приложение
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ServiceReference1.Service1Client s = new ServiceReference1.Service1Client("NetTcpBinding_IService1");
                GridView1.DataSource = s.GetData();
                GridView1.DataBind();

                DropDownList1.DataSource = s.FillFIO();
                DropDownList1.DataTextField = "FIO";
                DropDownList1.DataValueField = "ID_FIO";
                DropDownList1.DataBind();

                DropDownList2.DataSource = s.FillAvto();
                DropDownList2.DataTextField = "Model_avto";
                DropDownList2.DataValueField = "ID_AVTO";
                DropDownList2.DataBind();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client s = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            var ID_FIO = DropDownList1.Text;
            var ID_AVTO = DropDownList2.Text;
            var Data_vzitia = dateEx.Text;
            var Data_zdachi = dateEx0.Text;
            if (!(Data_vzitia == "" || Data_zdachi == ""))
            {
                s.NewRec(ID_FIO, ID_AVTO, Data_vzitia, Data_zdachi);
                Response.Redirect("WebForm2.aspx");
            }
        }
    }
}