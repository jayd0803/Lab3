using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        static PriorityQuene pq = new PriorityQuene();

        public Form1()
        {
            InitializeComponent();

            var items = new[]
            {
                new {Text = Enum.GetName(typeof(Priority),Priority.Low), Value = Priority.Low},
                new {Text = Enum.GetName(typeof(Priority),Priority.Normal),Value = Priority.Normal},
                new {Text = Enum.GetName(typeof(Priority),Priority.High),Value = Priority.High},
                new {Text = Enum.GetName(typeof(Priority),Priority.Critical),Value = Priority.Critical},

            };
            cmbPrio.DataSource = items;
            cmbPrio.DisplayMember = "Text";
            cmbPrio.ValueMember = "Value";
            btnComplete.Visible = false;
   

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Item next = pq.Peek();


            if (next != null)
            {
                lblItemName.Text = next.Name;
                lblItemPrio.Text = "(" +Enum.GetName(typeof(Priority), next.Priority)+" Priority)";

                btnComplete.Show();
               
            }
            else
            {
                lblItemName.Text = "Nothing";
                lblItemPrio.Text = "(List Empty)";
            }
            lblAdded.Text = "";
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtItem.Text == "")
                MessageBox.Show("you must enter a item name");
            else
            {

                Item itemToAdd = new Item(txtItem.Text, (Priority)cmbPrio.SelectedValue);
                pq.Enqueue(itemToAdd);
                lblAdded.Text = "'" + itemToAdd.Name + "' added";
                txtItem.Clear();
                cmbPrio.SelectedIndex = 0;
                updateStats();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pq.Clear();
            lblItemName.Text = "";
            lblItemPrio.Text = "";
            updateStats();
                
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            Item removed = pq.Dequeue();
            MessageBox.Show(removed.Name + " Completed!");
            lblItemName.Text = "";
            lblItemPrio.Text = "";
            btnComplete.Visible = false;
            updateStats();
        }

        private void updateStats()
        {
            lblStatsTotal.Text = pq.Count.ToString();
            lblStatsCri.Text = pq.Critical.ToString();
            lblStatsHigh.Text = pq.High.ToString();
            lblStatsLow.Text = pq.Low.ToString();
            lblStatsNormal.Text = pq.Normal.ToString();
        }
    }

}
