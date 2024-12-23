using Tyuiu.SeledkovNP.Sprint7.Lib;
namespace Tyuiu.SeledkovNP.Sprint7.From
{
    partial class Glavn
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glavn));
            textBox_SNP = new TextBox();
            button_save_SN = new Button();
            Info = new Button();
            Open = new Button();
            openFileDialog1 = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox_SNP
            // 
            resources.ApplyResources(textBox_SNP, "textBox_SNP");
            textBox_SNP.Name = "textBox_SNP";
            textBox_SNP.UseWaitCursor = true;
            textBox_SNP.TextChanged += textBox_SNP_TextChanged;
            // 
            // button_save_SN
            // 
            resources.ApplyResources(button_save_SN, "button_save_SN");
            button_save_SN.BackColor = Color.PaleGreen;
            button_save_SN.Name = "button_save_SN";
            toolTip1.SetToolTip(button_save_SN, resources.GetString("button_save_SN.ToolTip"));
            button_save_SN.UseVisualStyleBackColor = false;
            button_save_SN.UseWaitCursor = true;
            button_save_SN.Click += button1_Click;
            // 
            // Info
            // 
            resources.ApplyResources(Info, "Info");
            Info.Name = "Info";
            toolTip1.SetToolTip(Info, resources.GetString("Info.ToolTip"));
            Info.UseVisualStyleBackColor = true;
            Info.UseWaitCursor = true;
            Info.Click += Info_Click;
            // 
            // Open
            // 
            resources.ApplyResources(Open, "Open");
            Open.Name = "Open";
            toolTip1.SetToolTip(Open, resources.GetString("Open.ToolTip"));
            Open.UseVisualStyleBackColor = true;
            Open.UseWaitCursor = true;
            Open.Click += Open_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            // 
            // Glavn
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Open);
            Controls.Add(Info);
            Controls.Add(button_save_SN);
            Controls.Add(textBox_SNP);
            ForeColor = SystemColors.ControlText;
            Name = "Glavn";
            TransparencyKey = Color.FromArgb(255, 128, 0);
            UseWaitCursor = true;
            Load += Glavn_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private TextBox textBox_SNP;
        private Button button_save_SN;
        private Button Info;
        private Button Open;
        private OpenFileDialog openFileDialog1;
        private ToolTip toolTip1;
        private Button button1;
        private Button button2;
    }
}
