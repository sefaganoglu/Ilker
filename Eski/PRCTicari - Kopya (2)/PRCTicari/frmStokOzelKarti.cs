﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PRCTicari
{
    public partial class frmStokOzelKarti : Form
    {
        DataTable dtOzeller = new DataTable();
        public frmStokOzelKarti()
        {
            InitializeComponent();
        }

        private void tsbKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmStokOzelKarti_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            SqlConnection cnn = new SqlConnection(clsGenel.strConnectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Stok_Ozel_Tanitimi";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dtOzeller);
            sda.Dispose();
            cmd.Dispose();
            cnn.Close();

            dgvOzeller.DataSource = dtOzeller;
        }

        private void tsbKaydet_Click(object sender, EventArgs e)
        {
            dgvOzeller.CommitEdit(DataGridViewDataErrorContexts.Commit);

            SqlConnection cnn = new SqlConnection(clsGenel.strConnectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = "DELETE FROM Stok_Ozel_Tanitimi";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO Stok_Ozel_Tanitimi (Ozel_Kodu, Ozel_Adi) VALUES (@Ozel_Kodu, @Ozel_Adi)";
            foreach (DataRow dr in dtOzeller.Rows)
            {
                cmd.Parameters.AddWithValue("@Ozel_Kodu", dr["Ozel_Kodu"]);
                cmd.Parameters.AddWithValue("@Ozel_Adi", dr["Ozel_Adi"]);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            cmd.Dispose();
            cnn.Close();
        }
    }
}
