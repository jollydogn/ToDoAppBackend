using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Entities;

namespace ToDoApp.DataAccess.Abstract
{
    public interface IToDoRepository
    {
        List<ToDo> GetAllToDo();
        ToDo GetToDoById(int id);
        ToDo CreateTodo(ToDo todo);
        ToDo UpdateTodo(ToDo todo);
        void DeleteTodo(int id);
    }
}
