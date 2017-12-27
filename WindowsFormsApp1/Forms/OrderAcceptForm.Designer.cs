namespace WindowsFormsApp1.Forms
{
    partial class OrderAcceptForm
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
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BankInfoTextBox = new System.Windows.Forms.TextBox();
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.SoftwareTextBox = new System.Windows.Forms.TextBox();
            this.OrganizationTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateContractButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderListBox = new System.Windows.Forms.ListBox();
            this.EditContractButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.StagesListBox = new System.Windows.Forms.ListBox();
            this.AddStageButton = new System.Windows.Forms.Button();
            this.AcceptStatusButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StatusBox
            // 
            this.StatusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusBox.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Location = new System.Drawing.Point(459, 340);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(314, 28);
            this.StatusBox.TabIndex = 27;
            this.StatusBox.SelectedIndexChanged += new System.EventHandler(this.StatusBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.label5.Location = new System.Drawing.Point(456, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Статус заказа:";
            // 
            // BankInfoTextBox
            // 
            this.BankInfoTextBox.Enabled = false;
            this.BankInfoTextBox.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BankInfoTextBox.Location = new System.Drawing.Point(459, 282);
            this.BankInfoTextBox.Name = "BankInfoTextBox";
            this.BankInfoTextBox.Size = new System.Drawing.Size(314, 28);
            this.BankInfoTextBox.TabIndex = 25;
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.Enabled = false;
            this.CommentTextBox.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.CommentTextBox.Location = new System.Drawing.Point(459, 155);
            this.CommentTextBox.Multiline = true;
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(314, 93);
            this.CommentTextBox.TabIndex = 24;
            // 
            // SoftwareTextBox
            // 
            this.SoftwareTextBox.Enabled = false;
            this.SoftwareTextBox.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SoftwareTextBox.Location = new System.Drawing.Point(459, 102);
            this.SoftwareTextBox.Name = "SoftwareTextBox";
            this.SoftwareTextBox.Size = new System.Drawing.Size(314, 28);
            this.SoftwareTextBox.TabIndex = 23;
            // 
            // OrganizationTextBox
            // 
            this.OrganizationTextBox.Enabled = false;
            this.OrganizationTextBox.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrganizationTextBox.Location = new System.Drawing.Point(459, 45);
            this.OrganizationTextBox.Name = "OrganizationTextBox";
            this.OrganizationTextBox.Size = new System.Drawing.Size(314, 28);
            this.OrganizationTextBox.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.label4.Location = new System.Drawing.Point(456, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Банковские реквизиты (Номер карты):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.label3.Location = new System.Drawing.Point(456, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Краткое описание:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.label2.Location = new System.Drawing.Point(456, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Название програмного обеспечения:";
            // 
            // CreateContractButton
            // 
            this.CreateContractButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.CreateContractButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateContractButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.CreateContractButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateContractButton.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateContractButton.ForeColor = System.Drawing.Color.White;
            this.CreateContractButton.Location = new System.Drawing.Point(459, 431);
            this.CreateContractButton.Name = "CreateContractButton";
            this.CreateContractButton.Size = new System.Drawing.Size(193, 36);
            this.CreateContractButton.TabIndex = 18;
            this.CreateContractButton.Text = "Составить договор";
            this.CreateContractButton.UseVisualStyleBackColor = false;
            this.CreateContractButton.Click += new System.EventHandler(this.CreateContractButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(456, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Организация:";
            // 
            // OrderListBox
            // 
            this.OrderListBox.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderListBox.FormattingEnabled = true;
            this.OrderListBox.ItemHeight = 20;
            this.OrderListBox.Location = new System.Drawing.Point(12, 23);
            this.OrderListBox.Name = "OrderListBox";
            this.OrderListBox.Size = new System.Drawing.Size(426, 444);
            this.OrderListBox.TabIndex = 16;
            this.OrderListBox.SelectedIndexChanged += new System.EventHandler(this.OrderListBox_SelectedIndexChanged);
            // 
            // EditContractButton
            // 
            this.EditContractButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.EditContractButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditContractButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.EditContractButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditContractButton.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditContractButton.ForeColor = System.Drawing.Color.White;
            this.EditContractButton.Location = new System.Drawing.Point(658, 431);
            this.EditContractButton.Name = "EditContractButton";
            this.EditContractButton.Size = new System.Drawing.Size(193, 36);
            this.EditContractButton.TabIndex = 28;
            this.EditContractButton.Text = "Редактировать Договор";
            this.EditContractButton.UseVisualStyleBackColor = false;
            this.EditContractButton.Click += new System.EventHandler(this.EditContractButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(811, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Этапы:";
            // 
            // StagesListBox
            // 
            this.StagesListBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StagesListBox.FormattingEnabled = true;
            this.StagesListBox.ItemHeight = 18;
            this.StagesListBox.Location = new System.Drawing.Point(814, 45);
            this.StagesListBox.Name = "StagesListBox";
            this.StagesListBox.Size = new System.Drawing.Size(308, 184);
            this.StagesListBox.TabIndex = 33;
            this.StagesListBox.SelectedIndexChanged += new System.EventHandler(this.StagesListBox_SelectedIndexChanged);
            // 
            // AddStageButton
            // 
            this.AddStageButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddStageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStageButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.AddStageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStageButton.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddStageButton.ForeColor = System.Drawing.Color.White;
            this.AddStageButton.Location = new System.Drawing.Point(834, 247);
            this.AddStageButton.Name = "AddStageButton";
            this.AddStageButton.Size = new System.Drawing.Size(267, 36);
            this.AddStageButton.TabIndex = 18;
            this.AddStageButton.Text = "Добавить новый этап";
            this.AddStageButton.UseVisualStyleBackColor = false;
            this.AddStageButton.Click += new System.EventHandler(this.AddStageButton_Click);
            // 
            // AcceptStatusButton
            // 
            this.AcceptStatusButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AcceptStatusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AcceptStatusButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.AcceptStatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptStatusButton.Font = new System.Drawing.Font("Roboto Light", 8F, System.Drawing.FontStyle.Italic);
            this.AcceptStatusButton.ForeColor = System.Drawing.Color.Black;
            this.AcceptStatusButton.Location = new System.Drawing.Point(459, 374);
            this.AcceptStatusButton.Name = "AcceptStatusButton";
            this.AcceptStatusButton.Size = new System.Drawing.Size(172, 27);
            this.AcceptStatusButton.TabIndex = 18;
            this.AcceptStatusButton.Text = "Подтвердить статус";
            this.AcceptStatusButton.UseVisualStyleBackColor = false;
            this.AcceptStatusButton.Click += new System.EventHandler(this.AcceptStatusButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(834, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 37);
            this.button1.TabIndex = 34;
            this.button1.Text = "Посмотреть мои заказы";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderAcceptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 492);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StagesListBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EditContractButton);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BankInfoTextBox);
            this.Controls.Add(this.CommentTextBox);
            this.Controls.Add(this.SoftwareTextBox);
            this.Controls.Add(this.OrganizationTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddStageButton);
            this.Controls.Add(this.AcceptStatusButton);
            this.Controls.Add(this.CreateContractButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderListBox);
            this.Name = "OrderAcceptForm";
            this.Text = "Форма принятия заказов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderAcceptForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StatusBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BankInfoTextBox;
        private System.Windows.Forms.TextBox CommentTextBox;
        private System.Windows.Forms.TextBox SoftwareTextBox;
        private System.Windows.Forms.TextBox OrganizationTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox OrderListBox;
        private System.Windows.Forms.Button EditContractButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox StagesListBox;
        private System.Windows.Forms.Button AddStageButton;
        private System.Windows.Forms.Button AcceptStatusButton;
        private System.Windows.Forms.Button CreateContractButton;
        private System.Windows.Forms.Button button1;
    }
}