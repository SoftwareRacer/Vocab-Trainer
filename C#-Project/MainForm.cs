using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Vocab_Trainer
{
    public partial class MainForm : Form
    {
        Database_New db_new;
        Setup_Form setup;
        public MainForm()
        {
            InitializeComponent();
        }

        private void übersetzungErgänzenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void datenbankHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(db_new == null)
            {
                db_new = new Database_New();
                db_new.MdiParent = this;
                db_new.WindowState = FormWindowState.Maximized;
                db_new.Show();
                db_new.FormClosed += new FormClosedEventHandler(Database_New_FormClosed);
            }
        }

        private void Database_New_FormClosed(object sender, EventArgs e)
        {
            db_new = null;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(GlobalVariables.input) == false)
            {
                setup = new Setup_Form();
                setup.ShowDialog();
                this.Close();
            }
        }

        private void programmBeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mySQLSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (setup == null)
            {
                setup = new Setup_Form();
                setup.MdiParent = this;
                setup.WindowState = FormWindowState.Maximized;
                setup.Show();
                setup.FormClosed += new FormClosedEventHandler(Setup_FormClosed);
            }
        }
        private void Setup_FormClosed(object sender, EventArgs e)
        {
            setup = null;
        }

    }
}
