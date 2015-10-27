using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Part_084
{
    /// <summary>
    /// Part 84 : Real time example of queue collection class in c.
    /// </summary>
    public partial class WebForm1 : System.Web.UI.Page
    {
        /*
         * Here is one simple real-time working example where a Queue class can be used. 
         * 
         * 1. When you walk into a bank or a passport office, you will collect a token and wait in the queue for your token number to be called. 
         * 
         * 2. From the application perspective, when a token is issued, the token number will be added to the end of the Queue. 
         * 
         * 3. When a representative at the counter is available to server a customer, 
         *      he will push the "Next" button and the token number that is present at the beginning of the queue, will be dequeued. 
         * 
         * 4. So, this is one example, where a Queue collection class can be effectively used. 
         * 
         */

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["TokenQueue"] == null)
            {
                Queue<int> tokenQueue = new Queue<int>();
                Session["TokenQueue"] = tokenQueue;
            }
        }

        protected void btnCounter1_Click(object sender, EventArgs e)
        {
            ServerNextCustomer(txtCounter1, 1);
        }

        protected void btnCounter2_Click(object sender, EventArgs e)
        {
            ServerNextCustomer(txtCounter2, 2);
        }

        protected void btnCounter3_Click(object sender, EventArgs e)
        {
            ServerNextCustomer(txtCounter3, 3);
        }

        protected void btnPrintToken_Click(object sender, EventArgs e)
        {
            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];
            lblCurrentStatus.Text = "There are " + tokenQueue.Count.ToString()
                + " customers before you in the queue";

            if (Session["lastTokenNumberIssued"] == null)
            {
                Session["lastTokenNumberIssued"] = 0;
            }

            int nextTokenNumberToIssue = (int)Session["lastTokenNumberIssued"] + 1;
            Session["lastTokenNumberIssued"] = nextTokenNumberToIssue;
            tokenQueue.Enqueue(nextTokenNumberToIssue);

            AddTokenNumbersToListBox(tokenQueue);
        }

        private void AddTokenNumbersToListBox(Queue<int> tokenQueue)
        {
            listTokens.Items.Clear();
            foreach (int token in tokenQueue)
            {
                listTokens.Items.Add(token.ToString());
            }
        }

        private void ServerNextCustomer(TextBox textBox, int counterNumnber)
        {
            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];
            if (tokenQueue.Count > 0)
            {
                int tokenNumberToBeServed = tokenQueue.Dequeue();
                textBox.Text = tokenNumberToBeServed.ToString();
                txtNextToken.Text = "Token Number : " + tokenNumberToBeServed.ToString()
                    + ", please go to Counter " + counterNumnber.ToString();
                AddTokenNumbersToListBox(tokenQueue);
            }
            else
            {
                textBox.Text = "No cutomers in Queue";
            }
        }
    }
}