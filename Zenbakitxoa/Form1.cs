using System;
using System.Windows.Forms;

namespace Zenbakitxoa
{
    public partial class zenbakitxoa : Form
    {
        int AldizTimer = 0;

        public zenbakitxoa()
        {
            InitializeComponent();

            tik.Value = -1;
            ra.Value = 100;

            nor.Text = string.Empty;
            nz.Text = string.Empty;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                try { nor.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(); }
                catch { }

                switch (nor.Text)
                {
                    case "Ardo": pictureBox1.Image = Properties.Resources.Ardo; break;
                    case "Geni": pictureBox1.Image = Properties.Resources.Geni; break;
                    case "Iñaki Pilar": pictureBox1.Image = Properties.Resources.InakiPilar; break;
                    case "Pelos": pictureBox1.Image = Properties.Resources.Pelos; break;
                    case "Tamayo": pictureBox1.Image = Properties.Resources.Tamayo; break;
                    case "Txabi": pictureBox1.Image = Properties.Resources.Txabi; break;
                    case "Txomin": pictureBox1.Image = Properties.Resources.Txomin; break;
                    case "Txus Loiu": pictureBox1.Image = Properties.Resources.TxusLoiu; break;
                    case "Txus Txino": pictureBox1.Image = Properties.Resources.TxusTxino; break;
                    default: pictureBox1.Image = null; break;
                }



            }
        }

        private void bbehera_Click(object sender, EventArgs e)
        {
            if (Check(out int n))
            {
                ra.Value = n;
                Hurrengoa();
            }
            nz.Select();
        }

        private void bgora_Click(object sender, EventArgs e)
        {
            if (Check(out int n))
            {
                tik.Value = n;
                Hurrengoa();
            }
            nz.Select();
        }

        private void bbardin_Click(object sender, EventArgs e)
        {
            if (Check(out int n))
            {
                tik.Value = ra.Value = n;

              //  System.Media.SystemSounds.Beep.Play();

                if (dataGridView1.SelectedRows.Count == 1)
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    string v = row.Cells[1].Value as string ?? string.Empty;
                    v += '\u25C9';
                    row.Cells[1].Value = v;

                    if (v.Length >= 2)
                    {
                        System.Media.SystemSounds.Exclamation.Play();
                    }
                }

                tik.Value = -1;
                ra.Value = 100;
                Hurrengoa();
            }
            nz.Select();
        }

        private bool Check(out int n)
        {
            bool ok = false;
            if (int.TryParse(nz.Text, out n))
            {
                if (n > tik.Value && n < ra.Value)
                {
                    ok = true;
                }
                else
                {
                    //MessageBox.Show("{0}-tik  {1}-ra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tik.ForeColor = System.Drawing.Color.Red;
                    ra.ForeColor = System.Drawing.Color.Red;
                    timer1.Enabled = true;
                }
            }
            nz.Text = string.Empty;
            return ok;
        }

        private void Hurrengoa()
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int ind = dataGridView1.SelectedRows[0].Index;
                ind++;
                if (ind >= dataGridView1.Rows.Count) ind = 0;
                else if (dataGridView1.Rows[ind].IsNewRow) ind = 0;
                dataGridView1.Rows[ind].Selected = true;
            }
        }

        private void bHasi_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[1].Value = string.Empty;
            }
            tik.Value = -1;
            ra.Value = 100;
            nz.Text = string.Empty;

            dataGridView1_SelectionChanged(dataGridView1, new EventArgs());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tik.ForeColor == System.Drawing.Color.Red)
            {
                tik.ForeColor = System.Drawing.SystemColors.WindowText;
                ra.ForeColor = System.Drawing.SystemColors.WindowText;
                if (++AldizTimer >= 5)
                {
                    timer1.Enabled = false;
                    AldizTimer = 0;
                }
            }
            else
            {
                tik.ForeColor = System.Drawing.Color.Red;
                ra.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
