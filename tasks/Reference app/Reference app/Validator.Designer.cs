namespace Reference_app
{
    partial class Validator
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
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRefnum = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(158, 149);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 40);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Refrence number";
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(29, 149);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(99, 40);
            this.btnValidate.TabIndex = 3;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result";
            // 
            // txtRefnum
            // 
            this.txtRefnum.Location = new System.Drawing.Point(111, 37);
            this.txtRefnum.Name = "txtRefnum";
            this.txtRefnum.Size = new System.Drawing.Size(146, 20);
            this.txtRefnum.TabIndex = 5;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(111, 103);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(146, 20);
            this.txtResult.TabIndex = 6;
            // 
            // Validator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtRefnum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Name = "Validator";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Validator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRefnum;
        private System.Windows.Forms.TextBox txtResult;
    }
}