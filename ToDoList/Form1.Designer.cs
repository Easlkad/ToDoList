namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.completeButton = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(346, 185);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "ADD TASK";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(242, 382);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 36);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "DELETE TASK";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.buttonDeleteTask_Click);
            // 
            // completeButton
            // 
            this.completeButton.Location = new System.Drawing.Point(434, 382);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(94, 36);
            this.completeButton.TabIndex = 2;
            this.completeButton.Text = "COMPLETED";
            this.completeButton.UseVisualStyleBackColor = true;
            this.completeButton.Click += new System.EventHandler(this.buttonCompleteTask_Click);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.SystemColors.Info;
            this.TextBox.Location = new System.Drawing.Point(110, 40);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(583, 96);
            this.TextBox.TabIndex = 3;
            this.TextBox.Text = "";
            // 
            // ListBox
            // 
            this.ListBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(110, 259);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(583, 95);
            this.ListBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.completeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.ListBox ListBox;
    }
}

