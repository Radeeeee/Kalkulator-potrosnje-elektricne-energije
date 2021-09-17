namespace KalkulatorPotrosnjeElektricneEnergije
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.timerClk = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podešavanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelTarifa = new System.Windows.Forms.TableLayoutPanel();
            this.btnOcistiPolja = new System.Windows.Forms.Button();
            this.lblSezonaObracuna = new System.Windows.Forms.Label();
            this.txtBoxPotrosnjaNizaTarifa = new System.Windows.Forms.TextBox();
            this.comboBoxSezonaObracuna = new System.Windows.Forms.ComboBox();
            this.lblTarifnaGrupa = new System.Windows.Forms.Label();
            this.comboBoxTarifnaGrupa = new System.Windows.Forms.ComboBox();
            this.lblPotrosnjaVisaTarifa = new System.Windows.Forms.Label();
            this.lblPotrosnjaNizaTarifa = new System.Windows.Forms.Label();
            this.txtBoxPotrosnjaVisaTarifa = new System.Windows.Forms.TextBox();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.lblKw = new System.Windows.Forms.Label();
            this.lblkWSec = new System.Windows.Forms.Label();
            this.tableLayoutPanelKalkulacija = new System.Windows.Forms.TableLayoutPanel();
            this.lblKalkZaJedanMjesec = new System.Windows.Forms.Label();
            this.lblPretplata = new System.Windows.Forms.Label();
            this.lblPretplataCijena = new System.Windows.Forms.Label();
            this.lblPotrosnjaVT = new System.Windows.Forms.Label();
            this.lblPotrosnjaNT = new System.Windows.Forms.Label();
            this.lblNaknadaZaUS = new System.Windows.Forms.Label();
            this.lblNaknadaZaOI = new System.Windows.Forms.Label();
            this.lblPotrosnjaVTCijena = new System.Windows.Forms.Label();
            this.lblPotrosnjaNTCijena = new System.Windows.Forms.Label();
            this.lblNaknadaZaUSCijena = new System.Windows.Forms.Label();
            this.lblNaknadaZaOICijena = new System.Windows.Forms.Label();
            this.lblUkupanIznos = new System.Windows.Forms.Label();
            this.lblIznosRacuna = new System.Windows.Forms.Label();
            this.pictureBoxLine = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanelTarifa.SuspendLayout();
            this.tableLayoutPanelKalkulacija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).BeginInit();
            this.SuspendLayout();
            // 
            // timerClk
            // 
            this.timerClk.Enabled = true;
            this.timerClk.Interval = 1000;
            this.timerClk.Tick += new System.EventHandler(this.timerClk_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(864, 341);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(864, 25);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem
            // 
            this.toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podešavanjaToolStripMenuItem,
            this.toolStripSeparator1,
            this.izlazToolStripMenuItem});
            this.toolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem.Name = "toolStripMenuItem";
            this.toolStripMenuItem.Size = new System.Drawing.Size(49, 21);
            this.toolStripMenuItem.Text = "Meni";
            // 
            // podešavanjaToolStripMenuItem
            // 
            this.podešavanjaToolStripMenuItem.Image = global::KalkulatorPotrosnjeElektricneEnergije.Properties.Resources.mechanical_gears_;
            this.podešavanjaToolStripMenuItem.Name = "podešavanjaToolStripMenuItem";
            this.podešavanjaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.podešavanjaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.podešavanjaToolStripMenuItem.Text = "Podešavanja";
            this.podešavanjaToolStripMenuItem.Click += new System.EventHandler(this.podešavanjaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Image = global::KalkulatorPotrosnjeElektricneEnergije.Properties.Resources.logout__1_;
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelDateTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 319);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(864, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelDateTime
            // 
            this.toolStripStatusLabelDateTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelDateTime.Name = "toolStripStatusLabelDateTime";
            this.toolStripStatusLabelDateTime.Size = new System.Drawing.Size(93, 17);
            this.toolStripStatusLabelDateTime.Text = "Date and Time";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanelTarifa, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanelKalkulacija, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(858, 280);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanelTarifa
            // 
            this.tableLayoutPanelTarifa.AllowDrop = true;
            this.tableLayoutPanelTarifa.ColumnCount = 4;
            this.tableLayoutPanelTarifa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanelTarifa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanelTarifa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanelTarifa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanelTarifa.Controls.Add(this.btnOcistiPolja, 0, 7);
            this.tableLayoutPanelTarifa.Controls.Add(this.lblSezonaObracuna, 0, 4);
            this.tableLayoutPanelTarifa.Controls.Add(this.txtBoxPotrosnjaNizaTarifa, 2, 3);
            this.tableLayoutPanelTarifa.Controls.Add(this.comboBoxSezonaObracuna, 0, 5);
            this.tableLayoutPanelTarifa.Controls.Add(this.lblTarifnaGrupa, 0, 0);
            this.tableLayoutPanelTarifa.Controls.Add(this.comboBoxTarifnaGrupa, 0, 1);
            this.tableLayoutPanelTarifa.Controls.Add(this.lblPotrosnjaVisaTarifa, 0, 2);
            this.tableLayoutPanelTarifa.Controls.Add(this.lblPotrosnjaNizaTarifa, 2, 2);
            this.tableLayoutPanelTarifa.Controls.Add(this.txtBoxPotrosnjaVisaTarifa, 0, 3);
            this.tableLayoutPanelTarifa.Controls.Add(this.btnIzracunaj, 0, 6);
            this.tableLayoutPanelTarifa.Controls.Add(this.lblKw, 1, 3);
            this.tableLayoutPanelTarifa.Controls.Add(this.lblkWSec, 3, 3);
            this.tableLayoutPanelTarifa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTarifa.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelTarifa.Name = "tableLayoutPanelTarifa";
            this.tableLayoutPanelTarifa.RowCount = 8;
            this.tableLayoutPanelTarifa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanelTarifa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanelTarifa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanelTarifa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanelTarifa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanelTarifa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanelTarifa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanelTarifa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanelTarifa.Size = new System.Drawing.Size(294, 274);
            this.tableLayoutPanelTarifa.TabIndex = 2;
            // 
            // btnOcistiPolja
            // 
            this.btnOcistiPolja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOcistiPolja.BackColor = System.Drawing.Color.DarkCyan;
            this.tableLayoutPanelTarifa.SetColumnSpan(this.btnOcistiPolja, 4);
            this.btnOcistiPolja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcistiPolja.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOcistiPolja.Location = new System.Drawing.Point(3, 237);
            this.btnOcistiPolja.Name = "btnOcistiPolja";
            this.btnOcistiPolja.Size = new System.Drawing.Size(288, 30);
            this.btnOcistiPolja.TabIndex = 14;
            this.btnOcistiPolja.Text = "Očisti polja";
            this.btnOcistiPolja.UseVisualStyleBackColor = false;
            this.btnOcistiPolja.Click += new System.EventHandler(this.btnOcistiPolja_Click);
            // 
            // lblSezonaObracuna
            // 
            this.lblSezonaObracuna.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSezonaObracuna.AutoSize = true;
            this.tableLayoutPanelTarifa.SetColumnSpan(this.lblSezonaObracuna, 4);
            this.lblSezonaObracuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSezonaObracuna.Location = new System.Drawing.Point(3, 136);
            this.lblSezonaObracuna.Name = "lblSezonaObracuna";
            this.lblSezonaObracuna.Size = new System.Drawing.Size(114, 16);
            this.lblSezonaObracuna.TabIndex = 13;
            this.lblSezonaObracuna.Text = "Sezona obračuna";
            // 
            // txtBoxPotrosnjaNizaTarifa
            // 
            this.txtBoxPotrosnjaNizaTarifa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPotrosnjaNizaTarifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPotrosnjaNizaTarifa.Location = new System.Drawing.Point(149, 101);
            this.txtBoxPotrosnjaNizaTarifa.Name = "txtBoxPotrosnjaNizaTarifa";
            this.txtBoxPotrosnjaNizaTarifa.Size = new System.Drawing.Size(105, 22);
            this.txtBoxPotrosnjaNizaTarifa.TabIndex = 12;
            this.txtBoxPotrosnjaNizaTarifa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPotrosnjaVisaTarifa_KeyPress);
            // 
            // comboBoxSezonaObracuna
            // 
            this.tableLayoutPanelTarifa.SetColumnSpan(this.comboBoxSezonaObracuna, 4);
            this.comboBoxSezonaObracuna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSezonaObracuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSezonaObracuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSezonaObracuna.FormattingEnabled = true;
            this.comboBoxSezonaObracuna.Items.AddRange(new object[] {
            "1. Viša - Zimska (01.10. - 31.03.)",
            "2. Niža - Ljetna (01.04. - 30.09.)"});
            this.comboBoxSezonaObracuna.Location = new System.Drawing.Point(3, 163);
            this.comboBoxSezonaObracuna.Name = "comboBoxSezonaObracuna";
            this.comboBoxSezonaObracuna.Size = new System.Drawing.Size(288, 24);
            this.comboBoxSezonaObracuna.TabIndex = 9;
            // 
            // lblTarifnaGrupa
            // 
            this.lblTarifnaGrupa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTarifnaGrupa.AutoSize = true;
            this.tableLayoutPanelTarifa.SetColumnSpan(this.lblTarifnaGrupa, 4);
            this.lblTarifnaGrupa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarifnaGrupa.Location = new System.Drawing.Point(3, 8);
            this.lblTarifnaGrupa.Name = "lblTarifnaGrupa";
            this.lblTarifnaGrupa.Size = new System.Drawing.Size(88, 16);
            this.lblTarifnaGrupa.TabIndex = 0;
            this.lblTarifnaGrupa.Text = "Tarifna grupa";
            // 
            // comboBoxTarifnaGrupa
            // 
            this.tableLayoutPanelTarifa.SetColumnSpan(this.comboBoxTarifnaGrupa, 4);
            this.comboBoxTarifnaGrupa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxTarifnaGrupa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTarifnaGrupa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTarifnaGrupa.FormattingEnabled = true;
            this.comboBoxTarifnaGrupa.Items.AddRange(new object[] {
            "1. Tarifna grupa (jednotarifno brojilo)",
            "2. Tarifna grupa (dvotarifno brojilo)"});
            this.comboBoxTarifnaGrupa.Location = new System.Drawing.Point(3, 35);
            this.comboBoxTarifnaGrupa.Name = "comboBoxTarifnaGrupa";
            this.comboBoxTarifnaGrupa.Size = new System.Drawing.Size(288, 24);
            this.comboBoxTarifnaGrupa.TabIndex = 1;
            // 
            // lblPotrosnjaVisaTarifa
            // 
            this.lblPotrosnjaVisaTarifa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPotrosnjaVisaTarifa.AutoSize = true;
            this.tableLayoutPanelTarifa.SetColumnSpan(this.lblPotrosnjaVisaTarifa, 2);
            this.lblPotrosnjaVisaTarifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotrosnjaVisaTarifa.Location = new System.Drawing.Point(3, 72);
            this.lblPotrosnjaVisaTarifa.Name = "lblPotrosnjaVisaTarifa";
            this.lblPotrosnjaVisaTarifa.Size = new System.Drawing.Size(140, 16);
            this.lblPotrosnjaVisaTarifa.TabIndex = 2;
            this.lblPotrosnjaVisaTarifa.Text = "Potrošnja viša tarifa";
            this.lblPotrosnjaVisaTarifa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPotrosnjaNizaTarifa
            // 
            this.lblPotrosnjaNizaTarifa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPotrosnjaNizaTarifa.AutoSize = true;
            this.tableLayoutPanelTarifa.SetColumnSpan(this.lblPotrosnjaNizaTarifa, 2);
            this.lblPotrosnjaNizaTarifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotrosnjaNizaTarifa.Location = new System.Drawing.Point(149, 72);
            this.lblPotrosnjaNizaTarifa.Name = "lblPotrosnjaNizaTarifa";
            this.lblPotrosnjaNizaTarifa.Size = new System.Drawing.Size(142, 16);
            this.lblPotrosnjaNizaTarifa.TabIndex = 3;
            this.lblPotrosnjaNizaTarifa.Text = "Potrošnja niža tarifa";
            this.lblPotrosnjaNizaTarifa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxPotrosnjaVisaTarifa
            // 
            this.txtBoxPotrosnjaVisaTarifa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPotrosnjaVisaTarifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPotrosnjaVisaTarifa.Location = new System.Drawing.Point(3, 101);
            this.txtBoxPotrosnjaVisaTarifa.Name = "txtBoxPotrosnjaVisaTarifa";
            this.txtBoxPotrosnjaVisaTarifa.Size = new System.Drawing.Size(105, 22);
            this.txtBoxPotrosnjaVisaTarifa.TabIndex = 4;
            this.txtBoxPotrosnjaVisaTarifa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPotrosnjaVisaTarifa_KeyPress);
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzracunaj.BackColor = System.Drawing.Color.DarkCyan;
            this.tableLayoutPanelTarifa.SetColumnSpan(this.btnIzracunaj, 4);
            this.btnIzracunaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzracunaj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIzracunaj.Location = new System.Drawing.Point(3, 196);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(288, 30);
            this.btnIzracunaj.TabIndex = 10;
            this.btnIzracunaj.Text = "Izračunaj";
            this.btnIzracunaj.UseVisualStyleBackColor = false;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // lblKw
            // 
            this.lblKw.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKw.AutoSize = true;
            this.lblKw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKw.Location = new System.Drawing.Point(115, 104);
            this.lblKw.Name = "lblKw";
            this.lblKw.Size = new System.Drawing.Size(28, 16);
            this.lblKw.TabIndex = 15;
            this.lblKw.Text = "kW";
            this.lblKw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblkWSec
            // 
            this.lblkWSec.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblkWSec.AutoSize = true;
            this.lblkWSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkWSec.Location = new System.Drawing.Point(263, 104);
            this.lblkWSec.Name = "lblkWSec";
            this.lblkWSec.Size = new System.Drawing.Size(28, 16);
            this.lblkWSec.TabIndex = 16;
            this.lblkWSec.Text = "kW";
            this.lblkWSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanelKalkulacija
            // 
            this.tableLayoutPanelKalkulacija.ColumnCount = 3;
            this.tableLayoutPanelKalkulacija.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelKalkulacija.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanelKalkulacija.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanelKalkulacija.Controls.Add(this.lblKalkZaJedanMjesec, 0, 0);
            this.tableLayoutPanelKalkulacija.Controls.Add(this.lblPretplata, 0, 1);
            this.tableLayoutPanelKalkulacija.Controls.Add(this.lblPretplataCijena, 1, 1);
            this.tableLayoutPanelKalkulacija.Controls.Add(this.lblPotrosnjaVT, 0, 2);
            this.tableLayoutPanelKalkulacija.Controls.Add(this.lblPotrosnjaNT, 0, 3);
            this.tableLayoutPanelKalkulacija.Controls.Add(this.lblNaknadaZaUS, 0, 4);
            this.tableLayoutPanelKalkulacija.Controls.Add(this.lblNaknadaZaOI, 0, 5);
            this.tableLayoutPanelKalkulacija.Controls.Add(this.lblPotrosnjaVTCijena, 1, 2);
            this.tableLayoutPanelKalkulacija.Controls.Add(this.lblPotrosnjaNTCijena, 1, 3);
            this.tableLayoutPanelKalkulacija.Controls.Add(this.lblNaknadaZaUSCijena, 1, 4);
            this.tableLayoutPanelKalkulacija.Controls.Add(this.lblNaknadaZaOICijena, 1, 5);
            this.tableLayoutPanelKalkulacija.Controls.Add(this.lblUkupanIznos, 0, 7);
            this.tableLayoutPanelKalkulacija.Controls.Add(this.lblIznosRacuna, 1, 7);
            this.tableLayoutPanelKalkulacija.Controls.Add(this.pictureBoxLine, 0, 6);
            this.tableLayoutPanelKalkulacija.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelKalkulacija.Location = new System.Drawing.Point(388, 3);
            this.tableLayoutPanelKalkulacija.Name = "tableLayoutPanelKalkulacija";
            this.tableLayoutPanelKalkulacija.RowCount = 8;
            this.tableLayoutPanelKalkulacija.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanelKalkulacija.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanelKalkulacija.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanelKalkulacija.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanelKalkulacija.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanelKalkulacija.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanelKalkulacija.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanelKalkulacija.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanelKalkulacija.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelKalkulacija.Size = new System.Drawing.Size(467, 274);
            this.tableLayoutPanelKalkulacija.TabIndex = 3;
            // 
            // lblKalkZaJedanMjesec
            // 
            this.lblKalkZaJedanMjesec.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKalkZaJedanMjesec.AutoSize = true;
            this.lblKalkZaJedanMjesec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKalkZaJedanMjesec.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblKalkZaJedanMjesec.Location = new System.Drawing.Point(3, 11);
            this.lblKalkZaJedanMjesec.Name = "lblKalkZaJedanMjesec";
            this.lblKalkZaJedanMjesec.Size = new System.Drawing.Size(270, 16);
            this.lblKalkZaJedanMjesec.TabIndex = 0;
            this.lblKalkZaJedanMjesec.Text = "Kalkulacija potrošnje za jedan mjesec";
            // 
            // lblPretplata
            // 
            this.lblPretplata.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPretplata.AutoSize = true;
            this.lblPretplata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretplata.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblPretplata.Location = new System.Drawing.Point(261, 46);
            this.lblPretplata.Name = "lblPretplata";
            this.lblPretplata.Size = new System.Drawing.Size(62, 16);
            this.lblPretplata.TabIndex = 1;
            this.lblPretplata.Text = "Pretplata";
            // 
            // lblPretplataCijena
            // 
            this.lblPretplataCijena.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPretplataCijena.AutoSize = true;
            this.lblPretplataCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretplataCijena.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblPretplataCijena.Location = new System.Drawing.Point(364, 46);
            this.lblPretplataCijena.Name = "lblPretplataCijena";
            this.lblPretplataCijena.Size = new System.Drawing.Size(61, 16);
            this.lblPretplataCijena.TabIndex = 2;
            this.lblPretplataCijena.Text = "00.00 KM";
            // 
            // lblPotrosnjaVT
            // 
            this.lblPotrosnjaVT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPotrosnjaVT.AutoSize = true;
            this.lblPotrosnjaVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotrosnjaVT.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblPotrosnjaVT.Location = new System.Drawing.Point(198, 78);
            this.lblPotrosnjaVT.Name = "lblPotrosnjaVT";
            this.lblPotrosnjaVT.Size = new System.Drawing.Size(125, 16);
            this.lblPotrosnjaVT.TabIndex = 3;
            this.lblPotrosnjaVT.Text = "Potrošnja viša tarifa";
            // 
            // lblPotrosnjaNT
            // 
            this.lblPotrosnjaNT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPotrosnjaNT.AutoSize = true;
            this.lblPotrosnjaNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotrosnjaNT.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblPotrosnjaNT.Location = new System.Drawing.Point(199, 110);
            this.lblPotrosnjaNT.Name = "lblPotrosnjaNT";
            this.lblPotrosnjaNT.Size = new System.Drawing.Size(124, 16);
            this.lblPotrosnjaNT.TabIndex = 4;
            this.lblPotrosnjaNT.Text = "Potrošnja niža tarifa";
            // 
            // lblNaknadaZaUS
            // 
            this.lblNaknadaZaUS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNaknadaZaUS.AutoSize = true;
            this.lblNaknadaZaUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaknadaZaUS.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblNaknadaZaUS.Location = new System.Drawing.Point(115, 142);
            this.lblNaknadaZaUS.Name = "lblNaknadaZaUS";
            this.lblNaknadaZaUS.Size = new System.Drawing.Size(208, 16);
            this.lblNaknadaZaUS.TabIndex = 5;
            this.lblNaknadaZaUS.Text = "Naknada za uslugu snabdjevanja";
            // 
            // lblNaknadaZaOI
            // 
            this.lblNaknadaZaOI.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNaknadaZaOI.AutoSize = true;
            this.lblNaknadaZaOI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaknadaZaOI.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblNaknadaZaOI.Location = new System.Drawing.Point(25, 174);
            this.lblNaknadaZaOI.Name = "lblNaknadaZaOI";
            this.lblNaknadaZaOI.Size = new System.Drawing.Size(298, 16);
            this.lblNaknadaZaOI.TabIndex = 6;
            this.lblNaknadaZaOI.Text = "Naknada za obnovljive izvore električne energije";
            // 
            // lblPotrosnjaVTCijena
            // 
            this.lblPotrosnjaVTCijena.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPotrosnjaVTCijena.AutoSize = true;
            this.lblPotrosnjaVTCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotrosnjaVTCijena.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblPotrosnjaVTCijena.Location = new System.Drawing.Point(364, 78);
            this.lblPotrosnjaVTCijena.Name = "lblPotrosnjaVTCijena";
            this.lblPotrosnjaVTCijena.Size = new System.Drawing.Size(61, 16);
            this.lblPotrosnjaVTCijena.TabIndex = 7;
            this.lblPotrosnjaVTCijena.Text = "00.00 KM";
            // 
            // lblPotrosnjaNTCijena
            // 
            this.lblPotrosnjaNTCijena.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPotrosnjaNTCijena.AutoSize = true;
            this.lblPotrosnjaNTCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotrosnjaNTCijena.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblPotrosnjaNTCijena.Location = new System.Drawing.Point(364, 110);
            this.lblPotrosnjaNTCijena.Name = "lblPotrosnjaNTCijena";
            this.lblPotrosnjaNTCijena.Size = new System.Drawing.Size(61, 16);
            this.lblPotrosnjaNTCijena.TabIndex = 8;
            this.lblPotrosnjaNTCijena.Text = "00.00 KM";
            // 
            // lblNaknadaZaUSCijena
            // 
            this.lblNaknadaZaUSCijena.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNaknadaZaUSCijena.AutoSize = true;
            this.lblNaknadaZaUSCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaknadaZaUSCijena.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblNaknadaZaUSCijena.Location = new System.Drawing.Point(364, 142);
            this.lblNaknadaZaUSCijena.Name = "lblNaknadaZaUSCijena";
            this.lblNaknadaZaUSCijena.Size = new System.Drawing.Size(61, 16);
            this.lblNaknadaZaUSCijena.TabIndex = 9;
            this.lblNaknadaZaUSCijena.Text = "00.00 KM";
            // 
            // lblNaknadaZaOICijena
            // 
            this.lblNaknadaZaOICijena.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNaknadaZaOICijena.AutoSize = true;
            this.lblNaknadaZaOICijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaknadaZaOICijena.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblNaknadaZaOICijena.Location = new System.Drawing.Point(364, 174);
            this.lblNaknadaZaOICijena.Name = "lblNaknadaZaOICijena";
            this.lblNaknadaZaOICijena.Size = new System.Drawing.Size(61, 16);
            this.lblNaknadaZaOICijena.TabIndex = 10;
            this.lblNaknadaZaOICijena.Text = "00.00 KM";
            // 
            // lblUkupanIznos
            // 
            this.lblUkupanIznos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUkupanIznos.AutoSize = true;
            this.lblUkupanIznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkupanIznos.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblUkupanIznos.Location = new System.Drawing.Point(3, 244);
            this.lblUkupanIznos.Name = "lblUkupanIznos";
            this.lblUkupanIznos.Size = new System.Drawing.Size(271, 16);
            this.lblUkupanIznos.TabIndex = 11;
            this.lblUkupanIznos.Text = "Ukupan iznos računa sa PDV-om u KM";
            // 
            // lblIznosRacuna
            // 
            this.lblIznosRacuna.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblIznosRacuna.AutoSize = true;
            this.lblIznosRacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIznosRacuna.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblIznosRacuna.Location = new System.Drawing.Point(356, 244);
            this.lblIznosRacuna.Name = "lblIznosRacuna";
            this.lblIznosRacuna.Size = new System.Drawing.Size(69, 16);
            this.lblIznosRacuna.TabIndex = 12;
            this.lblIznosRacuna.Text = "00.00 KM";
            // 
            // pictureBoxLine
            // 
            this.pictureBoxLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelKalkulacija.SetColumnSpan(this.pictureBoxLine, 2);
            this.pictureBoxLine.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLine.Image")));
            this.pictureBoxLine.Location = new System.Drawing.Point(3, 213);
            this.pictureBoxLine.Name = "pictureBoxLine";
            this.pictureBoxLine.Size = new System.Drawing.Size(422, 2);
            this.pictureBoxLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLine.TabIndex = 13;
            this.pictureBoxLine.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 341);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 520);
            this.MinimumSize = new System.Drawing.Size(880, 380);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator potrošnje električne energije";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanelTarifa.ResumeLayout(false);
            this.tableLayoutPanelTarifa.PerformLayout();
            this.tableLayoutPanelKalkulacija.ResumeLayout(false);
            this.tableLayoutPanelKalkulacija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerClk;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podešavanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDateTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTarifa;
        private System.Windows.Forms.Button btnOcistiPolja;
        private System.Windows.Forms.Label lblSezonaObracuna;
        private System.Windows.Forms.TextBox txtBoxPotrosnjaNizaTarifa;
        private System.Windows.Forms.ComboBox comboBoxSezonaObracuna;
        private System.Windows.Forms.Label lblTarifnaGrupa;
        private System.Windows.Forms.ComboBox comboBoxTarifnaGrupa;
        private System.Windows.Forms.Label lblPotrosnjaVisaTarifa;
        private System.Windows.Forms.Label lblPotrosnjaNizaTarifa;
        private System.Windows.Forms.TextBox txtBoxPotrosnjaVisaTarifa;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.Label lblKw;
        private System.Windows.Forms.Label lblkWSec;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelKalkulacija;
        private System.Windows.Forms.Label lblKalkZaJedanMjesec;
        private System.Windows.Forms.Label lblPretplata;
        private System.Windows.Forms.Label lblPretplataCijena;
        private System.Windows.Forms.Label lblPotrosnjaVT;
        private System.Windows.Forms.Label lblPotrosnjaNT;
        private System.Windows.Forms.Label lblNaknadaZaUS;
        private System.Windows.Forms.Label lblNaknadaZaOI;
        private System.Windows.Forms.Label lblPotrosnjaVTCijena;
        private System.Windows.Forms.Label lblPotrosnjaNTCijena;
        private System.Windows.Forms.Label lblNaknadaZaUSCijena;
        private System.Windows.Forms.Label lblNaknadaZaOICijena;
        private System.Windows.Forms.Label lblUkupanIznos;
        private System.Windows.Forms.Label lblIznosRacuna;
        private System.Windows.Forms.PictureBox pictureBoxLine;
    }
}

