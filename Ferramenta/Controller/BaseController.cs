using ControleFerramentas.Model;

namespace ControleFerramentas.Controller
{
    public class BaseController
    {
        protected static FerramentasDBContainer contexto = new FerramentasDBContainer();
    }
}