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
using System.IO;

namespace prysp2FerMoya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        OleDbCommand btn = new OleDbCommand();
        OleDbConnection conn = new OleDbConnection();
        OleDbDataReader dr;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
           
            try
            {
                
                conn.ConnectionString = "Provider=Microsoft.OLEDB.4.0;Data Source=verdulero.mdb";
                conn.Open();

                lblText.Text = "Conexion exitosa";
                lblText.BackColor = Color.Green;
            }
            catch (Exception ex)
            {
                lblText.Text = "Conexion no establecida" + ex.Message + ex.Source;
                lblText.BackColor= Color.Red;
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {
                btn.Connection = conn;
                btn.CommandType = CommandType.TableDirect;
                btn.CommandText = "Biblioteca";

                lblText.Text = "Tabla obtenida";
                lblText.BackColor = Color.Green;

                dr = btn.ExecuteReader();

                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr
                }
            }
        }
    }
}
