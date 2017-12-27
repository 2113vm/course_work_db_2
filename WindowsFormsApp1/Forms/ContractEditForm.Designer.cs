namespace WindowsFormsApp1.Forms
{
    partial class ContractEditForm
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
            this.OkButton = new System.Windows.Forms.Button();
            this.SumPriseTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SumTimeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SoftwareTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PerformerTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClientTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberOrderTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkButton.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.OkButton.ForeColor = System.Drawing.Color.White;
            this.OkButton.Location = new System.Drawing.Point(158, 425);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(84, 34);
            this.OkButton.TabIndex = 32;
            this.OkButton.Text = "Ок";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // SumPriseTextBox
            // 
            this.SumPriseTextBox.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumPriseTextBox.Location = new System.Drawing.Point(12, 371);
            this.SumPriseTextBox.Name = "SumPriseTextBox";
            this.SumPriseTextBox.Size = new System.Drawing.Size(369, 28);
            this.SumPriseTextBox.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.label8.Location = new System.Drawing.Point(9, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Общая стоимость:";
            // 
            // SumTimeTextBox
            // 
            this.SumTimeTextBox.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumTimeTextBox.Location = new System.Drawing.Point(12, 316);
            this.SumTimeTextBox.Name = "SumTimeTextBox";
            this.SumTimeTextBox.Size = new System.Drawing.Size(370, 28);
            this.SumTimeTextBox.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.label6.Location = new System.Drawing.Point(9, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Срок действия:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(12, 259);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(370, 28);
            this.dateTimePicker.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.label5.Location = new System.Drawing.Point(9, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Дата:";
            // 
            // SoftwareTextBox
            // 
            this.SoftwareTextBox.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SoftwareTextBox.Location = new System.Drawing.Point(12, 204);
            this.SoftwareTextBox.Name = "SoftwareTextBox";
            this.SoftwareTextBox.Size = new System.Drawing.Size(370, 28);
            this.SoftwareTextBox.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.label4.Location = new System.Drawing.Point(9, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Предмет договора:";
            // 
            // PerformerTextBox
            // 
            this.PerformerTextBox.Enabled = false;
            this.PerformerTextBox.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PerformerTextBox.Location = new System.Drawing.Point(12, 143);
            this.PerformerTextBox.Name = "PerformerTextBox";
            this.PerformerTextBox.Size = new System.Drawing.Size(370, 28);
            this.PerformerTextBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.label3.Location = new System.Drawing.Point(9, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Исполнитель:";
            // 
            // ClientTextBox
            // 
            this.ClientTextBox.Enabled = false;
            this.ClientTextBox.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientTextBox.Location = new System.Drawing.Point(12, 85);
            this.ClientTextBox.Name = "ClientTextBox";
            this.ClientTextBox.Size = new System.Drawing.Size(370, 28);
            this.ClientTextBox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Заказчик:";
            // 
            // NumberOrderTextBox
            // 
            this.NumberOrderTextBox.Enabled = false;
            this.NumberOrderTextBox.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOrderTextBox.Location = new System.Drawing.Point(12, 30);
            this.NumberOrderTextBox.Name = "NumberOrderTextBox";
            this.NumberOrderTextBox.Size = new System.Drawing.Size(370, 28);
            this.NumberOrderTextBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 7.8F);
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Номер:";
            // 
            // ContractEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 471);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.SumPriseTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SumTimeTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SoftwareTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PerformerTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClientTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumberOrderTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ContractEditForm";
            this.Text = "Редактировать договор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TextBox SumPriseTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SumTimeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SoftwareTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PerformerTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClientTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumberOrderTextBox;
        private System.Windows.Forms.Label label1;
    }
}