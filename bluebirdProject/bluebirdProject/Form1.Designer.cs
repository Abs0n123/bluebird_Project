namespace bluebirdProject
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
            this.BtnAfsluiten = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BTNToeveogen = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBStoel = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBEconomy = new System.Windows.Forms.RadioButton();
            this.RBBuisnes = new System.Windows.Forms.RadioButton();
            this.RBFirstClas = new System.Windows.Forms.RadioButton();
            this.TBXNaam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RbAllen = new System.Windows.Forms.RadioButton();
            this.TbxVrij = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAfsluiten
            // 
            this.BtnAfsluiten.Location = new System.Drawing.Point(191, 300);
            this.BtnAfsluiten.Name = "BtnAfsluiten";
            this.BtnAfsluiten.Size = new System.Drawing.Size(75, 54);
            this.BtnAfsluiten.TabIndex = 0;
            this.BtnAfsluiten.Text = "Programma afsluiten";
            this.BtnAfsluiten.UseVisualStyleBackColor = true;
            this.BtnAfsluiten.Click += new System.EventHandler(this.BtnAfsluiten_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Stoel vrijgeven";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTNToeveogen
            // 
            this.BTNToeveogen.Location = new System.Drawing.Point(29, 300);
            this.BTNToeveogen.Name = "BTNToeveogen";
            this.BTNToeveogen.Size = new System.Drawing.Size(75, 54);
            this.BTNToeveogen.TabIndex = 2;
            this.BTNToeveogen.Text = "Stoel toevoegen";
            this.BTNToeveogen.UseVisualStyleBackColor = true;
            this.BTNToeveogen.Click += new System.EventHandler(this.BTNToeveogen_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(316, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 342);
            this.listBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "stoel:";
            // 
            // CBStoel
            // 
            this.CBStoel.FormattingEnabled = true;
            this.CBStoel.Location = new System.Drawing.Point(61, 259);
            this.CBStoel.Name = "CBStoel";
            this.CBStoel.Size = new System.Drawing.Size(121, 21);
            this.CBStoel.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbAllen);
            this.groupBox1.Controls.Add(this.RBEconomy);
            this.groupBox1.Controls.Add(this.RBBuisnes);
            this.groupBox1.Controls.Add(this.RBFirstClas);
            this.groupBox1.Location = new System.Drawing.Point(29, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 160);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class";
            // 
            // RBEconomy
            // 
            this.RBEconomy.AutoSize = true;
            this.RBEconomy.Location = new System.Drawing.Point(6, 104);
            this.RBEconomy.Name = "RBEconomy";
            this.RBEconomy.Size = new System.Drawing.Size(96, 17);
            this.RBEconomy.TabIndex = 2;
            this.RBEconomy.TabStop = true;
            this.RBEconomy.Text = "Economy class";
            this.RBEconomy.UseVisualStyleBackColor = true;
            this.RBEconomy.CheckedChanged += new System.EventHandler(this.RBEconomy_CheckedChanged);
            // 
            // RBBuisnes
            // 
            this.RBBuisnes.AutoSize = true;
            this.RBBuisnes.Location = new System.Drawing.Point(6, 67);
            this.RBBuisnes.Name = "RBBuisnes";
            this.RBBuisnes.Size = new System.Drawing.Size(89, 17);
            this.RBBuisnes.TabIndex = 1;
            this.RBBuisnes.TabStop = true;
            this.RBBuisnes.Text = "Buisnes class";
            this.RBBuisnes.UseVisualStyleBackColor = true;
            this.RBBuisnes.CheckedChanged += new System.EventHandler(this.RBBuisnes_CheckedChanged);
            // 
            // RBFirstClas
            // 
            this.RBFirstClas.AutoSize = true;
            this.RBFirstClas.Location = new System.Drawing.Point(6, 30);
            this.RBFirstClas.Name = "RBFirstClas";
            this.RBFirstClas.Size = new System.Drawing.Size(71, 17);
            this.RBFirstClas.TabIndex = 0;
            this.RBFirstClas.TabStop = true;
            this.RBFirstClas.Text = "First class";
            this.RBFirstClas.UseVisualStyleBackColor = true;
            this.RBFirstClas.CheckedChanged += new System.EventHandler(this.RBFirstClas_CheckedChanged);
            // 
            // TBXNaam
            // 
            this.TBXNaam.Location = new System.Drawing.Point(76, 39);
            this.TBXNaam.Name = "TBXNaam";
            this.TBXNaam.Size = new System.Drawing.Size(121, 20);
            this.TBXNaam.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Naam:";
            // 
            // RbAllen
            // 
            this.RbAllen.AutoSize = true;
            this.RbAllen.Location = new System.Drawing.Point(6, 137);
            this.RbAllen.Name = "RbAllen";
            this.RbAllen.Size = new System.Drawing.Size(69, 17);
            this.RbAllen.TabIndex = 3;
            this.RbAllen.TabStop = true;
            this.RbAllen.Text = "Toon alle";
            this.RbAllen.UseVisualStyleBackColor = true;
            this.RbAllen.CheckedChanged += new System.EventHandler(this.RbAllen_CheckedChanged);
            // 
            // TbxVrij
            // 
            this.TbxVrij.Enabled = false;
            this.TbxVrij.HideSelection = false;
            this.TbxVrij.Location = new System.Drawing.Point(76, 12);
            this.TbxVrij.Name = "TbxVrij";
            this.TbxVrij.ReadOnly = true;
            this.TbxVrij.Size = new System.Drawing.Size(121, 20);
            this.TbxVrij.TabIndex = 9;
            this.TbxVrij.Text = "Vrij";
            this.TbxVrij.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 368);
            this.Controls.Add(this.TbxVrij);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBXNaam);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CBStoel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BTNToeveogen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnAfsluiten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAfsluiten;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BTNToeveogen;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBStoel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBEconomy;
        private System.Windows.Forms.RadioButton RBBuisnes;
        private System.Windows.Forms.RadioButton RBFirstClas;
        private System.Windows.Forms.TextBox TBXNaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RbAllen;
        private System.Windows.Forms.TextBox TbxVrij;
    }
}

