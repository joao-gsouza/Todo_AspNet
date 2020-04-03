using System.Collections.Generic;
using System.Linq;

namespace Todo_id.Models
{
    public static class Dados
    {
        private static List<Tarefa> tarefas = new List<Tarefa>();

        public static DB db = new DB();

        public static void AdicionarTarefa(Tarefa item){
            
            item.Status = false;

            db.Add(item);

            db.SaveChanges();

        }

        public static void EditarTarefa(Tarefa tarefa){


            var item = db.Tarefas.Find(tarefa.Id);

            item.Nome = tarefa.Nome;

            db.SaveChanges();

        }

        public static List<Tarefa> ListarTarefas(){


            var item = db.Tarefas.OrderBy(b => b.Id).ToList();

            return(item);

        }

        
        public static List<Tarefa> ListaUmaTarefa(int id){
            
            var item = db.Tarefas.Where(b => b.Id == id).ToList();

            return(item);

        }
        

        public static void EditarStatusTarefa(int id){

            var item = db.Tarefas.Where(x => x.Id == id).First();

            item.Status = item.Status ? false : true;

            db.SaveChanges();

        }

        public static void RemoverTarefa(int id){

            var tarefa =db.Tarefas.Where(m => m.Id == id).First();

            db.Remove(tarefa);
            db.SaveChanges();

        }

    }
}