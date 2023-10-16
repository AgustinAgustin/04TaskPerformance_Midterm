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

namespace Agustin
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart delThread = new ThreadStart(MyThreadClass.Thread1);
            Thread ThreadA = new Thread(delThread);
            ThreadA.Name = "Thread A Process";

            Thread ThreadB = new Thread(delThread);
            ThreadB.Name = "Thread B Process";
            Console.WriteLine("Before the thread start");
            ThreadA.Start();
            ThreadB.Start();
            ThreadA.Join();
            ThreadB.Join();

            label1.Text = "-End of Thread-";
            Console.WriteLine(label1.Text.ToString());
        }
    }
}
