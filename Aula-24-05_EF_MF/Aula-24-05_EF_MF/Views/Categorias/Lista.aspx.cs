using System;
using System.Collections.Generic;
using System.Linq;
using Aula_24_05_EF_MF.Models;
using System.Web.UI.WebControls;

namespace Aula_24_05_EF_MF.Views.Categorias
{
    public partial class Lista : BasePage
    {
        protected new void Page_Load(object sender, EventArgs e)
        {
            List<Categoria> categorias = contexto.Categorias.ToList();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            cat.Nome = txtNomeCat.Text;
            cat.Descricao = txtDescricaoCat.Text;
            contexto.Categorias.Add(cat);
            contexto.SaveChanges();
            txtNomeCat.Text= "";
            txtDescricaoCat.Text = "";
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNomeCat.Text = "";
            txtDescricaoCat.Text = "";
        }
    }
}