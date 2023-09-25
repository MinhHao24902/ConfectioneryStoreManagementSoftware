namespace QLCuaHangBanhKeo.GUI
{
    partial class frmThanhToanOnline
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnVisa = new System.Windows.Forms.Button();
            this.btnMOMO = new System.Windows.Forms.Button();
            this.btnATM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(124, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(943, 56);
            this.label2.TabIndex = 3;
            this.label2.Text = "CHỌN PHƯƠNG THỨC THANH TOÁN";
            // 
            // btnVisa
            // 
            this.btnVisa.BackgroundImage = global::QLCuaHangBanhKeo.Properties.Resources.VISA;
            this.btnVisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVisa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVisa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVisa.Location = new System.Drawing.Point(846, 182);
            this.btnVisa.Name = "btnVisa";
            this.btnVisa.Size = new System.Drawing.Size(274, 241);
            this.btnVisa.TabIndex = 6;
            this.btnVisa.UseVisualStyleBackColor = true;
            // 
            // btnMOMO
            // 
            this.btnMOMO.BackgroundImage = global::QLCuaHangBanhKeo.Properties.Resources.MOMO;
            this.btnMOMO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMOMO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMOMO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMOMO.Location = new System.Drawing.Point(449, 182);
            this.btnMOMO.Name = "btnMOMO";
            this.btnMOMO.Size = new System.Drawing.Size(274, 241);
            this.btnMOMO.TabIndex = 5;
            this.btnMOMO.UseVisualStyleBackColor = true;
            this.btnMOMO.Click += new System.EventHandler(this.btnMOMO_Click);
            // 
            // btnATM
            // 
            this.btnATM.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnATM.BackgroundImage = global::QLCuaHangBanhKeo.Properties.Resources.ATM;
            this.btnATM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnATM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnATM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnATM.Location = new System.Drawing.Point(56, 182);
            this.btnATM.Name = "btnATM";
            this.btnATM.Size = new System.Drawing.Size(274, 241);
            this.btnATM.TabIndex = 4;
            this.btnATM.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(475, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 41);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quét mã QR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(897, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 41);
            this.label3.TabIndex = 8;
            this.label3.Text = "Thẻ VISA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label4.Location = new System.Drawing.Point(98, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 41);
            this.label4.TabIndex = 9;
            this.label4.Text = "Thẻ ATM";
            // 
            // frmThanhToanOnline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1192, 584);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVisa);
            this.Controls.Add(this.btnMOMO);
            this.Controls.Add(this.btnATM);
            this.Controls.Add(this.label2);
            this.Name = "frmThanhToanOnline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThanhToanOnline";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnATM;
        private System.Windows.Forms.Button btnMOMO;
        private System.Windows.Forms.Button btnVisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}