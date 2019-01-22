using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class cidadeRepositorio
    {
        public void inserir(cidade cid)
        {
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                db.cidade.Add(cid);
                db.SaveChanges();
            }
        }

        public void alterar(cidade cid)
        {
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                db.Entry(cid).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void excluir(cidade cid)
        {
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                db.Entry(cid).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public cidade selecionar(int codigo)
        {
            cidade cid = null;
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                cid = (from cidade in db.cidade where cidade.cidade_codigo == codigo select cidade).FirstOrDefault();
            }
            return cid;
        }

        public List<cidade> selecionar(string nome)
        {
            List<cidade> lista = null;
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                lista = (from cidade in db.cidade where cidade.cidade_nome.Contains(nome) orderby cidade.cidade_nome select cidade).ToList();
            }
            return lista;
        }

        public List<vw_cidades> selecionarView(string nome)
        {
            List<vw_cidades> lista = null;
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                lista = (from cidade in db.vw_cidades where cidade.cidade_nome.Contains(nome) orderby cidade.cidade_nome select cidade).ToList();
            }
            return lista;
        }
    }
}
