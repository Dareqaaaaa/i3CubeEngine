﻿namespace i3CubeEngine
{
    partial class PropertiesForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this._locationL = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this._createdL = new System.Windows.Forms.Label();
            this.createdTimeLabel = new System.Windows.Forms.Label();
            this._modifiedL = new System.Windows.Forms.Label();
            this.modifiedTimeLabel = new System.Windows.Forms.Label();
            this._typeL = new System.Windows.Forms.Label();
            this._sizeL = new System.Windows.Forms.Label();
            this._attributesL = new System.Windows.Forms.Label();
            this.readonlyCheckBox = new System.Windows.Forms.CheckBox();
            this.hiddenCheckBox = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contains = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(120, 29);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(279, 21);
            this.nameTextBox.TabIndex = 5;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(313, 376);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(87, 25);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(48, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(58, 57);
            this.pictureBox.TabIndex = 12;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(8, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 2);
            this.label1.TabIndex = 13;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(120, 95);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(29, 15);
            this.typeLabel.TabIndex = 14;
            this.typeLabel.Text = "type";
            // 
            // _locationL
            // 
            this._locationL.Location = new System.Drawing.Point(22, 125);
            this._locationL.Name = "_locationL";
            this._locationL.Size = new System.Drawing.Size(70, 15);
            this._locationL.TabIndex = 15;
            this._locationL.Text = "Location:";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(120, 155);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(29, 15);
            this.sizeLabel.TabIndex = 17;
            this.sizeLabel.Text = "size";
            // 
            // _createdL
            // 
            this._createdL.AutoSize = true;
            this._createdL.Location = new System.Drawing.Point(23, 236);
            this._createdL.Name = "_createdL";
            this._createdL.Size = new System.Drawing.Size(53, 15);
            this._createdL.TabIndex = 19;
            this._createdL.Text = "Created:";
            // 
            // createdTimeLabel
            // 
            this.createdTimeLabel.AutoSize = true;
            this.createdTimeLabel.Location = new System.Drawing.Point(121, 236);
            this.createdTimeLabel.Name = "createdTimeLabel";
            this.createdTimeLabel.Size = new System.Drawing.Size(48, 15);
            this.createdTimeLabel.TabIndex = 20;
            this.createdTimeLabel.Text = "created";
            // 
            // _modifiedL
            // 
            this._modifiedL.AutoSize = true;
            this._modifiedL.Location = new System.Drawing.Point(23, 266);
            this._modifiedL.Name = "_modifiedL";
            this._modifiedL.Size = new System.Drawing.Size(58, 15);
            this._modifiedL.TabIndex = 21;
            this._modifiedL.Text = "Modified:";
            // 
            // modifiedTimeLabel
            // 
            this.modifiedTimeLabel.AutoSize = true;
            this.modifiedTimeLabel.Location = new System.Drawing.Point(121, 266);
            this.modifiedTimeLabel.Name = "modifiedTimeLabel";
            this.modifiedTimeLabel.Size = new System.Drawing.Size(55, 15);
            this.modifiedTimeLabel.TabIndex = 22;
            this.modifiedTimeLabel.Text = "modified";
            // 
            // _typeL
            // 
            this._typeL.Location = new System.Drawing.Point(22, 95);
            this._typeL.Name = "_typeL";
            this._typeL.Size = new System.Drawing.Size(42, 15);
            this._typeL.TabIndex = 23;
            this._typeL.Text = "Type:";
            // 
            // _sizeL
            // 
            this._sizeL.Location = new System.Drawing.Point(22, 155);
            this._sizeL.Name = "_sizeL";
            this._sizeL.Size = new System.Drawing.Size(50, 15);
            this._sizeL.TabIndex = 24;
            this._sizeL.Text = "Size:";
            // 
            // _attributesL
            // 
            this._attributesL.AutoSize = true;
            this._attributesL.Location = new System.Drawing.Point(23, 318);
            this._attributesL.Name = "_attributesL";
            this._attributesL.Size = new System.Drawing.Size(60, 15);
            this._attributesL.TabIndex = 26;
            this._attributesL.Text = "Attributes:";
            // 
            // readonlyCheckBox
            // 
            this.readonlyCheckBox.AutoCheck = false;
            this.readonlyCheckBox.AutoSize = true;
            this.readonlyCheckBox.Location = new System.Drawing.Point(121, 318);
            this.readonlyCheckBox.Name = "readonlyCheckBox";
            this.readonlyCheckBox.Size = new System.Drawing.Size(82, 19);
            this.readonlyCheckBox.TabIndex = 27;
            this.readonlyCheckBox.Text = "Read-only";
            this.readonlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // hiddenCheckBox
            // 
            this.hiddenCheckBox.AutoCheck = false;
            this.hiddenCheckBox.AutoSize = true;
            this.hiddenCheckBox.Location = new System.Drawing.Point(121, 346);
            this.hiddenCheckBox.Name = "hiddenCheckBox";
            this.hiddenCheckBox.Size = new System.Drawing.Size(66, 19);
            this.hiddenCheckBox.TabIndex = 28;
            this.hiddenCheckBox.Text = "Hidden";
            this.hiddenCheckBox.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(9, 214);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(400, 2);
            this.label14.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(11, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(400, 2);
            this.label6.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(23, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Contains:";
            // 
            // contains
            // 
            this.contains.AutoSize = true;
            this.contains.Location = new System.Drawing.Point(121, 184);
            this.contains.Name = "contains";
            this.contains.Size = new System.Drawing.Size(29, 15);
            this.contains.TabIndex = 32;
            this.contains.Text = "files";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.LinkColor = System.Drawing.Color.DarkCyan;
            this.locationLabel.Location = new System.Drawing.Point(121, 125);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(50, 15);
            this.locationLabel.TabIndex = 33;
            this.locationLabel.TabStop = true;
            this.locationLabel.Text = "location";
            this.locationLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.locationLabel_LinkClicked);
            // 
            // PropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 423);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.contains);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.hiddenCheckBox);
            this.Controls.Add(this.readonlyCheckBox);
            this.Controls.Add(this._attributesL);
            this.Controls.Add(this._sizeL);
            this.Controls.Add(this._typeL);
            this.Controls.Add(this.modifiedTimeLabel);
            this.Controls.Add(this._modifiedL);
            this.Controls.Add(this.createdTimeLabel);
            this.Controls.Add(this._createdL);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this._locationL);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.nameTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PropertiesForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Properties";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label _locationL;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label _createdL;
        private System.Windows.Forms.Label createdTimeLabel;
        private System.Windows.Forms.Label _modifiedL;
        private System.Windows.Forms.Label modifiedTimeLabel;
        private System.Windows.Forms.Label _typeL;
        private System.Windows.Forms.Label _sizeL;
        private System.Windows.Forms.Label _attributesL;
        private System.Windows.Forms.CheckBox readonlyCheckBox;
        private System.Windows.Forms.CheckBox hiddenCheckBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label contains;
        private System.Windows.Forms.LinkLabel locationLabel;
    }
}