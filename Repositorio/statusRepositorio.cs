using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class statusRepositorio
    {
        public void inserir(status sta)
        {
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                db.status.Add(sta);
                db.SaveChanges();
            }
        }

        public void alterar(status sta)
        {
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                db.Entry(sta).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void excluir(status sta)
        {
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                db.Entry(sta).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public status selecionar(int codigo)
        {
            status sta = null;
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                sta = (from status in db.status where status.status_codigo == codigo select status).FirstOrDefault();
            }
            return sta;
        }

        public List<status> selecionar(string nome)
        {
            List<status> lista = null;
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                lista = (from status in db.status where status.status_nome.Contains(nome) orderby status.status_nome select status).ToList();
            }
            return lista;
        }

        public List<vw_status> selecionarView(string nome)
        {
            List<vw_status> lista = null;
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                lista = (from status in db.vw_status where status.status_nome.Contains(nome) orderby status.status_nome select status).ToList();
            }
            return lista;
        }
    }
}
