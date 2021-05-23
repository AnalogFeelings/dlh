
namespace DLH
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.entryList = new System.Windows.Forms.ListView();
            this.linkName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.linkType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.linkNotes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGroup = new System.Windows.Forms.GroupBox();
            this.editButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.linkBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.notesBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lookNameBox = new System.Windows.Forms.TextBox();
            this.lookButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.dataGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // entryList
            // 
            this.entryList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.linkName,
            this.linkType,
            this.linkNotes});
            this.entryList.HideSelection = false;
            this.entryList.Location = new System.Drawing.Point(12, 12);
            this.entryList.Name = "entryList";
            this.entryList.Size = new System.Drawing.Size(512, 328);
            this.entryList.TabIndex = 0;
            this.entryList.UseCompatibleStateImageBehavior = false;
            this.entryList.View = System.Windows.Forms.View.Details;
            // 
            // linkName
            // 
            this.linkName.Text = "Name";
            this.linkName.Width = 146;
            // 
            // linkType
            // 
            this.linkType.Text = "Type";
            this.linkType.Width = 95;
            // 
            // linkNotes
            // 
            this.linkNotes.Text = "Notes";
            this.linkNotes.Width = 265;
            // 
            // dataGroup
            // 
            this.dataGroup.Controls.Add(this.aboutButton);
            this.dataGroup.Controls.Add(this.editButton);
            this.dataGroup.Controls.Add(this.saveButton);
            this.dataGroup.Controls.Add(this.newButton);
            this.dataGroup.Controls.Add(this.copyButton);
            this.dataGroup.Controls.Add(this.linkBox);
            this.dataGroup.Controls.Add(this.label4);
            this.dataGroup.Controls.Add(this.deleteButton);
            this.dataGroup.Controls.Add(this.typeBox);
            this.dataGroup.Controls.Add(this.label3);
            this.dataGroup.Controls.Add(this.notesBox);
            this.dataGroup.Controls.Add(this.label2);
            this.dataGroup.Controls.Add(this.nameBox);
            this.dataGroup.Controls.Add(this.label1);
            this.dataGroup.Location = new System.Drawing.Point(12, 372);
            this.dataGroup.Name = "dataGroup";
            this.dataGroup.Size = new System.Drawing.Size(512, 182);
            this.dataGroup.TabIndex = 1;
            this.dataGroup.TabStop = false;
            this.dataGroup.Text = "Data";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(171, 150);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(98, 23);
            this.editButton.TabIndex = 12;
            this.editButton.Text = "Save";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(366, 150);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save JSON";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(90, 150);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 10;
            this.newButton.Text = "New Entry";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(285, 150);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 23);
            this.copyButton.TabIndex = 9;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // linkBox
            // 
            this.linkBox.Location = new System.Drawing.Point(285, 75);
            this.linkBox.Multiline = true;
            this.linkBox.Name = "linkBox";
            this.linkBox.Size = new System.Drawing.Size(212, 69);
            this.linkBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Link";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(9, 150);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // typeBox
            // 
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "Video",
            "GIF"});
            this.typeBox.Location = new System.Drawing.Point(285, 33);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(212, 21);
            this.typeBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type";
            // 
            // notesBox
            // 
            this.notesBox.Location = new System.Drawing.Point(9, 75);
            this.notesBox.Multiline = true;
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(260, 69);
            this.notesBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Notes";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(9, 34);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(260, 20);
            this.nameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name";
            // 
            // lookNameBox
            // 
            this.lookNameBox.Location = new System.Drawing.Point(64, 346);
            this.lookNameBox.Name = "lookNameBox";
            this.lookNameBox.Size = new System.Drawing.Size(379, 20);
            this.lookNameBox.TabIndex = 3;
            // 
            // lookButton
            // 
            this.lookButton.Location = new System.Drawing.Point(449, 344);
            this.lookButton.Name = "lookButton";
            this.lookButton.Size = new System.Drawing.Size(75, 23);
            this.lookButton.TabIndex = 5;
            this.lookButton.Text = "Search";
            this.lookButton.UseVisualStyleBackColor = true;
            this.lookButton.Click += new System.EventHandler(this.lookButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(447, 150);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(50, 23);
            this.aboutButton.TabIndex = 13;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 566);
            this.Controls.Add(this.lookButton);
            this.Controls.Add(this.lookNameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGroup);
            this.Controls.Add(this.entryList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Discord Link Helper";
            this.dataGroup.ResumeLayout(false);
            this.dataGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView entryList;
        private System.Windows.Forms.ColumnHeader linkName;
        private System.Windows.Forms.ColumnHeader linkType;
        private System.Windows.Forms.ColumnHeader linkNotes;
        private System.Windows.Forms.GroupBox dataGroup;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.TextBox linkBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox notesBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lookNameBox;
        private System.Windows.Forms.Button lookButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button aboutButton;
    }
}

