namespace WindowsFormsApp1.Forms
{
    partial class EditOrderForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.PerformerBox = new System.Windows.Forms.ComboBox();
            this.EditOrderButton = new System.Windows.Forms.Button();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BankTextBox = new System.Windows.Forms.TextBox();
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.NameSoftwareTextBox = new System.Windows.Forms.TextBox();
            this.OranizationTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenContractButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Исполнитель:";
            // 
            // PerformerBox
            // 
            this.PerformerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PerformerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PerformerBox.FormattingEnabled = true;
            this.PerformerBox.Location = new System.Drawing.Point(15, 317);
            this.PerformerBox.Name = "PerformerBox";
            this.PerformerBox.Size = new System.Drawing.Size(387, 28);
            this.PerformerBox.TabIndex = 28;
            // 
            // EditOrderButton
            // 
            this.EditOrderButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.EditOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditOrderButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.EditOrderButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.EditOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditOrderButton.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditOrderButton.ForeColor = System.Drawing.Color.White;
            this.EditOrderButton.Location = new System.Drawing.Point(15, 421);
            this.EditOrderButton.Name = "EditOrderButton";
            this.EditOrderButton.Size = new System.Drawing.Size(194, 36);
            this.EditOrderButton.TabIndex = 27;
            this.EditOrderButton.Text = "Сохранить изменения";
            this.EditOrderButton.UseVisualStyleBackColor = false;
            this.EditOrderButton.Click += new System.EventHandler(this.EditOrderButton_Click);
            // 
            // StatusBox
            // 
            this.StatusBox.Enabled = false;
            this.StatusBox.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Items.AddRange(new object[] {
            "Составление договора",
            "Договор составлен",
            "Договор подтверждён",
            "Договор отменён",
            "Договор просрочен",
            "На этапе \"Анализ требований\"",
            "На этапе \"Проектирование\"",
            "На этапе \"Реализация\"",
            "На этапе \"Внедрение\""});
            this.StatusBox.Location = new System.Drawing.Point(15, 378);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(387, 28);
            this.StatusBox.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.label5.Location = new System.Drawing.Point(12, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Статус заказа:";
            // 
            // BankTextBox
            // 
            this.BankTextBox.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BankTextBox.Location = new System.Drawing.Point(15, 266);
            this.BankTextBox.Name = "BankTextBox";
            this.BankTextBox.Size = new System.Drawing.Size(387, 28);
            this.BankTextBox.TabIndex = 24;
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.CommentTextBox.Location = new System.Drawing.Point(15, 139);
            this.CommentTextBox.Multiline = true;
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(387, 93);
            this.CommentTextBox.TabIndex = 23;
            // 
            // NameSoftwareTextBox
            // 
            this.NameSoftwareTextBox.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameSoftwareTextBox.Location = new System.Drawing.Point(15, 86);
            this.NameSoftwareTextBox.Name = "NameSoftwareTextBox";
            this.NameSoftwareTextBox.Size = new System.Drawing.Size(387, 28);
            this.NameSoftwareTextBox.TabIndex = 22;
            // 
            // OranizationTextBox
            // 
            this.OranizationTextBox.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OranizationTextBox.Location = new System.Drawing.Point(15, 29);
            this.OranizationTextBox.Name = "OranizationTextBox";
            this.OranizationTextBox.Size = new System.Drawing.Size(387, 28);
            this.OranizationTextBox.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.label4.Location = new System.Drawing.Point(12, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Банковские реквизиты (Номер карты):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Краткое описание:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Название програмного обеспечения:";
            // 
            // OpenContractButton
            // 
            this.OpenContractButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.OpenContractButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenContractButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.OpenContractButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenContractButton.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenContractButton.ForeColor = System.Drawing.Color.White;
            this.OpenContractButton.Location = new System.Drawing.Point(15, 463);
            this.OpenContractButton.Name = "OpenContractButton";
            this.OpenContractButton.Size = new System.Drawing.Size(194, 36);
            this.OpenContractButton.TabIndex = 16;
            this.OpenContractButton.Text = "Открыть договор";
            this.OpenContractButton.UseVisualStyleBackColor = false;
            this.OpenContractButton.Click += new System.EventHandler(this.OpenContractButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Организация:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(288, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 53);
            this.button1.TabIndex = 27;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 519);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PerformerBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EditOrderButton);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BankTextBox);
            this.Controls.Add(this.CommentTextBox);
            this.Controls.Add(this.NameSoftwareTextBox);
            this.Controls.Add(this.OranizationTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OpenContractButton);
            this.Controls.Add(this.label1);
            this.Name = "EditOrderForm";
            this.Text = "Редактирование заказа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button EditOrderButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OpenContractButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        protected internal System.Windows.Forms.ComboBox PerformerBox;
        protected internal System.Windows.Forms.TextBox BankTextBox;
        protected internal System.Windows.Forms.TextBox CommentTextBox;
        protected internal System.Windows.Forms.TextBox NameSoftwareTextBox;
        protected internal System.Windows.Forms.TextBox OranizationTextBox;
        protected internal System.Windows.Forms.ComboBox StatusBox;
    }
}