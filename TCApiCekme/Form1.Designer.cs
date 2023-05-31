namespace TCApiCekme
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tcTxb = new System.Windows.Forms.TextBox();
            this.adTxb = new System.Windows.Forms.TextBox();
            this.soyadTxb = new System.Windows.Forms.TextBox();
            this.dogumYiliTxb = new System.Windows.Forms.TextBox();
            this.sorgulaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(79, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C. Kimlik No : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(79, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad                  : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(79, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad             : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(79, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doğum Yılı      : ";
            // 
            // tcTxb
            // 
            this.tcTxb.Location = new System.Drawing.Point(216, 102);
            this.tcTxb.Name = "tcTxb";
            this.tcTxb.Size = new System.Drawing.Size(100, 22);
            this.tcTxb.TabIndex = 4;
            // 
            // adTxb
            // 
            this.adTxb.Location = new System.Drawing.Point(216, 136);
            this.adTxb.Name = "adTxb";
            this.adTxb.Size = new System.Drawing.Size(100, 22);
            this.adTxb.TabIndex = 5;
            // 
            // soyadTxb
            // 
            this.soyadTxb.Location = new System.Drawing.Point(216, 170);
            this.soyadTxb.Name = "soyadTxb";
            this.soyadTxb.Size = new System.Drawing.Size(100, 22);
            this.soyadTxb.TabIndex = 6;
            // 
            // dogumYiliTxb
            // 
            this.dogumYiliTxb.Location = new System.Drawing.Point(216, 200);
            this.dogumYiliTxb.Name = "dogumYiliTxb";
            this.dogumYiliTxb.Size = new System.Drawing.Size(100, 22);
            this.dogumYiliTxb.TabIndex = 7;
            // 
            // sorgulaBtn
            // 
            this.sorgulaBtn.Location = new System.Drawing.Point(216, 253);
            this.sorgulaBtn.Name = "sorgulaBtn";
            this.sorgulaBtn.Size = new System.Drawing.Size(89, 47);
            this.sorgulaBtn.TabIndex = 8;
            this.sorgulaBtn.Text = "Sorgula";
            this.sorgulaBtn.UseVisualStyleBackColor = true;
            this.sorgulaBtn.Click += new System.EventHandler(this.sorgulaBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sorgulaBtn);
            this.Controls.Add(this.dogumYiliTxb);
            this.Controls.Add(this.soyadTxb);
            this.Controls.Add(this.adTxb);
            this.Controls.Add(this.tcTxb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tcTxb;
        private System.Windows.Forms.TextBox adTxb;
        private System.Windows.Forms.TextBox soyadTxb;
        private System.Windows.Forms.TextBox dogumYiliTxb;
        private System.Windows.Forms.Button sorgulaBtn;
    }
}

