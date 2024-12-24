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
            button_save_SN = new Button();
            Info = new Button();
            Open = new Button();
            openFileDialog_SNP = new OpenFileDialog();
            toolTip_SNP = new ToolTip(components);
            Sort = new Button();
            Poisk = new Button();
            textBox_SNP = new TextBox();
            panelList = new Panel();
            dataGridViewMainGrid = new DataGridView();
            textPois = new TextBox();
            saveFileDialog_SNP2 = new SaveFileDialog();
            panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMainGrid).BeginInit();
            SuspendLayout();
            // 
            // button_save_SN
            // 
            resources.ApplyResources(button_save_SN, "button_save_SN");
            button_save_SN.BackColor = Color.PaleGreen;
            button_save_SN.Name = "button_save_SN";
            toolTip_SNP.SetToolTip(button_save_SN, resources.GetString("button_save_SN.ToolTip"));
            button_save_SN.UseVisualStyleBackColor = false;
            button_save_SN.UseWaitCursor = true;
            button_save_SN.Click += Button_save_Click;
            // 
            // Info
            // 
            resources.ApplyResources(Info, "Info");
            Info.Name = "Info";
            toolTip_SNP.SetToolTip(Info, resources.GetString("Info.ToolTip"));
            Info.UseVisualStyleBackColor = true;
            Info.UseWaitCursor = true;
            Info.Click += Info_Click;
            // 
            // Open
            // 
            resources.ApplyResources(Open, "Open");
            Open.Name = "Open";
            toolTip_SNP.SetToolTip(Open, resources.GetString("Open.ToolTip"));
            Open.UseVisualStyleBackColor = true;
            Open.UseWaitCursor = true;
            Open.Click += Open_Click_1;
            // 
            // openFileDialog_SNP
            // 
            openFileDialog_SNP.FileName = "openFileDialog1";
            // 
            // toolTip_SNP
            // 
            toolTip_SNP.Popup += toolTip1_Popup;
            // 
            // Sort
            // 
            resources.ApplyResources(Sort, "Sort");
            Sort.Name = "Sort";
            Sort.UseVisualStyleBackColor = true;
            Sort.UseWaitCursor = true;
            // 
            // Poisk
            // 
            resources.ApplyResources(Poisk, "Poisk");
            Poisk.Name = "Poisk";
            Poisk.UseVisualStyleBackColor = true;
            Poisk.UseWaitCursor = true;
            Poisk.Click += Poisk_Click;
            // 
            // textBox_SNP
            // 
            resources.ApplyResources(textBox_SNP, "textBox_SNP");
            textBox_SNP.Name = "textBox_SNP";
            textBox_SNP.ReadOnly = true;
            textBox_SNP.UseWaitCursor = true;
            textBox_SNP.TextChanged += textBox_SNP_TextChanged;
            // 
            // panelList
            // 
            panelList.Controls.Add(dataGridViewMainGrid);
            panelList.Controls.Add(textPois);
            panelList.Controls.Add(Poisk);
            resources.ApplyResources(panelList, "panelList");
            panelList.Name = "panelList";
            panelList.UseWaitCursor = true;
            // 
            // dataGridViewMainGrid
            // 
            dataGridViewMainGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGridViewMainGrid, "dataGridViewMainGrid");
            dataGridViewMainGrid.Name = "dataGridViewMainGrid";
            dataGridViewMainGrid.UseWaitCursor = true;
            dataGridViewMainGrid.CellContentClick += dataGridViewMainGrid_CellContentClick;
            // 
            // textPois
            // 
            resources.ApplyResources(textPois, "textPois");
            textPois.Name = "textPois";
            textPois.UseWaitCursor = true;
            textPois.TextChanged += textPois_TextChanged;
            // 
            // saveFileDialog_SNP2
            // 
            saveFileDialog_SNP2.FileOk += saveFileDialog1_FileOk;
            // 
            // Glavn
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(panelList);
            Controls.Add(button_save_SN);
            Controls.Add(Sort);
            Controls.Add(textBox_SNP);
            Controls.Add(Open);
            Controls.Add(Info);
            ForeColor = SystemColors.ControlText;
            Name = "Glavn";
            TransparencyKey = Color.FromArgb(255, 128, 0);
            UseWaitCursor = true;
            Load += Glavn_Load;
            panelList.ResumeLayout(false);
            panelList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMainGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_save_SN;
        private Button Info;
        private Button Open;
        private OpenFileDialog openFileDialog_SNP;
        private ToolTip toolTip_SNP;
        private Button Sort;
        private Button Poisk;
        private TextBox textBox_SNP;
        private Panel panelList;
        private TextBox textPois;
        private DataGridView dataGridViewMainGrid;
        private SaveFileDialog saveFileDialog_SNP2;
    }
}
