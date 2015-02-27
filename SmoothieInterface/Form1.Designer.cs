namespace SmoothieInterface
{
    partial class Form1
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
            this.lsb_History = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_ComPorts = new System.Windows.Forms.ComboBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mi_File = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_FileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_EditSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_XPos = new System.Windows.Forms.TextBox();
            this.txb_YPos = new System.Windows.Forms.TextBox();
            this.txb_ZPos = new System.Windows.Forms.TextBox();
            this.txb_SpindleSpeed = new System.Windows.Forms.TextBox();
            this.txb_ExtruderSpeed = new System.Windows.Forms.TextBox();
            this.txb_ExtruderTemp = new System.Windows.Forms.TextBox();
            this.txb_FeedRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_ExtruderTemp = new System.Windows.Forms.Label();
            this.cbx_HeatExtruder = new System.Windows.Forms.CheckBox();
            this.cbx_Fan = new System.Windows.Forms.CheckBox();
            this.lbl_Progress = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbx_MinX = new System.Windows.Forms.CheckBox();
            this.cbx_MaxX = new System.Windows.Forms.CheckBox();
            this.cbx_MaxY = new System.Windows.Forms.CheckBox();
            this.cbx_MinY = new System.Windows.Forms.CheckBox();
            this.cbx_MaxZ = new System.Windows.Forms.CheckBox();
            this.cbx_MinZ = new System.Windows.Forms.CheckBox();
            this.btn_MinusY = new System.Windows.Forms.Button();
            this.btn_PlusX = new System.Windows.Forms.Button();
            this.btn_MinusX = new System.Windows.Forms.Button();
            this.btn_PlusY = new System.Windows.Forms.Button();
            this.btn_PlusZ = new System.Windows.Forms.Button();
            this.btn_MinusZ = new System.Windows.Forms.Button();
            this.cbx_Probe = new System.Windows.Forms.CheckBox();
            this.btn_HomeX = new System.Windows.Forms.Button();
            this.btn_HomeY = new System.Windows.Forms.Button();
            this.btn_HomeZ = new System.Windows.Forms.Button();
            this.btn_Go = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txb_SendCmd = new System.Windows.Forms.TextBox();
            this.btn_SendCmd = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsb_History
            // 
            this.lsb_History.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsb_History.FormattingEnabled = true;
            this.lsb_History.Location = new System.Drawing.Point(12, 335);
            this.lsb_History.Name = "lsb_History";
            this.lsb_History.Size = new System.Drawing.Size(526, 95);
            this.lsb_History.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "History:";
            // 
            // cmb_ComPorts
            // 
            this.cmb_ComPorts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_ComPorts.FormattingEnabled = true;
            this.cmb_ComPorts.Location = new System.Drawing.Point(336, 29);
            this.cmb_ComPorts.Name = "cmb_ComPorts";
            this.cmb_ComPorts.Size = new System.Drawing.Size(121, 21);
            this.cmb_ComPorts.TabIndex = 2;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Connect.Location = new System.Drawing.Point(463, 27);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 3;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Com Port:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_File,
            this.mi_Edit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(550, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mi_File
            // 
            this.mi_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_FileOpen});
            this.mi_File.Name = "mi_File";
            this.mi_File.Size = new System.Drawing.Size(37, 20);
            this.mi_File.Text = "File";
            // 
            // mi_FileOpen
            // 
            this.mi_FileOpen.Name = "mi_FileOpen";
            this.mi_FileOpen.Size = new System.Drawing.Size(103, 22);
            this.mi_FileOpen.Text = "Open";
            // 
            // mi_Edit
            // 
            this.mi_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_EditSettings});
            this.mi_Edit.Name = "mi_Edit";
            this.mi_Edit.Size = new System.Drawing.Size(39, 20);
            this.mi_Edit.Text = "Edit";
            // 
            // mi_EditSettings
            // 
            this.mi_EditSettings.Name = "mi_EditSettings";
            this.mi_EditSettings.Size = new System.Drawing.Size(116, 22);
            this.mi_EditSettings.Text = "Settings";
            this.mi_EditSettings.Click += new System.EventHandler(this.mi_EditSettings_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "X Position:";
            // 
            // txb_XPos
            // 
            this.txb_XPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_XPos.Location = new System.Drawing.Point(280, 85);
            this.txb_XPos.Name = "txb_XPos";
            this.txb_XPos.Size = new System.Drawing.Size(100, 20);
            this.txb_XPos.TabIndex = 7;
            // 
            // txb_YPos
            // 
            this.txb_YPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_YPos.Location = new System.Drawing.Point(280, 112);
            this.txb_YPos.Name = "txb_YPos";
            this.txb_YPos.Size = new System.Drawing.Size(100, 20);
            this.txb_YPos.TabIndex = 8;
            // 
            // txb_ZPos
            // 
            this.txb_ZPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_ZPos.Location = new System.Drawing.Point(280, 139);
            this.txb_ZPos.Name = "txb_ZPos";
            this.txb_ZPos.Size = new System.Drawing.Size(100, 20);
            this.txb_ZPos.TabIndex = 9;
            // 
            // txb_SpindleSpeed
            // 
            this.txb_SpindleSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_SpindleSpeed.Location = new System.Drawing.Point(280, 201);
            this.txb_SpindleSpeed.Name = "txb_SpindleSpeed";
            this.txb_SpindleSpeed.Size = new System.Drawing.Size(100, 20);
            this.txb_SpindleSpeed.TabIndex = 10;
            // 
            // txb_ExtruderSpeed
            // 
            this.txb_ExtruderSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_ExtruderSpeed.Location = new System.Drawing.Point(280, 236);
            this.txb_ExtruderSpeed.Name = "txb_ExtruderSpeed";
            this.txb_ExtruderSpeed.Size = new System.Drawing.Size(100, 20);
            this.txb_ExtruderSpeed.TabIndex = 11;
            // 
            // txb_ExtruderTemp
            // 
            this.txb_ExtruderTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_ExtruderTemp.Location = new System.Drawing.Point(280, 262);
            this.txb_ExtruderTemp.Name = "txb_ExtruderTemp";
            this.txb_ExtruderTemp.Size = new System.Drawing.Size(100, 20);
            this.txb_ExtruderTemp.TabIndex = 12;
            // 
            // txb_FeedRate
            // 
            this.txb_FeedRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_FeedRate.Location = new System.Drawing.Point(280, 165);
            this.txb_FeedRate.Name = "txb_FeedRate";
            this.txb_FeedRate.Size = new System.Drawing.Size(100, 20);
            this.txb_FeedRate.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Y Position:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Z Position:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Feed Rate:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Spindle Speed:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Extruder Speed:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(195, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Extruder Temp:";
            // 
            // lbl_ExtruderTemp
            // 
            this.lbl_ExtruderTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ExtruderTemp.AutoSize = true;
            this.lbl_ExtruderTemp.Location = new System.Drawing.Point(395, 265);
            this.lbl_ExtruderTemp.Name = "lbl_ExtruderTemp";
            this.lbl_ExtruderTemp.Size = new System.Drawing.Size(74, 13);
            this.lbl_ExtruderTemp.TabIndex = 20;
            this.lbl_ExtruderTemp.Text = "Current Temp:";
            // 
            // cbx_HeatExtruder
            // 
            this.cbx_HeatExtruder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_HeatExtruder.AutoSize = true;
            this.cbx_HeatExtruder.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbx_HeatExtruder.Location = new System.Drawing.Point(395, 239);
            this.cbx_HeatExtruder.Name = "cbx_HeatExtruder";
            this.cbx_HeatExtruder.Size = new System.Drawing.Size(94, 17);
            this.cbx_HeatExtruder.TabIndex = 21;
            this.cbx_HeatExtruder.Text = "Heat Extruder:";
            this.cbx_HeatExtruder.UseVisualStyleBackColor = true;
            // 
            // cbx_Fan
            // 
            this.cbx_Fan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_Fan.AutoSize = true;
            this.cbx_Fan.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbx_Fan.Location = new System.Drawing.Point(395, 288);
            this.cbx_Fan.Name = "cbx_Fan";
            this.cbx_Fan.Size = new System.Drawing.Size(47, 17);
            this.cbx_Fan.TabIndex = 22;
            this.cbx_Fan.Text = "Fan:";
            this.cbx_Fan.UseVisualStyleBackColor = true;
            // 
            // lbl_Progress
            // 
            this.lbl_Progress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Progress.AutoSize = true;
            this.lbl_Progress.Location = new System.Drawing.Point(12, 289);
            this.lbl_Progress.Name = "lbl_Progress";
            this.lbl_Progress.Size = new System.Drawing.Size(51, 13);
            this.lbl_Progress.TabIndex = 23;
            this.lbl_Progress.Text = "Progress:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(464, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Limits";
            // 
            // cbx_MinX
            // 
            this.cbx_MinX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_MinX.AutoSize = true;
            this.cbx_MinX.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbx_MinX.Enabled = false;
            this.cbx_MinX.Location = new System.Drawing.Point(434, 84);
            this.cbx_MinX.Name = "cbx_MinX";
            this.cbx_MinX.Size = new System.Drawing.Size(46, 17);
            this.cbx_MinX.TabIndex = 25;
            this.cbx_MinX.Text = "Min:";
            this.cbx_MinX.UseVisualStyleBackColor = true;
            // 
            // cbx_MaxX
            // 
            this.cbx_MaxX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_MaxX.AutoSize = true;
            this.cbx_MaxX.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbx_MaxX.Enabled = false;
            this.cbx_MaxX.Location = new System.Drawing.Point(486, 84);
            this.cbx_MaxX.Name = "cbx_MaxX";
            this.cbx_MaxX.Size = new System.Drawing.Size(49, 17);
            this.cbx_MaxX.TabIndex = 26;
            this.cbx_MaxX.Text = "Max:";
            this.cbx_MaxX.UseVisualStyleBackColor = true;
            // 
            // cbx_MaxY
            // 
            this.cbx_MaxY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_MaxY.AutoSize = true;
            this.cbx_MaxY.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbx_MaxY.Enabled = false;
            this.cbx_MaxY.Location = new System.Drawing.Point(486, 112);
            this.cbx_MaxY.Name = "cbx_MaxY";
            this.cbx_MaxY.Size = new System.Drawing.Size(49, 17);
            this.cbx_MaxY.TabIndex = 28;
            this.cbx_MaxY.Text = "Max:";
            this.cbx_MaxY.UseVisualStyleBackColor = true;
            // 
            // cbx_MinY
            // 
            this.cbx_MinY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_MinY.AutoSize = true;
            this.cbx_MinY.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbx_MinY.Enabled = false;
            this.cbx_MinY.Location = new System.Drawing.Point(434, 112);
            this.cbx_MinY.Name = "cbx_MinY";
            this.cbx_MinY.Size = new System.Drawing.Size(46, 17);
            this.cbx_MinY.TabIndex = 27;
            this.cbx_MinY.Text = "Min:";
            this.cbx_MinY.UseVisualStyleBackColor = true;
            // 
            // cbx_MaxZ
            // 
            this.cbx_MaxZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_MaxZ.AutoSize = true;
            this.cbx_MaxZ.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbx_MaxZ.Enabled = false;
            this.cbx_MaxZ.Location = new System.Drawing.Point(486, 141);
            this.cbx_MaxZ.Name = "cbx_MaxZ";
            this.cbx_MaxZ.Size = new System.Drawing.Size(49, 17);
            this.cbx_MaxZ.TabIndex = 30;
            this.cbx_MaxZ.Text = "Max:";
            this.cbx_MaxZ.UseVisualStyleBackColor = true;
            // 
            // cbx_MinZ
            // 
            this.cbx_MinZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_MinZ.AutoSize = true;
            this.cbx_MinZ.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbx_MinZ.Enabled = false;
            this.cbx_MinZ.Location = new System.Drawing.Point(434, 141);
            this.cbx_MinZ.Name = "cbx_MinZ";
            this.cbx_MinZ.Size = new System.Drawing.Size(46, 17);
            this.cbx_MinZ.TabIndex = 29;
            this.cbx_MinZ.Text = "Min:";
            this.cbx_MinZ.UseVisualStyleBackColor = true;
            // 
            // btn_MinusY
            // 
            this.btn_MinusY.Location = new System.Drawing.Point(60, 78);
            this.btn_MinusY.Name = "btn_MinusY";
            this.btn_MinusY.Size = new System.Drawing.Size(29, 23);
            this.btn_MinusY.TabIndex = 31;
            this.btn_MinusY.Text = "-Y";
            this.btn_MinusY.UseVisualStyleBackColor = true;
            // 
            // btn_PlusX
            // 
            this.btn_PlusX.Location = new System.Drawing.Point(12, 110);
            this.btn_PlusX.Name = "btn_PlusX";
            this.btn_PlusX.Size = new System.Drawing.Size(29, 23);
            this.btn_PlusX.TabIndex = 32;
            this.btn_PlusX.Text = "+X";
            this.btn_PlusX.UseVisualStyleBackColor = true;
            // 
            // btn_MinusX
            // 
            this.btn_MinusX.Location = new System.Drawing.Point(108, 109);
            this.btn_MinusX.Name = "btn_MinusX";
            this.btn_MinusX.Size = new System.Drawing.Size(29, 23);
            this.btn_MinusX.TabIndex = 33;
            this.btn_MinusX.Text = "-X";
            this.btn_MinusX.UseVisualStyleBackColor = true;
            // 
            // btn_PlusY
            // 
            this.btn_PlusY.Location = new System.Drawing.Point(60, 142);
            this.btn_PlusY.Name = "btn_PlusY";
            this.btn_PlusY.Size = new System.Drawing.Size(29, 23);
            this.btn_PlusY.TabIndex = 34;
            this.btn_PlusY.Text = "+Y";
            this.btn_PlusY.UseVisualStyleBackColor = true;
            // 
            // btn_PlusZ
            // 
            this.btn_PlusZ.Location = new System.Drawing.Point(12, 54);
            this.btn_PlusZ.Name = "btn_PlusZ";
            this.btn_PlusZ.Size = new System.Drawing.Size(29, 23);
            this.btn_PlusZ.TabIndex = 35;
            this.btn_PlusZ.Text = "+Z";
            this.btn_PlusZ.UseVisualStyleBackColor = true;
            // 
            // btn_MinusZ
            // 
            this.btn_MinusZ.Location = new System.Drawing.Point(108, 54);
            this.btn_MinusZ.Name = "btn_MinusZ";
            this.btn_MinusZ.Size = new System.Drawing.Size(29, 23);
            this.btn_MinusZ.TabIndex = 36;
            this.btn_MinusZ.Text = "-Z";
            this.btn_MinusZ.UseVisualStyleBackColor = true;
            // 
            // cbx_Probe
            // 
            this.cbx_Probe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_Probe.AutoSize = true;
            this.cbx_Probe.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbx_Probe.Enabled = false;
            this.cbx_Probe.Location = new System.Drawing.Point(323, 288);
            this.cbx_Probe.Name = "cbx_Probe";
            this.cbx_Probe.Size = new System.Drawing.Size(57, 17);
            this.cbx_Probe.TabIndex = 37;
            this.cbx_Probe.Text = "Probe:";
            this.cbx_Probe.UseVisualStyleBackColor = true;
            // 
            // btn_HomeX
            // 
            this.btn_HomeX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_HomeX.Location = new System.Drawing.Point(386, 83);
            this.btn_HomeX.Name = "btn_HomeX";
            this.btn_HomeX.Size = new System.Drawing.Size(23, 23);
            this.btn_HomeX.TabIndex = 38;
            this.btn_HomeX.Text = "H";
            this.btn_HomeX.UseVisualStyleBackColor = true;
            // 
            // btn_HomeY
            // 
            this.btn_HomeY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_HomeY.Location = new System.Drawing.Point(386, 110);
            this.btn_HomeY.Name = "btn_HomeY";
            this.btn_HomeY.Size = new System.Drawing.Size(23, 23);
            this.btn_HomeY.TabIndex = 39;
            this.btn_HomeY.Text = "H";
            this.btn_HomeY.UseVisualStyleBackColor = true;
            // 
            // btn_HomeZ
            // 
            this.btn_HomeZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_HomeZ.Location = new System.Drawing.Point(386, 137);
            this.btn_HomeZ.Name = "btn_HomeZ";
            this.btn_HomeZ.Size = new System.Drawing.Size(23, 23);
            this.btn_HomeZ.TabIndex = 40;
            this.btn_HomeZ.Text = "H";
            this.btn_HomeZ.UseVisualStyleBackColor = true;
            // 
            // btn_Go
            // 
            this.btn_Go.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Go.Location = new System.Drawing.Point(140, 168);
            this.btn_Go.Name = "btn_Go";
            this.btn_Go.Size = new System.Drawing.Size(37, 23);
            this.btn_Go.TabIndex = 41;
            this.btn_Go.Text = "Go";
            this.btn_Go.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(217, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Command:";
            // 
            // txb_SendCmd
            // 
            this.txb_SendCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_SendCmd.Location = new System.Drawing.Point(280, 309);
            this.txb_SendCmd.Name = "txb_SendCmd";
            this.txb_SendCmd.Size = new System.Drawing.Size(205, 20);
            this.txb_SendCmd.TabIndex = 43;
            // 
            // btn_SendCmd
            // 
            this.btn_SendCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SendCmd.Location = new System.Drawing.Point(491, 307);
            this.btn_SendCmd.Name = "btn_SendCmd";
            this.btn_SendCmd.Size = new System.Drawing.Size(47, 23);
            this.btn_SendCmd.TabIndex = 44;
            this.btn_SendCmd.Text = "Send";
            this.btn_SendCmd.UseVisualStyleBackColor = true;
            this.btn_SendCmd.Click += new System.EventHandler(this.btn_SendCmd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 442);
            this.Controls.Add(this.btn_SendCmd);
            this.Controls.Add(this.txb_SendCmd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_Go);
            this.Controls.Add(this.btn_HomeZ);
            this.Controls.Add(this.btn_HomeY);
            this.Controls.Add(this.btn_HomeX);
            this.Controls.Add(this.cbx_Probe);
            this.Controls.Add(this.btn_MinusZ);
            this.Controls.Add(this.btn_PlusZ);
            this.Controls.Add(this.btn_PlusY);
            this.Controls.Add(this.btn_MinusX);
            this.Controls.Add(this.btn_PlusX);
            this.Controls.Add(this.btn_MinusY);
            this.Controls.Add(this.cbx_MaxZ);
            this.Controls.Add(this.cbx_MinZ);
            this.Controls.Add(this.cbx_MaxY);
            this.Controls.Add(this.cbx_MinY);
            this.Controls.Add(this.cbx_MaxX);
            this.Controls.Add(this.cbx_MinX);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_Progress);
            this.Controls.Add(this.cbx_Fan);
            this.Controls.Add(this.cbx_HeatExtruder);
            this.Controls.Add(this.lbl_ExtruderTemp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_FeedRate);
            this.Controls.Add(this.txb_ExtruderTemp);
            this.Controls.Add(this.txb_ExtruderSpeed);
            this.Controls.Add(this.txb_SpindleSpeed);
            this.Controls.Add(this.txb_ZPos);
            this.Controls.Add(this.txb_YPos);
            this.Controls.Add(this.txb_XPos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.cmb_ComPorts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsb_History);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SmoothieBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsb_History;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_ComPorts;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mi_File;
        private System.Windows.Forms.ToolStripMenuItem mi_FileOpen;
        private System.Windows.Forms.ToolStripMenuItem mi_Edit;
        private System.Windows.Forms.ToolStripMenuItem mi_EditSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_XPos;
        private System.Windows.Forms.TextBox txb_YPos;
        private System.Windows.Forms.TextBox txb_ZPos;
        private System.Windows.Forms.TextBox txb_SpindleSpeed;
        private System.Windows.Forms.TextBox txb_ExtruderSpeed;
        private System.Windows.Forms.TextBox txb_ExtruderTemp;
        private System.Windows.Forms.TextBox txb_FeedRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_ExtruderTemp;
        private System.Windows.Forms.CheckBox cbx_HeatExtruder;
        private System.Windows.Forms.CheckBox cbx_Fan;
        private System.Windows.Forms.Label lbl_Progress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cbx_MinX;
        private System.Windows.Forms.CheckBox cbx_MaxX;
        private System.Windows.Forms.CheckBox cbx_MaxY;
        private System.Windows.Forms.CheckBox cbx_MinY;
        private System.Windows.Forms.CheckBox cbx_MaxZ;
        private System.Windows.Forms.CheckBox cbx_MinZ;
        private System.Windows.Forms.Button btn_MinusY;
        private System.Windows.Forms.Button btn_PlusX;
        private System.Windows.Forms.Button btn_MinusX;
        private System.Windows.Forms.Button btn_PlusY;
        private System.Windows.Forms.Button btn_PlusZ;
        private System.Windows.Forms.Button btn_MinusZ;
        private System.Windows.Forms.CheckBox cbx_Probe;
        private System.Windows.Forms.Button btn_HomeX;
        private System.Windows.Forms.Button btn_HomeY;
        private System.Windows.Forms.Button btn_HomeZ;
        private System.Windows.Forms.Button btn_Go;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txb_SendCmd;
        private System.Windows.Forms.Button btn_SendCmd;
    }
}

