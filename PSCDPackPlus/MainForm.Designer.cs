namespace PSCDPackPlus
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox extraSaveModeComboBox;
		private System.Windows.Forms.TextBox extraPageMaskTextBox;
		private System.Windows.Forms.Label romSizeLabel;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox regionComboBox;
		private System.Windows.Forms.TextBox extraSizeMaskTextbox;
		private System.Windows.Forms.PictureBox thumbPictureBox;
		private System.Windows.Forms.Button openButton;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Button dumpRomButton;
		private System.Windows.Forms.Button replaceRomButton;
		private System.Windows.Forms.Button extractThumbButton;
		private System.Windows.Forms.Button replaceThumbButton;
		private System.Windows.Forms.Button removeThumbButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.SaveFileDialog extractFileDialog;
		private System.Windows.Forms.OpenFileDialog replaceFileDialog;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.thumbPictureBox = new System.Windows.Forms.PictureBox();
            this.regionComboBox = new System.Windows.Forms.ComboBox();
            this.extraSizeMaskTextbox = new System.Windows.Forms.TextBox();
            this.extraSaveModeComboBox = new System.Windows.Forms.ComboBox();
            this.extraPageMaskTextBox = new System.Windows.Forms.TextBox();
            this.romSizeLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.dumpRomButton = new System.Windows.Forms.Button();
            this.replaceRomButton = new System.Windows.Forms.Button();
            this.extractThumbButton = new System.Windows.Forms.Button();
            this.replaceThumbButton = new System.Windows.Forms.Button();
            this.removeThumbButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.extractFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.replaceFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.thumbPictureBox);
            this.groupBox1.Controls.Add(this.regionComboBox);
            this.groupBox1.Controls.Add(this.extraSizeMaskTextbox);
            this.groupBox1.Controls.Add(this.extraSaveModeComboBox);
            this.groupBox1.Controls.Add(this.extraPageMaskTextBox);
            this.groupBox1.Controls.Add(this.romSizeLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(303, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ROM Info";
            // 
            // thumbPictureBox
            // 
            this.thumbPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thumbPictureBox.Location = new System.Drawing.Point(58, 144);
            this.thumbPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.thumbPictureBox.Name = "thumbPictureBox";
            this.thumbPictureBox.Size = new System.Drawing.Size(186, 69);
            this.thumbPictureBox.TabIndex = 10;
            this.thumbPictureBox.TabStop = false;
            // 
            // regionComboBox
            // 
            this.regionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regionComboBox.FormattingEnabled = true;
            this.regionComboBox.Location = new System.Drawing.Point(82, 113);
            this.regionComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.regionComboBox.Name = "regionComboBox";
            this.regionComboBox.Size = new System.Drawing.Size(214, 23);
            this.regionComboBox.TabIndex = 9;
            // 
            // extraSizeMaskTextbox
            // 
            this.extraSizeMaskTextbox.Location = new System.Drawing.Point(236, 82);
            this.extraSizeMaskTextbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.extraSizeMaskTextbox.Name = "extraSizeMaskTextbox";
            this.extraSizeMaskTextbox.Size = new System.Drawing.Size(60, 23);
            this.extraSizeMaskTextbox.TabIndex = 7;
            // 
            // extraSaveModeComboBox
            // 
            this.extraSaveModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.extraSaveModeComboBox.FormattingEnabled = true;
            this.extraSaveModeComboBox.Location = new System.Drawing.Point(7, 82);
            this.extraSaveModeComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.extraSaveModeComboBox.Name = "extraSaveModeComboBox";
            this.extraSaveModeComboBox.Size = new System.Drawing.Size(153, 23);
            this.extraSaveModeComboBox.TabIndex = 5;
            // 
            // extraPageMaskTextBox
            // 
            this.extraPageMaskTextBox.Location = new System.Drawing.Point(168, 82);
            this.extraPageMaskTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.extraPageMaskTextBox.Name = "extraPageMaskTextBox";
            this.extraPageMaskTextBox.Size = new System.Drawing.Size(60, 23);
            this.extraPageMaskTextBox.TabIndex = 6;
            // 
            // romSizeLabel
            // 
            this.romSizeLabel.Location = new System.Drawing.Point(82, 48);
            this.romSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.romSizeLabel.Name = "romSizeLabel";
            this.romSizeLabel.Size = new System.Drawing.Size(215, 15);
            this.romSizeLabel.TabIndex = 3;
            this.romSizeLabel.Text = "Not loaded";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(82, 22);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(214, 23);
            this.nameTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Region:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "On-cartridge Memory Config:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ROM Size:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(14, 241);
            this.openButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(96, 27);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "New/Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.OpenButtonClick);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(117, 241);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(98, 27);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // closeButton
            // 
            this.closeButton.Enabled = false;
            this.closeButton.Location = new System.Drawing.Point(222, 241);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(96, 27);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // dumpRomButton
            // 
            this.dumpRomButton.Enabled = false;
            this.dumpRomButton.Location = new System.Drawing.Point(14, 275);
            this.dumpRomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dumpRomButton.Name = "dumpRomButton";
            this.dumpRomButton.Size = new System.Drawing.Size(148, 27);
            this.dumpRomButton.TabIndex = 4;
            this.dumpRomButton.Text = "Extract ROM";
            this.dumpRomButton.UseVisualStyleBackColor = true;
            this.dumpRomButton.Click += new System.EventHandler(this.DumpRomButtonClick);
            // 
            // replaceRomButton
            // 
            this.replaceRomButton.Enabled = false;
            this.replaceRomButton.Location = new System.Drawing.Point(169, 275);
            this.replaceRomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.replaceRomButton.Name = "replaceRomButton";
            this.replaceRomButton.Size = new System.Drawing.Size(148, 27);
            this.replaceRomButton.TabIndex = 5;
            this.replaceRomButton.Text = "Replace ROM";
            this.replaceRomButton.UseVisualStyleBackColor = true;
            this.replaceRomButton.Click += new System.EventHandler(this.ReplaceRomButtonClick);
            // 
            // extractThumbButton
            // 
            this.extractThumbButton.Enabled = false;
            this.extractThumbButton.Location = new System.Drawing.Point(14, 308);
            this.extractThumbButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.extractThumbButton.Name = "extractThumbButton";
            this.extractThumbButton.Size = new System.Drawing.Size(148, 27);
            this.extractThumbButton.TabIndex = 6;
            this.extractThumbButton.Text = "Extract Thumb";
            this.extractThumbButton.UseVisualStyleBackColor = true;
            this.extractThumbButton.Click += new System.EventHandler(this.ExtractThumbButtonClick);
            // 
            // replaceThumbButton
            // 
            this.replaceThumbButton.Enabled = false;
            this.replaceThumbButton.Location = new System.Drawing.Point(169, 308);
            this.replaceThumbButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.replaceThumbButton.Name = "replaceThumbButton";
            this.replaceThumbButton.Size = new System.Drawing.Size(148, 27);
            this.replaceThumbButton.TabIndex = 7;
            this.replaceThumbButton.Text = "Replace Thumb";
            this.replaceThumbButton.UseVisualStyleBackColor = true;
            this.replaceThumbButton.Click += new System.EventHandler(this.ReplaceThumbButtonClick);
            // 
            // removeThumbButton
            // 
            this.removeThumbButton.Enabled = false;
            this.removeThumbButton.Location = new System.Drawing.Point(14, 342);
            this.removeThumbButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.removeThumbButton.Name = "removeThumbButton";
            this.removeThumbButton.Size = new System.Drawing.Size(148, 27);
            this.removeThumbButton.TabIndex = 8;
            this.removeThumbButton.Text = "Remove Thumb";
            this.removeThumbButton.UseVisualStyleBackColor = true;
            this.removeThumbButton.Click += new System.EventHandler(this.RemoveThumbButtonClick);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(169, 342);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(148, 27);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "pak";
            this.saveFileDialog.Filter = "SEGA Genesis Classics ROM Pack|*.pak";
            this.saveFileDialog.OverwritePrompt = false;
            this.saveFileDialog.Title = "Open or Create ROM Pack";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Collection Type:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(169, 387);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 434);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.removeThumbButton);
            this.Controls.Add(this.replaceThumbButton);
            this.Controls.Add(this.extractThumbButton);
            this.Controls.Add(this.replaceRomButton);
            this.Controls.Add(this.dumpRomButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SEGA Genesis Classics ROM Packer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
