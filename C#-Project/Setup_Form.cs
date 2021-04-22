using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Vocab_Trainer
{
    public partial class Setup_Form : Form
    {
        public Setup_Form()
        {
            InitializeComponent();
        }

        private void cmdSafe_Click(object sender, EventArgs e)
        {
            StreamWriter SetupFile = new StreamWriter("setup.ini");
            SetupFile.Write("server=" + tbServer.Text + "; port=" + tbPort.Text + "; username=" + tbUsername.Text + "; password=" +  tbPassword.Text + "; database=" + tbDatabase.Text + ";");
            SetupFile.Close();
        }

        MainForm mdi;
        private void cmdRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
            mdi = new MainForm();
            mdi.ShowDialog();
        }

        private void cmdReload_Click(object sender, EventArgs e)
        {
            Streamreader_Setup.SR.Close();

            try
            {
                string update = File.ReadAllText(@"setup.ini");
                update = update.Replace(Streamreader_Setup.myCon_SR, "server=" + tbServer.Text + "; port=" + tbPort.Text + "; username=" + tbUsername.Text + "; password=" + tbPassword.Text + "; database=" + tbDatabase.Text + ";");
                File.WriteAllText(@"setup.ini", update);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Application.Restart();
            lblConnectionString.Text = Streamreader_Setup.myCon_SR;
        }

        private void Setup_Form_Load(object sender, EventArgs e)
        {
            if(File.Exists(GlobalVariables.input) == true)
            {
                lblConnectionString.Text = Streamreader_Setup.myCon_SR;
            }
            else
            {
                lblConnectionString.Text = "MySQL Connection String";
            }
        }
    }
}
