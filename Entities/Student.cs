using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAcademy.Entities
{
    class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; } // Твердов
        public Group Group { get; set; }
        public Guid GroupId { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
