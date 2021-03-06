﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRCTicari
{
    public partial class rpStokListesi : Form
    {
        public rpStokListesi(string strFormID)
        {
            InitializeComponent();

            this.AccessibleDescription = strFormID;
            prcdRaporDosyaListesi();
        }

        private void tsbKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbOnizleme_Click(object sender, EventArgs e)
        {
            prcdRaporHazirla(((ToolStripButton)sender).Tag.TOBYTE());
        }

        private void prcdRaporDosyaListesi()
        {
            cbRaporAdi.Items.Clear();
            cbRaporAdi.Items.AddRange(clsGenel.fncRaporDosyaListesi(this.AccessibleDescription));
            clsGenel.prcdRaporXMLGetir(this.AccessibleDescription, cbRaporAdi);
        }

        private void prcdRaporHazirla(byte bytTip)
        {
            Dictionary<string, DataTable> dDataTables = new Dictionary<string, DataTable>();

            DataTable dtStokListesi = new DataTable();
            SqlConnection cnn = new SqlConnection(clsGenel.strConnectionString);
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Stok_Tanitimi WHERE Silindi = 0";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dtStokListesi);
            sda.Dispose();
            cmd.Dispose();
            cnn.Close();
            dDataTables.Add("dtStokListesi", dtStokListesi);

            clsGenel.prcdRaporHazirla(bytTip, this.AccessibleDescription, cbRaporAdi, dDataTables);
        }
    }
}
