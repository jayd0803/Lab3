namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAdded = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmbPrio = new System.Windows.Forms.ComboBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblItemPrio = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblStatsLow = new System.Windows.Forms.Label();
            this.lblStatsHigh = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStatsNormal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatsCri = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatsTotal = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAdded);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.cmbPrio);
            this.groupBox1.Controls.Add(this.txtItem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Item";
            // 
            // lblAdded
            // 
            this.lblAdded.AutoSize = true;
            this.lblAdded.Location = new System.Drawing.Point(185, 98);
            this.lblAdded.Name = "lblAdded";
            this.lblAdded.Size = new System.Drawing.Size(0, 13);
            this.lblAdded.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 89);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add To-Do";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(185, 48);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cmbPrio
            // 
            this.cmbPrio.FormattingEnabled = true;
            this.cmbPrio.Location = new System.Drawing.Point(57, 48);
            this.cmbPrio.Name = "cmbPrio";
            this.cmbPrio.Size = new System.Drawing.Size(121, 21);
            this.cmbPrio.TabIndex = 2;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(9, 20);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(214, 20);
            this.txtItem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Priority: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblItemPrio);
            this.groupBox2.Controls.Add(this.lblItemName);
            this.groupBox2.Controls.Add(this.btnComplete);
            this.groupBox2.Controls.Add(this.btnShow);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 117);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View An Item";
            // 
            // lblItemPrio
            // 
            this.lblItemPrio.AutoSize = true;
            this.lblItemPrio.Location = new System.Drawing.Point(12, 80);
            this.lblItemPrio.Name = "lblItemPrio";
            this.lblItemPrio.Size = new System.Drawing.Size(0, 13);
            this.lblItemPrio.TabIndex = 4;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(12, 59);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(0, 16);
            this.lblItemName.TabIndex = 3;
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(188, 70);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(75, 23);
            this.btnComplete.TabIndex = 2;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(185, 19);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Find Out";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "What I need to do next .......";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblStatsLow);
            this.groupBox3.Controls.Add(this.lblStatsHigh);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblStatsNormal);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblStatsCri);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lblStatsTotal);
            this.groupBox3.Controls.Add(this.lblS);
            this.groupBox3.Location = new System.Drawing.Point(12, 339);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 110);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List Stats";
            // 
            // lblStatsLow
            // 
            this.lblStatsLow.AutoSize = true;
            this.lblStatsLow.Location = new System.Drawing.Point(234, 76);
            this.lblStatsLow.Name = "lblStatsLow";
            this.lblStatsLow.Size = new System.Drawing.Size(13, 13);
            this.lblStatsLow.TabIndex = 9;
            this.lblStatsLow.Text = "0";
            // 
            // lblStatsHigh
            // 
            this.lblStatsHigh.AutoSize = true;
            this.lblStatsHigh.Location = new System.Drawing.Point(234, 48);
            this.lblStatsHigh.Name = "lblStatsHigh";
            this.lblStatsHigh.Size = new System.Drawing.Size(13, 13);
            this.lblStatsHigh.TabIndex = 8;
            this.lblStatsHigh.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total Low :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total High :";
            // 
            // lblStatsNormal
            // 
            this.lblStatsNormal.AutoSize = true;
            this.lblStatsNormal.Location = new System.Drawing.Point(96, 76);
            this.lblStatsNormal.Name = "lblStatsNormal";
            this.lblStatsNormal.Size = new System.Drawing.Size(13, 13);
            this.lblStatsNormal.TabIndex = 5;
            this.lblStatsNormal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Normal :";
            // 
            // lblStatsCri
            // 
            this.lblStatsCri.AutoSize = true;
            this.lblStatsCri.Location = new System.Drawing.Point(96, 49);
            this.lblStatsCri.Name = "lblStatsCri";
            this.lblStatsCri.Size = new System.Drawing.Size(13, 13);
            this.lblStatsCri.TabIndex = 3;
            this.lblStatsCri.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Critical : ";
            // 
            // lblStatsTotal
            // 
            this.lblStatsTotal.AutoSize = true;
            this.lblStatsTotal.Location = new System.Drawing.Point(182, 20);
            this.lblStatsTotal.Name = "lblStatsTotal";
            this.lblStatsTotal.Size = new System.Drawing.Size(13, 13);
            this.lblStatsTotal.TabIndex = 1;
            this.lblStatsTotal.Text = "0";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Location = new System.Drawing.Point(13, 20);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(74, 13);
            this.lblS.TabIndex = 0;
            this.lblS.Text = "Total ToDo\'s :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 481);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "My To-Do List";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAdded;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbPrio;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblItemPrio;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblStatsLow;
        private System.Windows.Forms.Label lblStatsHigh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStatsNormal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatsCri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatsTotal;
        private System.Windows.Forms.Label lblS;
    }
}

