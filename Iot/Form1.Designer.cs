namespace Iot
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelChannel0 = new System.Windows.Forms.Label();
            this.labelChannel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelStatus0 = new System.Windows.Forms.Label();
            this.labelStatus1 = new System.Windows.Forms.Label();
            this.labelStatus2 = new System.Windows.Forms.Label();
            this.labelStatus3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Angsana New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Channel";
            // 
            // labelChannel0
            // 
            this.labelChannel0.AutoSize = true;
            this.labelChannel0.Font = new System.Drawing.Font("Angsana New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelChannel0.Location = new System.Drawing.Point(14, 89);
            this.labelChannel0.Name = "labelChannel0";
            this.labelChannel0.Size = new System.Drawing.Size(43, 29);
            this.labelChannel0.TabIndex = 1;
            this.labelChannel0.Text = "Ch0:";
            // 
            // labelChannel
            // 
            this.labelChannel.AutoSize = true;
            this.labelChannel.Font = new System.Drawing.Font("Angsana New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelChannel.Location = new System.Drawing.Point(14, 122);
            this.labelChannel.Name = "labelChannel";
            this.labelChannel.Size = new System.Drawing.Size(43, 29);
            this.labelChannel.TabIndex = 2;
            this.labelChannel.Text = "Ch1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Angsana New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(14, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ch2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Angsana New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(13, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ch3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Angsana New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(133, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status";
            // 
            // labelStatus0
            // 
            this.labelStatus0.AutoSize = true;
            this.labelStatus0.Font = new System.Drawing.Font("Angsana New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelStatus0.Location = new System.Drawing.Point(134, 89);
            this.labelStatus0.Name = "labelStatus0";
            this.labelStatus0.Size = new System.Drawing.Size(87, 29);
            this.labelStatus0.TabIndex = 6;
            this.labelStatus0.Text = "labelStatus0";
            // 
            // labelStatus1
            // 
            this.labelStatus1.AutoSize = true;
            this.labelStatus1.Font = new System.Drawing.Font("Angsana New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelStatus1.Location = new System.Drawing.Point(134, 122);
            this.labelStatus1.Name = "labelStatus1";
            this.labelStatus1.Size = new System.Drawing.Size(87, 29);
            this.labelStatus1.TabIndex = 7;
            this.labelStatus1.Text = "labelStatus1";
            // 
            // labelStatus2
            // 
            this.labelStatus2.AutoSize = true;
            this.labelStatus2.Font = new System.Drawing.Font("Angsana New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelStatus2.Location = new System.Drawing.Point(134, 154);
            this.labelStatus2.Name = "labelStatus2";
            this.labelStatus2.Size = new System.Drawing.Size(87, 29);
            this.labelStatus2.TabIndex = 8;
            this.labelStatus2.Text = "labelStatus2";
            // 
            // labelStatus3
            // 
            this.labelStatus3.AutoSize = true;
            this.labelStatus3.Font = new System.Drawing.Font("Angsana New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelStatus3.Location = new System.Drawing.Point(134, 187);
            this.labelStatus3.Name = "labelStatus3";
            this.labelStatus3.Size = new System.Drawing.Size(87, 29);
            this.labelStatus3.TabIndex = 9;
            this.labelStatus3.Text = "labelStatus3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Angsana New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 37);
            this.label11.TabIndex = 10;
            this.label11.Text = "IO Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(256, 246);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelStatus3);
            this.Controls.Add(this.labelStatus2);
            this.Controls.Add(this.labelStatus1);
            this.Controls.Add(this.labelStatus0);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelChannel);
            this.Controls.Add(this.labelChannel0);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelChannel0;
        private System.Windows.Forms.Label labelChannel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelStatus0;
        private System.Windows.Forms.Label labelStatus1;
        private System.Windows.Forms.Label labelStatus2;
        private System.Windows.Forms.Label labelStatus3;
        private System.Windows.Forms.Label label11;
    }
}

