using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoApp.Entities
{
    public class ToDo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [StringLength(200)]
        public string todo { get; set; }
        public DateTime createAt { get; set; }
        public DateTime updateAt { get; set; }

        [StringLength(10)]
        public string category { get; set; }
    }
}
