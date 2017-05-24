using Aula_24_05_EF_MF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula_24_05_EF_MF.Views
{
    public partial class BasePage : System.Web.UI.Page
    {
        protected BaseDadosContainer contexto = new BaseDadosContainer();

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}