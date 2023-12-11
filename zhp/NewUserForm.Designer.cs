namespace zhp
{
    partial class NewUserForm
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
            components = new System.ComponentModel.Container();
            txt_OK = new Button();
            txt_cancel = new Button();
            txt_cim = new TextBox();
            txt_nyelv = new TextBox();
            txt_osbem = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txt_OK
            // 
            txt_OK.Location = new Point(157, 125);
            txt_OK.Name = "txt_OK";
            txt_OK.Size = new Size(75, 23);
            txt_OK.TabIndex = 0;
            txt_OK.Text = "Mentés";
            txt_OK.UseVisualStyleBackColor = true;
            txt_OK.Click += txt_OK_Click;
            // 
            // txt_cancel
            // 
            txt_cancel.CausesValidation = false;
            txt_cancel.DialogResult = DialogResult.Cancel;
            txt_cancel.Location = new Point(247, 125);
            txt_cancel.Name = "txt_cancel";
            txt_cancel.Size = new Size(75, 23);
            txt_cancel.TabIndex = 1;
            txt_cancel.Text = "Mégse";
            txt_cancel.UseVisualStyleBackColor = true;
            // 
            // txt_cim
            // 
            txt_cim.Location = new Point(12, 68);
            txt_cim.Name = "txt_cim";
            txt_cim.Size = new Size(100, 23);
            txt_cim.TabIndex = 2;
            txt_cim.Validating += txt_cim_Validating;
            txt_cim.Validated += txt_cim_Validated;
            // 
            // txt_nyelv
            // 
            txt_nyelv.Location = new Point(132, 68);
            txt_nyelv.Name = "txt_nyelv";
            txt_nyelv.Size = new Size(100, 23);
            txt_nyelv.TabIndex = 3;
            txt_nyelv.Validating += txt_nyelv_Validating;
            txt_nyelv.Validated += txt_nyelv_Validated;
            // 
            // txt_osbem
            // 
            txt_osbem.Location = new Point(247, 68);
            txt_osbem.Name = "txt_osbem";
            txt_osbem.Size = new Size(100, 23);
            txt_osbem.TabIndex = 4;
            txt_osbem.Validating += txt_osbem_Validating;
            txt_osbem.Validated += txt_osbem_Validated;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 5;
            label1.Text = "Opera címe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 50);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 6;
            label2.Text = "Opera éneknyelve";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(247, 50);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 7;
            label3.Text = "Opera ősbemutatója";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // NewUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 161);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_osbem);
            Controls.Add(txt_nyelv);
            Controls.Add(txt_cim);
            Controls.Add(txt_cancel);
            Controls.Add(txt_OK);
            Name = "NewUserForm";
            ShowInTaskbar = false;
            Text = "NewUserForm";
            Load += NewUserForm_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button txt_OK;
        private Button txt_cancel;
        private Label label1;
        private Label label2;
        private Label label3;
        public TextBox txt_cim;
        public TextBox txt_nyelv;
        public TextBox txt_osbem;
        private ErrorProvider errorProvider1;
    }
}