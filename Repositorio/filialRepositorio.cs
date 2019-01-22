using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class filialRepositorio
    {
        public void inserir(filial fil)
        {
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                db.filial.Add(fil);
                db.SaveChanges();
            }
        }

        public void alterar(filial fil)
        {
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                db.Entry(fil).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void excluir(filial fil)
        {
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                db.Entry(fil).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public filial selecionar(int codigo)
        {
            filial fil = null;
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                fil = (from filial in db.filial where filial.filial_codigo == codigo select filial).FirstOrDefault();
            }
            return fil;
        }

        public List<filial> selecionar(string nome)
        {
            List<filial> lista = null;
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                lista = (from filial in db.filial where filial.filial_nome.Contains(nome) orderby filial.filial_nome select filial).ToList();
            }
            return lista;
        }

        public List<vw_filial> selecionarView(string nome)
        {
            List<vw_filial> lista = null;
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                lista = (from filial in db.vw_filial where filial.filial_nome.Contains(nome) orderby filial.filial_nome select filial).ToList();
            }
            return lista;
        }
    }
}
