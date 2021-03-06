﻿namespace DbD_Pingz
{
    partial class NetworkChooser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetworkChooser));
            this.networkAdapters = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDone = new System.Windows.Forms.Button();
            this.rememberDecisionCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // networkAdapters
            // 
            this.networkAdapters.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
            this.networkAdapters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.networkAdapters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.networkAdapters.FormattingEnabled = true;
            this.networkAdapters.Location = new System.Drawing.Point(12, 25);
            this.networkAdapters.Name = "networkAdapters";
            this.networkAdapters.Size = new System.Drawing.Size(367, 21);
            this.networkAdapters.TabIndex = 1;
            this.networkAdapters.SelectedIndexChanged += new System.EventHandler(this.NetworkAdapters_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a network adapter:";
            // 
            // buttonDone
            // 
            this.buttonDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone.Location = new System.Drawing.Point(304, 54);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(75, 23);
            this.buttonDone.TabIndex = 4;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.ButtonDone_Click);
            // 
            // rememberDecisionCheckbox
            // 
            this.rememberDecisionCheckbox.AutoSize = true;
            this.rememberDecisionCheckbox.Location = new System.Drawing.Point(15, 58);
            this.rememberDecisionCheckbox.Name = "rememberDecisionCheckbox";
            this.rememberDecisionCheckbox.Size = new System.Drawing.Size(119, 17);
            this.rememberDecisionCheckbox.TabIndex = 5;
            this.rememberDecisionCheckbox.Text = "Remember decision";
            this.rememberDecisionCheckbox.UseVisualStyleBackColor = true;
            this.rememberDecisionCheckbox.CheckedChanged += new System.EventHandler(this.rememberDecisionCheckbox_CheckedChanged);
            // 
            // NetworkChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 86);
            this.Controls.Add(this.rememberDecisionCheckbox);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.networkAdapters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 125);
            this.MinimumSize = new System.Drawing.Size(250, 125);
            this.Name = "NetworkChooser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DbD Pingz";
            this.TransparencyKey = System.Drawing.SystemColors.HotTrack;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox networkAdapters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.CheckBox rememberDecisionCheckbox;
    }
}