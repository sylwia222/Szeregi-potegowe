namespace projekt2_Karpowicz
{
    partial class SzeregLaboratoryjny
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtEps = new System.Windows.Forms.TextBox();
            this.txtSumaSzeregu = new System.Windows.Forms.TextBox();
            this.txtLicznikWyrazowSzeregu = new System.Windows.Forms.TextBox();
            this.btnObliczWartoscSzeregu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnWizualizacjaTabelaryczna = new System.Windows.Forms.Button();
            this.btnWizualizacjaGraficzna = new System.Windows.Forms.Button();
            this.btnResetuj = new System.Windows.Forms.Button();
            this.txtXd = new System.Windows.Forms.TextBox();
            this.txtXg = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvTWS = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszTabelaryczneZestawienieZmianWartościSzereguPotęgowegoWPlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajZPlikuTabelaryczneZestawienieZmianWartościSzereguPotęgowegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjścieExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typWykresuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wykresLiniowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wykresPunktowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wykresKolumnowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wykresSłupkowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koloryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorTłaWykresuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorLiniiWykresuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stylLiniiWykresuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liniaKreskowaDashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liniaKreskowoKropkowaDashDotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liniaKreskowoKropkowaKropkowaDashDotDotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liniaKropkowaDotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liniaCiaglaSolidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grubośćLiniiWykresuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.czcionkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czcionkaOpisuWykresuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czcionkaOpisuFormularzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chtWykresSzeregu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTWS)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtWykresSzeregu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(433, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Analizator laboratoryjnego szeregu potęgowego";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(1062, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Obliczona wartośc szeregu ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(1074, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Licznik zsumowanych \r\nwyrazów szeregu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(36, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wartość zmiennej niezależnej X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(36, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 38);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dokładność obliczania\r\nsumy szeregu Eps";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(112, 104);
            this.txtX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(124, 27);
            this.txtX.TabIndex = 5;
            // 
            // txtEps
            // 
            this.txtEps.Location = new System.Drawing.Point(109, 191);
            this.txtEps.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEps.Name = "txtEps";
            this.txtEps.Size = new System.Drawing.Size(124, 27);
            this.txtEps.TabIndex = 6;
            // 
            // txtSumaSzeregu
            // 
            this.txtSumaSzeregu.Location = new System.Drawing.Point(1114, 104);
            this.txtSumaSzeregu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSumaSzeregu.Name = "txtSumaSzeregu";
            this.txtSumaSzeregu.ReadOnly = true;
            this.txtSumaSzeregu.Size = new System.Drawing.Size(124, 27);
            this.txtSumaSzeregu.TabIndex = 7;
            this.txtSumaSzeregu.TextChanged += new System.EventHandler(this.txtSumaSzeregu_TextChanged);
            // 
            // txtLicznikWyrazowSzeregu
            // 
            this.txtLicznikWyrazowSzeregu.Location = new System.Drawing.Point(1114, 191);
            this.txtLicznikWyrazowSzeregu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLicznikWyrazowSzeregu.Name = "txtLicznikWyrazowSzeregu";
            this.txtLicznikWyrazowSzeregu.ReadOnly = true;
            this.txtLicznikWyrazowSzeregu.Size = new System.Drawing.Size(124, 27);
            this.txtLicznikWyrazowSzeregu.TabIndex = 8;
            // 
            // btnObliczWartoscSzeregu
            // 
            this.btnObliczWartoscSzeregu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObliczWartoscSzeregu.Location = new System.Drawing.Point(1040, 252);
            this.btnObliczWartoscSzeregu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnObliczWartoscSzeregu.Name = "btnObliczWartoscSzeregu";
            this.btnObliczWartoscSzeregu.Size = new System.Drawing.Size(239, 57);
            this.btnObliczWartoscSzeregu.TabIndex = 9;
            this.btnObliczWartoscSzeregu.Text = "Oblicz wartość szeregu";
            this.btnObliczWartoscSzeregu.UseVisualStyleBackColor = true;
            this.btnObliczWartoscSzeregu.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(36, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 38);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dolna granica przedziału\r\nXd (zmian wartości X)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(36, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 38);
            this.label7.TabIndex = 11;
            this.label7.Text = "Górna granica przedziału\r\nXg (zmian wartości X)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(36, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 38);
            this.label8.TabIndex = 12;
            this.label8.Text = "Przyrost h (zmian\r\nwartości zmiennej X)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnWizualizacjaTabelaryczna
            // 
            this.btnWizualizacjaTabelaryczna.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWizualizacjaTabelaryczna.Location = new System.Drawing.Point(1039, 324);
            this.btnWizualizacjaTabelaryczna.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWizualizacjaTabelaryczna.Name = "btnWizualizacjaTabelaryczna";
            this.btnWizualizacjaTabelaryczna.Size = new System.Drawing.Size(240, 71);
            this.btnWizualizacjaTabelaryczna.TabIndex = 13;
            this.btnWizualizacjaTabelaryczna.Text = "Tabelaryczna wizualizacja\r\nzmian wartości szeregu\r\npotęgowego";
            this.btnWizualizacjaTabelaryczna.UseVisualStyleBackColor = true;
            this.btnWizualizacjaTabelaryczna.Click += new System.EventHandler(this.btnWizualizacjaTabelaryczna_Click);
            // 
            // btnWizualizacjaGraficzna
            // 
            this.btnWizualizacjaGraficzna.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWizualizacjaGraficzna.Location = new System.Drawing.Point(1040, 411);
            this.btnWizualizacjaGraficzna.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWizualizacjaGraficzna.Name = "btnWizualizacjaGraficzna";
            this.btnWizualizacjaGraficzna.Size = new System.Drawing.Size(239, 95);
            this.btnWizualizacjaGraficzna.TabIndex = 14;
            this.btnWizualizacjaGraficzna.Text = "Graficzna wizualizacja zmian\r\nwartości szeregu \r\npotęgowego";
            this.btnWizualizacjaGraficzna.UseVisualStyleBackColor = true;
            this.btnWizualizacjaGraficzna.Click += new System.EventHandler(this.btnWizualizacjaGraficzna_Click);
            // 
            // btnResetuj
            // 
            this.btnResetuj.Location = new System.Drawing.Point(1040, 526);
            this.btnResetuj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnResetuj.Name = "btnResetuj";
            this.btnResetuj.Size = new System.Drawing.Size(239, 65);
            this.btnResetuj.TabIndex = 15;
            this.btnResetuj.Text = "RESETUJ\r\n(ustal stan początkowy)";
            this.btnResetuj.UseVisualStyleBackColor = true;
            this.btnResetuj.Click += new System.EventHandler(this.btnResetuj_Click);
            // 
            // txtXd
            // 
            this.txtXd.Location = new System.Drawing.Point(108, 282);
            this.txtXd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtXd.Name = "txtXd";
            this.txtXd.Size = new System.Drawing.Size(124, 27);
            this.txtXd.TabIndex = 16;
            // 
            // txtXg
            // 
            this.txtXg.Location = new System.Drawing.Point(112, 366);
            this.txtXg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtXg.Name = "txtXg";
            this.txtXg.Size = new System.Drawing.Size(124, 27);
            this.txtXg.TabIndex = 17;
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(109, 469);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(111, 27);
            this.txtH.TabIndex = 18;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgvTWS
            // 
            this.dgvTWS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTWS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvTWS.Location = new System.Drawing.Point(438, 81);
            this.dgvTWS.Name = "dgvTWS";
            this.dgvTWS.RowHeadersWidth = 51;
            this.dgvTWS.RowTemplate.Height = 24;
            this.dgvTWS.Size = new System.Drawing.Size(424, 389);
            this.dgvTWS.TabIndex = 19;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Wartość X";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Suma szeregu S (X)";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Licznik zsumwanych wyrazów szeregu";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.typWykresuToolStripMenuItem,
            this.koloryToolStripMenuItem,
            this.stylLiniiWykresuToolStripMenuItem,
            this.grubośćLiniiWykresuToolStripMenuItem,
            this.czcionkaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1342, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszTabelaryczneZestawienieZmianWartościSzereguPotęgowegoWPlikuToolStripMenuItem,
            this.wczytajZPlikuTabelaryczneZestawienieZmianWartościSzereguPotęgowegoToolStripMenuItem,
            this.wyjścieExitToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zapiszTabelaryczneZestawienieZmianWartościSzereguPotęgowegoWPlikuToolStripMenuItem
            // 
            this.zapiszTabelaryczneZestawienieZmianWartościSzereguPotęgowegoWPlikuToolStripMenuItem.Name = "zapiszTabelaryczneZestawienieZmianWartościSzereguPotęgowegoWPlikuToolStripMenuIte" +
    "m";
            this.zapiszTabelaryczneZestawienieZmianWartościSzereguPotęgowegoWPlikuToolStripMenuItem.Size = new System.Drawing.Size(607, 26);
            this.zapiszTabelaryczneZestawienieZmianWartościSzereguPotęgowegoWPlikuToolStripMenuItem.Text = "Zapisz tabelaryczne zestawienie zmian wartości szeregu potęgowego w pliku";
            this.zapiszTabelaryczneZestawienieZmianWartościSzereguPotęgowegoWPlikuToolStripMenuItem.Click += new System.EventHandler(this.zapiszTabelaryczneZestawienieZmianWartościSzereguPotęgowegoWPlikuToolStripMenuItem_Click);
            // 
            // wczytajZPlikuTabelaryczneZestawienieZmianWartościSzereguPotęgowegoToolStripMenuItem
            // 
            this.wczytajZPlikuTabelaryczneZestawienieZmianWartościSzereguPotęgowegoToolStripMenuItem.Name = "wczytajZPlikuTabelaryczneZestawienieZmianWartościSzereguPotęgowegoToolStripMenuIt" +
    "em";
            this.wczytajZPlikuTabelaryczneZestawienieZmianWartościSzereguPotęgowegoToolStripMenuItem.Size = new System.Drawing.Size(607, 26);
            this.wczytajZPlikuTabelaryczneZestawienieZmianWartościSzereguPotęgowegoToolStripMenuItem.Text = "Wczytaj z pliku tabelaryczne zestawienie zmian wartości szeregu potęgowego";
            this.wczytajZPlikuTabelaryczneZestawienieZmianWartościSzereguPotęgowegoToolStripMenuItem.Click += new System.EventHandler(this.wczytajZPlikuTabelaryczneZestawienieZmianWartościSzereguPotęgowegoToolStripMenuItem_Click);
            // 
            // wyjścieExitToolStripMenuItem
            // 
            this.wyjścieExitToolStripMenuItem.Name = "wyjścieExitToolStripMenuItem";
            this.wyjścieExitToolStripMenuItem.Size = new System.Drawing.Size(607, 26);
            this.wyjścieExitToolStripMenuItem.Text = "Wyjście (Exit)";
            this.wyjścieExitToolStripMenuItem.Click += new System.EventHandler(this.btnResetuj_Click);
            // 
            // typWykresuToolStripMenuItem
            // 
            this.typWykresuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wykresLiniowyToolStripMenuItem,
            this.wykresPunktowyToolStripMenuItem,
            this.wykresKolumnowyToolStripMenuItem,
            this.wykresSłupkowyToolStripMenuItem});
            this.typWykresuToolStripMenuItem.Name = "typWykresuToolStripMenuItem";
            this.typWykresuToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.typWykresuToolStripMenuItem.Text = "Typ wykresu";
            // 
            // wykresLiniowyToolStripMenuItem
            // 
            this.wykresLiniowyToolStripMenuItem.Name = "wykresLiniowyToolStripMenuItem";
            this.wykresLiniowyToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.wykresLiniowyToolStripMenuItem.Text = "Wykres liniowy";
            this.wykresLiniowyToolStripMenuItem.Click += new System.EventHandler(this.wykresLiniowyToolStripMenuItem_Click);
            // 
            // wykresPunktowyToolStripMenuItem
            // 
            this.wykresPunktowyToolStripMenuItem.Name = "wykresPunktowyToolStripMenuItem";
            this.wykresPunktowyToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.wykresPunktowyToolStripMenuItem.Text = "Wykres punktowy";
            this.wykresPunktowyToolStripMenuItem.Click += new System.EventHandler(this.wykresPunktowyToolStripMenuItem_Click);
            // 
            // wykresKolumnowyToolStripMenuItem
            // 
            this.wykresKolumnowyToolStripMenuItem.Name = "wykresKolumnowyToolStripMenuItem";
            this.wykresKolumnowyToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.wykresKolumnowyToolStripMenuItem.Text = "Wykres kolumnowy";
            this.wykresKolumnowyToolStripMenuItem.Click += new System.EventHandler(this.wykresKolumnowyToolStripMenuItem_Click);
            // 
            // wykresSłupkowyToolStripMenuItem
            // 
            this.wykresSłupkowyToolStripMenuItem.Name = "wykresSłupkowyToolStripMenuItem";
            this.wykresSłupkowyToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.wykresSłupkowyToolStripMenuItem.Text = "Wykres słupkowy";
            this.wykresSłupkowyToolStripMenuItem.Click += new System.EventHandler(this.wykresSłupkowyToolStripMenuItem_Click);
            // 
            // koloryToolStripMenuItem
            // 
            this.koloryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kolorTłaWykresuToolStripMenuItem,
            this.kolorLiniiWykresuToolStripMenuItem});
            this.koloryToolStripMenuItem.Name = "koloryToolStripMenuItem";
            this.koloryToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.koloryToolStripMenuItem.Text = "Kolory";
            // 
            // kolorTłaWykresuToolStripMenuItem
            // 
            this.kolorTłaWykresuToolStripMenuItem.Name = "kolorTłaWykresuToolStripMenuItem";
            this.kolorTłaWykresuToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.kolorTłaWykresuToolStripMenuItem.Text = "Kolor tła wykresu";
            this.kolorTłaWykresuToolStripMenuItem.Click += new System.EventHandler(this.kolorTłaWykresuToolStripMenuItem_Click);
            // 
            // kolorLiniiWykresuToolStripMenuItem
            // 
            this.kolorLiniiWykresuToolStripMenuItem.Name = "kolorLiniiWykresuToolStripMenuItem";
            this.kolorLiniiWykresuToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.kolorLiniiWykresuToolStripMenuItem.Text = "Kolor linii wykresu";
            this.kolorLiniiWykresuToolStripMenuItem.Click += new System.EventHandler(this.kolorLiniiWykresuToolStripMenuItem_Click);
            // 
            // stylLiniiWykresuToolStripMenuItem
            // 
            this.stylLiniiWykresuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liniaKreskowaDashToolStripMenuItem,
            this.liniaKreskowoKropkowaDashDotToolStripMenuItem,
            this.liniaKreskowoKropkowaKropkowaDashDotDotToolStripMenuItem,
            this.liniaKropkowaDotToolStripMenuItem,
            this.liniaCiaglaSolidToolStripMenuItem});
            this.stylLiniiWykresuToolStripMenuItem.Name = "stylLiniiWykresuToolStripMenuItem";
            this.stylLiniiWykresuToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.stylLiniiWykresuToolStripMenuItem.Text = "Styl linii wykresu";
            // 
            // liniaKreskowaDashToolStripMenuItem
            // 
            this.liniaKreskowaDashToolStripMenuItem.Name = "liniaKreskowaDashToolStripMenuItem";
            this.liniaKreskowaDashToolStripMenuItem.Size = new System.Drawing.Size(422, 26);
            this.liniaKreskowaDashToolStripMenuItem.Text = "Linia Kreskowa (Dash)";
            this.liniaKreskowaDashToolStripMenuItem.Click += new System.EventHandler(this.liniaKreskowaDashToolStripMenuItem_Click);
            // 
            // liniaKreskowoKropkowaDashDotToolStripMenuItem
            // 
            this.liniaKreskowoKropkowaDashDotToolStripMenuItem.Name = "liniaKreskowoKropkowaDashDotToolStripMenuItem";
            this.liniaKreskowoKropkowaDashDotToolStripMenuItem.Size = new System.Drawing.Size(422, 26);
            this.liniaKreskowoKropkowaDashDotToolStripMenuItem.Text = "Linia KreskowoKropkowa (DashDot)";
            this.liniaKreskowoKropkowaDashDotToolStripMenuItem.Click += new System.EventHandler(this.liniaKreskowoKropkowaDashDotToolStripMenuItem_Click);
            // 
            // liniaKreskowoKropkowaKropkowaDashDotDotToolStripMenuItem
            // 
            this.liniaKreskowoKropkowaKropkowaDashDotDotToolStripMenuItem.Name = "liniaKreskowoKropkowaKropkowaDashDotDotToolStripMenuItem";
            this.liniaKreskowoKropkowaKropkowaDashDotDotToolStripMenuItem.Size = new System.Drawing.Size(422, 26);
            this.liniaKreskowoKropkowaKropkowaDashDotDotToolStripMenuItem.Text = "Linia KreskowoKropkowaKropkowa (DashDotDot)";
            this.liniaKreskowoKropkowaKropkowaDashDotDotToolStripMenuItem.Click += new System.EventHandler(this.liniaKreskowoKropkowaKropkowaDashDotDotToolStripMenuItem_Click);
            // 
            // liniaKropkowaDotToolStripMenuItem
            // 
            this.liniaKropkowaDotToolStripMenuItem.Name = "liniaKropkowaDotToolStripMenuItem";
            this.liniaKropkowaDotToolStripMenuItem.Size = new System.Drawing.Size(422, 26);
            this.liniaKropkowaDotToolStripMenuItem.Text = "Linia Kropkowa (Dot)";
            this.liniaKropkowaDotToolStripMenuItem.Click += new System.EventHandler(this.liniaKropkowaDotToolStripMenuItem_Click);
            // 
            // liniaCiaglaSolidToolStripMenuItem
            // 
            this.liniaCiaglaSolidToolStripMenuItem.Name = "liniaCiaglaSolidToolStripMenuItem";
            this.liniaCiaglaSolidToolStripMenuItem.Size = new System.Drawing.Size(422, 26);
            this.liniaCiaglaSolidToolStripMenuItem.Text = "Linia Ciagla (Solid)";
            this.liniaCiaglaSolidToolStripMenuItem.Click += new System.EventHandler(this.liniaCiaglaSolidToolStripMenuItem_Click);
            // 
            // grubośćLiniiWykresuToolStripMenuItem
            // 
            this.grubośćLiniiWykresuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.grubośćLiniiWykresuToolStripMenuItem.Name = "grubośćLiniiWykresuToolStripMenuItem";
            this.grubośćLiniiWykresuToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.grubośćLiniiWykresuToolStripMenuItem.Text = "Grubość linii wykresu";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem2.Text = "1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem3.Text = "2";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem4.Text = "3";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem5.Text = "4";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem6.Text = "5";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // czcionkaToolStripMenuItem
            // 
            this.czcionkaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.czcionkaOpisuWykresuToolStripMenuItem,
            this.kontrolToolStripMenuItem,
            this.czcionkaOpisuFormularzaToolStripMenuItem});
            this.czcionkaToolStripMenuItem.Name = "czcionkaToolStripMenuItem";
            this.czcionkaToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.czcionkaToolStripMenuItem.Text = "Czcionka";
            // 
            // czcionkaOpisuWykresuToolStripMenuItem
            // 
            this.czcionkaOpisuWykresuToolStripMenuItem.Name = "czcionkaOpisuWykresuToolStripMenuItem";
            this.czcionkaOpisuWykresuToolStripMenuItem.Size = new System.Drawing.Size(358, 26);
            this.czcionkaOpisuWykresuToolStripMenuItem.Text = "Czcionka opisu wykresu (kontrolki Chart)";
            this.czcionkaOpisuWykresuToolStripMenuItem.Click += new System.EventHandler(this.czcionkaOpisuWykresuToolStripMenuItem_Click);
            // 
            // kontrolToolStripMenuItem
            // 
            this.kontrolToolStripMenuItem.Name = "kontrolToolStripMenuItem";
            this.kontrolToolStripMenuItem.Size = new System.Drawing.Size(358, 26);
            this.kontrolToolStripMenuItem.Text = "Czcionka opisu kontrolki DataGridView";
            this.kontrolToolStripMenuItem.Click += new System.EventHandler(this.kontrolToolStripMenuItem_Click);
            // 
            // czcionkaOpisuFormularzaToolStripMenuItem
            // 
            this.czcionkaOpisuFormularzaToolStripMenuItem.Name = "czcionkaOpisuFormularzaToolStripMenuItem";
            this.czcionkaOpisuFormularzaToolStripMenuItem.Size = new System.Drawing.Size(358, 26);
            this.czcionkaOpisuFormularzaToolStripMenuItem.Text = "Czcionka opisu formularza";
            this.czcionkaOpisuFormularzaToolStripMenuItem.Click += new System.EventHandler(this.czcionkaOpisuFormularzaToolStripMenuItem_Click);
            // 
            // chtWykresSzeregu
            // 
            chartArea1.Name = "ChartArea1";
            this.chtWykresSzeregu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtWykresSzeregu.Legends.Add(legend1);
            this.chtWykresSzeregu.Location = new System.Drawing.Point(357, 191);
            this.chtWykresSzeregu.Name = "chtWykresSzeregu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtWykresSzeregu.Series.Add(series1);
            this.chtWykresSzeregu.Size = new System.Drawing.Size(563, 342);
            this.chtWykresSzeregu.TabIndex = 21;
            this.chtWykresSzeregu.Text = "chart1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "text file |*.txt";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SzeregLaboratoryjny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 670);
            this.Controls.Add(this.chtWykresSzeregu);
            this.Controls.Add(this.dgvTWS);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtXg);
            this.Controls.Add(this.txtXd);
            this.Controls.Add(this.btnResetuj);
            this.Controls.Add(this.btnWizualizacjaGraficzna);
            this.Controls.Add(this.btnWizualizacjaTabelaryczna);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnObliczWartoscSzeregu);
            this.Controls.Add(this.txtLicznikWyrazowSzeregu);
            this.Controls.Add(this.txtSumaSzeregu);
            this.Controls.Add(this.txtEps);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SzeregLaboratoryjny";
            this.Text = "SzeregLaboratoryjny";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SzeregLaboratoryjny_FormClosing);
            this.Load += new System.EventHandler(this.SzeregLaboratoryjny_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTWS)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtWykresSzeregu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtEps;
        private System.Windows.Forms.TextBox txtSumaSzeregu;
        private System.Windows.Forms.TextBox txtLicznikWyrazowSzeregu;
        private System.Windows.Forms.Button btnObliczWartoscSzeregu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnWizualizacjaTabelaryczna;
        private System.Windows.Forms.Button btnWizualizacjaGraficzna;
        private System.Windows.Forms.Button btnResetuj;
        private System.Windows.Forms.TextBox txtXd;
        private System.Windows.Forms.TextBox txtXg;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvTWS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszTabelaryczneZestawienieZmianWartościSzereguPotęgowegoWPlikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajZPlikuTabelaryczneZestawienieZmianWartościSzereguPotęgowegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjścieExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typWykresuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wykresLiniowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wykresPunktowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wykresKolumnowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wykresSłupkowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koloryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorTłaWykresuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorLiniiWykresuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stylLiniiWykresuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liniaKreskowaDashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liniaKreskowoKropkowaDashDotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liniaKreskowoKropkowaKropkowaDashDotDotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liniaKropkowaDotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liniaCiaglaSolidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grubośćLiniiWykresuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem czcionkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czcionkaOpisuWykresuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontrolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czcionkaOpisuFormularzaToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtWykresSzeregu;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}