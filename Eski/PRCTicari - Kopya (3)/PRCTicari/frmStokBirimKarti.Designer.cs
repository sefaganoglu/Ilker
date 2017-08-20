﻿namespace PRCTicari
{
    partial class frmStokBirimKarti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokBirimKarti));
            this.dgvBirimler = new PRCTicari.MyDataGridView(this.components);
            this.colBirimKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirimAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAgirlikBirimi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbKapat = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBirimler)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBirimler
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvBirimler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBirimler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBirimler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBirimKodu,
            this.colBirimAdi,
            this.colAgirlikBirimi});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBirimler.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBirimler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBirimler.Location = new System.Drawing.Point(0, 54);
            this.dgvBirimler.Name = "dgvBirimler";
            this.dgvBirimler.RowHeadersWidth = 24;
            this.dgvBirimler.Size = new System.Drawing.Size(406, 221);
            this.dgvBirimler.TabIndex = 18;
            this.dgvBirimler.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvBirimler_DataError);
            // 
            // colBirimKodu
            // 
            this.colBirimKodu.DataPropertyName = "Birim_Kodu";
            this.colBirimKodu.HeaderText = "Birim Kodu";
            this.colBirimKodu.Name = "colBirimKodu";
            this.colBirimKodu.Width = 85;
            // 
            // colBirimAdi
            // 
            this.colBirimAdi.DataPropertyName = "Birim_Adi";
            this.colBirimAdi.HeaderText = "Birim Adı";
            this.colBirimAdi.Name = "colBirimAdi";
            this.colBirimAdi.Width = 200;
            // 
            // colAgirlikBirimi
            // 
            this.colAgirlikBirimi.DataPropertyName = "Agirlik_Birimi";
            this.colAgirlikBirimi.FalseValue = "0";
            this.colAgirlikBirimi.HeaderText = "Ağırlık Birimi";
            this.colAgirlikBirimi.Name = "colAgirlikBirimi";
            this.colAgirlikBirimi.TrueValue = "1";
            this.colAgirlikBirimi.Width = 75;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statusStrip1.BackgroundImage")));
            this.statusStrip1.Location = new System.Drawing.Point(0, 275);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(406, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbKaydet,
            this.toolStripSeparator1,
            this.tsbKapat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(406, 54);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbKaydet
            // 
            this.tsbKaydet.Image = ((System.Drawing.Image)(resources.GetObject("tsbKaydet.Image")));
            this.tsbKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKaydet.Name = "tsbKaydet";
            this.tsbKaydet.Size = new System.Drawing.Size(47, 51);
            this.tsbKaydet.Text = "Kaydet";
            this.tsbKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbKaydet.Click += new System.EventHandler(this.tsbKaydet_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // tsbKapat
            // 
            this.tsbKapat.Image = ((System.Drawing.Image)(resources.GetObject("tsbKapat.Image")));
            this.tsbKapat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKapat.Name = "tsbKapat";
            this.tsbKapat.Size = new System.Drawing.Size(41, 51);
            this.tsbKapat.Text = "Kapat";
            this.tsbKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbKapat.Click += new System.EventHandler(this.tsbKapat_Click);
            // 
            // frmStokBirimKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(406, 297);
            this.Controls.Add(this.dgvBirimler);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmStokBirimKarti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Birim Kartı";
            this.Shown += new System.EventHandler(this.frmStokBirimKarti_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBirimler)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyDataGridView dgvBirimler;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbKaydet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbKapat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirimKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirimAdi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAgirlikBirimi;
    }
}