using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoApp.DataAccess.Abstract;
using ToDoApp.Entities;

namespace ToDoApp.DataAccess.Concrete
{
    public class TodoRepository : IToDoRepository
    {
        ToDoAppDbContext c = new ToDoAppDbContext();
        public ToDo CreateTodo(ToDo todo)
        {
            using (var toDoAppDbContext = new ToDoAppDbContext())
            {
                
                todo.createAt = DateTime.Today;
                todo.updateAt= DateTime.Today;
                toDoAppDbContext.toDos.Add(todo);
                toDoAppDbContext.SaveChanges();
                return todo;
            }
        }
        public List<ToDo> GetAllToDo()
        {
            using (var toDoAppDbContext=new ToDoAppDbContext())
            {
                return toDoAppDbContext.toDos.ToList();
            }
        }

        public ToDo GetToDoById(int id)
        {
            using (var toDoAppDbContext = new ToDoAppDbContext())
            {
                return toDoAppDbContext.toDos.Find(id);
            }
        }

        public ToDo UpdateTodo(ToDo todo)
        {
            using (var toDoAppDbContext = new ToDoAppDbContext())
            {
                toDoAppDbContext.toDos.Update(todo);
                toDoAppDbContext.SaveChanges();
                return todo;
            }
        }

        void IToDoRepository.DeleteTodo(int id)
        {
            using (var toDoAppDbContext = new ToDoAppDbContext())
            {
                var deletedToDo = GetToDoById(id);
                toDoAppDbContext.toDos.Remove(deletedToDo);
                toDoAppDbContext.SaveChanges();
            }
        }
    }
}
