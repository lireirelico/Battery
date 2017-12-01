﻿using System;
using System.Windows.Forms;

namespace IiPUlab3._2_battery_
{
    partial class Battery : Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.PowerLineStatus = new System.Windows.Forms.TextBox();
            this.BatteryLifePercent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BatteryLifeRemaining = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BlackoutTimeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PowerLineStatus";
            // 
            // PowerLineStatus
            // 
            this.PowerLineStatus.Location = new System.Drawing.Point(20, 43);
            this.PowerLineStatus.Margin = new System.Windows.Forms.Padding(4);
            this.PowerLineStatus.Name = "PowerLineStatus";
            this.PowerLineStatus.ReadOnly = true;
            this.PowerLineStatus.Size = new System.Drawing.Size(121, 22);
            this.PowerLineStatus.TabIndex = 1;
            // 
            // BatteryLifePercent
            // 
            this.BatteryLifePercent.Location = new System.Drawing.Point(180, 44);
            this.BatteryLifePercent.Margin = new System.Windows.Forms.Padding(4);
            this.BatteryLifePercent.Name = "BatteryLifePercent";
            this.BatteryLifePercent.ReadOnly = true;
            this.BatteryLifePercent.Size = new System.Drawing.Size(121, 22);
            this.BatteryLifePercent.TabIndex = 3;
            this.BatteryLifePercent.TextChanged += new System.EventHandler(this.BatteryLifePercent_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "BatteryLifePercent";
            // 
            // BatteryLifeRemaining
            // 
            this.BatteryLifeRemaining.Location = new System.Drawing.Point(20, 102);
            this.BatteryLifeRemaining.Margin = new System.Windows.Forms.Padding(4);
            this.BatteryLifeRemaining.Name = "BatteryLifeRemaining";
            this.BatteryLifeRemaining.ReadOnly = true;
            this.BatteryLifeRemaining.Size = new System.Drawing.Size(282, 22);
            this.BatteryLifeRemaining.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "BatteryLifeRemaining";
            // 
            // BlackoutTimeComboBox
            // 
            this.BlackoutTimeComboBox.FormattingEnabled = true;
            this.BlackoutTimeComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "45",
            "60",
            "120",
            "180",
            "240",
            "300"});
            this.BlackoutTimeComboBox.Location = new System.Drawing.Point(98, 173);
            this.BlackoutTimeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.BlackoutTimeComboBox.Name = "BlackoutTimeComboBox";
            this.BlackoutTimeComboBox.Size = new System.Drawing.Size(143, 24);
            this.BlackoutTimeComboBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "DisplayBlackoutTime";
            // 
            // Battery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 214);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BlackoutTimeComboBox);
            this.Controls.Add(this.BatteryLifeRemaining);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BatteryLifePercent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PowerLineStatus);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Battery";
            this.Text = "Battery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PowerLineStatus;
        private System.Windows.Forms.TextBox BatteryLifePercent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BatteryLifeRemaining;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BlackoutTimeComboBox;
        private System.Windows.Forms.Label label4;


        private void BlackoutTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDisplayBlackout(Int32.Parse(BlackoutTimeComboBox.SelectedItem.ToString()));
        }

        private void Battery_FormClosing(object sender, FormClosingEventArgs e)
        {
            myThread.Abort();
            SetDisplayBlackout(defaultBlackoutTime);
        }

        private void BatteryLifePercent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

