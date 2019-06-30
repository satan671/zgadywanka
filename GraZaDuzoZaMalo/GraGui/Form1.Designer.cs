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
            this.buttonPrzerwij = new System.Windows.Forms.Button();
            this.buttonHistoria = new System.Windows.Forms.Button();
            this.panel_odpowiedz = new System.Windows.Forms.Panel();
            this.Laczny_czas_gry = new System.Windows.Forms.Label();
            this.Liczba_ruchow = new System.Windows.Forms.Label();
            this.Wylosowana = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSprawdz = new System.Windows.Forms.Button();
            this.Odpowiedz = new System.Windows.Forms.Label();
            this.textBoxSprawdzana = new System.Windows.Forms.TextBox();
            this.panel_sprawdz = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxHistoria = new System.Windows.Forms.GroupBox();
            this.Historia_tresc = new System.Windows.Forms.Label();
            this.groupBoxLosowanie.SuspendLayout();
            this.panel_odpowiedz.SuspendLayout();
            this.panel_sprawdz.SuspendLayout();
            this.groupBoxHistoria.SuspendLayout();
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
            // buttonPrzerwij
            // 
            this.buttonPrzerwij.Enabled = false;
            this.buttonPrzerwij.Location = new System.Drawing.Point(93, 12);
            this.buttonPrzerwij.Name = "buttonPrzerwij";
            this.buttonPrzerwij.Size = new System.Drawing.Size(75, 23);
            this.buttonPrzerwij.TabIndex = 2;
            this.buttonPrzerwij.Text = "Przerwij";
            this.buttonPrzerwij.UseVisualStyleBackColor = true;
            this.buttonPrzerwij.Click += new System.EventHandler(this.Przerwij_Click);
            // 
            // buttonHistoria
            // 
            this.buttonHistoria.Enabled = false;
            this.buttonHistoria.Location = new System.Drawing.Point(300, 12);
            this.buttonHistoria.Name = "buttonHistoria";
            this.buttonHistoria.Size = new System.Drawing.Size(92, 23);
            this.buttonHistoria.TabIndex = 3;
            this.buttonHistoria.Text = "Pokaż Historie";
            this.buttonHistoria.UseVisualStyleBackColor = true;
            this.buttonHistoria.Click += new System.EventHandler(this.Historia_Click);
            // 
            // panel_odpowiedz
            // 
            this.panel_odpowiedz.Controls.Add(this.label4);
            this.panel_odpowiedz.Controls.Add(this.Laczny_czas_gry);
            this.panel_odpowiedz.Controls.Add(this.Liczba_ruchow);
            this.panel_odpowiedz.Controls.Add(this.Wylosowana);
            this.panel_odpowiedz.Location = new System.Drawing.Point(12, 334);
            this.panel_odpowiedz.Name = "panel_odpowiedz";
            this.panel_odpowiedz.Size = new System.Drawing.Size(272, 97);
            this.panel_odpowiedz.TabIndex = 5;
            this.panel_odpowiedz.Visible = false;
            // 
            // Laczny_czas_gry
            // 
            this.Laczny_czas_gry.AutoSize = true;
            this.Laczny_czas_gry.Location = new System.Drawing.Point(6, 20);
            this.Laczny_czas_gry.Name = "Laczny_czas_gry";
            this.Laczny_czas_gry.Size = new System.Drawing.Size(84, 13);
            this.Laczny_czas_gry.TabIndex = 2;
            this.Laczny_czas_gry.Text = "Łączny czas gry";
            // 
            // Liczba_ruchow
            // 
            this.Liczba_ruchow.AutoSize = true;
            this.Liczba_ruchow.Location = new System.Drawing.Point(6, 44);
            this.Liczba_ruchow.Name = "Liczba_ruchow";
            this.Liczba_ruchow.Size = new System.Drawing.Size(76, 13);
            this.Liczba_ruchow.TabIndex = 1;
            this.Liczba_ruchow.Text = "Liczba ruchów";
            // 
            // Wylosowana
            // 
            this.Wylosowana.AutoSize = true;
            this.Wylosowana.Location = new System.Drawing.Point(6, 70);
            this.Wylosowana.Name = "Wylosowana";
            this.Wylosowana.Size = new System.Drawing.Size(68, 13);
            this.Wylosowana.TabIndex = 0;
            this.Wylosowana.Text = "Wylosowana";
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
            // buttonSprawdz
            // 
            this.buttonSprawdz.Location = new System.Drawing.Point(185, 38);
            this.buttonSprawdz.Name = "buttonSprawdz";
            this.buttonSprawdz.Size = new System.Drawing.Size(75, 23);
            this.buttonSprawdz.TabIndex = 1;
            this.buttonSprawdz.Text = "Sprawdź";
            this.buttonSprawdz.UseVisualStyleBackColor = true;
            this.buttonSprawdz.Click += new System.EventHandler(this.Sprawdz_Click);
            // 
            // Odpowiedz
            // 
            this.Odpowiedz.AutoSize = true;
            this.Odpowiedz.Location = new System.Drawing.Point(34, 77);
            this.Odpowiedz.Name = "Odpowiedz";
            this.Odpowiedz.Size = new System.Drawing.Size(60, 13);
            this.Odpowiedz.TabIndex = 3;
            this.Odpowiedz.Text = "Odpowiedź";
            this.Odpowiedz.Visible = false;
            // 
            // textBoxSprawdzana
            // 
            this.textBoxSprawdzana.Location = new System.Drawing.Point(21, 38);
            this.textBoxSprawdzana.Name = "textBoxSprawdzana";
            this.textBoxSprawdzana.Size = new System.Drawing.Size(100, 20);
            this.textBoxSprawdzana.TabIndex = 2;
            // 
            // panel_sprawdz
            // 
            this.panel_sprawdz.Controls.Add(this.textBoxSprawdzana);
            this.panel_sprawdz.Controls.Add(this.Odpowiedz);
            this.panel_sprawdz.Controls.Add(this.buttonSprawdz);
            this.panel_sprawdz.Controls.Add(this.label3);
            this.panel_sprawdz.Location = new System.Drawing.Point(12, 209);
            this.panel_sprawdz.Name = "panel_sprawdz";
            this.panel_sprawdz.Size = new System.Drawing.Size(272, 100);
            this.panel_sprawdz.TabIndex = 4;
            this.panel_sprawdz.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, -2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Statystyki";
            // 
            // groupBoxHistoria
            // 
            this.groupBoxHistoria.Controls.Add(this.Historia_tresc);
            this.groupBoxHistoria.Location = new System.Drawing.Point(290, 66);
            this.groupBoxHistoria.Name = "groupBoxHistoria";
            this.groupBoxHistoria.Size = new System.Drawing.Size(208, 365);
            this.groupBoxHistoria.TabIndex = 6;
            this.groupBoxHistoria.TabStop = false;
            this.groupBoxHistoria.Text = "Historia";
            this.groupBoxHistoria.Visible = false;
            // 
            // Historia_tresc
            // 
            this.Historia_tresc.AutoSize = true;
            this.Historia_tresc.Location = new System.Drawing.Point(7, 20);
            this.Historia_tresc.Name = "Historia_tresc";
            this.Historia_tresc.Size = new System.Drawing.Size(0, 13);
            this.Historia_tresc.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 442);
            this.Controls.Add(this.groupBoxHistoria);
            this.Controls.Add(this.panel_odpowiedz);
            this.Controls.Add(this.panel_sprawdz);
            this.Controls.Add(this.buttonHistoria);
            this.Controls.Add(this.buttonPrzerwij);
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
            this.groupBoxHistoria.ResumeLayout(false);
            this.groupBoxHistoria.PerformLayout();
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
        private System.Windows.Forms.Button buttonPrzerwij;
        private System.Windows.Forms.Button buttonHistoria;
        private System.Windows.Forms.Panel panel_odpowiedz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSprawdz;
        private System.Windows.Forms.Label Odpowiedz;
        private System.Windows.Forms.TextBox textBoxSprawdzana;
        private System.Windows.Forms.Panel panel_sprawdz;
        private System.Windows.Forms.Label Wylosowana;
        private System.Windows.Forms.Label Liczba_ruchow;
        private System.Windows.Forms.Label Laczny_czas_gry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxHistoria;
        private System.Windows.Forms.Label Historia_tresc;
    }
}

