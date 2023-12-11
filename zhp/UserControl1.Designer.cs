namespace zhp
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbox_opera = new ListBox();
            txt_opera = new TextBox();
            txt_zenezszerzo = new TextBox();
            lbox_zeneszerzo = new ListBox();
            SuspendLayout();
            // 
            // lbox_opera
            // 
            lbox_opera.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbox_opera.FormattingEnabled = true;
            lbox_opera.ItemHeight = 15;
            lbox_opera.Location = new Point(197, 68);
            lbox_opera.Name = "lbox_opera";
            lbox_opera.Size = new Size(221, 529);
            lbox_opera.TabIndex = 0;
            lbox_opera.SelectedIndexChanged += lbox_opera_SelectedIndexChanged;
            // 
            // txt_opera
            // 
            txt_opera.Location = new Point(197, 36);
            txt_opera.Name = "txt_opera";
            txt_opera.Size = new Size(221, 23);
            txt_opera.TabIndex = 1;
            txt_opera.TextChanged += textBox1_TextChanged;
            // 
            // txt_zenezszerzo
            // 
            txt_zenezszerzo.Location = new Point(5, 36);
            txt_zenezszerzo.Name = "txt_zenezszerzo";
            txt_zenezszerzo.Size = new Size(186, 23);
            txt_zenezszerzo.TabIndex = 4;
            txt_zenezszerzo.TextChanged += textBox2_TextChanged;
            // 
            // lbox_zeneszerzo
            // 
            lbox_zeneszerzo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbox_zeneszerzo.FormattingEnabled = true;
            lbox_zeneszerzo.ItemHeight = 15;
            lbox_zeneszerzo.Location = new Point(8, 68);
            lbox_zeneszerzo.Name = "lbox_zeneszerzo";
            lbox_zeneszerzo.Size = new Size(183, 529);
            lbox_zeneszerzo.TabIndex = 3;
            lbox_zeneszerzo.SelectedIndexChanged += lbox_zeneszerzo_SelectedIndexChanged;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            Controls.Add(txt_zenezszerzo);
            Controls.Add(lbox_zeneszerzo);
            Controls.Add(txt_opera);
            Controls.Add(lbox_opera);
            Name = "UserControl1";
            Size = new Size(910, 600);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbox_opera;
        private TextBox txt_opera;
        private TextBox txt_zenezszerzo;
        private ListBox lbox_zeneszerzo;
    }
}
