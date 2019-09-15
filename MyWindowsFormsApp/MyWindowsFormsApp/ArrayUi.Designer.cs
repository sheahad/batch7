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
            this.showButton.Location = new System.Drawing.Point(203, 177);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(87, 23);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Size";
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(123, 43);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sizeTextBox.TabIndex = 2;
            // 
            // addSizeButton
            // 
            this.addSizeButton.Location = new System.Drawing.Point(250, 39);
            this.addSizeButton.Name = "addSizeButton";
            this.addSizeButton.Size = new System.Drawing.Size(75, 23);
            this.addSizeButton.TabIndex = 3;
            this.addSizeButton.Text = "Add Size";
            this.addSizeButton.UseVisualStyleBackColor = true;
            this.addSizeButton.Click += new System.EventHandler(this.addSizeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Element";
            // 
            // elementTextBox
            // 
            this.elementTextBox.Location = new System.Drawing.Point(123, 84);
            this.elementTextBox.Name = "elementTextBox";
            this.elementTextBox.Size = new System.Drawing.Size(100, 20);
            this.elementTextBox.TabIndex = 2;
            // 
            // addElementButton
            // 
            this.addElementButton.Location = new System.Drawing.Point(250, 80);
            this.addElementButton.Name = "addElementButton";
            this.addElementButton.Size = new System.Drawing.Size(75, 23);
            this.addElementButton.TabIndex = 3;
            this.addElementButton.Text = "Add Element";
            this.addElementButton.UseVisualStyleBackColor = true;
            this.addElementButton.Click += new System.EventHandler(this.addElementButton_Click);
            // 
            // ArrayUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 450);
            this.Controls.Add(this.addElementButton);
            this.Controls.Add(this.elementTextBox);
            this.Controls.Add(this.addSizeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showButton);
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