namespace Texture_JSON_Factory
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Block = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_BlockName = new System.Windows.Forms.TextBox();
            this.btn_South = new System.Windows.Forms.Button();
            this.btn_East = new System.Windows.Forms.Button();
            this.btn_West = new System.Windows.Forms.Button();
            this.btn_Bottom = new System.Windows.Forms.Button();
            this.btn_North = new System.Windows.Forms.Button();
            this.btn_Top = new System.Windows.Forms.Button();
            this.tab_Item = new System.Windows.Forms.TabPage();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tb_ModName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Path = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_Item = new System.Windows.Forms.Button();
            this.lb_itemName = new System.Windows.Forms.Label();
            this.tb_ItemName = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tab_Block.SuspendLayout();
            this.tab_Item.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Block);
            this.tabControl1.Controls.Add(this.tab_Item);
            this.tabControl1.Location = new System.Drawing.Point(12, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(621, 308);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 6;
            // 
            // tab_Block
            // 
            this.tab_Block.Controls.Add(this.label1);
            this.tab_Block.Controls.Add(this.tb_BlockName);
            this.tab_Block.Controls.Add(this.btn_South);
            this.tab_Block.Controls.Add(this.btn_East);
            this.tab_Block.Controls.Add(this.btn_West);
            this.tab_Block.Controls.Add(this.btn_Bottom);
            this.tab_Block.Controls.Add(this.btn_North);
            this.tab_Block.Controls.Add(this.btn_Top);
            this.tab_Block.Location = new System.Drawing.Point(4, 22);
            this.tab_Block.Name = "tab_Block";
            this.tab_Block.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Block.Size = new System.Drawing.Size(613, 282);
            this.tab_Block.TabIndex = 0;
            this.tab_Block.Text = "Block";
            this.tab_Block.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Block Name";
            // 
            // tb_BlockName
            // 
            this.tb_BlockName.Location = new System.Drawing.Point(418, 129);
            this.tb_BlockName.Name = "tb_BlockName";
            this.tb_BlockName.Size = new System.Drawing.Size(168, 20);
            this.tb_BlockName.TabIndex = 12;
            // 
            // btn_South
            // 
            this.btn_South.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_South.Location = new System.Drawing.Point(298, 98);
            this.btn_South.Name = "btn_South";
            this.btn_South.Size = new System.Drawing.Size(88, 80);
            this.btn_South.TabIndex = 11;
            this.btn_South.Text = "South";
            this.btn_South.UseVisualStyleBackColor = true;
            this.btn_South.Click += new System.EventHandler(this.Btn_South_Click);
            // 
            // btn_East
            // 
            this.btn_East.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_East.Location = new System.Drawing.Point(204, 98);
            this.btn_East.Name = "btn_East";
            this.btn_East.Size = new System.Drawing.Size(88, 80);
            this.btn_East.TabIndex = 10;
            this.btn_East.Text = "East";
            this.btn_East.UseVisualStyleBackColor = true;
            this.btn_East.Click += new System.EventHandler(this.Btn_East_Click);
            // 
            // btn_West
            // 
            this.btn_West.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_West.Location = new System.Drawing.Point(16, 98);
            this.btn_West.Name = "btn_West";
            this.btn_West.Size = new System.Drawing.Size(88, 80);
            this.btn_West.TabIndex = 9;
            this.btn_West.Text = "West";
            this.btn_West.UseVisualStyleBackColor = true;
            this.btn_West.Click += new System.EventHandler(this.Btn_West_Click);
            // 
            // btn_Bottom
            // 
            this.btn_Bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Bottom.Location = new System.Drawing.Point(110, 184);
            this.btn_Bottom.Name = "btn_Bottom";
            this.btn_Bottom.Size = new System.Drawing.Size(88, 80);
            this.btn_Bottom.TabIndex = 8;
            this.btn_Bottom.Text = "Bottom";
            this.btn_Bottom.UseVisualStyleBackColor = true;
            this.btn_Bottom.Click += new System.EventHandler(this.Btn_Bottom_Click);
            // 
            // btn_North
            // 
            this.btn_North.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_North.Location = new System.Drawing.Point(110, 98);
            this.btn_North.Name = "btn_North";
            this.btn_North.Size = new System.Drawing.Size(88, 80);
            this.btn_North.TabIndex = 7;
            this.btn_North.Text = "North";
            this.btn_North.UseVisualStyleBackColor = true;
            this.btn_North.Click += new System.EventHandler(this.Btn_North_Click);
            // 
            // btn_Top
            // 
            this.btn_Top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Top.Location = new System.Drawing.Point(110, 12);
            this.btn_Top.Name = "btn_Top";
            this.btn_Top.Size = new System.Drawing.Size(88, 80);
            this.btn_Top.TabIndex = 6;
            this.btn_Top.Text = "Top";
            this.btn_Top.UseVisualStyleBackColor = true;
            this.btn_Top.Click += new System.EventHandler(this.Btn_Top_Click_1);
            // 
            // tab_Item
            // 
            this.tab_Item.Controls.Add(this.lb_itemName);
            this.tab_Item.Controls.Add(this.tb_ItemName);
            this.tab_Item.Controls.Add(this.btn_Item);
            this.tab_Item.Location = new System.Drawing.Point(4, 22);
            this.tab_Item.Name = "tab_Item";
            this.tab_Item.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Item.Size = new System.Drawing.Size(613, 282);
            this.tab_Item.TabIndex = 1;
            this.tab_Item.Text = "Item";
            this.tab_Item.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "png";
            this.saveFileDialog1.Filter = "PNG File|*.png|All Files|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "PNG File|*.png|All Files|*.*";
            // 
            // tb_ModName
            // 
            this.tb_ModName.Location = new System.Drawing.Point(16, 337);
            this.tb_ModName.Name = "tb_ModName";
            this.tb_ModName.Size = new System.Drawing.Size(165, 20);
            this.tb_ModName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mod ID";
            // 
            // tb_Path
            // 
            this.tb_Path.Location = new System.Drawing.Point(220, 337);
            this.tb_Path.Name = "tb_Path";
            this.tb_Path.ReadOnly = true;
            this.tb_Path.Size = new System.Drawing.Size(167, 20);
            this.tb_Path.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Output Path";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 20);
            this.button1.TabIndex = 17;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(515, 336);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(114, 23);
            this.btn_export.TabIndex = 18;
            this.btn_export.Text = "Export!";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.Btn_export_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(640, 26);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(293, 282);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // btn_Item
            // 
            this.btn_Item.Location = new System.Drawing.Point(89, 43);
            this.btn_Item.Name = "btn_Item";
            this.btn_Item.Size = new System.Drawing.Size(176, 171);
            this.btn_Item.TabIndex = 0;
            this.btn_Item.Text = "Item Texture";
            this.btn_Item.UseVisualStyleBackColor = true;
            this.btn_Item.Click += new System.EventHandler(this.Btn_Item_Click);
            // 
            // lb_itemName
            // 
            this.lb_itemName.AutoSize = true;
            this.lb_itemName.Location = new System.Drawing.Point(337, 119);
            this.lb_itemName.Name = "lb_itemName";
            this.lb_itemName.Size = new System.Drawing.Size(58, 13);
            this.lb_itemName.TabIndex = 15;
            this.lb_itemName.Text = "Item Name";
            // 
            // tb_ItemName
            // 
            this.tb_ItemName.Location = new System.Drawing.Point(337, 141);
            this.tb_ItemName.Name = "tb_ItemName";
            this.tb_ItemName.Size = new System.Drawing.Size(168, 20);
            this.tb_ItemName.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 392);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Path);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ModName);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tab_Block.ResumeLayout(false);
            this.tab_Block.PerformLayout();
            this.tab_Item.ResumeLayout(false);
            this.tab_Item.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Block;
        private System.Windows.Forms.Button btn_South;
        private System.Windows.Forms.Button btn_East;
        private System.Windows.Forms.Button btn_West;
        private System.Windows.Forms.Button btn_Bottom;
        private System.Windows.Forms.Button btn_North;
        private System.Windows.Forms.Button btn_Top;
        private System.Windows.Forms.TabPage tab_Item;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tb_BlockName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ModName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Path;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_Item;
        private System.Windows.Forms.Label lb_itemName;
        private System.Windows.Forms.TextBox tb_ItemName;
    }
}

