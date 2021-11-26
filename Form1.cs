using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RedColorsPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            RedColorsPanel.Controls.Clear();
            BlueColorsPanel.Controls.Clear();
            GreenColorsPanel.Controls.Clear();
            Color[] redclrs = new Color[100];
            Color[] blueclrs = new Color[100];
            Color[] greenclrs = new Color[100];
            Random rn = new Random();
            //можно разделить в разные функции и сделать их ассинхронными
            //но как, неизвестно. Он жалуется что я обращаюсь к RedColorsPanel не в потоке
            //в котором он был создан.
            for (int i = 0; i < redclrs.Length; i++)
            {
                Label lb = new Label();
                lb.Text = " ";
                redclrs[i] = Color.FromArgb(rn.Next(1, 255), 10, 10);
                lb.BackColor = redclrs[i];
                RedColorsPanel.Controls.Add(lb);
            }
            for (int i = 0; i < blueclrs.Length; i++)
            {
                Label lb = new Label();
                lb.Text = " ";
                blueclrs[i] = Color.FromArgb(10, 10, rn.Next(1, 255));
                lb.BackColor = blueclrs[i];
                BlueColorsPanel.Controls.Add(lb);
            }
            for (int i = 0; i < greenclrs.Length; i++)
            {
                Label lb = new Label();
                lb.Text = " ";
                greenclrs[i] = Color.FromArgb(10, rn.Next(1, 255), 10);
                lb.BackColor = greenclrs[i];
                GreenColorsPanel.Controls.Add(lb);
            }
        }
    }
}
