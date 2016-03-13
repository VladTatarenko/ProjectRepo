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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.dataSet2.Students);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();  
        }

        private void fillByStudToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void fillByStudToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentsTableAdapter.FillByStud(this.dataSet2.Students);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void searchStudToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentsTableAdapter.SearchStud(this.dataSet2.Students, idStudentToolStripTextBox.Text, fullNameToolStripTextBox.Text, passportToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
