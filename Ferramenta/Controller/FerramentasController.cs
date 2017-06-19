using ControleFerramentas.Model;
using System.Collections.Generic;
using System.Linq;

namespace ControleFerramentas.Controller
{
    public class FerramentasController : BaseController
    {
        public void Adicionar(Ferramenta ferramenta)
        {
            if (ferramenta != null)
            {
                contexto.Ferramentas.Add(ferramenta);
                contexto.SaveChanges();
            }
        }
        public List<Ferramenta> Listar()
        {
            return contexto.Ferramentas.ToList();
        }

        public Ferramenta BuscarPorMatricula(string Matricula)
        {
            return contexto.Ferramentas.Find(Matricula);
        }

        public void Excluir(Ferramenta ferramenta)
        {
            contexto.Entry(ferramenta).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }
        public void Editar(Ferramenta ferramenta)
        {
            contexto.Entry(ferramenta).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
    }
}