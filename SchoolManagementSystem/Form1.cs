using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDataSet1.pupils' table. You can move, or remove it, as needed.
            this.pupilsTableAdapter.Fill(this.schoolDataSet1.pupils);
            // TODO: This line of code loads data into the 'schoolDataSet.classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.schoolDataSet.classes);

        }

        private void GetPupils()
        {
            var subjectID = (int)pupil_combobox.SelectedValue;

            using (var context = new SchoolContext())
            {
                pupilsBindingSource.DataSource = context.Pupils.Where(s => s.Classid == subjectID).OrderBy(s => s.FirstName).ToList();
            }
        }

        private void GetAllPupils()
        {
            using (var context = new SchoolContext())
                        {
                            pupilsBindingSource.DataSource = context.Pupils.Select(p => p).ToList();
                        }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {

            GetPupils();
        }

        private void allpupils_btn_Click(object sender, EventArgs e)
        {

            GetAllPupils();
        }

        private void pupil_datagrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this?", "Delete", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            var pupilid = (int)e.Row.Cells[0].Value;

            using (var context = new SchoolContext())
            {
                var pupil = context.Pupils.SingleOrDefault(p => p.id == pupilid);

                if (pupil != null)
                {
                    context.Pupils.Remove(pupil);
                    var result = context.SaveChanges();

                    MessageBox.Show(string.Format("{0} pupils deleted.", result));
                }
            }
        }

        private void pupil_datagrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {


            var pupilID = (int)pupil_datagrid.Rows[e.RowIndex].Cells[0].Value;
            var firstName = (string)pupil_datagrid.Rows[e.RowIndex].Cells[1].Value;
            var lastName = (string)pupil_datagrid.Rows[e.RowIndex].Cells[2].Value;
            var age = (int)pupil_datagrid.Rows[e.RowIndex].Cells[3].Value;
            var telephone = (string)pupil_datagrid.Rows[e.RowIndex].Cells[4].Value;
            var year = (int)pupil_datagrid.Rows[e.RowIndex].Cells[5].Value;
            var grade = (string)pupil_datagrid.Rows[e.RowIndex].Cells[6].Value;
            var classID = (int)pupil_datagrid.Rows[e.RowIndex].Cells[7].Value;


            using (var context = new SchoolContext())
            {
                var pupil = context.Pupils.SingleOrDefault(p => p.id == pupilID);

                if (pupil != null)
                {
                    pupil.FirstName = firstName;
                    pupil.LastName = lastName;
                    pupil.Age = age;
                    pupil.Telephone = telephone;
                    pupil.Year = year;
                    pupil.Grade = grade;
                    pupil.Classid = classID;

                    var result = context.SaveChanges();

                    MessageBox.Show(string.Format("{0} pupils updated.", result));
                }
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.ShowDialog();
        }
    }
}
