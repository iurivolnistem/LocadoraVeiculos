using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class clienteRepositorio
    {
        public void inserir(cliente cli)
        {
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                db.cliente.Add(cli);
                db.SaveChanges();
            }
        }

        public void alterar(cliente cli)
        {
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                db.Entry(cli).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void excluir(cliente cli)
        {
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                db.Entry(cli).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public cliente selecionar(int codigo)
        {
            cliente cli = null;
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                cli = (from cliente in db.cliente where cliente.cliente_codigo == codigo select cliente).FirstOrDefault();
            }
            return cli;
        }

        public List<cliente> selecionar(string nome)
        {
            List<cliente> lista = null;
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                lista = (from cliente in db.cliente where cliente.cliente_nome.Contains(nome) orderby cliente.cliente_nome select cliente).ToList();
            }
            return lista;
        }

        public List<vw_cliente> selecionarView(string nome)
        {
            List<vw_cliente> lista = null;
            using (locadoraEntities1 db = new locadoraEntities1())
            {
                lista = (from c in db.vw_cliente where c.cliente_nome.Contains(nome) orderby c.cliente_nome select c).ToList();
            }
            return lista;
        }
    }
}
