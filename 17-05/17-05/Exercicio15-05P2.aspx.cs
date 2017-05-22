using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _17_05
{
    public partial class Exercicio15_05P2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int Valor1 = Convert.ToInt32(Session["Valor1"]);
            int Valor2 = Convert.ToInt32(Session["Valor2"]);
            int Soma = Convert.ToInt32(Session["Soma"]);
            int Sub = Convert.ToInt32(Session["Sub"]);
            int Mult = Convert.ToInt32(Session["Mult"]);
            int Div = Convert.ToInt32(Session["Div"]);
            //Resuldados da operações
            txtResultSoma.Text = Soma.ToString();
            txtResultSub.Text = Sub.ToString();
            txtResulMult.Text = Mult.ToString();
            txtresultDiv.Text = Div.ToString();
            // Soma
            txtAdd1.Text = Valor1.ToString();
            txtAdd2.Text = Valor2.ToString();
            // Divisão
            txtDividendo.Text = Valor1.ToString();
            txtDivisor.Text = Valor2.ToString();
            // Subtração
            txtSub1.Text = Valor1.ToString();
            txtSub2.Text = Valor2.ToString();
            // Multiplicação
            txtV1.Text = Valor1.ToString();
            txtV2.Text = Valor2.ToString();
        }
    }
}