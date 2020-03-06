namespace async_winform_task_await
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
            this.btnAwait = new System.Windows.Forms.Button();
            this.txtTal = new System.Windows.Forms.TextBox();
            this.btnAwaitAfbryd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSync = new System.Windows.Forms.Button();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnAwait
            // 
            this.btnAwait.Location = new System.Drawing.Point(93, 12);
            this.btnAwait.Name = "btnAwait";
            this.btnAwait.Size = new System.Drawing.Size(75, 23);
            this.btnAwait.TabIndex = 3;
            this.btnAwait.Text = "ASync";
            this.btnAwait.UseVisualStyleBackColor = true;
            this.btnAwait.Click += new System.EventHandler(this.BtnAwait_Click);
            // 
            // txtTal
            // 
            this.txtTal.BackColor = System.Drawing.Color.White;
            this.txtTal.Location = new System.Drawing.Point(93, 71);
            this.txtTal.Name = "txtTal";
            this.txtTal.ReadOnly = true;
            this.txtTal.Size = new System.Drawing.Size(75, 20);
            this.txtTal.TabIndex = 6;
            // 
            // btnAwaitAfbryd
            // 
            this.btnAwaitAfbryd.Enabled = false;
            this.btnAwaitAfbryd.Location = new System.Drawing.Point(93, 42);
            this.btnAwaitAfbryd.Name = "btnAwaitAfbryd";
            this.btnAwaitAfbryd.Size = new System.Drawing.Size(75, 23);
            this.btnAwaitAfbryd.TabIndex = 4;
            this.btnAwaitAfbryd.Text = "Afbryd";
            this.btnAwaitAfbryd.UseVisualStyleBackColor = true;
            this.btnAwaitAfbryd.Click += new System.EventHandler(this.BtnAwaitAfbryd_Click);
            this.btnAwaitAfbryd.MouseEnter += new System.EventHandler(this.BtnAwaitAfbryd_MouseEnter);
            this.btnAwaitAfbryd.MouseLeave += new System.EventHandler(this.BtnAwaitAfbryd_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tal fra nettet:";
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(12, 12);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(75, 23);
            this.btnSync.TabIndex = 0;
            this.btnSync.Text = "Sync";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.BtnSync_Click);
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(12, 98);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(156, 23);
            this.ProgressBar1.TabIndex = 7;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 128);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAwaitAfbryd);
            this.Controls.Add(this.txtTal);
            this.Controls.Add(this.btnAwait);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Async Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAwait;
        private System.Windows.Forms.TextBox txtTal;
        private System.Windows.Forms.Button btnAwaitAfbryd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.ProgressBar ProgressBar1;
        private System.Windows.Forms.Timer Timer1;
    }
}

