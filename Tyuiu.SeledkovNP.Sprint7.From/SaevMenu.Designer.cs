﻿namespace Tyuiu.SeledkovNP.Sprint7.From
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
            openFileDialog1 = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            Closed = new Button();
            Save = new Button();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Closed
            // 
            Closed.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Closed.BackColor = Color.Orange;
            Closed.Location = new Point(12, 50);
            Closed.Name = "Closed";
            Closed.Size = new Size(123, 60);
            Closed.TabIndex = 0;
            Closed.Text = "Закрыт";
            toolTip1.SetToolTip(Closed, "Перейти в прошлое окно");
            Closed.UseVisualStyleBackColor = false;
            Closed.Click += Closed_Click;
            // 
            // Save
            // 
            Save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Save.BackColor = Color.LawnGreen;
            Save.Location = new Point(224, 49);
            Save.Name = "Save";
            Save.Size = new Size(133, 61);
            Save.TabIndex = 1;
            Save.Text = "Сохранить";
            toolTip1.SetToolTip(Save, "Безвозратно сохранить файл");
            Save.UseVisualStyleBackColor = false;
            // 
            // Saev_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 150);
            Controls.Add(Save);
            Controls.Add(Closed);
            Name = "Saev_menu";
            Text = "Seledkov Nikita";
            Load += Saev_menu_Load;
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private ToolTip toolTip1;
        private Button Closed;
        private Button Save;
    }
}