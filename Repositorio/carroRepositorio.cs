using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class carroRepositorio
    {
        public void inserir(carro car)
        {
            using(locadoraEntities1 db = new locadoraEntities1())
            {
                db.carro.Add(car);
                db.SaveChanges();
            }
        }

        public void alterar(carro car)
        {
            using(locadoraEntities1 db = new locadoraEntities1())
            {
                db.Entry(car).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void excluir(carro car)
        {
            using(locadoraEntities1 db = new locadoraEntities1())
            {
                db.Entry(car).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public carro selecionar(int codigo)
        {
            carro car = null;
            using(locadoraEntities1 db = new locadoraEntities1())
            {
                car = (from carro in db.carro where carro.carro_codigo == codigo select carro).FirstOrDefault();
            }
            return car;
        }

        public List<carro> selecionar(string nome)
        {
            List<carro> lista = null;
            using(locadoraEntities1 db = new locadoraEntities1())
            {
                lista = (from carro in db.carro where carro.carro_nome.Contains(nome) orderby carro.carro_nome select carro).ToList();
            }
            return lista;
        }

        public List<vw_carro> selecionarView(string nome)
        {
            List<vw_carro> lista = null;
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                lista = (from carro in db.vw_carro where carro.carro_nome.Contains(nome) orderby carro.carro_nome select carro).ToList();
            }
            return lista;
        }
    }
}
