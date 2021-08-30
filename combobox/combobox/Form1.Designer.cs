
namespace combobox
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
            this.savebtn = new System.Windows.Forms.Button();
            this.coursecmb = new System.Windows.Forms.ComboBox();
            this.courselbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(534, 156);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(104, 42);
            this.savebtn.TabIndex = 0;
            this.savebtn.Text = "save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // coursecmb
            // 
            this.coursecmb.FormattingEnabled = true;
            this.coursecmb.Location = new System.Drawing.Point(243, 113);
            this.coursecmb.Name = "coursecmb";
            this.coursecmb.Size = new System.Drawing.Size(395, 23);
            this.coursecmb.TabIndex = 1;
            this.coursecmb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // courselbl
            // 
            this.courselbl.AutoSize = true;
            this.courselbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.courselbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.courselbl.Location = new System.Drawing.Point(128, 104);
            this.courselbl.Name = "courselbl";
            this.courselbl.Size = new System.Drawing.Size(107, 32);
            this.courselbl.TabIndex = 4;
            this.courselbl.Text = "Course: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.courselbl);
            this.Controls.Add(this.coursecmb);
            this.Controls.Add(this.savebtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.ComboBox coursecmb;
        private System.Windows.Forms.Label courselbl;
    }
}

