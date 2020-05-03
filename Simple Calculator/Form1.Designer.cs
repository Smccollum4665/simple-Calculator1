namespace Simple_Calculator
{
    partial class Frm1
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
            this.labelOperand1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.txtOperand2 = new System.Windows.Forms.TextBox();
            this.labelOperand2 = new System.Windows.Forms.Label();
            this.txtOperator1 = new System.Windows.Forms.TextBox();
            this.labelOperator1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelOperand1
            // 
            this.labelOperand1.AutoSize = true;
            this.labelOperand1.Location = new System.Drawing.Point(43, 33);
            this.labelOperand1.Name = "labelOperand1";
            this.labelOperand1.Size = new System.Drawing.Size(76, 17);
            this.labelOperand1.TabIndex = 10;
            this.labelOperand1.Text = "Operand1:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(46, 224);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(82, 33);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate:";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtOperand1
            // 
            this.txtOperand1.AcceptsTab = true;
            this.txtOperand1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperand1.Location = new System.Drawing.Point(199, 33);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(100, 30);
            this.txtOperand1.TabIndex = 0;
            this.txtOperand1.Text = "0.00";
            //           
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(199, 159);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(100, 30);
            this.txtResult.TabIndex = 5;
            this.txtResult.TabStop = false;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(43, 169);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(52, 17);
            this.labelResult.TabIndex = 11;
            this.labelResult.Text = "Result:";
            // 
            // txtOperand2
            // 
            this.txtOperand2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperand2.Location = new System.Drawing.Point(199, 119);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.Size = new System.Drawing.Size(100, 30);
            this.txtOperand2.TabIndex = 3;
            this.txtOperand2.Text = "0.00";
            
            // 
            // labelOperand2
            // 
            this.labelOperand2.AutoSize = true;
            this.labelOperand2.Location = new System.Drawing.Point(43, 119);
            this.labelOperand2.Name = "labelOperand2";
            this.labelOperand2.Size = new System.Drawing.Size(76, 17);
            this.labelOperand2.TabIndex = 6;
            this.labelOperand2.Text = "Operand2:";
            // 
            // txtOperator1
            // 
            this.txtOperator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperator1.Location = new System.Drawing.Point(199, 72);
            this.txtOperator1.Name = "txtOperator1";
            this.txtOperator1.Size = new System.Drawing.Size(100, 34);
            this.txtOperator1.TabIndex = 1;
            this.txtOperator1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            
            // 
            // labelOperator1
            // 
            this.labelOperator1.AutoSize = true;
            this.labelOperator1.Location = new System.Drawing.Point(43, 72);
            this.labelOperator1.Name = "labelOperator1";
            this.labelOperator1.Size = new System.Drawing.Size(69, 17);
            this.labelOperator1.TabIndex = 8;
            this.labelOperator1.Text = "Operator:";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(208, 224);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 33);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&Exit:";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Frm1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(326, 316);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtOperator1);
            this.Controls.Add(this.labelOperator1);
            this.Controls.Add(this.txtOperand2);
            this.Controls.Add(this.labelOperand2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.txtOperand1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.labelOperand1);
            this.Name = "Frm1";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOperand1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtOperand1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox txtOperand2;
        private System.Windows.Forms.Label labelOperand2;
        private System.Windows.Forms.TextBox txtOperator1;
        private System.Windows.Forms.Label labelOperator1;
        private System.Windows.Forms.Button btnExit;
    }
}

