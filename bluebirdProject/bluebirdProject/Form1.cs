using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace bluebirdProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ToonAllen()
        {
            listBox1.Items.Clear();
            Globaal.Connection.Open();
            OleDbDataReader dbread = null;
            string sql = "SELECT StoelNummer , CurrentValue  FROM Reserveringen";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                listBox1.Items.Add(dbread.GetValue(0).ToString() + " " + dbread.GetValue(1).ToString());
            }
            dbread.Close();
            Globaal.Connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Globaal.Connection.Open();
            OleDbDataReader dbread = null;
            string sql = "SELECT StoelNummer , CurrentValue  FROM Reserveringen";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                listBox1.Items.Add(dbread.GetValue(0).ToString() + " " + dbread.GetValue(1).ToString());
                CBStoel.Items.Add(dbread["StoelNummer"].ToString());
            }
            dbread.Close();
            Globaal.Connection.Close();
        }


        private void RBFirstClas_CheckedChanged(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            Globaal.Connection.Open();
            OleDbDataReader dbread = null;
            string sql = "SELECT StoelNummer , CurrentValue FROM Reserveringen Where Klasse = 'Firstclass'";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                listBox1.Items.Add(dbread.GetValue(0).ToString() + " " + dbread.GetValue(1).ToString());
            }
            dbread.Close();
            Globaal.Connection.Close();
        }

        private void RBBuisnes_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Globaal.Connection.Open();
            OleDbDataReader dbread = null;
            string sql = "SELECT StoelNummer , CurrentValue FROM Reserveringen Where Klasse = 'Businessclass'";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                listBox1.Items.Add(dbread.GetValue(0).ToString() + " " + dbread.GetValue(1).ToString());
            }
            dbread.Close();
            Globaal.Connection.Close();
        }

        private void RBEconomy_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Globaal.Connection.Open();
            OleDbDataReader dbread = null;
            string sql = "SELECT StoelNummer , CurrentValue FROM Reserveringen Where Klasse = 'Economyclass'";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                listBox1.Items.Add(dbread.GetValue(0).ToString() + " " + dbread.GetValue(1).ToString());
            }
            dbread.Close();
            Globaal.Connection.Close();
        }
        private void RbAllen_CheckedChanged(object sender, EventArgs e)
        {
            ToonAllen();
        }
        
      

        private void BTNToeveogen_Click(object sender, EventArgs e)
        {
            Globaal.Connection.Open();
            string sql = "UPDATE Reserveringen SET CurrentValue = @Naam WHERE StoelNummer =  ('" + CBStoel.Text + "') ";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            dbcom.Parameters.AddWithValue("@Naam", TBXNaam.Text);
            dbcom.ExecuteNonQuery();
            dbcom.Dispose();
            Globaal.Connection.Close();
            MessageBox.Show("Gewijzigd");
            ToonAllen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Globaal.Connection.Open();
            string sql = "UPDATE Reserveringen SET CurrentValue = @Naam WHERE StoelNummer =  ('" + CBStoel.Text + "') ";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            dbcom.Parameters.AddWithValue("@Naam", TbxVrij.Text);
            dbcom.ExecuteNonQuery();
            dbcom.Dispose();
            Globaal.Connection.Close();
            MessageBox.Show("Gewijzigd");
            ToonAllen();
        }

        private void BtnAfsluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
