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

namespace Vocab_Trainer
{
    public partial class Database_New : Form
    {
        //string Connection = GlobalVariables.GlobalMySqlCon;
        string Connection = Streamreader_Setup.myCon_SR;
        public Database_New()
        {
            InitializeComponent();
            fill_comboBoxDatabase();
        }

        private void fill_comboBoxDatabase()
        {
            string ShowQuery = "show databases;";
            MySqlConnection conDataBase = new MySqlConnection(Connection);
            MySqlCommand cmdDataBase = new MySqlCommand(ShowQuery, conDataBase);
            MySqlDataReader dbreader;
            
            try
            {
                conDataBase.Open();
                dbreader = cmdDataBase.ExecuteReader();
                while (dbreader.Read())
                {
                    string databases_svar = dbreader.GetString("database");
                    comboBoxDatabase.Items.Add(databases_svar);
                }
                conDataBase.Close();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Database_New_Load(object sender, EventArgs e)
        {

        }

        private void cmdCreateDatabase_Click(object sender, EventArgs e)
        {
            string QueryCreateDB = "create database " + tbxDatabase.Text + ";";
            MySqlConnection conDataBase = new MySqlConnection(Connection);
            MySqlCommand cmdDataBase = new MySqlCommand(QueryCreateDB, conDataBase);

            try
            {
                conDataBase.Open();
                cmdDataBase.ExecuteNonQuery();
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            tbConsole.Text += QueryCreateDB;
        }

        private void comboBoxDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            string UseDBQuery = "use " + comboBoxDatabase.Text + ";";
        }

        private void cmdAddPK_Click(object sender, EventArgs e)
        {
            tbQuery.Text = "create table " + comboBoxDatabase.Text + "." + tbTableName.Text + " (" + tbPrimaryKey.Text + " " + tbTypePK.Text + ",";
        }

        private void cmdAddColumn_Click(object sender, EventArgs e)
        {
            tbQuery.Text += tbColumns.Text + " "  + cbTypes.Text;
        }

        private void cmdNewColumn_Click(object sender, EventArgs e)
        {
            tbColumns.Text = "";
            tbQuery.Text += ", ";
        }

        private void cmdQuery_Click(object sender, EventArgs e)
        {
            string createTableQuery = tbQuery.Text + ");";
            MySqlConnection conDataBase = new MySqlConnection(Connection);
            MySqlCommand cmdDataBase = new MySqlCommand(createTableQuery, conDataBase);

            try
            {
                conDataBase.Open();
                cmdDataBase.ExecuteNonQuery();
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            tbConsole.Text += createTableQuery;
        }
    }
}
