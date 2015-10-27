using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Part_086
{
    /// <summary>
    /// Part 86 : Multithreading in C
    /// </summary>
    public partial class Form1 : Form
    {
        /*
         * What is process ?
         *  Process is what the operating system uses to facilitate the execution of a program by providing the resources required.
         *      Each process has a unique process Id associated with it. 
         *      You can view the process within which a program is being executed using windows task manager.
         *      
         * What is thread ?
         *  A thread is a light weight process. A process has at least one thread which is commonly called as main thread,
         *      which actually executes the application code. A single process can have multiple threads.
         * 
         * ** NOTE ::
         *      All the threading related classes are present in System.Threading namespace.
         */
        public Form1()
        {
            InitializeComponent();
        }

        #region 1. Program become un-responsive without using thread.
        private void btnTimeConsumingWork_Click(object sender, EventArgs e)
        {
            btnTimeConsumingWork.Enabled = false;
            btnPrintNumbers.Enabled = false;

            DoTimeConsumingWork();

            btnTimeConsumingWork.Enabled = true;
            btnPrintNumbers.Enabled = true;
        }

        private void DoTimeConsumingWork()
        {
            // It will keep thread busy for 5sec.
            Thread.Sleep(5000);
        }

        private void btnPrintNumbers_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                lstNumbers.Items.Add(i);
            }
        }
        #endregion

        #region 2. Program become responsive Using threading
        private void btnTimeConsumingWorByThreading_Click(object sender, EventArgs e)
        {
            btnTimeConsumingWorByThreading.Enabled = false;
            btnPrintNumbersByThreading.Enabled = false;

            Thread workerThread = new Thread(DoTimeConsumingWorkByThreading);
            workerThread.Start();

            btnTimeConsumingWorByThreading.Enabled = true;
            btnPrintNumbersByThreading.Enabled = true;

        }

        private void DoTimeConsumingWorkByThreading()
        {
            // It will keep thread busy for 5sec.
            Thread.Sleep(5000);
        }

        private void btnPrintNumbersByThreading_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                lstNumbersByThreading.Items.Add(i);
            }
        }
        #endregion
    }
}
