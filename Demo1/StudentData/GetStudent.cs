﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1.StudentData
{
    public partial class GetStudent : Form
    {
        public GetStudent()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetStudent_Load(object sender, EventArgs e)
        {
            StuData.StuData studata = new StuData.StuData();
            studata.Background();
        }
    }
}
