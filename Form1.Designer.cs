namespace CSharp_TinhTienLai
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
            this.lblsotien = new System.Windows.Forms.Label();
            this.btntinh = new System.Windows.Forms.Button();
            this.txtlaisuat = new System.Windows.Forms.TextBox();
            this.lbx = new System.Windows.Forms.ListBox();
            this.lbllaisuat = new System.Windows.Forms.Label();
            this.lbltiengui = new System.Windows.Forms.Label();
            this.txtsotien = new System.Windows.Forms.TextBox();
            this.txttiengui = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblsotien
            // 
            this.lblsotien.AutoSize = true;
            this.lblsotien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsotien.Location = new System.Drawing.Point(175, 109);
            this.lblsotien.Name = "lblsotien";
            this.lblsotien.Size = new System.Drawing.Size(105, 31);
            this.lblsotien.TabIndex = 0;
            this.lblsotien.Text = "Số tiền";
            // 
            // btntinh
            // 
            this.btntinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntinh.Location = new System.Drawing.Point(514, 276);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(100, 45);
            this.btntinh.TabIndex = 1;
            this.btntinh.Text = "tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // txtlaisuat
            // 
            this.txtlaisuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlaisuat.Location = new System.Drawing.Point(362, 166);
            this.txtlaisuat.Name = "txtlaisuat";
            this.txtlaisuat.Size = new System.Drawing.Size(147, 31);
            this.txtlaisuat.TabIndex = 2;
            // 
            // lbx
            // 
            this.lbx.FormattingEnabled = true;
            this.lbx.Location = new System.Drawing.Point(144, 312);
            this.lbx.Name = "lbx";
            this.lbx.Size = new System.Drawing.Size(237, 95);
            this.lbx.TabIndex = 3;
            // 
            // lbllaisuat
            // 
            this.lbllaisuat.AutoSize = true;
            this.lbllaisuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllaisuat.Location = new System.Drawing.Point(175, 166);
            this.lbllaisuat.Name = "lbllaisuat";
            this.lbllaisuat.Size = new System.Drawing.Size(117, 31);
            this.lbllaisuat.TabIndex = 4;
            this.lbllaisuat.Text = "Lãi suất";
            // 
            // lbltiengui
            // 
            this.lbltiengui.AutoSize = true;
            this.lbltiengui.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltiengui.Location = new System.Drawing.Point(175, 215);
            this.lbltiengui.Name = "lbltiengui";
            this.lbltiengui.Size = new System.Drawing.Size(152, 31);
            this.lbltiengui.TabIndex = 5;
            this.lbltiengui.Text = "Số tiền gửi";
            // 
            // txtsotien
            // 
            this.txtsotien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsotien.Location = new System.Drawing.Point(362, 109);
            this.txtsotien.Name = "txtsotien";
            this.txtsotien.Size = new System.Drawing.Size(147, 31);
            this.txtsotien.TabIndex = 2;
            // 
            // txttiengui
            // 
            this.txttiengui.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttiengui.Location = new System.Drawing.Point(362, 218);
            this.txttiengui.Name = "txttiengui";
            this.txttiengui.Size = new System.Drawing.Size(147, 31);
            this.txttiengui.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttiengui);
            this.Controls.Add(this.lbltiengui);
            this.Controls.Add(this.lbllaisuat);
            this.Controls.Add(this.lbx);
            this.Controls.Add(this.txtsotien);
            this.Controls.Add(this.txtlaisuat);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.lblsotien);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsotien;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.TextBox txtlaisuat;
        private System.Windows.Forms.ListBox lbx;
        private System.Windows.Forms.Label lbllaisuat;
        private System.Windows.Forms.Label lbltiengui;
        private System.Windows.Forms.TextBox txtsotien;
        private System.Windows.Forms.TextBox txttiengui;
    }
}

