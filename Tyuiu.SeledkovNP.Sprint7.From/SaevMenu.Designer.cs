namespace Tyuiu.SeledkovNP.Sprint7.From
{
    partial class Saev_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saev_menu));
            openFileDialog_SNP2 = new OpenFileDialog();
            toolTip_SNP2 = new ToolTip(components);
            Closed = new Button();
            Save = new Button();
            saveFileDialog_SNP = new SaveFileDialog();
            SuspendLayout();
            // 
            // openFileDialog_SNP2
            // 
            openFileDialog_SNP2.FileName = "openFileDialog1";
            // 
            // Closed
            // 
            Closed.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Closed.BackColor = Color.Orange;
            Closed.Location = new Point(52, 88);
            Closed.Name = "Closed";
            Closed.Size = new Size(89, 36);
            Closed.TabIndex = 0;
            Closed.Text = "Закрыт";
            toolTip_SNP2.SetToolTip(Closed, "Перейти в прошлое окно");
            Closed.UseVisualStyleBackColor = false;
            Closed.Click += Closed_Click;
            // 
            // Save
            // 
            Save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Save.BackColor = Color.LawnGreen;
            Save.Location = new Point(181, 88);
            Save.Name = "Save";
            Save.Size = new Size(89, 37);
            Save.TabIndex = 1;
            Save.Text = "Сохранить";
            toolTip_SNP2.SetToolTip(Save, "Безвозратно сохранить файл");
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // Saev_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(311, 177);
            Controls.Add(Save);
            Controls.Add(Closed);
            Name = "Saev_menu";
            Text = "Seledkov Nikita";
            Load += Saev_menu_Load;
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog_SNP2;
        private ToolTip toolTip_SNP2;
        private Button Closed;
        private Button Save;
        private SaveFileDialog saveFileDialog_SNP;
    }
}