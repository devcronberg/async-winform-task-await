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
            this.btnTask = new System.Windows.Forms.Button();
            this.btnAwait = new System.Windows.Forms.Button();
            this.txtTal = new System.Windows.Forms.TextBox();
            this.btnAwaitAfbryd = new System.Windows.Forms.Button();
            this.chkDanFejl = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaskAfbryd = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTask
            // 
            this.btnTask.Location = new System.Drawing.Point(132, 38);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(75, 23);
            this.btnTask.TabIndex = 1;
            this.btnTask.Text = "Med Task";
            this.btnTask.UseVisualStyleBackColor = true;
            this.btnTask.Click += new System.EventHandler(this.BtnTask_Click);
            // 
            // btnAwait
            // 
            this.btnAwait.Location = new System.Drawing.Point(223, 38);
            this.btnAwait.Name = "btnAwait";
            this.btnAwait.Size = new System.Drawing.Size(75, 23);
            this.btnAwait.TabIndex = 3;
            this.btnAwait.Text = "Med await";
            this.btnAwait.UseVisualStyleBackColor = true;
            this.btnAwait.Click += new System.EventHandler(this.BtnAwait_Click);
            // 
            // txtTal
            // 
            this.txtTal.Location = new System.Drawing.Point(230, 126);
            this.txtTal.Name = "txtTal";
            this.txtTal.ReadOnly = true;
            this.txtTal.Size = new System.Drawing.Size(68, 20);
            this.txtTal.TabIndex = 6;
            // 
            // btnAwaitAfbryd
            // 
            this.btnAwaitAfbryd.Enabled = false;
            this.btnAwaitAfbryd.Location = new System.Drawing.Point(223, 68);
            this.btnAwaitAfbryd.Name = "btnAwaitAfbryd";
            this.btnAwaitAfbryd.Size = new System.Drawing.Size(75, 23);
            this.btnAwaitAfbryd.TabIndex = 4;
            this.btnAwaitAfbryd.Text = "Afbryd";
            this.btnAwaitAfbryd.UseVisualStyleBackColor = true;
            this.btnAwaitAfbryd.Click += new System.EventHandler(this.BtnAwaitAfbryd_Click);
            // 
            // chkDanFejl
            // 
            this.chkDanFejl.AutoSize = true;
            this.chkDanFejl.Location = new System.Drawing.Point(39, 129);
            this.chkDanFejl.Name = "chkDanFejl";
            this.chkDanFejl.Size = new System.Drawing.Size(62, 17);
            this.chkDanFejl.TabIndex = 5;
            this.chkDanFejl.Text = "Dan fejl";
            this.chkDanFejl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkDanFejl.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tal fra nettet:";
            // 
            // btnTaskAfbryd
            // 
            this.btnTaskAfbryd.Enabled = false;
            this.btnTaskAfbryd.Location = new System.Drawing.Point(132, 68);
            this.btnTaskAfbryd.Name = "btnTaskAfbryd";
            this.btnTaskAfbryd.Size = new System.Drawing.Size(75, 23);
            this.btnTaskAfbryd.TabIndex = 2;
            this.btnTaskAfbryd.Text = "Afbryd";
            this.btnTaskAfbryd.UseVisualStyleBackColor = true;
            this.btnTaskAfbryd.Click += new System.EventHandler(this.BtnTaskAfbryd_Click);
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(39, 38);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(75, 23);
            this.btnSync.TabIndex = 0;
            this.btnSync.Text = "Sync";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.BtnSync_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 158);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.btnTaskAfbryd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkDanFejl);
            this.Controls.Add(this.btnAwaitAfbryd);
            this.Controls.Add(this.txtTal);
            this.Controls.Add(this.btnAwait);
            this.Controls.Add(this.btnTask);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Async Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Button btnAwait;
        private System.Windows.Forms.TextBox txtTal;
        private System.Windows.Forms.Button btnAwaitAfbryd;
        private System.Windows.Forms.CheckBox chkDanFejl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTaskAfbryd;
        private System.Windows.Forms.Button btnSync;
    }
}

