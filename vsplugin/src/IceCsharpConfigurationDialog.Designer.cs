// **********************************************************************
//
// Copyright (c) 2009 ZeroC, Inc. All rights reserved.
//
// This copy of Ice is licensed to you under the terms described in the
// LICENSE file included in this distribution.
//
// **********************************************************************

namespace Ice.VisualStudio
{
    partial class IceCsharpConfigurationDialog
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
            this.chkEnableBuilder = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMoveIncludeDown = new System.Windows.Forms.Button();
            this.btnMoveIncludeUp = new System.Windows.Forms.Button();
            this.btnRemoveInclude = new System.Windows.Forms.Button();
            this.btnAddInclude = new System.Windows.Forms.Button();
            this.includeDirList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtMacros = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkIceStorm = new System.Windows.Forms.CheckBox();
            this.chkIceSSL = new System.Windows.Forms.CheckBox();
            this.chkIcePatch2 = new System.Windows.Forms.CheckBox();
            this.chkIceGrid = new System.Windows.Forms.CheckBox();
            this.chkIceBox = new System.Windows.Forms.CheckBox();
            this.chkGlacier2 = new System.Windows.Forms.CheckBox();
            this.chkIce = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkIcePrefix = new System.Windows.Forms.CheckBox();
            this.chkStreaming = new System.Windows.Forms.CheckBox();
            this.chkTie = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSelectIceHome = new System.Windows.Forms.Button();
            this.txtIceHome = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkEnableBuilder
            // 
            this.chkEnableBuilder.AutoSize = true;
            this.chkEnableBuilder.Location = new System.Drawing.Point(12, 13);
            this.chkEnableBuilder.Name = "chkEnableBuilder";
            this.chkEnableBuilder.Size = new System.Drawing.Size(112, 17);
            this.chkEnableBuilder.TabIndex = 0;
            this.chkEnableBuilder.Text = "Enable Ice Builder";
            this.chkEnableBuilder.UseVisualStyleBackColor = true;
            this.chkEnableBuilder.CheckedChanged += new System.EventHandler(this.chkEnableBuilder_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMoveIncludeDown);
            this.groupBox1.Controls.Add(this.btnMoveIncludeUp);
            this.groupBox1.Controls.Add(this.btnRemoveInclude);
            this.groupBox1.Controls.Add(this.btnAddInclude);
            this.groupBox1.Controls.Add(this.includeDirList);
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 169);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Slice Include Path";
            // 
            // btnMoveIncludeDown
            // 
            this.btnMoveIncludeDown.Location = new System.Drawing.Point(405, 106);
            this.btnMoveIncludeDown.Name = "btnMoveIncludeDown";
            this.btnMoveIncludeDown.Size = new System.Drawing.Size(75, 23);
            this.btnMoveIncludeDown.TabIndex = 11;
            this.btnMoveIncludeDown.Text = "Down";
            this.btnMoveIncludeDown.UseVisualStyleBackColor = true;
            this.btnMoveIncludeDown.Click += new System.EventHandler(this.btnMoveIncludeDown_Click);
            // 
            // btnMoveIncludeUp
            // 
            this.btnMoveIncludeUp.Location = new System.Drawing.Point(405, 76);
            this.btnMoveIncludeUp.Name = "btnMoveIncludeUp";
            this.btnMoveIncludeUp.Size = new System.Drawing.Size(75, 23);
            this.btnMoveIncludeUp.TabIndex = 10;
            this.btnMoveIncludeUp.Text = "Up";
            this.btnMoveIncludeUp.UseVisualStyleBackColor = true;
            this.btnMoveIncludeUp.Click += new System.EventHandler(this.btnMoveIncludeUp_Click);
            // 
            // btnRemoveInclude
            // 
            this.btnRemoveInclude.Location = new System.Drawing.Point(405, 47);
            this.btnRemoveInclude.Name = "btnRemoveInclude";
            this.btnRemoveInclude.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveInclude.TabIndex = 9;
            this.btnRemoveInclude.Text = "Remove";
            this.btnRemoveInclude.UseVisualStyleBackColor = true;
            this.btnRemoveInclude.Click += new System.EventHandler(this.btnRemoveInclude_Click);
            // 
            // btnAddInclude
            // 
            this.btnAddInclude.Location = new System.Drawing.Point(405, 19);
            this.btnAddInclude.Name = "btnAddInclude";
            this.btnAddInclude.Size = new System.Drawing.Size(75, 23);
            this.btnAddInclude.TabIndex = 8;
            this.btnAddInclude.Text = "Add";
            this.btnAddInclude.UseVisualStyleBackColor = true;
            this.btnAddInclude.Click += new System.EventHandler(this.btnAddInclude_Click);
            // 
            // includeDirList
            // 
            this.includeDirList.FormattingEnabled = true;
            this.includeDirList.Location = new System.Drawing.Point(6, 22);
            this.includeDirList.Name = "includeDirList";
            this.includeDirList.Size = new System.Drawing.Size(390, 134);
            this.includeDirList.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblInfo);
            this.groupBox2.Controls.Add(this.txtMacros);
            this.groupBox2.Location = new System.Drawing.Point(12, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 82);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preprocessor Macros";
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(7, 13);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(473, 17);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "Enter preprocessor macros (\';\' separated) for example enter FOO; BAR to define -D" +
                "FOO -DBAR";
            // 
            // txtMacros
            // 
            this.txtMacros.Location = new System.Drawing.Point(6, 33);
            this.txtMacros.Multiline = true;
            this.txtMacros.Name = "txtMacros";
            this.txtMacros.Size = new System.Drawing.Size(474, 40);
            this.txtMacros.TabIndex = 6;
            this.txtMacros.LostFocus += new System.EventHandler(this.txtMacros_LostFocus);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkIceStorm);
            this.groupBox3.Controls.Add(this.chkIceSSL);
            this.groupBox3.Controls.Add(this.chkIcePatch2);
            this.groupBox3.Controls.Add(this.chkIceGrid);
            this.groupBox3.Controls.Add(this.chkIceBox);
            this.groupBox3.Controls.Add(this.chkGlacier2);
            this.groupBox3.Controls.Add(this.chkIce);
            this.groupBox3.Location = new System.Drawing.Point(12, 401);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(487, 47);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ice Components";
            // 
            // chkIceStorm
            // 
            this.chkIceStorm.AutoSize = true;
            this.chkIceStorm.Location = new System.Drawing.Point(404, 19);
            this.chkIceStorm.Name = "chkIceStorm";
            this.chkIceStorm.Size = new System.Drawing.Size(68, 17);
            this.chkIceStorm.TabIndex = 6;
            this.chkIceStorm.TabStop = false;
            this.chkIceStorm.Text = "IceStorm";
            this.chkIceStorm.UseVisualStyleBackColor = true;
            this.chkIceStorm.CheckedChanged += new System.EventHandler(this.chkIceStorm_CheckedChanged);
            // 
            // chkIceSSL
            // 
            this.chkIceSSL.AutoSize = true;
            this.chkIceSSL.Location = new System.Drawing.Point(337, 19);
            this.chkIceSSL.Name = "chkIceSSL";
            this.chkIceSSL.Size = new System.Drawing.Size(61, 17);
            this.chkIceSSL.TabIndex = 5;
            this.chkIceSSL.TabStop = false;
            this.chkIceSSL.Text = "IceSSL";
            this.chkIceSSL.UseVisualStyleBackColor = true;
            this.chkIceSSL.CheckedChanged += new System.EventHandler(this.chkIceSSL_CheckedChanged);
            // 
            // chkIcePatch2
            // 
            this.chkIcePatch2.AutoSize = true;
            this.chkIcePatch2.Location = new System.Drawing.Point(256, 19);
            this.chkIcePatch2.Name = "chkIcePatch2";
            this.chkIcePatch2.Size = new System.Drawing.Size(75, 17);
            this.chkIcePatch2.TabIndex = 4;
            this.chkIcePatch2.TabStop = false;
            this.chkIcePatch2.Text = "IcePatch2";
            this.chkIcePatch2.UseVisualStyleBackColor = true;
            this.chkIcePatch2.CheckedChanged += new System.EventHandler(this.chkIcePatch2_CheckedChanged);
            // 
            // chkIceGrid
            // 
            this.chkIceGrid.AutoSize = true;
            this.chkIceGrid.Location = new System.Drawing.Point(190, 19);
            this.chkIceGrid.Name = "chkIceGrid";
            this.chkIceGrid.Size = new System.Drawing.Size(60, 17);
            this.chkIceGrid.TabIndex = 3;
            this.chkIceGrid.TabStop = false;
            this.chkIceGrid.Text = "IceGrid";
            this.chkIceGrid.UseVisualStyleBackColor = true;
            this.chkIceGrid.CheckedChanged += new System.EventHandler(this.chkIceGrid_CheckedChanged);
            // 
            // chkIceBox
            // 
            this.chkIceBox.AutoSize = true;
            this.chkIceBox.Location = new System.Drawing.Point(125, 19);
            this.chkIceBox.Name = "chkIceBox";
            this.chkIceBox.Size = new System.Drawing.Size(59, 17);
            this.chkIceBox.TabIndex = 2;
            this.chkIceBox.TabStop = false;
            this.chkIceBox.Text = "IceBox";
            this.chkIceBox.UseVisualStyleBackColor = true;
            this.chkIceBox.CheckedChanged += new System.EventHandler(this.chkIceBox_CheckedChanged);
            // 
            // chkGlacier2
            // 
            this.chkGlacier2.AutoSize = true;
            this.chkGlacier2.Location = new System.Drawing.Point(7, 19);
            this.chkGlacier2.Name = "chkGlacier2";
            this.chkGlacier2.Size = new System.Drawing.Size(65, 17);
            this.chkGlacier2.TabIndex = 0;
            this.chkGlacier2.TabStop = false;
            this.chkGlacier2.Text = "Glacier2";
            this.chkGlacier2.UseVisualStyleBackColor = true;
            this.chkGlacier2.CheckedChanged += new System.EventHandler(this.chkGlacier2_CheckedChanged);
            // 
            // chkIce
            // 
            this.chkIce.AutoSize = true;
            this.chkIce.Location = new System.Drawing.Point(78, 19);
            this.chkIce.Name = "chkIce";
            this.chkIce.Size = new System.Drawing.Size(41, 17);
            this.chkIce.TabIndex = 1;
            this.chkIce.TabStop = false;
            this.chkIce.Text = "Ice";
            this.chkIce.UseVisualStyleBackColor = true;
            this.chkIce.CheckedChanged += new System.EventHandler(this.chkIce_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkIcePrefix);
            this.groupBox4.Controls.Add(this.chkStreaming);
            this.groupBox4.Controls.Add(this.chkTie);
            this.groupBox4.Location = new System.Drawing.Point(12, 88);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(487, 44);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Slice Compiler Options";
            // 
            // chkIcePrefix
            // 
            this.chkIcePrefix.AutoSize = true;
            this.chkIcePrefix.Location = new System.Drawing.Point(10, 19);
            this.chkIcePrefix.Name = "chkIcePrefix";
            this.chkIcePrefix.Size = new System.Drawing.Size(70, 17);
            this.chkIcePrefix.TabIndex = 2;
            this.chkIcePrefix.Text = "Ice (--ice)";
            this.chkIcePrefix.UseVisualStyleBackColor = true;
            this.chkIcePrefix.CheckedChanged += new System.EventHandler(this.chkIcePrefix_CheckedChanged);
            // 
            // chkStreaming
            // 
            this.chkStreaming.AutoSize = true;
            this.chkStreaming.Location = new System.Drawing.Point(169, 19);
            this.chkStreaming.Name = "chkStreaming";
            this.chkStreaming.Size = new System.Drawing.Size(119, 17);
            this.chkStreaming.TabIndex = 1;
            this.chkStreaming.Text = "Streaming (--stream)";
            this.chkStreaming.UseVisualStyleBackColor = true;
            this.chkStreaming.CheckedChanged += new System.EventHandler(this.chkStreaming_CheckedChanged);
            // 
            // chkTie
            // 
            this.chkTie.AutoSize = true;
            this.chkTie.Location = new System.Drawing.Point(91, 19);
            this.chkTie.Name = "chkTie";
            this.chkTie.Size = new System.Drawing.Size(67, 17);
            this.chkTie.TabIndex = 0;
            this.chkTie.Text = "Tie (--tie)";
            this.chkTie.UseVisualStyleBackColor = true;
            this.chkTie.CheckedChanged += new System.EventHandler(this.chkTie_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(423, 461);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSelectIceHome);
            this.groupBox5.Controls.Add(this.txtIceHome);
            this.groupBox5.Location = new System.Drawing.Point(12, 37);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(486, 45);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ice Home";
            // 
            // btnSelectIceHome
            // 
            this.btnSelectIceHome.Location = new System.Drawing.Point(405, 16);
            this.btnSelectIceHome.Name = "btnSelectIceHome";
            this.btnSelectIceHome.Size = new System.Drawing.Size(75, 23);
            this.btnSelectIceHome.TabIndex = 1;
            this.btnSelectIceHome.Text = "....";
            this.btnSelectIceHome.UseVisualStyleBackColor = true;
            this.btnSelectIceHome.Click += new System.EventHandler(this.btnSelectIceHome_Click);
            // 
            // txtIceHome
            // 
            this.txtIceHome.Location = new System.Drawing.Point(10, 20);
            this.txtIceHome.Name = "txtIceHome";
            this.txtIceHome.ReadOnly = true;
            this.txtIceHome.Size = new System.Drawing.Size(386, 20);
            this.txtIceHome.TabIndex = 0;
            // 
            // IceCsharpConfigurationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(515, 496);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkEnableBuilder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "IceCsharpConfigurationDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ice Configuration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEnableBuilder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMoveIncludeDown;
        private System.Windows.Forms.Button btnMoveIncludeUp;
        private System.Windows.Forms.Button btnRemoveInclude;
        private System.Windows.Forms.Button btnAddInclude;
        private System.Windows.Forms.ListBox includeDirList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtMacros;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkIceStorm;
        private System.Windows.Forms.CheckBox chkIceSSL;
        private System.Windows.Forms.CheckBox chkIcePatch2;
        private System.Windows.Forms.CheckBox chkIceGrid;
        private System.Windows.Forms.CheckBox chkIceBox;
        private System.Windows.Forms.CheckBox chkGlacier2;
        private System.Windows.Forms.CheckBox chkIce;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkTie;
        private System.Windows.Forms.CheckBox chkIcePrefix;
        private System.Windows.Forms.CheckBox chkStreaming;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSelectIceHome;
        private System.Windows.Forms.TextBox txtIceHome;
        private System.Windows.Forms.ToolTip toolTip;
    }
}