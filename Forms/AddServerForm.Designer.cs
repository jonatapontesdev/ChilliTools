namespace JPRagTools.Forms
{
    partial class AddServerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddServerForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.processCB = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.txtName8 = new System.Windows.Forms.TextBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.txtName7 = new System.Windows.Forms.TextBox();
            this.txtName3 = new System.Windows.Forms.TextBox();
            this.txtName6 = new System.Windows.Forms.TextBox();
            this.txtName4 = new System.Windows.Forms.TextBox();
            this.txtName5 = new System.Windows.Forms.TextBox();
            this.txtHP1 = new System.Windows.Forms.TextBox();
            this.txtHP8 = new System.Windows.Forms.TextBox();
            this.txtHP2 = new System.Windows.Forms.TextBox();
            this.txtHP7 = new System.Windows.Forms.TextBox();
            this.txtHP3 = new System.Windows.Forms.TextBox();
            this.txtHP6 = new System.Windows.Forms.TextBox();
            this.txtHP4 = new System.Windows.Forms.TextBox();
            this.txtHP5 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtName1);
            this.groupBox1.Controls.Add(this.txtName8);
            this.groupBox1.Controls.Add(this.txtName2);
            this.groupBox1.Controls.Add(this.txtName7);
            this.groupBox1.Controls.Add(this.txtName3);
            this.groupBox1.Controls.Add(this.txtName6);
            this.groupBox1.Controls.Add(this.txtName4);
            this.groupBox1.Controls.Add(this.txtName5);
            this.groupBox1.Controls.Add(this.txtHP1);
            this.groupBox1.Controls.Add(this.txtHP8);
            this.groupBox1.Controls.Add(this.txtHP2);
            this.groupBox1.Controls.Add(this.txtHP7);
            this.groupBox1.Controls.Add(this.txtHP3);
            this.groupBox1.Controls.Add(this.txtHP6);
            this.groupBox1.Controls.Add(this.txtHP4);
            this.groupBox1.Controls.Add(this.txtHP5);
            this.groupBox1.Controls.Add(this.processCB);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Novo Servidor";
            // 
            // processCB
            // 
            this.processCB.FormattingEnabled = true;
            this.processCB.Location = new System.Drawing.Point(137, 104);
            this.processCB.Name = "processCB";
            this.processCB.Size = new System.Drawing.Size(204, 21);
            this.processCB.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(224, 144);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nome do Processo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "0 x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "0 x";
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(64, 144);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "HP Address:";
            // 
            // txtName1
            // 
            this.txtName1.Location = new System.Drawing.Point(137, 68);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(20, 20);
            this.txtName1.TabIndex = 26;
            this.txtName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName8
            // 
            this.txtName8.Location = new System.Drawing.Point(321, 68);
            this.txtName8.Name = "txtName8";
            this.txtName8.Size = new System.Drawing.Size(20, 20);
            this.txtName8.TabIndex = 33;
            this.txtName8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(163, 68);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(20, 20);
            this.txtName2.TabIndex = 27;
            this.txtName2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName7
            // 
            this.txtName7.Location = new System.Drawing.Point(295, 68);
            this.txtName7.Name = "txtName7";
            this.txtName7.Size = new System.Drawing.Size(20, 20);
            this.txtName7.TabIndex = 32;
            this.txtName7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName3
            // 
            this.txtName3.Location = new System.Drawing.Point(190, 68);
            this.txtName3.Name = "txtName3";
            this.txtName3.Size = new System.Drawing.Size(20, 20);
            this.txtName3.TabIndex = 28;
            this.txtName3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName6
            // 
            this.txtName6.Location = new System.Drawing.Point(268, 68);
            this.txtName6.Name = "txtName6";
            this.txtName6.Size = new System.Drawing.Size(20, 20);
            this.txtName6.TabIndex = 31;
            this.txtName6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName4
            // 
            this.txtName4.Location = new System.Drawing.Point(216, 68);
            this.txtName4.Name = "txtName4";
            this.txtName4.Size = new System.Drawing.Size(20, 20);
            this.txtName4.TabIndex = 29;
            this.txtName4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName5
            // 
            this.txtName5.Location = new System.Drawing.Point(242, 68);
            this.txtName5.Name = "txtName5";
            this.txtName5.Size = new System.Drawing.Size(20, 20);
            this.txtName5.TabIndex = 30;
            this.txtName5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHP1
            // 
            this.txtHP1.Location = new System.Drawing.Point(137, 31);
            this.txtHP1.Name = "txtHP1";
            this.txtHP1.Size = new System.Drawing.Size(20, 20);
            this.txtHP1.TabIndex = 18;
            this.txtHP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHP8
            // 
            this.txtHP8.Location = new System.Drawing.Point(321, 31);
            this.txtHP8.Name = "txtHP8";
            this.txtHP8.Size = new System.Drawing.Size(20, 20);
            this.txtHP8.TabIndex = 25;
            this.txtHP8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHP2
            // 
            this.txtHP2.Location = new System.Drawing.Point(163, 31);
            this.txtHP2.Name = "txtHP2";
            this.txtHP2.Size = new System.Drawing.Size(20, 20);
            this.txtHP2.TabIndex = 19;
            this.txtHP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHP7
            // 
            this.txtHP7.Location = new System.Drawing.Point(295, 31);
            this.txtHP7.Name = "txtHP7";
            this.txtHP7.Size = new System.Drawing.Size(20, 20);
            this.txtHP7.TabIndex = 24;
            this.txtHP7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHP3
            // 
            this.txtHP3.Location = new System.Drawing.Point(190, 31);
            this.txtHP3.Name = "txtHP3";
            this.txtHP3.Size = new System.Drawing.Size(20, 20);
            this.txtHP3.TabIndex = 20;
            this.txtHP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHP6
            // 
            this.txtHP6.Location = new System.Drawing.Point(268, 31);
            this.txtHP6.Name = "txtHP6";
            this.txtHP6.Size = new System.Drawing.Size(20, 20);
            this.txtHP6.TabIndex = 23;
            this.txtHP6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHP4
            // 
            this.txtHP4.Location = new System.Drawing.Point(216, 31);
            this.txtHP4.Name = "txtHP4";
            this.txtHP4.Size = new System.Drawing.Size(20, 20);
            this.txtHP4.TabIndex = 21;
            this.txtHP4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHP5
            // 
            this.txtHP5.Location = new System.Drawing.Point(242, 31);
            this.txtHP5.Name = "txtHP5";
            this.txtHP5.Size = new System.Drawing.Size(20, 20);
            this.txtHP5.TabIndex = 22;
            this.txtHP5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(385, 224);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddServerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Novo Servidor";
            this.Load += new System.EventHandler(this.AddServerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox processCB;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.TextBox txtName8;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.TextBox txtName7;
        private System.Windows.Forms.TextBox txtName3;
        private System.Windows.Forms.TextBox txtName6;
        private System.Windows.Forms.TextBox txtName4;
        private System.Windows.Forms.TextBox txtName5;
        private System.Windows.Forms.TextBox txtHP1;
        private System.Windows.Forms.TextBox txtHP8;
        private System.Windows.Forms.TextBox txtHP2;
        private System.Windows.Forms.TextBox txtHP7;
        private System.Windows.Forms.TextBox txtHP3;
        private System.Windows.Forms.TextBox txtHP6;
        private System.Windows.Forms.TextBox txtHP4;
        private System.Windows.Forms.TextBox txtHP5;
    }
}