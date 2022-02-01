using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAcademy.Data;

namespace WinFormsAcademy.Veiws
{
    public partial class Main : Form
    {
        AppDbContext _db = new AppDbContext();
        private Entities.Group selectedGroup;
        private Entities.Student selectedStudent;
        public Main()
        {
            InitializeComponent();
            LoadGroupList();
        }

        private void LoadGroupList()
        {
            ListGroup.Items.Clear();
            ListGroup.Items.AddRange(_db.Groups.ToArray());
        }
        private void LoadStudentsList()
        {
            ListStudents.Items.Clear();
            if (selectedGroup == null)
            {
                MessageBox.Show("Выберите группу");
                return;
            }
            ListStudents.Items.AddRange(
                _db.Students.Where(s => s.GroupId == selectedGroup.Id).ToArray()
            );
        }


        private void tbnCreateGroup_Click_Click(object sender, EventArgs e)
        {
            Entities.Group g = new Entities.Group
            {
                Id = Guid.NewGuid(),
                Name = inGroupName.Text
            };
            _db.Groups.Add(g);
            _db.SaveChanges();

            inGroupName.Text = "";
            LoadGroupList();
        }
        private void btnCreateStudent_Click_Click(object sender, EventArgs e)
        {
            if (selectedGroup == null)
            {
                MessageBox.Show("Выберите группу");
                return;
            }
            else
            {
                Entities.Student s = new Entities.Student
                {
                    Id = Guid.NewGuid(),
                    Name = inStudentName.Text,
                    Group = selectedGroup
                };
                _db.Students.Add(s);
                _db.SaveChanges();

                inStudentName.Text = "";
                LoadStudentsList();
            }
        }
        private void ListGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListStudents.Items.Clear();
            selectedGroup = (ListGroup.SelectedItem as Entities.Group);
            label2.Text = selectedGroup.Name;
            LoadStudentsList();
        }

        private void ListStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboGroupNames.Items.Clear();
            ComboGroupNames.Items.AddRange(_db.Groups.ToArray());

            selectedStudent = (ListStudents.SelectedItem as Entities.Student);
            if(selectedStudent == null ) { return; }
            ChangeStudentName.Text = selectedStudent.Name;
            ComboGroupNames.SelectedItem = selectedStudent.Group;
        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            selectedStudent.Name = ChangeStudentName.Text;
            selectedStudent.Group = (ComboGroupNames.SelectedItem as Entities.Group);
            _db.SaveChanges();
            LoadStudentsList();
        }

        private void btnDellStudent_Click(object sender, EventArgs e)
        {
            if (selectedStudent == null || selectedStudent.GroupId != selectedGroup.Id )
            {
                MessageBox.Show("Выберите студента");
                return;
            }
            else
            {
                _db.Students.Remove(selectedStudent);
                _db.SaveChanges();
                inStudentName.Text = "";
                ChangeStudentName.Clear();
                ComboGroupNames.Items.Clear();
                ComboGroupNames.Text = "";
                LoadStudentsList();
            }
        }
    } 
}
