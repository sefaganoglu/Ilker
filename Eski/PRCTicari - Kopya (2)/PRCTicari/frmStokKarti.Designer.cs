﻿namespace PRCTicari
{
    partial class frmStokKarti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokKarti));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbKaydet = new System.Windows.Forms.ToolStripButton();
            this.tsbSil = new System.Windows.Forms.ToolStripButton();
            this.tsbVazgec = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbKapat = new System.Windows.Forms.ToolStripButton();
            this.pnlBaslik = new System.Windows.Forms.Panel();
            this.lblStokNo = new System.Windows.Forms.Label();
            this.btnStokKodu = new System.Windows.Forms.Button();
            this.txtStokKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDetay = new System.Windows.Forms.Panel();
            this.tcDetay = new System.Windows.Forms.TabControl();
            this.tpGenel = new System.Windows.Forms.TabPage();
            this.dgvAlislar = new PRCTicari.MyDataGridView(this.components);
            this.colAy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtKisaAdi = new System.Windows.Forms.TextBox();
            this.txtStokAdi = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTedarikciler = new PRCTicari.MyDataGridView(this.components);
            this.colTedarikciNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTedarikciKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTedarikciSec = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colTedarikciAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGrupKodu = new System.Windows.Forms.TextBox();
            this.btnGrupKodu = new System.Windows.Forms.Button();
            this.tcBirimler = new System.Windows.Forms.TabControl();
            this.tpBirim1 = new System.Windows.Forms.TabPage();
            this.cbBT1HizliSatis = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.nudBT1BirimOrani = new System.Windows.Forms.NumericUpDown();
            this.nudBT1SatisFiyati = new System.Windows.Forms.NumericUpDown();
            this.nudBT1AlisFiyatiKdvli = new System.Windows.Forms.NumericUpDown();
            this.nudBT1AlisFiyati = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBT1Barkod = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbBT1BirimTipi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tpBirim2 = new System.Windows.Forms.TabPage();
            this.cbBT2HizliSatis = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.nudBT2BirimOrani = new System.Windows.Forms.NumericUpDown();
            this.nudBT2SatisFiyati = new System.Windows.Forms.NumericUpDown();
            this.nudBT2AlisFiyatiKdvli = new System.Windows.Forms.NumericUpDown();
            this.nudBT2AlisFiyati = new System.Windows.Forms.NumericUpDown();
            this.txtBT2Barkod = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cbBT2BirimTipi = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOzelKodu = new System.Windows.Forms.TextBox();
            this.cbKdvPerakende = new System.Windows.Forms.ComboBox();
            this.btnOzelKodu = new System.Windows.Forms.Button();
            this.cbKdvToptan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tpBagliStoklar = new System.Windows.Forms.TabPage();
            this.dgvBagliStoklar = new PRCTicari.MyDataGridView(this.components);
            this.colStokNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStokKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSecStokKodu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colStokAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbStokTipi = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnlBaslik.SuspendLayout();
            this.pnlDetay.SuspendLayout();
            this.tcDetay.SuspendLayout();
            this.tpGenel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlislar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTedarikciler)).BeginInit();
            this.tcBirimler.SuspendLayout();
            this.tpBirim1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBT1BirimOrani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBT1SatisFiyati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBT1AlisFiyatiKdvli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBT1AlisFiyati)).BeginInit();
            this.tpBirim2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBT2BirimOrani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBT2SatisFiyati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBT2AlisFiyatiKdvli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBT2AlisFiyati)).BeginInit();
            this.tpBagliStoklar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBagliStoklar)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statusStrip1.BackgroundImage")));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(601, 23);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 505);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 25);
            this.panel1.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbKaydet,
            this.tsbSil,
            this.tsbVazgec,
            this.toolStripSeparator1,
            this.tsbKapat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(603, 54);
            this.toolStrip1.TabIndex = 6;
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
            // tsbSil
            // 
            this.tsbSil.Image = ((System.Drawing.Image)(resources.GetObject("tsbSil.Image")));
            this.tsbSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSil.Name = "tsbSil";
            this.tsbSil.Size = new System.Drawing.Size(36, 51);
            this.tsbSil.Text = "Sil";
            this.tsbSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSil.Click += new System.EventHandler(this.tsbSil_Click);
            // 
            // tsbVazgec
            // 
            this.tsbVazgec.Image = ((System.Drawing.Image)(resources.GetObject("tsbVazgec.Image")));
            this.tsbVazgec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVazgec.Name = "tsbVazgec";
            this.tsbVazgec.Size = new System.Drawing.Size(47, 51);
            this.tsbVazgec.Text = "Vazgeç";
            this.tsbVazgec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbVazgec.Click += new System.EventHandler(this.tsbVazgec_Click);
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
            // pnlBaslik
            // 
            this.pnlBaslik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBaslik.Controls.Add(this.lblStokNo);
            this.pnlBaslik.Controls.Add(this.btnStokKodu);
            this.pnlBaslik.Controls.Add(this.txtStokKodu);
            this.pnlBaslik.Controls.Add(this.label1);
            this.pnlBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBaslik.Location = new System.Drawing.Point(0, 54);
            this.pnlBaslik.Name = "pnlBaslik";
            this.pnlBaslik.Size = new System.Drawing.Size(603, 37);
            this.pnlBaslik.TabIndex = 0;
            // 
            // lblStokNo
            // 
            this.lblStokNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStokNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStokNo.Location = new System.Drawing.Point(498, 8);
            this.lblStokNo.Name = "lblStokNo";
            this.lblStokNo.Size = new System.Drawing.Size(100, 20);
            this.lblStokNo.TabIndex = 2;
            this.lblStokNo.Text = "0";
            this.lblStokNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStokKodu
            // 
            this.btnStokKodu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStokKodu.Location = new System.Drawing.Point(171, 7);
            this.btnStokKodu.Name = "btnStokKodu";
            this.btnStokKodu.Size = new System.Drawing.Size(27, 22);
            this.btnStokKodu.TabIndex = 1;
            this.btnStokKodu.TabStop = false;
            this.btnStokKodu.Text = "...";
            this.btnStokKodu.UseVisualStyleBackColor = true;
            this.btnStokKodu.Click += new System.EventHandler(this.btnStokKodu_Click);
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(71, 8);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Size = new System.Drawing.Size(100, 20);
            this.txtStokKodu.TabIndex = 0;
            this.txtStokKodu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStokKodu_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stok Kodu:";
            // 
            // pnlDetay
            // 
            this.pnlDetay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetay.Controls.Add(this.tcDetay);
            this.pnlDetay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetay.Location = new System.Drawing.Point(0, 91);
            this.pnlDetay.Name = "pnlDetay";
            this.pnlDetay.Size = new System.Drawing.Size(603, 414);
            this.pnlDetay.TabIndex = 1;
            // 
            // tcDetay
            // 
            this.tcDetay.Controls.Add(this.tpGenel);
            this.tcDetay.Controls.Add(this.tpBagliStoklar);
            this.tcDetay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcDetay.Location = new System.Drawing.Point(0, 0);
            this.tcDetay.Name = "tcDetay";
            this.tcDetay.SelectedIndex = 0;
            this.tcDetay.Size = new System.Drawing.Size(601, 412);
            this.tcDetay.TabIndex = 25;
            // 
            // tpGenel
            // 
            this.tpGenel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tpGenel.Controls.Add(this.label15);
            this.tpGenel.Controls.Add(this.cbStokTipi);
            this.tpGenel.Controls.Add(this.dgvAlislar);
            this.tpGenel.Controls.Add(this.txtKisaAdi);
            this.tpGenel.Controls.Add(this.txtStokAdi);
            this.tpGenel.Controls.Add(this.label14);
            this.tpGenel.Controls.Add(this.label2);
            this.tpGenel.Controls.Add(this.dgvTedarikciler);
            this.tpGenel.Controls.Add(this.label3);
            this.tpGenel.Controls.Add(this.label11);
            this.tpGenel.Controls.Add(this.txtGrupKodu);
            this.tpGenel.Controls.Add(this.btnGrupKodu);
            this.tpGenel.Controls.Add(this.tcBirimler);
            this.tpGenel.Controls.Add(this.label4);
            this.tpGenel.Controls.Add(this.label6);
            this.tpGenel.Controls.Add(this.txtOzelKodu);
            this.tpGenel.Controls.Add(this.cbKdvPerakende);
            this.tpGenel.Controls.Add(this.btnOzelKodu);
            this.tpGenel.Controls.Add(this.cbKdvToptan);
            this.tpGenel.Controls.Add(this.label5);
            this.tpGenel.Location = new System.Drawing.Point(4, 22);
            this.tpGenel.Name = "tpGenel";
            this.tpGenel.Padding = new System.Windows.Forms.Padding(3);
            this.tpGenel.Size = new System.Drawing.Size(593, 386);
            this.tpGenel.TabIndex = 1;
            this.tpGenel.Text = "Genel";
            // 
            // dgvAlislar
            // 
            this.dgvAlislar.AllowUserToAddRows = false;
            this.dgvAlislar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAlislar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlislar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAlislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlislar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAy,
            this.colMiktar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlislar.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAlislar.Location = new System.Drawing.Point(432, 6);
            this.dgvAlislar.Name = "dgvAlislar";
            this.dgvAlislar.RowHeadersVisible = false;
            this.dgvAlislar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlislar.Size = new System.Drawing.Size(156, 374);
            this.dgvAlislar.TabIndex = 9;
            // 
            // colAy
            // 
            this.colAy.DataPropertyName = "Ay";
            this.colAy.HeaderText = "Ay";
            this.colAy.Name = "colAy";
            this.colAy.ReadOnly = true;
            this.colAy.Width = 60;
            // 
            // colMiktar
            // 
            this.colMiktar.DataPropertyName = "Miktar";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colMiktar.DefaultCellStyle = dataGridViewCellStyle2;
            this.colMiktar.HeaderText = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.ReadOnly = true;
            this.colMiktar.Width = 75;
            // 
            // txtKisaAdi
            // 
            this.txtKisaAdi.Location = new System.Drawing.Point(69, 32);
            this.txtKisaAdi.Name = "txtKisaAdi";
            this.txtKisaAdi.Size = new System.Drawing.Size(359, 20);
            this.txtKisaAdi.TabIndex = 1;
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Location = new System.Drawing.Point(69, 6);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Size = new System.Drawing.Size(359, 20);
            this.txtStokAdi.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Kısa Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stok Adı:";
            // 
            // dgvTedarikciler
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvTedarikciler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTedarikciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTedarikciler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTedarikciNo,
            this.colTedarikciKodu,
            this.colTedarikciSec,
            this.colTedarikciAdi});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTedarikciler.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTedarikciler.Location = new System.Drawing.Point(69, 270);
            this.dgvTedarikciler.Name = "dgvTedarikciler";
            this.dgvTedarikciler.RowHeadersWidth = 24;
            this.dgvTedarikciler.Size = new System.Drawing.Size(359, 110);
            this.dgvTedarikciler.TabIndex = 8;
            this.dgvTedarikciler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTedarikciler_CellClick);
            this.dgvTedarikciler.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTedarikciler_CellEndEdit);
            // 
            // colTedarikciNo
            // 
            this.colTedarikciNo.DataPropertyName = "Tedarikci_No";
            this.colTedarikciNo.HeaderText = "Tedarikçi No";
            this.colTedarikciNo.Name = "colTedarikciNo";
            this.colTedarikciNo.ReadOnly = true;
            this.colTedarikciNo.Visible = false;
            // 
            // colTedarikciKodu
            // 
            this.colTedarikciKodu.DataPropertyName = "Tedarikci_Kodu";
            this.colTedarikciKodu.HeaderText = "Tedarikçi Kodu";
            this.colTedarikciKodu.Name = "colTedarikciKodu";
            this.colTedarikciKodu.Width = 102;
            // 
            // colTedarikciSec
            // 
            this.colTedarikciSec.DataPropertyName = "Tedarikci_Sec";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = "...";
            this.colTedarikciSec.DefaultCellStyle = dataGridViewCellStyle5;
            this.colTedarikciSec.HeaderText = "";
            this.colTedarikciSec.Name = "colTedarikciSec";
            this.colTedarikciSec.ReadOnly = true;
            this.colTedarikciSec.Width = 30;
            // 
            // colTedarikciAdi
            // 
            this.colTedarikciAdi.DataPropertyName = "Tedarikci_Adi";
            this.colTedarikciAdi.HeaderText = "Tedarikçi Adı";
            this.colTedarikciAdi.Name = "colTedarikciAdi";
            this.colTedarikciAdi.ReadOnly = true;
            this.colTedarikciAdi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTedarikciAdi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTedarikciAdi.Width = 175;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Grup Kodu:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 274);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Tedarikçiler:";
            // 
            // txtGrupKodu
            // 
            this.txtGrupKodu.Location = new System.Drawing.Point(69, 58);
            this.txtGrupKodu.Name = "txtGrupKodu";
            this.txtGrupKodu.Size = new System.Drawing.Size(100, 20);
            this.txtGrupKodu.TabIndex = 2;
            // 
            // btnGrupKodu
            // 
            this.btnGrupKodu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrupKodu.Location = new System.Drawing.Point(169, 57);
            this.btnGrupKodu.Name = "btnGrupKodu";
            this.btnGrupKodu.Size = new System.Drawing.Size(27, 22);
            this.btnGrupKodu.TabIndex = 9;
            this.btnGrupKodu.TabStop = false;
            this.btnGrupKodu.Text = "...";
            this.btnGrupKodu.UseVisualStyleBackColor = true;
            this.btnGrupKodu.Click += new System.EventHandler(this.btnGrupKodu_Click);
            // 
            // tcBirimler
            // 
            this.tcBirimler.Controls.Add(this.tpBirim1);
            this.tcBirimler.Controls.Add(this.tpBirim2);
            this.tcBirimler.ItemSize = new System.Drawing.Size(178, 18);
            this.tcBirimler.Location = new System.Drawing.Point(69, 140);
            this.tcBirimler.Name = "tcBirimler";
            this.tcBirimler.SelectedIndex = 0;
            this.tcBirimler.Size = new System.Drawing.Size(359, 122);
            this.tcBirimler.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcBirimler.TabIndex = 7;
            this.tcBirimler.TabStop = false;
            // 
            // tpBirim1
            // 
            this.tpBirim1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tpBirim1.Controls.Add(this.cbBT1HizliSatis);
            this.tpBirim1.Controls.Add(this.label12);
            this.tpBirim1.Controls.Add(this.nudBT1BirimOrani);
            this.tpBirim1.Controls.Add(this.nudBT1SatisFiyati);
            this.tpBirim1.Controls.Add(this.nudBT1AlisFiyatiKdvli);
            this.tpBirim1.Controls.Add(this.nudBT1AlisFiyati);
            this.tpBirim1.Controls.Add(this.label10);
            this.tpBirim1.Controls.Add(this.label9);
            this.tpBirim1.Controls.Add(this.txtBT1Barkod);
            this.tpBirim1.Controls.Add(this.label21);
            this.tpBirim1.Controls.Add(this.label8);
            this.tpBirim1.Controls.Add(this.cbBT1BirimTipi);
            this.tpBirim1.Controls.Add(this.label7);
            this.tpBirim1.Location = new System.Drawing.Point(4, 22);
            this.tpBirim1.Name = "tpBirim1";
            this.tpBirim1.Padding = new System.Windows.Forms.Padding(3);
            this.tpBirim1.Size = new System.Drawing.Size(351, 96);
            this.tpBirim1.TabIndex = 0;
            this.tpBirim1.Text = "1. BİRİM";
            // 
            // cbBT1HizliSatis
            // 
            this.cbBT1HizliSatis.AutoSize = true;
            this.cbBT1HizliSatis.Location = new System.Drawing.Point(216, 33);
            this.cbBT1HizliSatis.Name = "cbBT1HizliSatis";
            this.cbBT1HizliSatis.Size = new System.Drawing.Size(71, 17);
            this.cbBT1HizliSatis.TabIndex = 3;
            this.cbBT1HizliSatis.TabStop = false;
            this.cbBT1HizliSatis.Text = "Hızlı Satış";
            this.cbBT1HizliSatis.UseVisualStyleBackColor = true;
            this.cbBT1HizliSatis.CheckedChanged += new System.EventHandler(this.cbBT1HizliSatis_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Birim Oranı:";
            // 
            // nudBT1BirimOrani
            // 
            this.nudBT1BirimOrani.DecimalPlaces = 2;
            this.nudBT1BirimOrani.Location = new System.Drawing.Point(64, 31);
            this.nudBT1BirimOrani.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.nudBT1BirimOrani.Name = "nudBT1BirimOrani";
            this.nudBT1BirimOrani.Size = new System.Drawing.Size(93, 20);
            this.nudBT1BirimOrani.TabIndex = 2;
            this.nudBT1BirimOrani.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudBT1BirimOrani.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudBT1SatisFiyati
            // 
            this.nudBT1SatisFiyati.DecimalPlaces = 4;
            this.nudBT1SatisFiyati.Location = new System.Drawing.Point(250, 70);
            this.nudBT1SatisFiyati.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.nudBT1SatisFiyati.Name = "nudBT1SatisFiyati";
            this.nudBT1SatisFiyati.Size = new System.Drawing.Size(93, 20);
            this.nudBT1SatisFiyati.TabIndex = 6;
            this.nudBT1SatisFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudBT1AlisFiyatiKdvli
            // 
            this.nudBT1AlisFiyatiKdvli.DecimalPlaces = 4;
            this.nudBT1AlisFiyatiKdvli.Location = new System.Drawing.Point(157, 70);
            this.nudBT1AlisFiyatiKdvli.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.nudBT1AlisFiyatiKdvli.Name = "nudBT1AlisFiyatiKdvli";
            this.nudBT1AlisFiyatiKdvli.Size = new System.Drawing.Size(93, 20);
            this.nudBT1AlisFiyatiKdvli.TabIndex = 5;
            this.nudBT1AlisFiyatiKdvli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudBT1AlisFiyati
            // 
            this.nudBT1AlisFiyati.DecimalPlaces = 4;
            this.nudBT1AlisFiyati.Location = new System.Drawing.Point(64, 70);
            this.nudBT1AlisFiyati.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.nudBT1AlisFiyati.Name = "nudBT1AlisFiyati";
            this.nudBT1AlisFiyati.Size = new System.Drawing.Size(93, 20);
            this.nudBT1AlisFiyati.TabIndex = 4;
            this.nudBT1AlisFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.LightSlateGray;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(250, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Satış Fiyatı";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.Color.LightSlateGray;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(157, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Alış Fiyatı (Kdv\'li)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBT1Barkod
            // 
            this.txtBT1Barkod.Location = new System.Drawing.Point(216, 6);
            this.txtBT1Barkod.Name = "txtBT1Barkod";
            this.txtBT1Barkod.Size = new System.Drawing.Size(127, 20);
            this.txtBT1Barkod.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(166, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 13);
            this.label21.TabIndex = 15;
            this.label21.Text = "Barkodu:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.LightSlateGray;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(64, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Alış Fiyatı";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbBT1BirimTipi
            // 
            this.cbBT1BirimTipi.FormattingEnabled = true;
            this.cbBT1BirimTipi.Location = new System.Drawing.Point(64, 6);
            this.cbBT1BirimTipi.Name = "cbBT1BirimTipi";
            this.cbBT1BirimTipi.Size = new System.Drawing.Size(91, 21);
            this.cbBT1BirimTipi.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Birim Tipi:";
            // 
            // tpBirim2
            // 
            this.tpBirim2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tpBirim2.Controls.Add(this.cbBT2HizliSatis);
            this.tpBirim2.Controls.Add(this.label13);
            this.tpBirim2.Controls.Add(this.nudBT2BirimOrani);
            this.tpBirim2.Controls.Add(this.nudBT2SatisFiyati);
            this.tpBirim2.Controls.Add(this.nudBT2AlisFiyatiKdvli);
            this.tpBirim2.Controls.Add(this.nudBT2AlisFiyati);
            this.tpBirim2.Controls.Add(this.txtBT2Barkod);
            this.tpBirim2.Controls.Add(this.label22);
            this.tpBirim2.Controls.Add(this.label17);
            this.tpBirim2.Controls.Add(this.label18);
            this.tpBirim2.Controls.Add(this.label19);
            this.tpBirim2.Controls.Add(this.cbBT2BirimTipi);
            this.tpBirim2.Controls.Add(this.label20);
            this.tpBirim2.Location = new System.Drawing.Point(4, 22);
            this.tpBirim2.Name = "tpBirim2";
            this.tpBirim2.Padding = new System.Windows.Forms.Padding(3);
            this.tpBirim2.Size = new System.Drawing.Size(351, 96);
            this.tpBirim2.TabIndex = 1;
            this.tpBirim2.Text = "2. BİRİM";
            // 
            // cbBT2HizliSatis
            // 
            this.cbBT2HizliSatis.AutoSize = true;
            this.cbBT2HizliSatis.Location = new System.Drawing.Point(216, 33);
            this.cbBT2HizliSatis.Name = "cbBT2HizliSatis";
            this.cbBT2HizliSatis.Size = new System.Drawing.Size(71, 17);
            this.cbBT2HizliSatis.TabIndex = 3;
            this.cbBT2HizliSatis.TabStop = false;
            this.cbBT2HizliSatis.Text = "Hızlı Satış";
            this.cbBT2HizliSatis.UseVisualStyleBackColor = true;
            this.cbBT2HizliSatis.CheckedChanged += new System.EventHandler(this.cbBT2HizliSatis_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Birim Oranı:";
            // 
            // nudBT2BirimOrani
            // 
            this.nudBT2BirimOrani.DecimalPlaces = 2;
            this.nudBT2BirimOrani.Location = new System.Drawing.Point(64, 31);
            this.nudBT2BirimOrani.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.nudBT2BirimOrani.Name = "nudBT2BirimOrani";
            this.nudBT2BirimOrani.Size = new System.Drawing.Size(93, 20);
            this.nudBT2BirimOrani.TabIndex = 2;
            this.nudBT2BirimOrani.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudBT2BirimOrani.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudBT2SatisFiyati
            // 
            this.nudBT2SatisFiyati.DecimalPlaces = 4;
            this.nudBT2SatisFiyati.Location = new System.Drawing.Point(250, 70);
            this.nudBT2SatisFiyati.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.nudBT2SatisFiyati.Name = "nudBT2SatisFiyati";
            this.nudBT2SatisFiyati.Size = new System.Drawing.Size(93, 20);
            this.nudBT2SatisFiyati.TabIndex = 6;
            this.nudBT2SatisFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudBT2AlisFiyatiKdvli
            // 
            this.nudBT2AlisFiyatiKdvli.DecimalPlaces = 4;
            this.nudBT2AlisFiyatiKdvli.Location = new System.Drawing.Point(157, 70);
            this.nudBT2AlisFiyatiKdvli.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.nudBT2AlisFiyatiKdvli.Name = "nudBT2AlisFiyatiKdvli";
            this.nudBT2AlisFiyatiKdvli.Size = new System.Drawing.Size(93, 20);
            this.nudBT2AlisFiyatiKdvli.TabIndex = 5;
            this.nudBT2AlisFiyatiKdvli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudBT2AlisFiyati
            // 
            this.nudBT2AlisFiyati.DecimalPlaces = 4;
            this.nudBT2AlisFiyati.Location = new System.Drawing.Point(64, 70);
            this.nudBT2AlisFiyati.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.nudBT2AlisFiyati.Name = "nudBT2AlisFiyati";
            this.nudBT2AlisFiyati.Size = new System.Drawing.Size(93, 20);
            this.nudBT2AlisFiyati.TabIndex = 4;
            this.nudBT2AlisFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBT2Barkod
            // 
            this.txtBT2Barkod.Location = new System.Drawing.Point(216, 6);
            this.txtBT2Barkod.Name = "txtBT2Barkod";
            this.txtBT2Barkod.Size = new System.Drawing.Size(127, 20);
            this.txtBT2Barkod.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(166, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(50, 13);
            this.label22.TabIndex = 17;
            this.label22.Text = "Barkodu:";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.BackColor = System.Drawing.Color.LightSlateGray;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Location = new System.Drawing.Point(250, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 15);
            this.label17.TabIndex = 33;
            this.label17.Text = "Satış Fiyatı";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.BackColor = System.Drawing.Color.LightSlateGray;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Location = new System.Drawing.Point(157, 55);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 15);
            this.label18.TabIndex = 32;
            this.label18.Text = "Alış Fiyatı (Kdv\'li)";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.BackColor = System.Drawing.Color.LightSlateGray;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Location = new System.Drawing.Point(64, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 15);
            this.label19.TabIndex = 31;
            this.label19.Text = "Alış Fiyatı";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbBT2BirimTipi
            // 
            this.cbBT2BirimTipi.FormattingEnabled = true;
            this.cbBT2BirimTipi.Location = new System.Drawing.Point(64, 6);
            this.cbBT2BirimTipi.Name = "cbBT2BirimTipi";
            this.cbBT2BirimTipi.Size = new System.Drawing.Size(91, 21);
            this.cbBT2BirimTipi.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 13);
            this.label20.TabIndex = 29;
            this.label20.Text = "Birim Tipi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Özel Kodu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Perakende Kdv:";
            // 
            // txtOzelKodu
            // 
            this.txtOzelKodu.Location = new System.Drawing.Point(69, 84);
            this.txtOzelKodu.Name = "txtOzelKodu";
            this.txtOzelKodu.Size = new System.Drawing.Size(100, 20);
            this.txtOzelKodu.TabIndex = 3;
            // 
            // cbKdvPerakende
            // 
            this.cbKdvPerakende.FormattingEnabled = true;
            this.cbKdvPerakende.Items.AddRange(new object[] {
            "0",
            "1",
            "8",
            "18"});
            this.cbKdvPerakende.Location = new System.Drawing.Point(306, 84);
            this.cbKdvPerakende.Name = "cbKdvPerakende";
            this.cbKdvPerakende.Size = new System.Drawing.Size(122, 21);
            this.cbKdvPerakende.TabIndex = 5;
            // 
            // btnOzelKodu
            // 
            this.btnOzelKodu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOzelKodu.Location = new System.Drawing.Point(169, 83);
            this.btnOzelKodu.Name = "btnOzelKodu";
            this.btnOzelKodu.Size = new System.Drawing.Size(27, 22);
            this.btnOzelKodu.TabIndex = 10;
            this.btnOzelKodu.TabStop = false;
            this.btnOzelKodu.Text = "...";
            this.btnOzelKodu.UseVisualStyleBackColor = true;
            this.btnOzelKodu.Click += new System.EventHandler(this.btnOzelKodu_Click);
            // 
            // cbKdvToptan
            // 
            this.cbKdvToptan.FormattingEnabled = true;
            this.cbKdvToptan.Items.AddRange(new object[] {
            "0",
            "1",
            "8",
            "18"});
            this.cbKdvToptan.Location = new System.Drawing.Point(306, 58);
            this.cbKdvToptan.Name = "cbKdvToptan";
            this.cbKdvToptan.Size = new System.Drawing.Size(122, 21);
            this.cbKdvToptan.TabIndex = 4;
            this.cbKdvToptan.SelectedIndexChanged += new System.EventHandler(this.nudBT1AlisFiyati_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Toptan Kdv:";
            // 
            // tpBagliStoklar
            // 
            this.tpBagliStoklar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tpBagliStoklar.Controls.Add(this.dgvBagliStoklar);
            this.tpBagliStoklar.Location = new System.Drawing.Point(4, 22);
            this.tpBagliStoklar.Name = "tpBagliStoklar";
            this.tpBagliStoklar.Padding = new System.Windows.Forms.Padding(3);
            this.tpBagliStoklar.Size = new System.Drawing.Size(593, 386);
            this.tpBagliStoklar.TabIndex = 2;
            this.tpBagliStoklar.Text = "Bağlı Stoklar";
            // 
            // dgvBagliStoklar
            // 
            this.dgvBagliStoklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBagliStoklar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStokNo,
            this.colStokKodu,
            this.colSecStokKodu,
            this.colStokAdi});
            this.dgvBagliStoklar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBagliStoklar.Location = new System.Drawing.Point(3, 3);
            this.dgvBagliStoklar.Name = "dgvBagliStoklar";
            this.dgvBagliStoklar.RowHeadersWidth = 24;
            this.dgvBagliStoklar.Size = new System.Drawing.Size(587, 380);
            this.dgvBagliStoklar.TabIndex = 0;
            this.dgvBagliStoklar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBagliStoklar_CellClick);
            this.dgvBagliStoklar.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBagliStoklar_CellEndEdit);
            // 
            // colStokNo
            // 
            this.colStokNo.DataPropertyName = "Stok_No";
            this.colStokNo.HeaderText = "Stok No";
            this.colStokNo.Name = "colStokNo";
            this.colStokNo.ReadOnly = true;
            this.colStokNo.Visible = false;
            // 
            // colStokKodu
            // 
            this.colStokKodu.DataPropertyName = "Stok_Kodu";
            this.colStokKodu.HeaderText = "Stok Kodu";
            this.colStokKodu.Name = "colStokKodu";
            // 
            // colSecStokKodu
            // 
            this.colSecStokKodu.DataPropertyName = "Sec_Stok_Kodu";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = "...";
            this.colSecStokKodu.DefaultCellStyle = dataGridViewCellStyle7;
            this.colSecStokKodu.HeaderText = "";
            this.colSecStokKodu.Name = "colSecStokKodu";
            this.colSecStokKodu.ReadOnly = true;
            this.colSecStokKodu.Width = 30;
            // 
            // colStokAdi
            // 
            this.colStokAdi.DataPropertyName = "Stok_Adi";
            this.colStokAdi.HeaderText = "Stok Adı";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.ReadOnly = true;
            this.colStokAdi.Width = 250;
            // 
            // cbStokTipi
            // 
            this.cbStokTipi.FormattingEnabled = true;
            this.cbStokTipi.Items.AddRange(new object[] {
            "Ticari Mal",
            "Mamul",
            "Yarı Mamul",
            "Hammadde",
            "Çeşni"});
            this.cbStokTipi.Location = new System.Drawing.Point(69, 110);
            this.cbStokTipi.Name = "cbStokTipi";
            this.cbStokTipi.Size = new System.Drawing.Size(125, 21);
            this.cbStokTipi.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Stok Tipi:";
            // 
            // frmStokKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(603, 530);
            this.Controls.Add(this.pnlDetay);
            this.Controls.Add(this.pnlBaslik);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmStokKarti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Kartı";
            this.Shown += new System.EventHandler(this.frmStokKarti_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStokKarti_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlBaslik.ResumeLayout(false);
            this.pnlBaslik.PerformLayout();
            this.pnlDetay.ResumeLayout(false);
            this.tcDetay.ResumeLayout(false);
            this.tpGenel.ResumeLayout(false);
            this.tpGenel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlislar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTedarikciler)).EndInit();
            this.tcBirimler.ResumeLayout(false);
            this.tpBirim1.ResumeLayout(false);
            this.tpBirim1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBT1BirimOrani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBT1SatisFiyati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBT1AlisFiyatiKdvli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBT1AlisFiyati)).EndInit();
            this.tpBirim2.ResumeLayout(false);
            this.tpBirim2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBT2BirimOrani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBT2SatisFiyati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBT2AlisFiyatiKdvli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBT2AlisFiyati)).EndInit();
            this.tpBagliStoklar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBagliStoklar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbKaydet;
        private System.Windows.Forms.ToolStripButton tsbSil;
        private System.Windows.Forms.ToolStripButton tsbVazgec;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbKapat;
        private System.Windows.Forms.Panel pnlBaslik;
        private System.Windows.Forms.Panel pnlDetay;
        private System.Windows.Forms.Button btnStokKodu;
        private System.Windows.Forms.TextBox txtStokKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStokNo;
        private System.Windows.Forms.Button btnOzelKodu;
        private System.Windows.Forms.TextBox txtOzelKodu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGrupKodu;
        private System.Windows.Forms.TextBox txtGrupKodu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStokAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbKdvPerakende;
        private System.Windows.Forms.ComboBox cbKdvToptan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tcBirimler;
        private System.Windows.Forms.TabPage tpBirim1;
        private System.Windows.Forms.TabPage tpBirim2;
        private System.Windows.Forms.ComboBox cbBT1BirimTipi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudBT1SatisFiyati;
        private System.Windows.Forms.NumericUpDown nudBT1AlisFiyatiKdvli;
        private System.Windows.Forms.NumericUpDown nudBT1AlisFiyati;
        private System.Windows.Forms.NumericUpDown nudBT2SatisFiyati;
        private System.Windows.Forms.NumericUpDown nudBT2AlisFiyatiKdvli;
        private System.Windows.Forms.NumericUpDown nudBT2AlisFiyati;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbBT2BirimTipi;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtBT2Barkod;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtBT1Barkod;
        private System.Windows.Forms.Label label21;
        private MyDataGridView dgvTedarikciler;
        private System.Windows.Forms.Label label11;
        private MyDataGridView dgvAlislar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudBT1BirimOrani;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudBT2BirimOrani;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTedarikciNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTedarikciKodu;
        private System.Windows.Forms.DataGridViewButtonColumn colTedarikciSec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTedarikciAdi;
        private System.Windows.Forms.TextBox txtKisaAdi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox cbBT1HizliSatis;
        private System.Windows.Forms.CheckBox cbBT2HizliSatis;
        private System.Windows.Forms.TabControl tcDetay;
        private System.Windows.Forms.TabPage tpGenel;
        private System.Windows.Forms.TabPage tpBagliStoklar;
        private MyDataGridView dgvBagliStoklar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStokNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStokKodu;
        private System.Windows.Forms.DataGridViewButtonColumn colSecStokKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStokAdi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbStokTipi;
    }
}