using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _17_05
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public int QntDeCliques
        {
            get
            {
                return QntDeCliques = Convert.ToInt32(ViewState["qtdCliques"]);
            }
            set
            {
                ViewState["qtdCliques"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                QntDeCliques = 0;
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            //QntDeCliques = Convert.ToInt32(ViewState["qtdCliques"]);
            QntDeCliques++;
            lblQntDeClickes.Text = QntDeCliques.ToString();
            //ViewState["qtdCliques"] = QntDeCliques;
        }

        protected void btnEnviarCliques_Click(object sender, EventArgs e)
        {
            Session.Add("QtdCliquesSession", QntDeCliques);
            Response.Redirect("~/WebForm2.aspx"); 
        }
    }
}