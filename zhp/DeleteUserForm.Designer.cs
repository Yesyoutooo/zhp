namespace zhp
{
    partial class DeleteUserForm
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
            btn_remove = new Button();
            btn_cancel = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_remove
            // 
            btn_remove.DialogResult = DialogResult.OK;
            btn_remove.Location = new Point(116, 76);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(75, 23);
            btn_remove.TabIndex = 0;
            btn_remove.Text = "Törlés";
            btn_remove.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            btn_cancel.CausesValidation = false;
            btn_cancel.DialogResult = DialogResult.Cancel;
            btn_cancel.Location = new Point(197, 76);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 1;
            btn_cancel.Text = "Mégse";
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(266, 15);
            label1.TabIndex = 2;
            label1.Text = "Biztosan törölni szeretnéd ezt az operát a listából?";
            // 
            // DeleteUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 111);
            Controls.Add(label1);
            Controls.Add(btn_cancel);
            Controls.Add(btn_remove);
            Name = "DeleteUserForm";
            Text = "DeleteUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_remove;
        private Button btn_cancel;
        private Label label1;
    }
}