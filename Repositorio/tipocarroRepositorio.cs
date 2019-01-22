using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class tipocarroRepositorio
    {
        public void inserir(tipocarro tipcar)
        {
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                db.tipocarro.Add(tipcar);
                db.SaveChanges();
            }
        }

        public void alterar(tipocarro tipcar)
        {
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                db.Entry(tipcar).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void excluir(tipocarro tipcar)
        {
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                db.Entry(tipcar).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public tipocarro selecionar(int codigo)
        {
            tipocarro tipcar = null;
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                tipcar = (from tipocarro in db.tipocarro where tipocarro.tipocarro_codigo == codigo select tipocarro).FirstOrDefault();
            }
            return tipcar;
        }

        public List<tipocarro> selecionar(string nome)
        {
            List<tipocarro> lista = null;
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                lista = (from tipocarro in db.tipocarro where tipocarro.tipocarro_tipo.Contains(nome) orderby tipocarro.tipocarro_tipo select tipocarro).ToList();
            }
            return lista;
        }

        public List<vw_tipocarro> selecionarView(string nome)
        {
            List<vw_tipocarro> lista = null;
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                lista = (from tpcarro in db.vw_tipocarro where tpcarro.tipocarro_tipo.Contains(nome) orderby tpcarro.tipocarro_tipo select tpcarro).ToList();
            }
            return lista;
        }
    }
}
