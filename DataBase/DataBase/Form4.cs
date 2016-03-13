﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void coursesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coursesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet3);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet3.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.dataSet3.Courses);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.coursesTableAdapter.FillByCourses(this.dataSet3.Courses);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillByCoursesToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void serachCourseToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.coursesTableAdapter.SerachCourse(this.dataSet3.Courses, idCourseToolStripTextBox.Text, coursetTitleToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
