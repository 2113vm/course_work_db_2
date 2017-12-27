namespace WindowsFormsApp1.Forms
{
    partial class OrderForm
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
            this.OrderListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OranizationTextBox = new System.Windows.Forms.TextBox();
            this.NameSoftwareTextBox = new System.Windows.Forms.TextBox();
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.BankTextBox = new System.Windows.Forms.TextBox();
            this.PerformerBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OrderListBox
            // 
            this.OrderListBox.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderListBox.FormattingEnabled = true;
            this.OrderListBox.ItemHeight = 20;
            this.OrderListBox.Location = new System.Drawing.Point(32, 33);
            this.OrderListBox.Name = "OrderListBox";
            this.OrderListBox.Size = new System.Drawing.Size(479, 384);
            this.OrderListBox.TabIndex = 0;
            this.OrderListBox.SelectedIndexChanged += new System.EventHandler(this.OrderListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(537, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Организация:";
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddOrderButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.AddOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddOrderButton.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOrderButton.ForeColor = System.Drawing.Color.White;
            this.AddOrderButton.Location = new System.Drawing.Point(615, 381);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(173, 36);
            this.AddOrderButton.TabIndex = 2;
            this.AddOrderButton.Text = "Добавить Заказ";
            this.AddOrderButton.UseVisualStyleBackColor = false;
            this.AddOrderButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.label2.Location = new System.Drawing.Point(537, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название програмного обеспечения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.label3.Location = new System.Drawing.Point(537, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Краткое описание:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.label4.Location = new System.Drawing.Point(537, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Банковские реквизиты (Номер карты):";
            // 
            // OranizationTextBox
            // 
            this.OranizationTextBox.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OranizationTextBox.Location = new System.Drawing.Point(540, 54);
            this.OranizationTextBox.Name = "OranizationTextBox";
            this.OranizationTextBox.Size = new System.Drawing.Size(314, 28);
            this.OranizationTextBox.TabIndex = 6;
            // 
            // NameSoftwareTextBox
            // 
            this.NameSoftwareTextBox.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameSoftwareTextBox.Location = new System.Drawing.Point(540, 111);
            this.NameSoftwareTextBox.Name = "NameSoftwareTextBox";
            this.NameSoftwareTextBox.Size = new System.Drawing.Size(314, 28);
            this.NameSoftwareTextBox.TabIndex = 7;
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.CommentTextBox.Location = new System.Drawing.Point(540, 164);
            this.CommentTextBox.Multiline = true;
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(314, 93);
            this.CommentTextBox.TabIndex = 8;
            // 
            // BankTextBox
            // 
            this.BankTextBox.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BankTextBox.Location = new System.Drawing.Point(540, 291);
            this.BankTextBox.Name = "BankTextBox";
            this.BankTextBox.Size = new System.Drawing.Size(314, 28);
            this.BankTextBox.TabIndex = 9;
            // 
            // PerformerBox
            // 
            this.PerformerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PerformerBox.Font = new System.Drawing.Font("Roboto", 10.2F);
            this.PerformerBox.FormattingEnabled = true;
            this.PerformerBox.Location = new System.Drawing.Point(540, 342);
            this.PerformerBox.Name = "PerformerBox";
            this.PerformerBox.Size = new System.Drawing.Size(314, 28);
            this.PerformerBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(537, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Исполнитель:";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 447);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PerformerBox);
            this.Controls.Add(this.BankTextBox);
            this.Controls.Add(this.CommentTextBox);
            this.Controls.Add(this.NameSoftwareTextBox);
            this.Controls.Add(this.OranizationTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddOrderButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderListBox);
            this.Name = "OrderForm";
            this.Text = "Заказы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CommentTextBox;
        private System.Windows.Forms.TextBox BankTextBox;
        private System.Windows.Forms.Label label6;
        protected internal System.Windows.Forms.ListBox OrderListBox;
        protected internal System.Windows.Forms.TextBox OranizationTextBox;
        protected internal System.Windows.Forms.TextBox NameSoftwareTextBox;
        protected internal System.Windows.Forms.ComboBox PerformerBox;
    }
}