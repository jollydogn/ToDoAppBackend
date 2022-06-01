using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Entities;

namespace TodoApp.Business.Abstract
{
   public interface IToDoService
    {
        List<ToDo> GetAllToDos();
        ToDo GetToDoById(int id);
        ToDo CreateTodo(ToDo todo);
        ToDo UpdateTodo(ToDo todo);
        void DeleteTodo(int id);
    }
}
