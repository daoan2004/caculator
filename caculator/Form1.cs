using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool isTypingNumber = false;
        enum PhepToan { cong,tru,nhan,chia };
        double nho;
        PhepToan pheptoan;
        private void nhapso(object sender, EventArgs e)
        {
          
            Button btn = (Button)sender;
            nhapso(btn.Text);
        }
        private void nhapso(string so)
        {
            if (isTypingNumber)
                textBox1.Text = textBox1.Text + so;
            else
            {
                textBox1.Text=so;
                isTypingNumber = true;
            }

        }
        private void NhapPhepToan(object sender, EventArgs e)
        {
            TinhKetQua();
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "/": pheptoan = PhepToan.chia; break;                
                case "*": pheptoan = PhepToan.nhan;break;
                case "-": pheptoan = PhepToan.tru; break;
                case "+": pheptoan = PhepToan.cong; break;
            }
            nho = double.Parse(textBox1.Text);
            isTypingNumber = false;
        }
        private void TinhKetQua()
        {
            double tam = double.Parse(textBox1.Text);
            double ketqua = 0.0;
            switch (pheptoan)
            {
                case PhepToan.cong: ketqua = nho + tam;break;
                case PhepToan.tru:  ketqua = nho - tam;break;
                case PhepToan.nhan: ketqua = nho * tam;break;
                case PhepToan.chia: ketqua = nho / tam;break;
            }
            textBox1.Text = ketqua.ToString();
            isTypingNumber = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            TinhKetQua();
            isTypingNumber = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";

        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text =( int.Parse(textBox1.Text) * -1).ToString();
        }
    }
}
