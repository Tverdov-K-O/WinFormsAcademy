using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAcademy.Entities
{
    class Group
    {
        public Guid Id { get; set; }
        public string Name { get; set; } // ПУ011
        public List<Student> Students { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
