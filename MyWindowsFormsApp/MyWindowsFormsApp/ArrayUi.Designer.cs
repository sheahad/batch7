namespace MyWindowsFormsApp
{
    partial class ArrayUi
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
            this.showButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.addSizeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.elementTextBox = new System.Windows.Forms.TextBox();
            this.addElementButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(317, 160);
            this.showButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(116, 28);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Size";
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(164, 53);
            this.sizeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(132, 22);
            this.sizeTextBox.TabIndex = 2;
            // 
            // addSizeButton
            // 
            this.addSizeButton.Location = new System.Drawing.Point(333, 48);
            this.addSizeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addSizeButton.Name = "addSizeButton";
            this.addSizeButton.Size = new System.Drawing.Size(100, 28);
            this.addSizeButton.TabIndex = 3;
            this.addSizeButton.Text = "Add Size";
            this.addSizeButton.UseVisualStyleBackColor = true;
            this.addSizeButton.Click += new System.EventHandler(this.addSizeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Element";
            // 
            // elementTextBox
            // 
            this.elementTextBox.Location = new System.Drawing.Point(164, 103);
            this.elementTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.elementTextBox.Name = "elementTextBox";
            this.elementTextBox.Size = new System.Drawing.Size(132, 22);
            this.elementTextBox.TabIndex = 2;
            // 
            // addElementButton
            // 
            this.addElementButton.Location = new System.Drawing.Point(333, 98);
            this.addElementButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addElementButton.Name = "addElementButton";
            this.addElementButton.Size = new System.Drawing.Size(100, 28);
            this.addElementButton.TabIndex = 3;
            this.addElementButton.Text = "Add Element";
            this.addElementButton.UseVisualStyleBackColor = true;
            this.addElementButton.Click += new System.EventHandler(this.addElementButton_Click);
            // 
            // ArrayUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 247);
            this.Controls.Add(this.addElementButton);
            this.Controls.Add(this.elementTextBox);
            this.Controls.Add(this.addSizeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ArrayUi";
            this.Text = "LabUi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.Button addSizeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox elementTextBox;
        private System.Windows.Forms.Button addElementButton;
    }
}