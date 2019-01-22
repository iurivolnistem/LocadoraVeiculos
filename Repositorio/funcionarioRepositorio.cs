using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class funcionarioRepositorio
    {
        public void inserir(funcionario fun)
        {
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                db.funcionario.Add(fun);
                db.SaveChanges();
            }
        }

        public void alterar(funcionario fun)
        {
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                db.Entry(fun).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void excluir(funcionario fun)
        {
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                db.Entry(fun).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public funcionario selecionar(int codigo)
        {
            funcionario fun = null;
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                fun = (from funcionario in db.funcionario where funcionario.funcionario_codigo == codigo select funcionario).FirstOrDefault();
            }
            return fun;
        }

        public List<funcionario> selecionar(string nome)
        {
            List<funcionario> lista = null;
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                lista = (from funcionario in db.funcionario where funcionario.funcionario_nome.Contains(nome) orderby funcionario.funcionario_nome select funcionario).ToList();
            }
            return lista;
        }

        public List<vw_funcionario> selecionarView(string nome)
        {
            List<vw_funcionario> lista = null;
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                lista = (from f in db.vw_funcionario where f.funcionario_nome.Contains(nome) orderby f.funcionario_nome select f).ToList();
            }
            return lista;
        }
    }
}
