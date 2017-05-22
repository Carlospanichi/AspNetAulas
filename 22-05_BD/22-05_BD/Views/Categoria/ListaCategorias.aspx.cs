using _22_05_BD.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _22_05_BD.Views.Categoria
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Contexto (referencia pro banco)
            strconnLojaEntities contexto = new strconnLojaEntities();

            gvwCategoria.DataSource = contexto.Categorias.ToList();
            gvwCategoria.DataBind();
        }
    }
}