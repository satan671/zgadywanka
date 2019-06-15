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
            this.groupBoxLosowanie.SuspendLayout();
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
            this.groupBoxLosowanie.Size = new System.Drawing.Size(272, 172);
            this.groupBoxLosowanie.TabIndex = 1;
            this.groupBoxLosowanie.TabStop = false;
            this.groupBoxLosowanie.Text = "Losowanie";
            this.groupBoxLosowanie.Visible = false;
            this.groupBoxLosowanie.Enter += new System.EventHandler(this.groupBoxLosowanie_Enter);
            // 
            // buttonLosuj
            // 
            this.buttonLosuj.Location = new System.Drawing.Point(138, 62);
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
            this.textBoxZakresDo.Size = new System.Drawing.Size(48, 20);
            this.textBoxZakresDo.TabIndex = 3;
            this.textBoxZakresDo.Text = "100";
            // 
            // textBoxZakresOd
            // 
            this.textBoxZakresOd.Location = new System.Drawing.Point(69, 43);
            this.textBoxZakresOd.Name = "textBoxZakresOd";
            this.textBoxZakresOd.Size = new System.Drawing.Size(48, 20);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 541);
            this.Controls.Add(this.groupBoxLosowanie);
            this.Controls.Add(this.buttonNowaGra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxLosowanie.ResumeLayout(false);
            this.groupBoxLosowanie.PerformLayout();
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
    }
}

