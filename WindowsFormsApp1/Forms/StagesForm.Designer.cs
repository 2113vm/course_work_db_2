namespace WindowsFormsApp1.Forms
{
    partial class StagesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.AddStagesButton = new System.Windows.Forms.Button();
            this.SubContractButton = new System.Windows.Forms.Button();
            this.PerformerBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NameStageComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.label3.Location = new System.Drawing.Point(21, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Длительность (дней):";
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Location = new System.Drawing.Point(24, 214);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(253, 22);
            this.TimeTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.label2.Location = new System.Drawing.Point(21, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Стоимость:";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(24, 277);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(253, 22);
            this.PriceTextBox.TabIndex = 9;
            // 
            // AddStagesButton
            // 
            this.AddStagesButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddStagesButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.AddStagesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStagesButton.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddStagesButton.ForeColor = System.Drawing.Color.White;
            this.AddStagesButton.Location = new System.Drawing.Point(61, 325);
            this.AddStagesButton.Name = "AddStagesButton";
            this.AddStagesButton.Size = new System.Drawing.Size(189, 32);
            this.AddStagesButton.TabIndex = 10;
            this.AddStagesButton.Text = "Добавить этап";
            this.AddStagesButton.UseVisualStyleBackColor = false;
            this.AddStagesButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SubContractButton
            // 
            this.SubContractButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SubContractButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubContractButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.SubContractButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubContractButton.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubContractButton.ForeColor = System.Drawing.Color.White;
            this.SubContractButton.Location = new System.Drawing.Point(61, 133);
            this.SubContractButton.Name = "SubContractButton";
            this.SubContractButton.Size = new System.Drawing.Size(189, 37);
            this.SubContractButton.TabIndex = 19;
            this.SubContractButton.Text = "Заказать субподряд";
            this.SubContractButton.UseVisualStyleBackColor = false;
            this.SubContractButton.Visible = false;
            this.SubContractButton.Click += new System.EventHandler(this.SubContractButton_Click);
            // 
            // PerformerBox
            // 
            this.PerformerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PerformerBox.FormattingEnabled = true;
            this.PerformerBox.Location = new System.Drawing.Point(24, 92);
            this.PerformerBox.Name = "PerformerBox";
            this.PerformerBox.Size = new System.Drawing.Size(253, 24);
            this.PerformerBox.TabIndex = 20;
            this.PerformerBox.SelectedIndexChanged += new System.EventHandler(this.PerformerBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.label4.Location = new System.Drawing.Point(24, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Исполнитель:";
            // 
            // NameStageComboBox
            // 
            this.NameStageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NameStageComboBox.FormattingEnabled = true;
            this.NameStageComboBox.Items.AddRange(new object[] {
            "Анализ требований",
            "Проектирование",
            "Реализация",
            "Внедрение",
            "Сопровождение",
            "Полное выполнение"});
            this.NameStageComboBox.Location = new System.Drawing.Point(24, 38);
            this.NameStageComboBox.Name = "NameStageComboBox";
            this.NameStageComboBox.Size = new System.Drawing.Size(253, 24);
            this.NameStageComboBox.TabIndex = 22;
            // 
            // StagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 389);
            this.Controls.Add(this.NameStageComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PerformerBox);
            this.Controls.Add(this.SubContractButton);
            this.Controls.Add(this.AddStagesButton);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "StagesForm";
            this.Text = "Добавление этапа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Button AddStagesButton;
        private System.Windows.Forms.Button SubContractButton;
        private System.Windows.Forms.ComboBox PerformerBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox NameStageComboBox;
    }
}