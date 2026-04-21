namespace Dictionary_của_4_cô_CS
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
            this.panelsearch = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelfamily = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbsynonym = new System.Windows.Forms.ListBox();
            this.panelwordfamily = new System.Windows.Forms.Panel();
            this.lbwordfamily = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelmeaning = new System.Windows.Forms.Panel();
            this.rtbmeanings = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelword = new System.Windows.Forms.Label();
            this.panelsearch.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelfamily.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelwordfamily.SuspendLayout();
            this.panelmeaning.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelsearch
            // 
            this.panelsearch.Controls.Add(this.label4);
            this.panelsearch.Controls.Add(this.textBox1);
            this.panelsearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsearch.Location = new System.Drawing.Point(0, 0);
            this.panelsearch.Name = "panelsearch";
            this.panelsearch.Size = new System.Drawing.Size(1252, 78);
            this.panelsearch.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "English";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(190, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelfamily);
            this.panel2.Controls.Add(this.panelmeaning);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1252, 688);
            this.panel2.TabIndex = 1;
            // 
            // panelfamily
            // 
            this.panelfamily.Controls.Add(this.panel1);
            this.panelfamily.Controls.Add(this.panelwordfamily);
            this.panelfamily.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelfamily.Location = new System.Drawing.Point(946, 0);
            this.panelfamily.Name = "panelfamily";
            this.panelfamily.Size = new System.Drawing.Size(306, 688);
            this.panelfamily.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbsynonym);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 349);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(18, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Synonyms";
            // 
            // lbsynonym
            // 
            this.lbsynonym.FormattingEnabled = true;
            this.lbsynonym.ItemHeight = 16;
            this.lbsynonym.Location = new System.Drawing.Point(18, 55);
            this.lbsynonym.Name = "lbsynonym";
            this.lbsynonym.Size = new System.Drawing.Size(270, 276);
            this.lbsynonym.TabIndex = 0;
            // 
            // panelwordfamily
            // 
            this.panelwordfamily.BackColor = System.Drawing.Color.SeaGreen;
            this.panelwordfamily.Controls.Add(this.lbwordfamily);
            this.panelwordfamily.Controls.Add(this.label2);
            this.panelwordfamily.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelwordfamily.Location = new System.Drawing.Point(0, 0);
            this.panelwordfamily.Name = "panelwordfamily";
            this.panelwordfamily.Size = new System.Drawing.Size(306, 339);
            this.panelwordfamily.TabIndex = 0;
            // 
            // lbwordfamily
            // 
            this.lbwordfamily.FormattingEnabled = true;
            this.lbwordfamily.ItemHeight = 16;
            this.lbwordfamily.Location = new System.Drawing.Point(18, 44);
            this.lbwordfamily.Name = "lbwordfamily";
            this.lbwordfamily.Size = new System.Drawing.Size(270, 276);
            this.lbwordfamily.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Word family";
            // 
            // panelmeaning
            // 
            this.panelmeaning.BackColor = System.Drawing.Color.LightPink;
            this.panelmeaning.Controls.Add(this.rtbmeanings);
            this.panelmeaning.Controls.Add(this.label1);
            this.panelmeaning.Controls.Add(this.labelword);
            this.panelmeaning.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmeaning.Location = new System.Drawing.Point(0, 0);
            this.panelmeaning.Name = "panelmeaning";
            this.panelmeaning.Size = new System.Drawing.Size(946, 688);
            this.panelmeaning.TabIndex = 0;
            // 
            // rtbmeanings
            // 
            this.rtbmeanings.Location = new System.Drawing.Point(19, 53);
            this.rtbmeanings.Name = "rtbmeanings";
            this.rtbmeanings.Size = new System.Drawing.Size(900, 613);
            this.rtbmeanings.TabIndex = 2;
            this.rtbmeanings.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "phiên âm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelword
            // 
            this.labelword.AutoSize = true;
            this.labelword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelword.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelword.Location = new System.Drawing.Point(13, 7);
            this.labelword.Name = "labelword";
            this.labelword.Size = new System.Drawing.Size(150, 32);
            this.labelword.TabIndex = 0;
            this.labelword.Text = "Từ cần tra";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 766);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelsearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelsearch.ResumeLayout(false);
            this.panelsearch.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelfamily.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelwordfamily.ResumeLayout(false);
            this.panelwordfamily.PerformLayout();
            this.panelmeaning.ResumeLayout(false);
            this.panelmeaning.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelsearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelfamily;
        private System.Windows.Forms.Panel panelmeaning;
        private System.Windows.Forms.Label labelword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelwordfamily;
        private System.Windows.Forms.RichTextBox rtbmeanings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbsynonym;
        private System.Windows.Forms.ListBox lbwordfamily;
        private System.Windows.Forms.Label label2;
    }
}

