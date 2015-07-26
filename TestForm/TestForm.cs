﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordTools;

namespace TestForm
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            WordParser lib = new WordParser();
            try
            {
                lib.fileName = textBoxFileName.Text;
                Cursor.Current = Cursors.WaitCursor;
                lib.ParseFile();
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Parsing completed", "Parsing result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Parsing result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
