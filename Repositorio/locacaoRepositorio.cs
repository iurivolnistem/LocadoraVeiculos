using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class locacaoRepositorio
    {
        public void inserir(locacao loc)
        {
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                db.locacao.Add(loc);
                db.SaveChanges();
            }
        }

        public void alterar(locacao loc)
        {
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                db.Entry(loc).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void excluir(locacao loc)
        {
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                db.Entry(loc).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public locacao selecionar(int codigo)
        {
            locacao loc = null;
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                loc = (from locacao in db.locacao where locacao.locacao_codigo == codigo select locacao).FirstOrDefault();
            }
            return loc;
        }

        public List<locacao> selecionar(string status)
        {
            List<locacao> lista = null;
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                lista = (from locacao in db.locacao where locacao.status.status_nome.Contains(status) orderby locacao.status.status_nome select locacao).ToList();
            }
            return lista;
        }

        public List<vw_locacoes> selecionarView(DateTime data1, DateTime data2)
        {
            List<vw_locacoes> lista = null;
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                lista = (from locacao in db.vw_locacoes where locacao.locacao_dataLocacao >= data1.Date && locacao.locacao_dataLocacao <= data2.Date orderby locacao.locacao_dataLocacao select locacao).ToList();
            }
            return lista;
        }
    }
}
