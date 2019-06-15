namespace GraGui
{
    partial class Form1
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
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.groupBoxLosowanie = new System.Windows.Forms.GroupBox();
            this.buttonLosuj = new System.Windows.Forms.Button();
            this.textBoxZakresDo = new System.Windows.Forms.TextBox();
            this.textBoxZakresOd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Przerwij = new System.Windows.Forms.Button();
            this.Historia = new System.Windows.Forms.Button();
            this.panel_odpowiedz = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Sprawdz = new System.Windows.Forms.Button();
            this.Odpowiedz = new System.Windows.Forms.Label();
            this.Sprawdzana = new System.Windows.Forms.TextBox();
            this.panel_sprawdz = new System.Windows.Forms.Panel();
            this.Wylosowana = new System.Windows.Forms.Label();
            this.Liczba_ruchow = new System.Windows.Forms.Label();
            this.Laczny_czas_gry = new System.Windows.Forms.Label();
            this.groupBoxLosowanie.SuspendLayout();
            this.panel_odpowiedz.SuspendLayout();
            this.panel_sprawdz.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(12, 12);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(75, 23);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.buttonNowaGra_Click);
            // 
            // groupBoxLosowanie
            // 
            this.groupBoxLosowanie.Controls.Add(this.buttonLosuj);
            this.groupBoxLosowanie.Controls.Add(this.textBoxZakresDo);
            this.groupBoxLosowanie.Controls.Add(this.textBoxZakresOd);
            this.groupBoxLosowanie.Controls.Add(this.label2);
            this.groupBoxLosowanie.Controls.Add(this.label1);
            this.groupBoxLosowanie.Location = new System.Drawing.Point(12, 66);
            this.groupBoxLosowanie.Name = "groupBoxLosowanie";
            this.groupBoxLosowanie.Size = new System.Drawing.Size(272, 118);
            this.groupBoxLosowanie.TabIndex = 1;
            this.groupBoxLosowanie.TabStop = false;
            this.groupBoxLosowanie.Text = "Losowanie";
            this.groupBoxLosowanie.Visible = false;
            this.groupBoxLosowanie.Enter += new System.EventHandler(this.groupBoxLosowanie_Enter);
            // 
            // buttonLosuj
            // 
            this.buttonLosuj.Location = new System.Drawing.Point(185, 61);
            this.buttonLosuj.Name = "buttonLosuj";
            this.buttonLosuj.Size = new System.Drawing.Size(75, 23);
            this.buttonLosuj.TabIndex = 4;
            this.buttonLosuj.Text = "Wylosuj";
            this.buttonLosuj.UseVisualStyleBackColor = true;
            this.buttonLosuj.Click += new System.EventHandler(this.buttonLosuj_Click);
            // 
            // textBoxZakresDo
            // 
            this.textBoxZakresDo.Location = new System.Drawing.Point(69, 90);
            this.textBoxZakresDo.Name = "textBoxZakresDo";
            this.textBoxZakresDo.Size = new System.Drawing.Size(85, 20);
            this.textBoxZakresDo.TabIndex = 3;
            this.textBoxZakresDo.Text = "100";
            // 
            // textBoxZakresOd
            // 
            this.textBoxZakresOd.Location = new System.Drawing.Point(69, 43);
            this.textBoxZakresOd.Name = "textBoxZakresOd";
            this.textBoxZakresOd.Size = new System.Drawing.Size(85, 20);
            this.textBoxZakresOd.TabIndex = 2;
            this.textBoxZakresOd.Text = "1";
            this.textBoxZakresOd.TextChanged += new System.EventHandler(this.TextBoxZakresOd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ZakresDo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zakres Od";
            // 
            // Przerwij
            // 
            this.Przerwij.Enabled = false;
            this.Przerwij.Location = new System.Drawing.Point(209, 12);
            this.Przerwij.Name = "Przerwij";
            this.Przerwij.Size = new System.Drawing.Size(75, 23);
            this.Przerwij.TabIndex = 2;
            this.Przerwij.Text = "Przerwij";
            this.Przerwij.UseVisualStyleBackColor = true;
            this.Przerwij.Click += new System.EventHandler(this.Przerwij_Click);
            // 
            // Historia
            // 
            this.Historia.Location = new System.Drawing.Point(21, 506);
            this.Historia.Name = "Historia";
            this.Historia.Size = new System.Drawing.Size(75, 23);
            this.Historia.TabIndex = 3;
            this.Historia.Text = "Historia";
            this.Historia.UseVisualStyleBackColor = true;
            this.Historia.Click += new System.EventHandler(this.Historia_Click);
            // 
            // panel_odpowiedz
            // 
            this.panel_odpowiedz.Controls.Add(this.Laczny_czas_gry);
            this.panel_odpowiedz.Controls.Add(this.Liczba_ruchow);
            this.panel_odpowiedz.Controls.Add(this.Wylosowana);
            this.panel_odpowiedz.Location = new System.Drawing.Point(12, 334);
            this.panel_odpowiedz.Name = "panel_odpowiedz";
            this.panel_odpowiedz.Size = new System.Drawing.Size(272, 81);
            this.panel_odpowiedz.TabIndex = 5;
            this.panel_odpowiedz.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Liczba wylosowana. Zgadnij ją!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Sprawdz
            // 
            this.Sprawdz.Location = new System.Drawing.Point(185, 38);
            this.Sprawdz.Name = "Sprawdz";
            this.Sprawdz.Size = new System.Drawing.Size(75, 23);
            this.Sprawdz.TabIndex = 1;
            this.Sprawdz.Text = "Sprawdź";
            this.Sprawdz.UseVisualStyleBackColor = true;
            this.Sprawdz.Click += new System.EventHandler(this.Sprawdz_Click);
            // 
            // Odpowiedz
            // 
            this.Odpowiedz.AutoSize = true;
            this.Odpowiedz.Location = new System.Drawing.Point(34, 77);
            this.Odpowiedz.Name = "Odpowiedz";
            this.Odpowiedz.Size = new System.Drawing.Size(60, 13);
            this.Odpowiedz.TabIndex = 3;
            this.Odpowiedz.Text = "Odpowiedź";
            // 
            // Sprawdzana
            // 
            this.Sprawdzana.Location = new System.Drawing.Point(21, 38);
            this.Sprawdzana.Name = "Sprawdzana";
            this.Sprawdzana.Size = new System.Drawing.Size(100, 20);
            this.Sprawdzana.TabIndex = 2;
            // 
            // panel_sprawdz
            // 
            this.panel_sprawdz.Controls.Add(this.Sprawdzana);
            this.panel_sprawdz.Controls.Add(this.Odpowiedz);
            this.panel_sprawdz.Controls.Add(this.Sprawdz);
            this.panel_sprawdz.Controls.Add(this.label3);
            this.panel_sprawdz.Location = new System.Drawing.Point(12, 209);
            this.panel_sprawdz.Name = "panel_sprawdz";
            this.panel_sprawdz.Size = new System.Drawing.Size(272, 100);
            this.panel_sprawdz.TabIndex = 4;
            this.panel_sprawdz.Visible = false;
            // 
            // Wylosowana
            // 
            this.Wylosowana.AutoSize = true;
            this.Wylosowana.Location = new System.Drawing.Point(6, 57);
            this.Wylosowana.Name = "Wylosowana";
            this.Wylosowana.Size = new System.Drawing.Size(68, 13);
            this.Wylosowana.TabIndex = 0;
            this.Wylosowana.Text = "Wylosowana";
            // 
            // Liczba_ruchow
            // 
            this.Liczba_ruchow.AutoSize = true;
            this.Liczba_ruchow.Location = new System.Drawing.Point(6, 34);
            this.Liczba_ruchow.Name = "Liczba_ruchow";
            this.Liczba_ruchow.Size = new System.Drawing.Size(76, 13);
            this.Liczba_ruchow.TabIndex = 1;
            this.Liczba_ruchow.Text = "Liczba ruchów";
            // 
            // Laczny_czas_gry
            // 
            this.Laczny_czas_gry.AutoSize = true;
            this.Laczny_czas_gry.Location = new System.Drawing.Point(6, 10);
            this.Laczny_czas_gry.Name = "Laczny_czas_gry";
            this.Laczny_czas_gry.Size = new System.Drawing.Size(84, 13);
            this.Laczny_czas_gry.TabIndex = 2;
            this.Laczny_czas_gry.Text = "Łączny czas gry";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 541);
            this.Controls.Add(this.panel_odpowiedz);
            this.Controls.Add(this.panel_sprawdz);
            this.Controls.Add(this.Historia);
            this.Controls.Add(this.Przerwij);
            this.Controls.Add(this.groupBoxLosowanie);
            this.Controls.Add(this.buttonNowaGra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxLosowanie.ResumeLayout(false);
            this.groupBoxLosowanie.PerformLayout();
            this.panel_odpowiedz.ResumeLayout(false);
            this.panel_odpowiedz.PerformLayout();
            this.panel_sprawdz.ResumeLayout(false);
            this.panel_sprawdz.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.GroupBox groupBoxLosowanie;
        private System.Windows.Forms.TextBox textBoxZakresDo;
        private System.Windows.Forms.TextBox textBoxZakresOd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLosuj;
        private System.Windows.Forms.Button Przerwij;
        private System.Windows.Forms.Button Historia;
        private System.Windows.Forms.Panel panel_odpowiedz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Sprawdz;
        private System.Windows.Forms.Label Odpowiedz;
        private System.Windows.Forms.TextBox Sprawdzana;
        private System.Windows.Forms.Panel panel_sprawdz;
        private System.Windows.Forms.Label Wylosowana;
        private System.Windows.Forms.Label Liczba_ruchow;
        private System.Windows.Forms.Label Laczny_czas_gry;
    }
}

