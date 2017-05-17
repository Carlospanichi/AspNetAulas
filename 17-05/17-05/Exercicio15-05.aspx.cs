using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _17_05
{
    public partial class Exercicio15_05 : System.Web.UI.Page
    {
        public int n1 { get; set; }        
        public int n2 { get; set; }
        public int rsoma { get; set; }
        public int rsub { get; set; }
        public int rdiv { get; set; }
        public int rmult { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSoma_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToInt32(txtValor1.Text);
            n2 = Convert.ToInt32(txtvalor2.Text);
            rsoma = n1 + n2;
            rsub = n1 - n2;
            rmult = n1 * n2;
            rdiv = n1 / n2;
            txtResuldado.Text = rsoma.ToString();
        }

        protected void btnIgual_Click(object sender, EventArgs e)
        {
            Session.Add("Valor1", n1);
            Session.Add("Valor2", n2);
            Session.Add("Soma", rsoma);
            Session.Add("Sub", rsub);
            Session.Add("Mult", rmult);
            Session.Add("Divi", rdiv);
            Response.Redirect("~/Exercicio15-05P2.aspx");
        }
    }
}