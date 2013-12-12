namespace LightWeb
{
    partial class frmSetupDialog
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
            this.cmbNodeSelect = new System.Windows.Forms.ComboBox();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.cmdImport = new System.Windows.Forms.Button();
            this.cmdExport = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape5 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpFile = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.v = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdAddNode = new System.Windows.Forms.Button();
            this.cmdModify = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.txtIP1 = new System.Windows.Forms.TextBox();
            this.txtIP2 = new System.Windows.Forms.TextBox();
            this.txtIP3 = new System.Windows.Forms.TextBox();
            this.txtIP4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChannelCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNodeDescription = new System.Windows.Forms.TextBox();
            this.cmdSaveNode = new System.Windows.Forms.Button();
            this.cmdCancelNode = new System.Windows.Forms.Button();
            this.txtXML = new System.Windows.Forms.TextBox();
            this.grpSettings.SuspendLayout();
            this.grpFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbNodeSelect
            // 
            this.cmbNodeSelect.FormattingEnabled = true;
            this.cmbNodeSelect.Location = new System.Drawing.Point(18, 132);
            this.cmbNodeSelect.Name = "cmbNodeSelect";
            this.cmbNodeSelect.Size = new System.Drawing.Size(305, 21);
            this.cmbNodeSelect.TabIndex = 1;
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.cmdImport);
            this.grpSettings.Controls.Add(this.cmdExport);
            this.grpSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSettings.Location = new System.Drawing.Point(15, 505);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(320, 71);
            this.grpSettings.TabIndex = 4;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "LightWeb Settings";
            // 
            // cmdImport
            // 
            this.cmdImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImport.Image = global::LightWeb.Properties.Resources.export_icon_32x32;
            this.cmdImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdImport.Location = new System.Drawing.Point(163, 19);
            this.cmdImport.Name = "cmdImport";
            this.cmdImport.Size = new System.Drawing.Size(151, 39);
            this.cmdImport.TabIndex = 2;
            this.cmdImport.Text = "IMPORT";
            this.cmdImport.UseVisualStyleBackColor = true;
            // 
            // cmdExport
            // 
            this.cmdExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExport.Image = global::LightWeb.Properties.Resources.import_icon_32x32;
            this.cmdExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExport.Location = new System.Drawing.Point(6, 19);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.Size = new System.Drawing.Size(151, 39);
            this.cmdExport.TabIndex = 3;
            this.cmdExport.Text = "EXPORT";
            this.cmdExport.UseVisualStyleBackColor = true;
            // 
            // cmdExit
            // 
            this.cmdExit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Image = global::LightWeb.Properties.Resources.Exit_Icon_Small;
            this.cmdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExit.Location = new System.Drawing.Point(761, 524);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(169, 39);
            this.cmdExit.TabIndex = 0;
            this.cmdExit.Text = "EXIT";
            this.cmdExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "LightWeb Setup";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape5,
            this.rectangleShape4,
            this.rectangleShape3,
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(956, 600);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape5
            // 
            this.rectangleShape5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rectangleShape5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rectangleShape5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rectangleShape5.CornerRadius = 5;
            this.rectangleShape5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rectangleShape5.FillGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rectangleShape5.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.ForwardDiagonal;
            this.rectangleShape5.Location = new System.Drawing.Point(8, 499);
            this.rectangleShape5.Name = "rectangleShape5";
            this.rectangleShape5.Size = new System.Drawing.Size(938, 85);
            // 
            // rectangleShape4
            // 
            this.rectangleShape4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rectangleShape4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rectangleShape4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rectangleShape4.CornerRadius = 5;
            this.rectangleShape4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rectangleShape4.FillGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rectangleShape4.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.ForwardDiagonal;
            this.rectangleShape4.Location = new System.Drawing.Point(347, 19);
            this.rectangleShape4.Name = "rectangleShape4";
            this.rectangleShape4.Size = new System.Drawing.Size(599, 36);
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rectangleShape3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rectangleShape3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rectangleShape3.CornerRadius = 5;
            this.rectangleShape3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rectangleShape3.FillGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rectangleShape3.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.ForwardDiagonal;
            this.rectangleShape3.Location = new System.Drawing.Point(9, 66);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(322, 36);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rectangleShape2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rectangleShape2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rectangleShape2.CornerRadius = 5;
            this.rectangleShape2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rectangleShape2.FillGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rectangleShape2.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.ForwardDiagonal;
            this.rectangleShape2.Location = new System.Drawing.Point(348, 65);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(598, 421);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rectangleShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rectangleShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rectangleShape1.CornerRadius = 5;
            this.rectangleShape1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rectangleShape1.FillGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rectangleShape1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.ForwardDiagonal;
            this.rectangleShape1.Location = new System.Drawing.Point(9, 112);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(322, 374);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(515, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Channel Assignment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(84, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Node Setup";
            // 
            // grpFile
            // 
            this.grpFile.Controls.Add(this.label4);
            this.grpFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFile.Location = new System.Drawing.Point(352, 505);
            this.grpFile.Name = "grpFile";
            this.grpFile.Size = new System.Drawing.Size(390, 71);
            this.grpFile.TabIndex = 9;
            this.grpFile.TabStop = false;
            this.grpFile.Text = "Active Configuration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "LightWeb Setup";
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v.Location = new System.Drawing.Point(15, 198);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(68, 13);
            this.v.TabIndex = 10;
            this.v.Text = "IP Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Node Select";
            // 
            // cmdAddNode
            // 
            this.cmdAddNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddNode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAddNode.Location = new System.Drawing.Point(18, 159);
            this.cmdAddNode.Name = "cmdAddNode";
            this.cmdAddNode.Size = new System.Drawing.Size(90, 21);
            this.cmdAddNode.TabIndex = 12;
            this.cmdAddNode.Text = "ADD";
            this.cmdAddNode.UseVisualStyleBackColor = true;
            // 
            // cmdModify
            // 
            this.cmdModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdModify.Location = new System.Drawing.Point(233, 159);
            this.cmdModify.Name = "cmdModify";
            this.cmdModify.Size = new System.Drawing.Size(90, 21);
            this.cmdModify.TabIndex = 13;
            this.cmdModify.Text = "MODIFY";
            this.cmdModify.UseVisualStyleBackColor = true;
            // 
            // cmdDelete
            // 
            this.cmdDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdDelete.Location = new System.Drawing.Point(125, 159);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(90, 21);
            this.cmdDelete.TabIndex = 14;
            this.cmdDelete.Text = "DELETE";
            this.cmdDelete.UseVisualStyleBackColor = true;
            // 
            // txtIP1
            // 
            this.txtIP1.Location = new System.Drawing.Point(18, 214);
            this.txtIP1.MaxLength = 3;
            this.txtIP1.Name = "txtIP1";
            this.txtIP1.Size = new System.Drawing.Size(60, 20);
            this.txtIP1.TabIndex = 15;
            // 
            // txtIP2
            // 
            this.txtIP2.Location = new System.Drawing.Point(89, 214);
            this.txtIP2.Name = "txtIP2";
            this.txtIP2.Size = new System.Drawing.Size(60, 20);
            this.txtIP2.TabIndex = 16;
            // 
            // txtIP3
            // 
            this.txtIP3.Location = new System.Drawing.Point(160, 214);
            this.txtIP3.Name = "txtIP3";
            this.txtIP3.Size = new System.Drawing.Size(60, 20);
            this.txtIP3.TabIndex = 17;
            // 
            // txtIP4
            // 
            this.txtIP4.Location = new System.Drawing.Point(232, 214);
            this.txtIP4.Name = "txtIP4";
            this.txtIP4.Size = new System.Drawing.Size(60, 20);
            this.txtIP4.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Channel Count";
            // 
            // txtChannelCount
            // 
            this.txtChannelCount.Location = new System.Drawing.Point(18, 266);
            this.txtChannelCount.MaxLength = 3;
            this.txtChannelCount.Name = "txtChannelCount";
            this.txtChannelCount.Size = new System.Drawing.Size(60, 20);
            this.txtChannelCount.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Node Description";
            // 
            // txtNodeDescription
            // 
            this.txtNodeDescription.Location = new System.Drawing.Point(18, 318);
            this.txtNodeDescription.Multiline = true;
            this.txtNodeDescription.Name = "txtNodeDescription";
            this.txtNodeDescription.Size = new System.Drawing.Size(305, 94);
            this.txtNodeDescription.TabIndex = 22;
            // 
            // cmdSaveNode
            // 
            this.cmdSaveNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSaveNode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSaveNode.Location = new System.Drawing.Point(37, 436);
            this.cmdSaveNode.Name = "cmdSaveNode";
            this.cmdSaveNode.Size = new System.Drawing.Size(101, 30);
            this.cmdSaveNode.TabIndex = 23;
            this.cmdSaveNode.Text = "SAVE";
            this.cmdSaveNode.UseVisualStyleBackColor = true;
            this.cmdSaveNode.Click += new System.EventHandler(this.cmdSaveNode_Click);
            // 
            // cmdCancelNode
            // 
            this.cmdCancelNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelNode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancelNode.Location = new System.Drawing.Point(191, 436);
            this.cmdCancelNode.Name = "cmdCancelNode";
            this.cmdCancelNode.Size = new System.Drawing.Size(101, 30);
            this.cmdCancelNode.TabIndex = 24;
            this.cmdCancelNode.Text = "CANCEL";
            this.cmdCancelNode.UseVisualStyleBackColor = true;
            // 
            // txtXML
            // 
            this.txtXML.Location = new System.Drawing.Point(383, 87);
            this.txtXML.MaximumSize = new System.Drawing.Size(32000, 32000);
            this.txtXML.Multiline = true;
            this.txtXML.Name = "txtXML";
            this.txtXML.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtXML.Size = new System.Drawing.Size(537, 368);
            this.txtXML.TabIndex = 25;
            this.txtXML.Text = "Test";
            // 
            // frmSetupDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 600);
            this.Controls.Add(this.txtXML);
            this.Controls.Add(this.cmdCancelNode);
            this.Controls.Add(this.cmdSaveNode);
            this.Controls.Add(this.txtNodeDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtChannelCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIP4);
            this.Controls.Add(this.txtIP3);
            this.Controls.Add(this.txtIP2);
            this.Controls.Add(this.txtIP1);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdModify);
            this.Controls.Add(this.cmdAddNode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.v);
            this.Controls.Add(this.grpFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.cmbNodeSelect);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "frmSetupDialog";
            this.Text = "LightWeb Setup";
            this.grpSettings.ResumeLayout(false);
            this.grpFile.ResumeLayout(false);
            this.grpFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.ComboBox cmbNodeSelect;
        private System.Windows.Forms.Button cmdImport;
        private System.Windows.Forms.Button cmdExport;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label v;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdAddNode;
        private System.Windows.Forms.Button cmdModify;
        private System.Windows.Forms.Button cmdDelete;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape4;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private System.Windows.Forms.TextBox txtIP1;
        private System.Windows.Forms.TextBox txtIP2;
        private System.Windows.Forms.TextBox txtIP3;
        private System.Windows.Forms.TextBox txtIP4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChannelCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNodeDescription;
        private System.Windows.Forms.Button cmdSaveNode;
        private System.Windows.Forms.Button cmdCancelNode;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape5;
        private System.Windows.Forms.TextBox txtXML;
    }
}