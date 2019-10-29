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
                txtTal.ResetText();                
                Repository r = new Repository();
                string resultat = await r.HentTilfældigVærdiAsync(tokenSource.Token).ConfigureAwait(true);
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
                txtTal.ResetText();                
                Repository r = new Repository();
                txtTal.Text = r.HentTilfældigVærdiSync();
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

        

        private void BtnTaskAfbryd_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();            
        }
    }
}
