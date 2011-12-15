using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using client.model;

namespace client
{
    public partial class Form1 : Form
    {
        private List<Student> _students;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtEnterClick(object sender, EventArgs e)
        {
            StudentManager.Port = tbPort.Text;
            _students = StudentManager.GetAll();
            dgStudentList.DataSource = _students;
        }

        private void DgStudentListCellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var editedStudent = _students[e.RowIndex];
            var res = StudentManager.Update(editedStudent);
            tStatus.Text = res ? "Update ok!" : "Update failed!";
        }
    }
}
