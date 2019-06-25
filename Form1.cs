using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace async_winform_task_await
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private CancellationTokenSource tokenSource = new CancellationTokenSource();

        private async void BtnAwait_Click(object sender, EventArgs e)
        {
            try
            {
                tokenSource = new CancellationTokenSource();
                btnAwait.Enabled = false;
                btnAwaitAfbryd.Enabled = true;
                txtTal.Text = "";
                Repository r = new Repository();
                string resultat = await r.HentTilfældigVærdiAsync(tokenSource.Token, chkDanFejl.Checked);
                txtTal.Text = resultat;
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show("Operation afbrudt", "Afbryd");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fejl");
            }
            finally
            {
                btnAwait.Enabled = true;
                btnAwaitAfbryd.Enabled = false;
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
                txtTal.Text = "";
                Repository r = new Repository();
                txtTal.Text = r.HentTilfældigVærdiSync(chkDanFejl.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fejl");
            }
            finally
            {
                btnSync.Enabled = true;
                this.Cursor = Cursors.Default;
            }
        }

        private void BtnTask_Click(object sender, EventArgs e)
        {
            tokenSource = new CancellationTokenSource();
            btnTask.Enabled = false;
            btnTaskAfbryd.Enabled = true;
            txtTal.Text = "";
            Repository r = new Repository();
            Task<string> task = r.HentTilfældigVærdiAsync(tokenSource.Token, chkDanFejl.Checked);
            task.ContinueWith(t =>
            {
                switch (t.Status)
                {
                    case TaskStatus.RanToCompletion:
                        txtTal.Text = t.Result;
                        break;
                    case TaskStatus.Canceled:
                        MessageBox.Show("Operation afbrudt", "Afbryd");
                        break;
                    case TaskStatus.Faulted:
                        foreach (var item in t.Exception.Flatten().InnerExceptions)
                            MessageBox.Show(item.Message, "Fejl");
                        break;
                }
                btnTask.Enabled = true;
                btnTaskAfbryd.Enabled = false;

            }, TaskScheduler.FromCurrentSynchronizationContext());

        }

        private void BtnTaskAfbryd_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();            
        }
    }
}
