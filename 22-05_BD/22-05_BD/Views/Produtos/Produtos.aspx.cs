using _22_05_BD.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _22_05_BD.Views;

namespace _22_05_BD.Views.Produtos
{
    public partial class Produtos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            strconnLojaEntities contexto = new strconnLojaEntities();

            gwvProdutos.DataSource = contexto.Produtoes.ToList();
            gwvProdutos.DataBind();
        }
    }
}