using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAcademy.Entities;

namespace WinFormsAcademy.Data
{
    class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }


        private string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tverd\source\repos\WinFormsAcademy\DBFiles\DatabaseAcademy.mdf;Integrated Security=True";
       
        public AppDbContext(string str = null) : base()
        {
            ////вариант когда я строю соединение снаружи
            //this.connString = str;
        }

        // конфигурирует мое соединение с базой данных
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            //sb.DataSource = @"Data Source=(LocalDB)\MSSQLLocalDB";
            optionsBuilder.UseSqlServer(connString);

        }

    }
}
