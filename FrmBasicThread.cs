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
            ThreadStart delThread2 = new ThreadStart(MyThreadClass.Thread2);

            Thread ThreadA = new Thread(delThread);
            ThreadA.Name = "Thread A Process";

            Thread ThreadB = new Thread(delThread2);
            ThreadB.Name = "Thread B Process";

            Thread ThreadC = new Thread(delThread);
            ThreadC.Name = "Thread C Process";

            Thread ThreadD = new Thread(delThread2);
            ThreadD.Name = "Thread D Process";

 
            Console.WriteLine("Before the thread start");

            //Thread Priority
            ThreadA.Priority = ThreadPriority.Highest;
            ThreadB.Priority = ThreadPriority.Normal;
            ThreadC.Priority = ThreadPriority.AboveNormal;
            ThreadD.Priority = ThreadPriority.BelowNormal;

            ThreadA.Start();
            ThreadB.Start();
            ThreadC.Start();
            ThreadD.Start();

            ThreadA.Join();
            ThreadB.Join();
            ThreadC.Join();
            ThreadD.Join();
            label1.Text = "-End of Thread-";
            Console.WriteLine(label1.Text.ToString());
        }

        private void FrmBasicThread_Load(object sender, EventArgs e)
        {

        }
    }
}
