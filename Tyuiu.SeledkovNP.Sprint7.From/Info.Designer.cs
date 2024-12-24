using Tyuiu.SeledkovNP.Sprint7.Lib;
namespace Tyuiu.SeledkovNP.Sprint7.From
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            toolTip1 = new ToolTip(components);
            pictureBox1 = new PictureBox();
            Let = new Button();
            openFileDialog1 = new OpenFileDialog();
            Inforac = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(47, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 249);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            toolTip1.SetToolTip(pictureBox1, "Иконка ползователя");
            // 
            // Let
            // 
            Let.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Let.BackColor = Color.Orange;
            Let.Location = new Point(662, 401);
            Let.Name = "Let";
            Let.Size = new Size(109, 37);
            Let.TabIndex = 2;
            Let.Text = "Закрыт";
            toolTip1.SetToolTip(Let, "Перейти на прошлую страницу");
            Let.UseVisualStyleBackColor = false;
            Let.Click += Let_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Inforac
            // 
            Inforac.Anchor = AnchorStyles.Top;
            Inforac.Location = new Point(381, 36);
            Inforac.Multiline = true;
            Inforac.Name = "Inforac";
            Inforac.ReadOnly = true;
            Inforac.Size = new Size(390, 359);
            Inforac.TabIndex = 1;
            Inforac.TabStop = false;
            Inforac.Text = resources.GetString("Inforac.Text");
            Inforac.TextChanged += Inforac_TextChanged;
            // 
            // Info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(Let);
            Controls.Add(Inforac);
            Controls.Add(pictureBox1);
            Name = "Info";
            Text = "Seledkov Nikita";
            Load += Info_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip1;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private TextBox Inforac;
        private Button Let;
    }
}