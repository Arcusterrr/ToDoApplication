namespace ToDoApplication
{
    partial class ToDoList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDoList));
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(298, 436);
            this.checkedListBox1.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddButton.BackgroundImage")));
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddButton.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddButton.Location = new System.Drawing.Point(0, 433);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(298, 132);
            this.AddButton.TabIndex = 2;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 566);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "ToDoList";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ToDoList_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Button AddButton;
    }
}