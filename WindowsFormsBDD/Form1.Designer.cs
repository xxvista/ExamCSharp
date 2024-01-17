namespace WindowsFormsBDD
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
            this.dgvEmployes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDATENAISS = new System.Windows.Forms.Label();
            this.tb_struct = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePickerDN = new System.Windows.Forms.DateTimePicker();
            this.labelEMAIL = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.labelPRENOM = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelNOM = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployes
            // 
            this.dgvEmployes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEmployes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployes.Location = new System.Drawing.Point(1, 389);
            this.dgvEmployes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEmployes.Name = "dgvEmployes";
            this.dgvEmployes.RowHeadersWidth = 51;
            this.dgvEmployes.RowTemplate.Height = 24;
            this.dgvEmployes.Size = new System.Drawing.Size(714, 250);
            this.dgvEmployes.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelDATENAISS);
            this.panel1.Controls.Add(this.tb_struct);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateTimePickerDN);
            this.panel1.Controls.Add(this.labelEMAIL);
            this.panel1.Controls.Add(this.textBoxPrenom);
            this.panel1.Controls.Add(this.labelPRENOM);
            this.panel1.Controls.Add(this.textBoxNom);
            this.panel1.Controls.Add(this.labelNOM);
            this.panel1.Location = new System.Drawing.Point(73, 57);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 206);
            this.panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(191, 156);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 33);
            this.comboBox1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mat";
            // 
            // labelDATENAISS
            // 
            this.labelDATENAISS.AutoSize = true;
            this.labelDATENAISS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDATENAISS.Location = new System.Drawing.Point(35, 159);
            this.labelDATENAISS.Name = "labelDATENAISS";
            this.labelDATENAISS.Size = new System.Drawing.Size(118, 25);
            this.labelDATENAISS.TabIndex = 6;
            this.labelDATENAISS.Text = "Date Naiss :";
            // 
            // tb_struct
            // 
            this.tb_struct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_struct.Location = new System.Drawing.Point(191, 4);
            this.tb_struct.Margin = new System.Windows.Forms.Padding(4);
            this.tb_struct.Name = "tb_struct";
            this.tb_struct.Size = new System.Drawing.Size(147, 30);
            this.tb_struct.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(392, 106);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 39);
            this.button2.TabIndex = 18;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 39);
            this.button1.TabIndex = 17;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePickerDN
            // 
            this.dateTimePickerDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDN.Location = new System.Drawing.Point(191, 115);
            this.dateTimePickerDN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDN.Name = "dateTimePickerDN";
            this.dateTimePickerDN.Size = new System.Drawing.Size(147, 30);
            this.dateTimePickerDN.TabIndex = 16;
            // 
            // labelEMAIL
            // 
            this.labelEMAIL.AutoSize = true;
            this.labelEMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEMAIL.Location = new System.Drawing.Point(35, 120);
            this.labelEMAIL.Name = "labelEMAIL";
            this.labelEMAIL.Size = new System.Drawing.Size(69, 25);
            this.labelEMAIL.TabIndex = 8;
            this.labelEMAIL.Text = "Sexe :";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrenom.Location = new System.Drawing.Point(191, 77);
            this.textBoxPrenom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(147, 30);
            this.textBoxPrenom.TabIndex = 5;
            // 
            // labelPRENOM
            // 
            this.labelPRENOM.AutoSize = true;
            this.labelPRENOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPRENOM.Location = new System.Drawing.Point(35, 80);
            this.labelPRENOM.Name = "labelPRENOM";
            this.labelPRENOM.Size = new System.Drawing.Size(91, 25);
            this.labelPRENOM.TabIndex = 4;
            this.labelPRENOM.Text = "Prenom :";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(191, 40);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(147, 30);
            this.textBoxNom.TabIndex = 3;
            // 
            // labelNOM
            // 
            this.labelNOM.AutoSize = true;
            this.labelNOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNOM.Location = new System.Drawing.Point(35, 43);
            this.labelNOM.Name = "labelNOM";
            this.labelNOM.Size = new System.Drawing.Size(64, 25);
            this.labelNOM.TabIndex = 2;
            this.labelNOM.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 46);
            this.label2.TabIndex = 22;
            this.label2.Text = "ITEEM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(719, 641);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvEmployes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "FormEmployes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelEMAIL;
        private System.Windows.Forms.Label labelDATENAISS;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label labelPRENOM;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelNOM;
        private System.Windows.Forms.DateTimePicker dateTimePickerDN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_struct;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}

