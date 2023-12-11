namespace zhp
{
    partial class Form1
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
            Panel1 = new Button();
            btn_uc1 = new Button();
            btn_uc2 = new Button();
            btn_uc3 = new Button();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.Location = new Point(102, 44);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(686, 394);
            Panel1.TabIndex = 1;
            Panel1.UseVisualStyleBackColor = true;
            // 
            // btn_uc1
            // 
            btn_uc1.Location = new Point(12, 44);
            btn_uc1.Name = "btn_uc1";
            btn_uc1.Size = new Size(84, 65);
            btn_uc1.TabIndex = 2;
            btn_uc1.Text = "UserControl1";
            btn_uc1.UseVisualStyleBackColor = true;
            btn_uc1.Click += btn_uc1_Click;
            // 
            // btn_uc2
            // 
            btn_uc2.Location = new Point(12, 115);
            btn_uc2.Name = "btn_uc2";
            btn_uc2.Size = new Size(84, 65);
            btn_uc2.TabIndex = 3;
            btn_uc2.Text = "UserControl2";
            btn_uc2.UseVisualStyleBackColor = true;
            btn_uc2.Click += btn_uc2_Click;
            // 
            // btn_uc3
            // 
            btn_uc3.Location = new Point(12, 186);
            btn_uc3.Name = "btn_uc3";
            btn_uc3.Size = new Size(84, 65);
            btn_uc3.TabIndex = 4;
            btn_uc3.Text = "UserControl3";
            btn_uc3.UseVisualStyleBackColor = true;
            btn_uc3.Click += btn_uc3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_uc3);
            Controls.Add(btn_uc2);
            Controls.Add(btn_uc1);
            Controls.Add(Panel1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
        }

        #endregion
        private Button Panel1;
        private Button btn_uc1;
        private Button btn_uc2;
        private Button btn_uc3;
    }
}
