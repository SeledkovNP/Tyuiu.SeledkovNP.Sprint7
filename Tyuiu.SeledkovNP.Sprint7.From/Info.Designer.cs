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
            openFileDialog1 = new OpenFileDialog();
            Inforac = new TextBox();
            Let = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 276);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            toolTip1.SetToolTip(pictureBox1, "Иконка ползователя");
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Inforac
            // 
            Inforac.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Inforac.Location = new Point(381, 36);
            Inforac.Multiline = true;
            Inforac.Name = "Inforac";
            Inforac.ReadOnly = true;
            Inforac.Size = new Size(390, 359);
            Inforac.TabIndex = 1;
            Inforac.Text = resources.GetString("Inforac.Text");
            // 
            // Let
            // 
            Let.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Let.BackColor = Color.Orange;
            Let.Location = new Point(662, 401);
            Let.Name = "Let";
            Let.Size = new Size(109, 37);
            Let.TabIndex = 2;
            Let.Text = "Закрыт";
            Let.UseVisualStyleBackColor = false;
            Let.Click += Let_Click;
            // 
            // Info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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