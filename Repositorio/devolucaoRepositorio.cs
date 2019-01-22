using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class devolucaoRepositorio
    {
        public void inserir(devolucao dev)
        {
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                db.devolucao.Add(dev);
                db.SaveChanges();
            }
        }

        public void alterar(devolucao dev)
        {
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                db.Entry(dev).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void excluir(devolucao dev)
        {
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                db.Entry(dev).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public devolucao selecionar(int codigo)
        {
            devolucao dev = null;
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                dev = (from devolucao in db.devolucao where devolucao.devolucao_codigo == codigo select devolucao).FirstOrDefault();
            }
            return dev;
        }

        public List<devolucao> selecionar(string status)
        {
            List<devolucao> lista = null;
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                lista = (from devolucao in db.devolucao where devolucao.status.status_nome.Contains(status) orderby devolucao.status.status_nome select devolucao).ToList();
            }
            return lista;
        }

        public List<vw_devolucoes> selecionarView(DateTime data1, DateTime data2)
        {
            List<vw_devolucoes> lista = null;
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                lista = (from devolucao in db.vw_devolucoes where devolucao.devolucao_dataEfetiva >= data1.Date && devolucao.devolucao_dataEfetiva <= data2.Date orderby devolucao.devolucao_dataEfetiva select devolucao).ToList();
            }
            return lista;
        }
    }
}