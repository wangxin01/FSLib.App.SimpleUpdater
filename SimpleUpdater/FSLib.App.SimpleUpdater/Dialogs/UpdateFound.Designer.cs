﻿namespace FSLib.App.SimpleUpdater.Dialogs
{
	partial class UpdateFound
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateFound));
			this.lblFound = new System.Windows.Forms.Label();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.lnkSoft = new System.Windows.Forms.LinkLabel();
			this.lblSize = new System.Windows.Forms.Label();
			this.lblVersion = new System.Windows.Forms.Label();
			this.controlContainer = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lnkCance = new System.Windows.Forms.LinkLabel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblFound
			// 
			resources.ApplyResources(this.lblFound, "lblFound");
			this.lblFound.ForeColor = System.Drawing.Color.White;
			this.lblFound.Name = "lblFound";
			// 
			// btnUpdate
			// 
			resources.ApplyResources(this.btnUpdate, "btnUpdate");
			this.btnUpdate.Image = global::FSLib.App.SimpleUpdater.Properties.Resources.cou_32_refresh;
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// lnkSoft
			// 
			resources.ApplyResources(this.lnkSoft, "lnkSoft");
			this.lnkSoft.Name = "lnkSoft";
			this.lnkSoft.TabStop = true;
			// 
			// lblSize
			// 
			resources.ApplyResources(this.lblSize, "lblSize");
			this.lblSize.Name = "lblSize";
			// 
			// lblVersion
			// 
			resources.ApplyResources(this.lblVersion, "lblVersion");
			this.lblVersion.ForeColor = System.Drawing.Color.White;
			this.lblVersion.Name = "lblVersion";
			// 
			// controlContainer
			// 
			resources.ApplyResources(this.controlContainer, "controlContainer");
			this.controlContainer.Name = "controlContainer";
			// 
			// panel1
			// 
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(99)))), ((int)(((byte)(163)))));
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.lblVersion);
			this.panel1.Controls.Add(this.lblFound);
			this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel1.Name = "panel1";
			// 
			// groupBox1
			// 
			resources.ApplyResources(this.groupBox1, "groupBox1");
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabStop = false;
			// 
			// lnkCance
			// 
			resources.ApplyResources(this.lnkCance, "lnkCance");
			this.lnkCance.Image = global::FSLib.App.SimpleUpdater.Properties.Resources.block_16;
			this.lnkCance.Name = "lnkCance";
			this.lnkCance.TabStop = true;
			this.lnkCance.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCance_LinkClicked);
			// 
			// UpdateFound
			// 
			this.AcceptButton = this.btnUpdate;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lnkCance);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.controlContainer);
			this.Controls.Add(this.lblSize);
			this.Controls.Add(this.lnkSoft);
			this.Controls.Add(this.btnUpdate);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UpdateFound";
			this.Load += new System.EventHandler(this.UpdateFound_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblFound;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.LinkLabel lnkSoft;
		private System.Windows.Forms.Label lblSize;
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.Panel controlContainer;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.LinkLabel lnkCance;
	}
}