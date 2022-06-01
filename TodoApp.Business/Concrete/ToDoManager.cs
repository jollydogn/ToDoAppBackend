using System;
using System.Collections.Generic;
using System.Text;
using TodoApp.Business.Abstract;
using ToDoApp.DataAccess.Abstract;
using ToDoApp.DataAccess.Concrete;
using ToDoApp.Entities;

namespace TodoApp.Business.Concrete
{
    public class ToDoManager : IToDoService
    {
        private IToDoRepository _todoRepository;
        public ToDoManager(IToDoRepository toDoRepository)
        {
            _todoRepository = toDoRepository;
        }
        public ToDo CreateTodo(ToDo todo)
        {
            return _todoRepository.CreateTodo(todo);
        }

        public void DeleteTodo(int id)
        {
            _todoRepository.DeleteTodo(id);
        }

        public List<ToDo> GetAllToDos()
        {
            return _todoRepository.GetAllToDo();
        }

        public ToDo GetToDoById(int id)
        {
            if (id>0)
            {
                return _todoRepository.GetToDoById(id);
            }
            throw new Exception("id can not be less than 1");
        }

        public ToDo UpdateTodo(ToDo todo)
        {
            return _todoRepository.UpdateTodo(todo);
        }
    }
}
