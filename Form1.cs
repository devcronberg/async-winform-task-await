using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace async_winform_task_await
{
    public partial class Form1 : Form
    {

        private const string url = "https://httpbin.org/delay/5";

        public Form1()
        {
            InitializeComponent();
        }

        private CancellationTokenSource tokenSource = new CancellationTokenSource();

        private async void BtnAwait_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                tokenSource = new CancellationTokenSource();
                CancellationToken token = tokenSource.Token;
                btnAwait.Enabled = false;
                btnSync.Enabled = false;
                btnAwaitAfbryd.Enabled = true;
                txtTal.ResetText();
                txtTal.Enabled = false;
                using (HttpClient client = new HttpClient())
                {
                    token.ThrowIfCancellationRequested();
                    HttpResponseMessage r = await client.GetAsync(url, token);
                    txtTal.Text = "200 OK";
                }
            }
            catch (TaskCanceledException)
            {
                txtTal.ResetText();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fejl");
            }
            finally
            {
                btnAwait.Enabled = true;
                btnAwaitAfbryd.Enabled = false;
                txtTal.Enabled = true;
                this.Cursor = Cursors.Default;
                btnSync.Enabled = true;
            }
        }

        private void BtnAwaitAfbryd_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();
        }

        private void BtnSync_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                btnSync.Enabled = false;
                btnAwait.Enabled = false;
                txtTal.Enabled = false;
                txtTal.ResetText();
                this.Update();
                using (WebClient w = new WebClient())
                {
                    var r = w.DownloadString(new Uri(url));
                    txtTal.Text = txtTal.Text = "200 OK";
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fejl");
            }
            finally
            {
                btnSync.Enabled = true;
                this.Cursor = Cursors.Default;
                txtTal.Enabled = true;
                btnAwait.Enabled = true;
            }
        }



        private void BtnTaskAfbryd_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (ProgressBar1.Value == 100)
                ProgressBar1.Value = 0;
            ProgressBar1.Value += 10;
        }

        private void BtnAwaitAfbryd_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void BtnAwaitAfbryd_MouseLeave(object sender, EventArgs e)
        {
            if(btnAwaitAfbryd.Enabled)
                this.Cursor = Cursors.WaitCursor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = " " + url;
        }
    }
}
