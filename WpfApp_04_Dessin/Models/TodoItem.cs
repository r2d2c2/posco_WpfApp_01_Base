using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_04_Dessin.Models
{
    public class TodoItem //할 일 
    {
        public string Task { get; set; } //할 일 내용
        public override string ToString() => Task;
    }
}
