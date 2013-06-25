using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MiProyectoFinalAsp
{
    public partial class crystal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Class1 cls = new Class1();
            CrystalReport1 rpt = new CrystalReport1();
            rpt.SetDataSource(cls.Datos("select*from proyectos"));
            this.CrystalReportViewer1.ReportSource = rpt;
            this.CrystalReportViewer1.Enabled = true;
        }

        protected void CrystalReportViewer1_Init(object sender, EventArgs e)
        {

        }
    }
}