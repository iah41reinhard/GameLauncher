namespace Game_Launcher
{
    partial class SteamBibliothek
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxSpiele = new System.Windows.Forms.ListBox();
            this.lbTitel = new System.Windows.Forms.Label();
            this.lbInstallationspfad = new System.Windows.Forms.Label();
            this.lbInstallationsdatum = new System.Windows.Forms.Label();
            this.lbzuletzt_gespielt = new System.Windows.Forms.Label();
            this.lbKategorie = new System.Windows.Forms.Label();
            this.lbUSK = new System.Windows.Forms.Label();
            this.lbhinzufügen = new System.Windows.Forms.Label();
            this.lbentfernen = new System.Windows.Forms.Label();
            this.lbstarten = new System.Windows.Forms.Label();
            this.tbTitel = new System.Windows.Forms.TextBox();
            this.tbPublisher = new System.Windows.Forms.TextBox();
            this.tbUSK = new System.Windows.Forms.TextBox();
            this.tbKategorie = new System.Windows.Forms.TextBox();
            this.tbZuletztGespielt = new System.Windows.Forms.TextBox();
            this.tbInstallationsdatum = new System.Windows.Forms.TextBox();
            this.tbInstallationspfad = new System.Windows.Forms.TextBox();
            this.lbPublisher = new System.Windows.Forms.Label();
            this.bthinzufügen = new System.Windows.Forms.Button();
            this.btstarten = new System.Windows.Forms.Button();
            this.tbentfernen = new System.Windows.Forms.Button();
            this.btdurchsuchen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // listBoxSpiele
            // 
            this.listBoxSpiele.FormattingEnabled = true;
            this.listBoxSpiele.Location = new System.Drawing.Point(397, 12);
            this.listBoxSpiele.Name = "listBoxSpiele";
            this.listBoxSpiele.Size = new System.Drawing.Size(164, 303);
            this.listBoxSpiele.TabIndex = 0;
            this.listBoxSpiele.SelectedIndexChanged += new System.EventHandler(this.listBoxSpiele_SelectedIndexChanged);
            // 
            // lbTitel
            // 
            this.lbTitel.AutoSize = true;
            this.lbTitel.Location = new System.Drawing.Point(33, 9);
            this.lbTitel.Name = "lbTitel";
            this.lbTitel.Size = new System.Drawing.Size(27, 13);
            this.lbTitel.TabIndex = 1;
            this.lbTitel.Text = "Titel";
            // 
            // lbInstallationspfad
            // 
            this.lbInstallationspfad.AutoSize = true;
            this.lbInstallationspfad.Location = new System.Drawing.Point(129, 66);
            this.lbInstallationspfad.Name = "lbInstallationspfad";
            this.lbInstallationspfad.Size = new System.Drawing.Size(83, 13);
            this.lbInstallationspfad.TabIndex = 2;
            this.lbInstallationspfad.Text = "Installationspfad";
            // 
            // lbInstallationsdatum
            // 
            this.lbInstallationsdatum.AutoSize = true;
            this.lbInstallationsdatum.Location = new System.Drawing.Point(4, 66);
            this.lbInstallationsdatum.Name = "lbInstallationsdatum";
            this.lbInstallationsdatum.Size = new System.Drawing.Size(91, 13);
            this.lbInstallationsdatum.TabIndex = 3;
            this.lbInstallationsdatum.Text = "Installationsdatum";
            // 
            // lbzuletzt_gespielt
            // 
            this.lbzuletzt_gespielt.AutoSize = true;
            this.lbzuletzt_gespielt.Location = new System.Drawing.Point(12, 138);
            this.lbzuletzt_gespielt.Name = "lbzuletzt_gespielt";
            this.lbzuletzt_gespielt.Size = new System.Drawing.Size(76, 13);
            this.lbzuletzt_gespielt.TabIndex = 4;
            this.lbzuletzt_gespielt.Text = "zuletzt gespielt";
            // 
            // lbKategorie
            // 
            this.lbKategorie.AutoSize = true;
            this.lbKategorie.Location = new System.Drawing.Point(265, 66);
            this.lbKategorie.Name = "lbKategorie";
            this.lbKategorie.Size = new System.Drawing.Size(52, 13);
            this.lbKategorie.TabIndex = 5;
            this.lbKategorie.Text = "Kategorie";
            // 
            // lbUSK
            // 
            this.lbUSK.AutoSize = true;
            this.lbUSK.Location = new System.Drawing.Point(288, 9);
            this.lbUSK.Name = "lbUSK";
            this.lbUSK.Size = new System.Drawing.Size(29, 13);
            this.lbUSK.TabIndex = 6;
            this.lbUSK.Text = "USK";
            // 
            // lbhinzufügen
            // 
            this.lbhinzufügen.AutoSize = true;
            this.lbhinzufügen.Location = new System.Drawing.Point(46, 411);
            this.lbhinzufügen.Name = "lbhinzufügen";
            this.lbhinzufügen.Size = new System.Drawing.Size(0, 13);
            this.lbhinzufügen.TabIndex = 7;
            // 
            // lbentfernen
            // 
            this.lbentfernen.AutoSize = true;
            this.lbentfernen.Location = new System.Drawing.Point(197, 411);
            this.lbentfernen.Name = "lbentfernen";
            this.lbentfernen.Size = new System.Drawing.Size(0, 13);
            this.lbentfernen.TabIndex = 8;
            // 
            // lbstarten
            // 
            this.lbstarten.AutoSize = true;
            this.lbstarten.Location = new System.Drawing.Point(317, 411);
            this.lbstarten.Name = "lbstarten";
            this.lbstarten.Size = new System.Drawing.Size(0, 13);
            this.lbstarten.TabIndex = 9;
            // 
            // tbTitel
            // 
            this.tbTitel.Location = new System.Drawing.Point(7, 25);
            this.tbTitel.Name = "tbTitel";
            this.tbTitel.Size = new System.Drawing.Size(100, 20);
            this.tbTitel.TabIndex = 1;
            // 
            // tbPublisher
            // 
            this.tbPublisher.Location = new System.Drawing.Point(124, 25);
            this.tbPublisher.Name = "tbPublisher";
            this.tbPublisher.Size = new System.Drawing.Size(100, 20);
            this.tbPublisher.TabIndex = 2;
            // 
            // tbUSK
            // 
            this.tbUSK.Location = new System.Drawing.Point(240, 25);
            this.tbUSK.Name = "tbUSK";
            this.tbUSK.Size = new System.Drawing.Size(100, 20);
            this.tbUSK.TabIndex = 3;
            // 
            // tbKategorie
            // 
            this.tbKategorie.Location = new System.Drawing.Point(240, 91);
            this.tbKategorie.Name = "tbKategorie";
            this.tbKategorie.Size = new System.Drawing.Size(100, 20);
            this.tbKategorie.TabIndex = 6;
            // 
            // tbZuletztGespielt
            // 
            this.tbZuletztGespielt.Location = new System.Drawing.Point(7, 154);
            this.tbZuletztGespielt.Name = "tbZuletztGespielt";
            this.tbZuletztGespielt.Size = new System.Drawing.Size(100, 20);
            this.tbZuletztGespielt.TabIndex = 14;
            // 
            // tbInstallationsdatum
            // 
            this.tbInstallationsdatum.Location = new System.Drawing.Point(7, 91);
            this.tbInstallationsdatum.Name = "tbInstallationsdatum";
            this.tbInstallationsdatum.Size = new System.Drawing.Size(100, 20);
            this.tbInstallationsdatum.TabIndex = 4;
            // 
            // tbInstallationspfad
            // 
            this.tbInstallationspfad.Location = new System.Drawing.Point(124, 91);
            this.tbInstallationspfad.Name = "tbInstallationspfad";
            this.tbInstallationspfad.Size = new System.Drawing.Size(100, 20);
            this.tbInstallationspfad.TabIndex = 16;
            // 
            // lbPublisher
            // 
            this.lbPublisher.AutoSize = true;
            this.lbPublisher.Location = new System.Drawing.Point(147, 9);
            this.lbPublisher.Name = "lbPublisher";
            this.lbPublisher.Size = new System.Drawing.Size(50, 13);
            this.lbPublisher.TabIndex = 17;
            this.lbPublisher.Text = "Publisher";
            // 
            // bthinzufügen
            // 
            this.bthinzufügen.Location = new System.Drawing.Point(12, 247);
            this.bthinzufügen.Name = "bthinzufügen";
            this.bthinzufügen.Size = new System.Drawing.Size(75, 23);
            this.bthinzufügen.TabIndex = 7;
            this.bthinzufügen.Text = "hinzufügen";
            this.bthinzufügen.UseVisualStyleBackColor = true;
            this.bthinzufügen.Click += new System.EventHandler(this.bthinzufügen_Click);
            // 
            // btstarten
            // 
            this.btstarten.Location = new System.Drawing.Point(242, 247);
            this.btstarten.Name = "btstarten";
            this.btstarten.Size = new System.Drawing.Size(75, 23);
            this.btstarten.TabIndex = 9;
            this.btstarten.Text = "starten";
            this.btstarten.UseVisualStyleBackColor = true;
            this.btstarten.Click += new System.EventHandler(this.btstarten_Click);
            // 
            // tbentfernen
            // 
            this.tbentfernen.Location = new System.Drawing.Point(124, 247);
            this.tbentfernen.Name = "tbentfernen";
            this.tbentfernen.Size = new System.Drawing.Size(75, 23);
            this.tbentfernen.TabIndex = 8;
            this.tbentfernen.Text = "entfernen";
            this.tbentfernen.UseVisualStyleBackColor = true;
            this.tbentfernen.Click += new System.EventHandler(this.tbentfernen_Click);
            // 
            // btdurchsuchen
            // 
            this.btdurchsuchen.Location = new System.Drawing.Point(132, 117);
            this.btdurchsuchen.Name = "btdurchsuchen";
            this.btdurchsuchen.Size = new System.Drawing.Size(87, 23);
            this.btdurchsuchen.TabIndex = 5;
            this.btdurchsuchen.Text = "durchsuchen";
            this.btdurchsuchen.UseVisualStyleBackColor = true;
            this.btdurchsuchen.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SteamBibliothek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(573, 322);
            this.Controls.Add(this.btdurchsuchen);
            this.Controls.Add(this.tbentfernen);
            this.Controls.Add(this.btstarten);
            this.Controls.Add(this.bthinzufügen);
            this.Controls.Add(this.lbPublisher);
            this.Controls.Add(this.tbInstallationspfad);
            this.Controls.Add(this.tbInstallationsdatum);
            this.Controls.Add(this.tbZuletztGespielt);
            this.Controls.Add(this.tbKategorie);
            this.Controls.Add(this.tbUSK);
            this.Controls.Add(this.tbPublisher);
            this.Controls.Add(this.tbTitel);
            this.Controls.Add(this.lbstarten);
            this.Controls.Add(this.lbentfernen);
            this.Controls.Add(this.lbhinzufügen);
            this.Controls.Add(this.lbUSK);
            this.Controls.Add(this.lbKategorie);
            this.Controls.Add(this.lbzuletzt_gespielt);
            this.Controls.Add(this.lbInstallationsdatum);
            this.Controls.Add(this.lbInstallationspfad);
            this.Controls.Add(this.lbTitel);
            this.Controls.Add(this.listBoxSpiele);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "SteamBibliothek";
            this.Text = "SteamBibliothek";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSpiele;
        private System.Windows.Forms.Label lbTitel;
        private System.Windows.Forms.Label lbInstallationspfad;
        private System.Windows.Forms.Label lbInstallationsdatum;
        private System.Windows.Forms.Label lbzuletzt_gespielt;
        private System.Windows.Forms.Label lbKategorie;
        private System.Windows.Forms.Label lbUSK;
        private System.Windows.Forms.Label lbhinzufügen;
        private System.Windows.Forms.Label lbentfernen;
        private System.Windows.Forms.Label lbstarten;
        private System.Windows.Forms.TextBox tbTitel;
        private System.Windows.Forms.TextBox tbPublisher;
        private System.Windows.Forms.TextBox tbUSK;
        private System.Windows.Forms.TextBox tbKategorie;
        private System.Windows.Forms.TextBox tbZuletztGespielt;
        private System.Windows.Forms.TextBox tbInstallationsdatum;
        private System.Windows.Forms.TextBox tbInstallationspfad;
        private System.Windows.Forms.Label lbPublisher;
        private System.Windows.Forms.Button bthinzufügen;
        private System.Windows.Forms.Button btstarten;
        private System.Windows.Forms.Button tbentfernen;
        private System.Windows.Forms.Button btdurchsuchen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

