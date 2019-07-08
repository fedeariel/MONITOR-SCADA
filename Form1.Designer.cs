namespace MONITOR_SCADA
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
            this.rd = new VncSharp.RemoteDesktop();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // rd
            // 
            this.rd.AutoScroll = true;
            this.rd.AutoScrollMinSize = new System.Drawing.Size(608, 427);
            this.rd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rd.Location = new System.Drawing.Point(0, 0);
            this.rd.Name = "rd";
            this.rd.Size = new System.Drawing.Size(974, 552);
            this.rd.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 552);
            this.Controls.Add(this.rd);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MONITOR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private VncSharp.RemoteDesktop rd;
        private System.Windows.Forms.Timer timer1;

    }
}