using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _17_05
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int qtdCliquesViewStates = Convert.ToInt32(ViewState["qntCliques"]);
            int qntCliquesSession = Convert.ToInt32(Session["QtdCliquesSession"]);

            lblQuantidadeCliques.Text = qntCliquesSession.ToString();
        }
    }
}