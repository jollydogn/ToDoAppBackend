using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Business.Abstract;
using TodoApp.Business.Concrete;
using ToDoApp.Entities;

namespace ToDoApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDosController : ControllerBase
    {
        private IToDoService _toDoService;
        public ToDosController(IToDoService toDoService)
        {
            _toDoService = toDoService;
        }
        [HttpGet]
        public List<ToDo> Get()
        {
            return _toDoService.GetAllToDos();
        }
        [HttpGet("{id}")]
        public ToDo Get(int id)
        {
            return _toDoService.GetToDoById(id);
        }

        [HttpPost]
        public ToDo Post([FromBody]ToDo toDo)
        {
            return _toDoService.CreateTodo(toDo);
        }
        [HttpPut]
        public ToDo Put([FromBody] ToDo toDo)
        {
            return _toDoService.UpdateTodo(toDo);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           _toDoService.DeleteTodo(id);
        }
    }
}
