namespace MajorExpressTestTask.UI.Forms
{
    partial class CancelRequestForm
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
            buttonSave = new Button();
            buttonCancel = new Button();
            textBoxCancellingReason = new TextBox();
            labelHeader = new Label();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 14F);
            buttonSave.Location = new Point(408, 165);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(145, 41);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new Font("Segoe UI", 14F);
            buttonCancel.Location = new Point(253, 165);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(145, 41);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxCancellingReason
            // 
            textBoxCancellingReason.Font = new Font("Segoe UI", 14F);
            textBoxCancellingReason.Location = new Point(114, 86);
            textBoxCancellingReason.Name = "textBoxCancellingReason";
            textBoxCancellingReason.PlaceholderText = "Причина отмены заявки";
            textBoxCancellingReason.Size = new Size(561, 39);
            textBoxCancellingReason.TabIndex = 7;
            // 
            // labelHeader
            // 
            labelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelHeader.Location = new Point(200, 20);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(407, 32);
            labelHeader.TabIndex = 6;
            labelHeader.Text = "Введите причину отмены заявки";
            labelHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CancellingReasonForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 253);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(textBoxCancellingReason);
            Controls.Add(labelHeader);
            Name = "CancellingReasonForm";
            Text = "Форма ввода причины отмены заявки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Button buttonCancel;
        private TextBox textBoxCancellingReason;
        private Label labelHeader;
    }
}