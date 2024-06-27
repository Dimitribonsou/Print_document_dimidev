namespace PrintDocument
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxsection = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxclass = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnM = new System.Windows.Forms.RadioButton();
            this.rbtnF = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtdoc = new System.Windows.Forms.TextBox();
            this.btnDoc = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxDoc = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(114, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Image";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Location = new System.Drawing.Point(303, 182);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(254, 15);
            this.txtName.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(303, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 2);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 2);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(677, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "section";
            // 
            // comboBoxsection
            // 
            this.comboBoxsection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxsection.FormattingEnabled = true;
            this.comboBoxsection.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.comboBoxsection.Location = new System.Drawing.Point(643, 182);
            this.comboBoxsection.Name = "comboBoxsection";
            this.comboBoxsection.Size = new System.Drawing.Size(154, 24);
            this.comboBoxsection.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Location = new System.Drawing.Point(643, 202);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(154, 2);
            this.panel3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Class";
            // 
            // comboBoxclass
            // 
            this.comboBoxclass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxclass.FormattingEnabled = true;
            this.comboBoxclass.Items.AddRange(new object[] {
            "one",
            "two",
            "three",
            "four",
            "five",
            "six",
            "seven",
            "eight",
            "nine",
            "ten",
            "eleven",
            "twelve"});
            this.comboBoxclass.Location = new System.Drawing.Point(303, 283);
            this.comboBoxclass.Name = "comboBoxclass";
            this.comboBoxclass.Size = new System.Drawing.Size(154, 24);
            this.comboBoxclass.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Location = new System.Drawing.Point(303, 303);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(154, 2);
            this.panel4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gender";
            // 
            // rbtnM
            // 
            this.rbtnM.AutoSize = true;
            this.rbtnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnM.Location = new System.Drawing.Point(656, 270);
            this.rbtnM.Name = "rbtnM";
            this.rbtnM.Size = new System.Drawing.Size(70, 24);
            this.rbtnM.TabIndex = 7;
            this.rbtnM.TabStop = true;
            this.rbtnM.Text = "Male";
            this.rbtnM.UseVisualStyleBackColor = true;
            // 
            // rbtnF
            // 
            this.rbtnF.AutoSize = true;
            this.rbtnF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnF.Location = new System.Drawing.Point(656, 309);
            this.rbtnF.Name = "rbtnF";
            this.rbtnF.Size = new System.Drawing.Size(91, 24);
            this.rbtnF.TabIndex = 7;
            this.rbtnF.TabStop = true;
            this.rbtnF.Text = "Female";
            this.rbtnF.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(385, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "Generate Invoice";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackColor = System.Drawing.Color.White;
            this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxImage.Location = new System.Drawing.Point(114, 112);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(155, 166);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtdoc
            // 
            this.txtdoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdoc.Location = new System.Drawing.Point(114, 470);
            this.txtdoc.Multiline = true;
            this.txtdoc.Name = "txtdoc";
            this.txtdoc.Size = new System.Drawing.Size(172, 39);
            this.txtdoc.TabIndex = 8;
            this.txtdoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDoc
            // 
            this.btnDoc.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDoc.FlatAppearance.BorderSize = 0;
            this.btnDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDoc.Location = new System.Drawing.Point(130, 515);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(155, 45);
            this.btnDoc.TabIndex = 1;
            this.btnDoc.Text = "Document";
            this.btnDoc.UseVisualStyleBackColor = false;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // pictureBoxDoc
            // 
            this.pictureBoxDoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxDoc.Location = new System.Drawing.Point(115, 360);
            this.pictureBoxDoc.Name = "pictureBoxDoc";
            this.pictureBoxDoc.Size = new System.Drawing.Size(171, 149);
            this.pictureBoxDoc.TabIndex = 9;
            this.pictureBoxDoc.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(869, 694);
            this.Controls.Add(this.rbtnF);
            this.Controls.Add(this.rbtnM);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.comboBoxclass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxsection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDoc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.txtdoc);
            this.Controls.Add(this.pictureBoxDoc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxsection;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxclass;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtnM;
        private System.Windows.Forms.RadioButton rbtnF;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtdoc;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.PictureBox pictureBoxDoc;
    }
}

