namespace Int.Refnumber_App
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
            this.btnValidate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputValidate = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtOutputValidate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInputCreate = new System.Windows.Forms.TextBox();
            this.txtOutputCreate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(197, 67);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 0;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter RefNumber";
            // 
            // txtInputValidate
            // 
            this.txtInputValidate.Location = new System.Drawing.Point(12, 25);
            this.txtInputValidate.Name = "txtInputValidate";
            this.txtInputValidate.Size = new System.Drawing.Size(128, 20);
            this.txtInputValidate.TabIndex = 2;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(197, 176);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtOutputValidate
            // 
            this.txtOutputValidate.Location = new System.Drawing.Point(12, 67);
            this.txtOutputValidate.Name = "txtOutputValidate";
            this.txtOutputValidate.Size = new System.Drawing.Size(128, 20);
            this.txtOutputValidate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter RefNumber base";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Result";
            // 
            // txtInputCreate
            // 
            this.txtInputCreate.Location = new System.Drawing.Point(12, 137);
            this.txtInputCreate.Name = "txtInputCreate";
            this.txtInputCreate.Size = new System.Drawing.Size(128, 20);
            this.txtInputCreate.TabIndex = 8;
            // 
            // txtOutputCreate
            // 
            this.txtOutputCreate.Location = new System.Drawing.Point(12, 179);
            this.txtOutputCreate.Name = "txtOutputCreate";
            this.txtOutputCreate.Size = new System.Drawing.Size(128, 20);
            this.txtOutputCreate.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 210);
            this.Controls.Add(this.txtOutputCreate);
            this.Controls.Add(this.txtInputCreate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOutputValidate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtInputValidate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValidate);
            this.Name = "Form1";
            this.Text = "Int Refnumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputValidate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtOutputValidate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInputCreate;
        private System.Windows.Forms.TextBox txtOutputCreate;
    }
}

