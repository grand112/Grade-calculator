namespace SredniaForm
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
            this.btnOblicz = new System.Windows.Forms.Button();
            this.txtOcena1 = new System.Windows.Forms.TextBox();
            this.txtOcena2 = new System.Windows.Forms.TextBox();
            this.txtSrednia = new System.Windows.Forms.TextBox();
            this.txtOcena3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOcena5 = new System.Windows.Forms.TextBox();
            this.txtOcena6 = new System.Windows.Forms.TextBox();
            this.txtOcena4 = new System.Windows.Forms.TextBox();
            this.OcenaNapis1 = new System.Windows.Forms.Label();
            this.OcenaNapis2 = new System.Windows.Forms.Label();
            this.OcenaNapis3 = new System.Windows.Forms.Label();
            this.OcenaNapis4 = new System.Windows.Forms.Label();
            this.OcenaNapis5 = new System.Windows.Forms.Label();
            this.OcenaNapis6 = new System.Windows.Forms.Label();
            this.SredniaNapis = new System.Windows.Forms.Label();
            this.txtZdane = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtPoprawne = new System.Windows.Forms.TextBox();
            this.btnWyczysc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOblicz
            // 
            this.btnOblicz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOblicz.Location = new System.Drawing.Point(301, 450);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(241, 52);
            this.btnOblicz.TabIndex = 0;
            this.btnOblicz.Text = "Oblicz Średnią";
            this.btnOblicz.UseVisualStyleBackColor = true;
            this.btnOblicz.Click += new System.EventHandler(this.btnOblicz_Click);
            // 
            // txtOcena1
            // 
            this.txtOcena1.Location = new System.Drawing.Point(158, 272);
            this.txtOcena1.Name = "txtOcena1";
            this.txtOcena1.Size = new System.Drawing.Size(93, 26);
            this.txtOcena1.TabIndex = 1;
            // 
            // txtOcena2
            // 
            this.txtOcena2.Location = new System.Drawing.Point(389, 269);
            this.txtOcena2.Name = "txtOcena2";
            this.txtOcena2.Size = new System.Drawing.Size(93, 26);
            this.txtOcena2.TabIndex = 2;
            // 
            // txtSrednia
            // 
            this.txtSrednia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSrednia.Location = new System.Drawing.Point(412, 626);
            this.txtSrednia.Name = "txtSrednia";
            this.txtSrednia.Size = new System.Drawing.Size(150, 30);
            this.txtSrednia.TabIndex = 3;
            this.txtSrednia.Visible = false;
            // 
            // txtOcena3
            // 
            this.txtOcena3.Location = new System.Drawing.Point(612, 269);
            this.txtOcena3.Name = "txtOcena3";
            this.txtOcena3.Size = new System.Drawing.Size(93, 26);
            this.txtOcena3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(223, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Witaj w kalkulatorze średniej!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(311, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Podaj swoje oceny:";
            // 
            // txtOcena5
            // 
            this.txtOcena5.Location = new System.Drawing.Point(389, 321);
            this.txtOcena5.Name = "txtOcena5";
            this.txtOcena5.Size = new System.Drawing.Size(93, 26);
            this.txtOcena5.TabIndex = 7;
            this.txtOcena5.Visible = false;
            // 
            // txtOcena6
            // 
            this.txtOcena6.Location = new System.Drawing.Point(612, 321);
            this.txtOcena6.Name = "txtOcena6";
            this.txtOcena6.Size = new System.Drawing.Size(93, 26);
            this.txtOcena6.TabIndex = 8;
            this.txtOcena6.Visible = false;
            // 
            // txtOcena4
            // 
            this.txtOcena4.Location = new System.Drawing.Point(158, 324);
            this.txtOcena4.Name = "txtOcena4";
            this.txtOcena4.Size = new System.Drawing.Size(93, 26);
            this.txtOcena4.TabIndex = 9;
            this.txtOcena4.Visible = false;
            // 
            // OcenaNapis1
            // 
            this.OcenaNapis1.AutoSize = true;
            this.OcenaNapis1.Location = new System.Drawing.Point(79, 278);
            this.OcenaNapis1.Name = "OcenaNapis1";
            this.OcenaNapis1.Size = new System.Drawing.Size(73, 20);
            this.OcenaNapis1.TabIndex = 10;
            this.OcenaNapis1.Text = "Ocena 1:";
            // 
            // OcenaNapis2
            // 
            this.OcenaNapis2.AutoSize = true;
            this.OcenaNapis2.Location = new System.Drawing.Point(312, 275);
            this.OcenaNapis2.Name = "OcenaNapis2";
            this.OcenaNapis2.Size = new System.Drawing.Size(73, 20);
            this.OcenaNapis2.TabIndex = 11;
            this.OcenaNapis2.Text = "Ocena 2:";
            // 
            // OcenaNapis3
            // 
            this.OcenaNapis3.AutoSize = true;
            this.OcenaNapis3.Location = new System.Drawing.Point(533, 275);
            this.OcenaNapis3.Name = "OcenaNapis3";
            this.OcenaNapis3.Size = new System.Drawing.Size(73, 20);
            this.OcenaNapis3.TabIndex = 12;
            this.OcenaNapis3.Text = "Ocena 3:";
            // 
            // OcenaNapis4
            // 
            this.OcenaNapis4.AutoSize = true;
            this.OcenaNapis4.Location = new System.Drawing.Point(79, 330);
            this.OcenaNapis4.Name = "OcenaNapis4";
            this.OcenaNapis4.Size = new System.Drawing.Size(73, 20);
            this.OcenaNapis4.TabIndex = 13;
            this.OcenaNapis4.Text = "Ocena 4:";
            this.OcenaNapis4.Visible = false;
            // 
            // OcenaNapis5
            // 
            this.OcenaNapis5.AutoSize = true;
            this.OcenaNapis5.Location = new System.Drawing.Point(312, 327);
            this.OcenaNapis5.Name = "OcenaNapis5";
            this.OcenaNapis5.Size = new System.Drawing.Size(73, 20);
            this.OcenaNapis5.TabIndex = 14;
            this.OcenaNapis5.Text = "Ocena 5:";
            this.OcenaNapis5.Visible = false;
            // 
            // OcenaNapis6
            // 
            this.OcenaNapis6.AutoSize = true;
            this.OcenaNapis6.Location = new System.Drawing.Point(533, 327);
            this.OcenaNapis6.Name = "OcenaNapis6";
            this.OcenaNapis6.Size = new System.Drawing.Size(73, 20);
            this.OcenaNapis6.TabIndex = 15;
            this.OcenaNapis6.Text = "Ocena 6:";
            this.OcenaNapis6.Visible = false;
            // 
            // SredniaNapis
            // 
            this.SredniaNapis.AutoSize = true;
            this.SredniaNapis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SredniaNapis.Location = new System.Drawing.Point(224, 631);
            this.SredniaNapis.Name = "SredniaNapis";
            this.SredniaNapis.Size = new System.Drawing.Size(161, 25);
            this.SredniaNapis.TabIndex = 16;
            this.SredniaNapis.Text = "Twoja średnia to:";
            this.SredniaNapis.Visible = false;
            // 
            // txtZdane
            // 
            this.txtZdane.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtZdane.Location = new System.Drawing.Point(130, 571);
            this.txtZdane.Name = "txtZdane";
            this.txtZdane.Size = new System.Drawing.Size(599, 30);
            this.txtZdane.TabIndex = 17;
            this.txtZdane.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtZdane.Visible = false;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(316, 371);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(217, 55);
            this.btnDodaj.TabIndex = 18;
            this.btnDodaj.Text = "Dodaj więcej rubryk na oceny";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtPoprawne
            // 
            this.txtPoprawne.BackColor = System.Drawing.Color.White;
            this.txtPoprawne.Location = new System.Drawing.Point(12, 527);
            this.txtPoprawne.Name = "txtPoprawne";
            this.txtPoprawne.Size = new System.Drawing.Size(771, 26);
            this.txtPoprawne.TabIndex = 25;
            this.txtPoprawne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPoprawne.Visible = false;
            // 
            // btnWyczysc
            // 
            this.btnWyczysc.Location = new System.Drawing.Point(326, 187);
            this.btnWyczysc.Name = "btnWyczysc";
            this.btnWyczysc.Size = new System.Drawing.Size(189, 38);
            this.btnWyczysc.TabIndex = 29;
            this.btnWyczysc.Text = "Wyczyść rubryki";
            this.btnWyczysc.UseVisualStyleBackColor = true;
            this.btnWyczysc.Click += new System.EventHandler(this.btnWyczysc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(795, 854);
            this.Controls.Add(this.btnWyczysc);
            this.Controls.Add(this.txtPoprawne);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtZdane);
            this.Controls.Add(this.SredniaNapis);
            this.Controls.Add(this.OcenaNapis6);
            this.Controls.Add(this.OcenaNapis5);
            this.Controls.Add(this.OcenaNapis4);
            this.Controls.Add(this.OcenaNapis3);
            this.Controls.Add(this.OcenaNapis2);
            this.Controls.Add(this.OcenaNapis1);
            this.Controls.Add(this.txtOcena4);
            this.Controls.Add(this.txtOcena6);
            this.Controls.Add(this.txtOcena5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOcena3);
            this.Controls.Add(this.txtSrednia);
            this.Controls.Add(this.txtOcena2);
            this.Controls.Add(this.txtOcena1);
            this.Controls.Add(this.btnOblicz);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator średniej";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.TextBox txtOcena1;
        private System.Windows.Forms.TextBox txtOcena2;
        private System.Windows.Forms.TextBox txtSrednia;
        private System.Windows.Forms.TextBox txtOcena3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOcena5;
        private System.Windows.Forms.TextBox txtOcena6;
        private System.Windows.Forms.TextBox txtOcena4;
        private System.Windows.Forms.Label OcenaNapis1;
        private System.Windows.Forms.Label OcenaNapis2;
        private System.Windows.Forms.Label OcenaNapis3;
        private System.Windows.Forms.Label OcenaNapis4;
        private System.Windows.Forms.Label OcenaNapis5;
        private System.Windows.Forms.Label OcenaNapis6;
        private System.Windows.Forms.Label SredniaNapis;
        private System.Windows.Forms.TextBox txtZdane;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtPoprawne;
        private System.Windows.Forms.Button btnWyczysc;
    }
}

