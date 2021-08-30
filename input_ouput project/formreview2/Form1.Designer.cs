
namespace formreview2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.txtposition = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.lbldisplay = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnmale = new System.Windows.Forms.RadioButton();
            this.rbtndemale = new System.Windows.Forms.RadioButton();
            this.dtdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleName = " ";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "name:";
            // 
            // label2
            // 
            this.label2.AccessibleName = " ";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Position:";
            // 
            // label3
            // 
            this.label3.AccessibleName = " ";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(111, 65);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(280, 23);
            this.txtname.TabIndex = 3;
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(111, 123);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(280, 23);
            this.txtsalary.TabIndex = 4;
            // 
            // txtposition
            // 
            this.txtposition.Location = new System.Drawing.Point(111, 94);
            this.txtposition.Name = "txtposition";
            this.txtposition.Size = new System.Drawing.Size(280, 23);
            this.txtposition.TabIndex = 5;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(411, 65);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(104, 32);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // lbldisplay
            // 
            this.lbldisplay.AccessibleName = " ";
            this.lbldisplay.AutoSize = true;
            this.lbldisplay.Location = new System.Drawing.Point(52, 304);
            this.lbldisplay.Name = "lbldisplay";
            this.lbldisplay.Size = new System.Drawing.Size(0, 15);
            this.lbldisplay.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AccessibleName = " ";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gender:";
            // 
            // rbtnmale
            // 
            this.rbtnmale.AutoSize = true;
            this.rbtnmale.Location = new System.Drawing.Point(154, 155);
            this.rbtnmale.Name = "rbtnmale";
            this.rbtnmale.Size = new System.Drawing.Size(51, 19);
            this.rbtnmale.TabIndex = 9;
            this.rbtnmale.TabStop = true;
            this.rbtnmale.Text = "male";
            this.rbtnmale.UseVisualStyleBackColor = true;
            // 
            // rbtndemale
            // 
            this.rbtndemale.AutoSize = true;
            this.rbtndemale.Location = new System.Drawing.Point(270, 155);
            this.rbtndemale.Name = "rbtndemale";
            this.rbtndemale.Size = new System.Drawing.Size(61, 19);
            this.rbtndemale.TabIndex = 10;
            this.rbtndemale.TabStop = true;
            this.rbtndemale.Text = "female";
            this.rbtndemale.UseVisualStyleBackColor = true;
            // 
            // dtdataGridView
            // 
            this.dtdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtdataGridView.Location = new System.Drawing.Point(75, 196);
            this.dtdataGridView.Name = "dtdataGridView";
            this.dtdataGridView.RowTemplate.Height = 25;
            this.dtdataGridView.Size = new System.Drawing.Size(416, 135);
            this.dtdataGridView.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 583);
            this.Controls.Add(this.dtdataGridView);
            this.Controls.Add(this.rbtndemale);
            this.Controls.Add(this.rbtnmale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbldisplay);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtposition);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.TextBox txtposition;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label lbldisplay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtnmale;
        private System.Windows.Forms.RadioButton rbtndemale;
        private System.Windows.Forms.DataGridView dtdataGridView;
    }
}

