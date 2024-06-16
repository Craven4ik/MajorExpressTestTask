namespace MajorExpressTestTask.UI.Forms
{
    partial class SelectCourierForm
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
            labelHeader = new Label();
            comboBoxCouriers = new ComboBox();
            buttonCancel = new Button();
            buttonApprove = new Button();
            SuspendLayout();
            // 
            // labelHeader
            // 
            labelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelHeader.Location = new Point(141, 25);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(379, 32);
            labelHeader.TabIndex = 1;
            labelHeader.Text = "Выберите исполнителя заявки";
            labelHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxCouriers
            // 
            comboBoxCouriers.Font = new Font("Segoe UI", 14F);
            comboBoxCouriers.FormattingEnabled = true;
            comboBoxCouriers.Location = new Point(141, 91);
            comboBoxCouriers.Name = "comboBoxCouriers";
            comboBoxCouriers.Size = new Size(379, 39);
            comboBoxCouriers.TabIndex = 2;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 14F);
            buttonCancel.Location = new Point(141, 264);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(165, 41);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonApprove
            // 
            buttonApprove.Font = new Font("Segoe UI", 14F);
            buttonApprove.Location = new Point(355, 264);
            buttonApprove.Name = "buttonApprove";
            buttonApprove.Size = new Size(165, 41);
            buttonApprove.TabIndex = 6;
            buttonApprove.Text = "Подтвердить";
            buttonApprove.UseVisualStyleBackColor = true;
            buttonApprove.Click += buttonApprove_Click;
            // 
            // SelectCourierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 394);
            Controls.Add(buttonApprove);
            Controls.Add(buttonCancel);
            Controls.Add(comboBoxCouriers);
            Controls.Add(labelHeader);
            Name = "SelectCourierForm";
            Text = "Форма выбора исполнителя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeader;
        private ComboBox comboBoxCouriers;
        private Button buttonCancel;
        private Button buttonApprove;
    }
}