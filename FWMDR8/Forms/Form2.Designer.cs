namespace FWMDR8
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            saveButton = new Button();
            cancelButton = new Button();
            musicTitleBox = new TextBox();
            priorityBox = new TextBox();
            musicLengthBox = new TextBox();
            releaseDateBox = new TextBox();
            performerNameBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(445, 28);
            label1.TabIndex = 0;
            label1.Text = "Please fullfill the below form to add/modify music";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 57);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 98);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Performer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 142);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 3;
            label4.Text = "Release date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 185);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 4;
            label5.Text = "Music length";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 229);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 5;
            label6.Text = "Priority";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(23, 280);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(239, 280);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // musicTitleBox
            // 
            musicTitleBox.Location = new Point(106, 57);
            musicTitleBox.Name = "musicTitleBox";
            musicTitleBox.Size = new Size(208, 23);
            musicTitleBox.TabIndex = 8;
            // 
            // priorityBox
            // 
            priorityBox.Location = new Point(106, 229);
            priorityBox.Name = "priorityBox";
            priorityBox.Size = new Size(208, 23);
            priorityBox.TabIndex = 9;
            // 
            // musicLengthBox
            // 
            musicLengthBox.Location = new Point(106, 185);
            musicLengthBox.Name = "musicLengthBox";
            musicLengthBox.Size = new Size(208, 23);
            musicLengthBox.TabIndex = 10;
            // 
            // releaseDateBox
            // 
            releaseDateBox.Location = new Point(106, 142);
            releaseDateBox.Name = "releaseDateBox";
            releaseDateBox.Size = new Size(208, 23);
            releaseDateBox.TabIndex = 11;
            // 
            // performerNameBox
            // 
            performerNameBox.Location = new Point(106, 98);
            performerNameBox.Name = "performerNameBox";
            performerNameBox.Size = new Size(208, 23);
            performerNameBox.TabIndex = 12;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 537);
            Controls.Add(performerNameBox);
            Controls.Add(releaseDateBox);
            Controls.Add(musicLengthBox);
            Controls.Add(priorityBox);
            Controls.Add(musicTitleBox);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Add new music";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button saveButton;
        private Button cancelButton;
        private TextBox musicTitleBox;
        private TextBox priorityBox;
        private TextBox musicLengthBox;
        private TextBox releaseDateBox;
        private TextBox performerNameBox;
    }
}