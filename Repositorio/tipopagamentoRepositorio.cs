using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class tipopagamentoRepositorio
    {
        public void inserir(tipopagamento tippag)
        {
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                db.tipopagamento.Add(tippag);
                db.SaveChanges();
            }
        }

        public void alterar(tipopagamento tippag)
        {
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                db.Entry(tippag).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void excluir(tipopagamento tippag)
        {
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                db.Entry(tippag).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public tipopagamento selecionar(int codigo)
        {
            tipopagamento tippag = null;
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                tippag = (from tipopagamento in db.tipopagamento where tipopagamento.tipopagamento_codigo == codigo select tipopagamento).FirstOrDefault();
            }
            return tippag;
        }

        public List<tipopagamento> selecionar(string nome)
        {
            List<tipopagamento> lista = null;
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                lista = (from tipopagamento in db.tipopagamento where tipopagamento.tipopagamento_nome.Contains(nome) orderby tipopagamento.tipopagamento_nome select tipopagamento).ToList();
            }
            return lista;
        }
    }
}
