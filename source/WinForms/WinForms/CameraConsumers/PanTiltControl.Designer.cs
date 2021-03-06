﻿namespace PiCamCV.WinForms.CameraConsumers
{
    partial class PanTiltControl
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

        private System.Windows.Forms.GroupBox groupBoxMoveTo;
        private System.Windows.Forms.Button btnGoto;
        private System.Windows.Forms.TextBox txtTiltPercent;
        private System.Windows.Forms.TextBox txtPanPercent;
        private System.Windows.Forms.Label labelTilt;
        private System.Windows.Forms.Label labelPan;
        private System.Windows.Forms.GroupBox groupBoxControls;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.panelScreen = new System.Windows.Forms.Panel();
            this.txtScreen = new System.Windows.Forms.TextBox();
            this.groupBoxView = new System.Windows.Forms.GroupBox();
            this.sliderSize = new PiCamCV.WinForms.UserControls.SliderControl();
            this.groupBoxCalibration = new System.Windows.Forms.GroupBox();
            this.btnInterpolate = new System.Windows.Forms.Button();
            this.btnToCsv = new System.Windows.Forms.Button();
            this.btnCalibrate = new System.Windows.Forms.Button();
            this.groupBoxControllers = new System.Windows.Forms.GroupBox();
            this.btnMultimodeCommand = new System.Windows.Forms.TextBox();
            this.chkMultimode = new System.Windows.Forms.CheckBox();
            this.labelMotoinSettle = new System.Windows.Forms.Label();
            this.spinEditMotionSettle = new System.Windows.Forms.NumericUpDown();
            this.chkBoxMotionTracking = new System.Windows.Forms.CheckBox();
            this.labelServoSettle = new System.Windows.Forms.Label();
            this.spinEditServoSettle = new System.Windows.Forms.NumericUpDown();
            this.chkBoxColourTracking = new System.Windows.Forms.CheckBox();
            this.chkBoxFaceTracker = new System.Windows.Forms.CheckBox();
            this.groupBoxReticle = new System.Windows.Forms.GroupBox();
            this.btnPaintReticle = new System.Windows.Forms.Button();
            this.txtReticleY = new System.Windows.Forms.TextBox();
            this.txtReticleX = new System.Windows.Forms.TextBox();
            this.labelReticleX = new System.Windows.Forms.Label();
            this.labelReticleY = new System.Windows.Forms.Label();
            this.groupBoxMoveTo = new System.Windows.Forms.GroupBox();
            this.btnGoto = new System.Windows.Forms.Button();
            this.txtTiltPercent = new System.Windows.Forms.TextBox();
            this.txtPanPercent = new System.Windows.Forms.TextBox();
            this.labelTilt = new System.Windows.Forms.Label();
            this.labelPan = new System.Windows.Forms.Label();
            this.txtTimeCalibration = new System.Windows.Forms.TextBox();
            this.panelFlowRhs = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxCaptured = new System.Windows.Forms.GroupBox();
            this.imageBoxCaptured = new Emgu.CV.UI.ImageBox();
            this.groupBoxFiltered = new System.Windows.Forms.GroupBox();
            this.imageBoxFiltered = new Emgu.CV.UI.ImageBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBoxControls.SuspendLayout();
            this.panelScreen.SuspendLayout();
            this.groupBoxView.SuspendLayout();
            this.groupBoxCalibration.SuspendLayout();
            this.groupBoxControllers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMotionSettle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditServoSettle)).BeginInit();
            this.groupBoxReticle.SuspendLayout();
            this.groupBoxMoveTo.SuspendLayout();
            this.panelFlowRhs.SuspendLayout();
            this.groupBoxCaptured.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxCaptured)).BeginInit();
            this.groupBoxFiltered.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFiltered)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Controls.Add(this.panelScreen);
            this.groupBoxControls.Controls.Add(this.groupBoxView);
            this.groupBoxControls.Controls.Add(this.groupBoxCalibration);
            this.groupBoxControls.Controls.Add(this.groupBoxControllers);
            this.groupBoxControls.Controls.Add(this.groupBoxReticle);
            this.groupBoxControls.Controls.Add(this.groupBoxMoveTo);
            this.groupBoxControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxControls.Location = new System.Drawing.Point(0, 0);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Size = new System.Drawing.Size(271, 641);
            this.groupBoxControls.TabIndex = 1;
            this.groupBoxControls.TabStop = false;
            // 
            // panelScreen
            // 
            this.panelScreen.Controls.Add(this.txtScreen);
            this.panelScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScreen.Location = new System.Drawing.Point(3, 396);
            this.panelScreen.Name = "panelScreen";
            this.panelScreen.Size = new System.Drawing.Size(265, 242);
            this.panelScreen.TabIndex = 9;
            // 
            // txtScreen
            // 
            this.txtScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtScreen.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScreen.Location = new System.Drawing.Point(0, 0);
            this.txtScreen.Multiline = true;
            this.txtScreen.Name = "txtScreen";
            this.txtScreen.Size = new System.Drawing.Size(265, 242);
            this.txtScreen.TabIndex = 0;
            // 
            // groupBoxView
            // 
            this.groupBoxView.Controls.Add(this.sliderSize);
            this.groupBoxView.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxView.Location = new System.Drawing.Point(3, 315);
            this.groupBoxView.Name = "groupBoxView";
            this.groupBoxView.Size = new System.Drawing.Size(265, 81);
            this.groupBoxView.TabIndex = 10;
            this.groupBoxView.TabStop = false;
            this.groupBoxView.Text = "View";
            // 
            // sliderSize
            // 
            this.sliderSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.sliderSize.Label = "Image Scale";
            this.sliderSize.LargeChange = 5;
            this.sliderSize.Location = new System.Drawing.Point(3, 16);
            this.sliderSize.Maximum = 255;
            this.sliderSize.Minimum = 50;
            this.sliderSize.Name = "sliderSize";
            this.sliderSize.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.sliderSize.Size = new System.Drawing.Size(259, 55);
            this.sliderSize.SmallChange = 1;
            this.sliderSize.TabIndex = 1;
            this.sliderSize.TickFrequency = 20;
            this.sliderSize.Value = 100;
            this.sliderSize.ValueChanged += new System.EventHandler(this.sliderSize_ValueChanged);
            // 
            // groupBoxCalibration
            // 
            this.groupBoxCalibration.Controls.Add(this.btnInterpolate);
            this.groupBoxCalibration.Controls.Add(this.btnToCsv);
            this.groupBoxCalibration.Controls.Add(this.btnCalibrate);
            this.groupBoxCalibration.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxCalibration.Location = new System.Drawing.Point(3, 261);
            this.groupBoxCalibration.Name = "groupBoxCalibration";
            this.groupBoxCalibration.Size = new System.Drawing.Size(265, 54);
            this.groupBoxCalibration.TabIndex = 8;
            this.groupBoxCalibration.TabStop = false;
            this.groupBoxCalibration.Text = "Calibration";
            // 
            // btnInterpolate
            // 
            this.btnInterpolate.Location = new System.Drawing.Point(166, 19);
            this.btnInterpolate.Name = "btnInterpolate";
            this.btnInterpolate.Size = new System.Drawing.Size(73, 23);
            this.btnInterpolate.TabIndex = 6;
            this.btnInterpolate.Text = "Interpolate";
            this.btnInterpolate.UseVisualStyleBackColor = true;
            this.btnInterpolate.Click += new System.EventHandler(this.btnInterpolate_Click);
            // 
            // btnToCsv
            // 
            this.btnToCsv.Location = new System.Drawing.Point(87, 19);
            this.btnToCsv.Name = "btnToCsv";
            this.btnToCsv.Size = new System.Drawing.Size(73, 23);
            this.btnToCsv.TabIndex = 5;
            this.btnToCsv.Text = "To Csv";
            this.btnToCsv.UseVisualStyleBackColor = true;
            this.btnToCsv.Click += new System.EventHandler(this.btnToCsv_Click);
            // 
            // btnCalibrate
            // 
            this.btnCalibrate.Location = new System.Drawing.Point(6, 19);
            this.btnCalibrate.Name = "btnCalibrate";
            this.btnCalibrate.Size = new System.Drawing.Size(75, 23);
            this.btnCalibrate.TabIndex = 4;
            this.btnCalibrate.Text = "Calibrate";
            this.btnCalibrate.UseVisualStyleBackColor = true;
            this.btnCalibrate.Click += new System.EventHandler(this.btnCalibrate_Click);
            // 
            // groupBoxControllers
            // 
            this.groupBoxControllers.Controls.Add(this.linkLabel1);
            this.groupBoxControllers.Controls.Add(this.btnMultimodeCommand);
            this.groupBoxControllers.Controls.Add(this.chkMultimode);
            this.groupBoxControllers.Controls.Add(this.labelMotoinSettle);
            this.groupBoxControllers.Controls.Add(this.spinEditMotionSettle);
            this.groupBoxControllers.Controls.Add(this.chkBoxMotionTracking);
            this.groupBoxControllers.Controls.Add(this.labelServoSettle);
            this.groupBoxControllers.Controls.Add(this.spinEditServoSettle);
            this.groupBoxControllers.Controls.Add(this.chkBoxColourTracking);
            this.groupBoxControllers.Controls.Add(this.chkBoxFaceTracker);
            this.groupBoxControllers.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxControllers.Location = new System.Drawing.Point(3, 119);
            this.groupBoxControllers.Name = "groupBoxControllers";
            this.groupBoxControllers.Size = new System.Drawing.Size(265, 142);
            this.groupBoxControllers.TabIndex = 6;
            this.groupBoxControllers.TabStop = false;
            this.groupBoxControllers.Text = "Controllers";
            // 
            // btnMultimodeCommand
            // 
            this.btnMultimodeCommand.Location = new System.Drawing.Point(118, 87);
            this.btnMultimodeCommand.Name = "btnMultimodeCommand";
            this.btnMultimodeCommand.Size = new System.Drawing.Size(83, 20);
            this.btnMultimodeCommand.TabIndex = 15;
            this.btnMultimodeCommand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnMultimodeCommand_KeyPress);
            // 
            // chkMultimode
            // 
            this.chkMultimode.AutoSize = true;
            this.chkMultimode.Location = new System.Drawing.Point(8, 88);
            this.chkMultimode.Name = "chkMultimode";
            this.chkMultimode.Size = new System.Drawing.Size(74, 17);
            this.chkMultimode.TabIndex = 14;
            this.chkMultimode.Text = "Multimode";
            this.chkMultimode.UseVisualStyleBackColor = true;
            // 
            // labelMotoinSettle
            // 
            this.labelMotoinSettle.AutoSize = true;
            this.labelMotoinSettle.Location = new System.Drawing.Point(115, 67);
            this.labelMotoinSettle.Name = "labelMotoinSettle";
            this.labelMotoinSettle.Size = new System.Drawing.Size(91, 13);
            this.labelMotoinSettle.TabIndex = 13;
            this.labelMotoinSettle.Text = "Motion Settle (ms)";
            // 
            // spinEditMotionSettle
            // 
            this.spinEditMotionSettle.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.spinEditMotionSettle.Location = new System.Drawing.Point(208, 65);
            this.spinEditMotionSettle.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.spinEditMotionSettle.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.spinEditMotionSettle.Name = "spinEditMotionSettle";
            this.spinEditMotionSettle.Size = new System.Drawing.Size(51, 20);
            this.spinEditMotionSettle.TabIndex = 12;
            this.spinEditMotionSettle.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.spinEditMotionSettle.ValueChanged += new System.EventHandler(this.spinEditMotionSettle_ValueChanged);
            // 
            // chkBoxMotionTracking
            // 
            this.chkBoxMotionTracking.AutoSize = true;
            this.chkBoxMotionTracking.Location = new System.Drawing.Point(8, 65);
            this.chkBoxMotionTracking.Name = "chkBoxMotionTracking";
            this.chkBoxMotionTracking.Size = new System.Drawing.Size(103, 17);
            this.chkBoxMotionTracking.TabIndex = 11;
            this.chkBoxMotionTracking.Text = "Motion Tracking";
            this.chkBoxMotionTracking.UseVisualStyleBackColor = true;
            // 
            // labelServoSettle
            // 
            this.labelServoSettle.AutoSize = true;
            this.labelServoSettle.Location = new System.Drawing.Point(115, 43);
            this.labelServoSettle.Name = "labelServoSettle";
            this.labelServoSettle.Size = new System.Drawing.Size(87, 13);
            this.labelServoSettle.TabIndex = 10;
            this.labelServoSettle.Text = "Servo Settle (ms)";
            // 
            // spinEditServoSettle
            // 
            this.spinEditServoSettle.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.spinEditServoSettle.Location = new System.Drawing.Point(208, 41);
            this.spinEditServoSettle.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.spinEditServoSettle.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.spinEditServoSettle.Name = "spinEditServoSettle";
            this.spinEditServoSettle.Size = new System.Drawing.Size(51, 20);
            this.spinEditServoSettle.TabIndex = 2;
            this.spinEditServoSettle.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.spinEditServoSettle.ValueChanged += new System.EventHandler(this.spinEditServoSettle_ValueChanged);
            // 
            // chkBoxColourTracking
            // 
            this.chkBoxColourTracking.AutoSize = true;
            this.chkBoxColourTracking.Location = new System.Drawing.Point(8, 19);
            this.chkBoxColourTracking.Name = "chkBoxColourTracking";
            this.chkBoxColourTracking.Size = new System.Drawing.Size(101, 17);
            this.chkBoxColourTracking.TabIndex = 1;
            this.chkBoxColourTracking.Text = "Colour Tracking";
            this.chkBoxColourTracking.UseVisualStyleBackColor = true;
            // 
            // chkBoxFaceTracker
            // 
            this.chkBoxFaceTracker.AutoSize = true;
            this.chkBoxFaceTracker.Location = new System.Drawing.Point(8, 42);
            this.chkBoxFaceTracker.Name = "chkBoxFaceTracker";
            this.chkBoxFaceTracker.Size = new System.Drawing.Size(95, 17);
            this.chkBoxFaceTracker.TabIndex = 0;
            this.chkBoxFaceTracker.Text = "Face Tracking";
            this.chkBoxFaceTracker.UseVisualStyleBackColor = true;
            // 
            // groupBoxReticle
            // 
            this.groupBoxReticle.Controls.Add(this.btnPaintReticle);
            this.groupBoxReticle.Controls.Add(this.txtReticleY);
            this.groupBoxReticle.Controls.Add(this.txtReticleX);
            this.groupBoxReticle.Controls.Add(this.labelReticleX);
            this.groupBoxReticle.Controls.Add(this.labelReticleY);
            this.groupBoxReticle.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxReticle.Location = new System.Drawing.Point(3, 66);
            this.groupBoxReticle.Name = "groupBoxReticle";
            this.groupBoxReticle.Size = new System.Drawing.Size(265, 53);
            this.groupBoxReticle.TabIndex = 5;
            this.groupBoxReticle.TabStop = false;
            this.groupBoxReticle.Text = "Calibration Reticle";
            // 
            // btnPaintReticle
            // 
            this.btnPaintReticle.Location = new System.Drawing.Point(155, 17);
            this.btnPaintReticle.Name = "btnPaintReticle";
            this.btnPaintReticle.Size = new System.Drawing.Size(70, 23);
            this.btnPaintReticle.TabIndex = 13;
            this.btnPaintReticle.Text = "Paint";
            this.btnPaintReticle.UseVisualStyleBackColor = true;
            this.btnPaintReticle.Click += new System.EventHandler(this.btnPaintReticle_Click);
            // 
            // txtReticleY
            // 
            this.txtReticleY.Location = new System.Drawing.Point(105, 19);
            this.txtReticleY.Name = "txtReticleY";
            this.txtReticleY.Size = new System.Drawing.Size(44, 20);
            this.txtReticleY.TabIndex = 12;
            // 
            // txtReticleX
            // 
            this.txtReticleX.Location = new System.Drawing.Point(37, 19);
            this.txtReticleX.Name = "txtReticleX";
            this.txtReticleX.Size = new System.Drawing.Size(35, 20);
            this.txtReticleX.TabIndex = 11;
            // 
            // labelReticleX
            // 
            this.labelReticleX.AutoSize = true;
            this.labelReticleX.Location = new System.Drawing.Point(5, 22);
            this.labelReticleX.Name = "labelReticleX";
            this.labelReticleX.Size = new System.Drawing.Size(12, 13);
            this.labelReticleX.TabIndex = 9;
            this.labelReticleX.Text = "x";
            // 
            // labelReticleY
            // 
            this.labelReticleY.AutoSize = true;
            this.labelReticleY.Location = new System.Drawing.Point(78, 22);
            this.labelReticleY.Name = "labelReticleY";
            this.labelReticleY.Size = new System.Drawing.Size(12, 13);
            this.labelReticleY.TabIndex = 10;
            this.labelReticleY.Text = "y";
            // 
            // groupBoxMoveTo
            // 
            this.groupBoxMoveTo.Controls.Add(this.btnGoto);
            this.groupBoxMoveTo.Controls.Add(this.txtTiltPercent);
            this.groupBoxMoveTo.Controls.Add(this.txtPanPercent);
            this.groupBoxMoveTo.Controls.Add(this.labelTilt);
            this.groupBoxMoveTo.Controls.Add(this.labelPan);
            this.groupBoxMoveTo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxMoveTo.Location = new System.Drawing.Point(3, 16);
            this.groupBoxMoveTo.Name = "groupBoxMoveTo";
            this.groupBoxMoveTo.Size = new System.Drawing.Size(265, 50);
            this.groupBoxMoveTo.TabIndex = 4;
            this.groupBoxMoveTo.TabStop = false;
            this.groupBoxMoveTo.Text = "Goto";
            // 
            // btnGoto
            // 
            this.btnGoto.Location = new System.Drawing.Point(155, 17);
            this.btnGoto.Name = "btnGoto";
            this.btnGoto.Size = new System.Drawing.Size(70, 23);
            this.btnGoto.TabIndex = 8;
            this.btnGoto.Text = "Go";
            this.btnGoto.UseVisualStyleBackColor = true;
            this.btnGoto.Click += new System.EventHandler(this.btnGoto_Click);
            // 
            // txtTiltPercent
            // 
            this.txtTiltPercent.Location = new System.Drawing.Point(105, 19);
            this.txtTiltPercent.Name = "txtTiltPercent";
            this.txtTiltPercent.Size = new System.Drawing.Size(44, 20);
            this.txtTiltPercent.TabIndex = 7;
            this.txtTiltPercent.Text = "50";
            // 
            // txtPanPercent
            // 
            this.txtPanPercent.Location = new System.Drawing.Point(37, 19);
            this.txtPanPercent.Name = "txtPanPercent";
            this.txtPanPercent.Size = new System.Drawing.Size(35, 20);
            this.txtPanPercent.TabIndex = 6;
            this.txtPanPercent.Text = "50";
            // 
            // labelTilt
            // 
            this.labelTilt.AutoSize = true;
            this.labelTilt.Location = new System.Drawing.Point(78, 22);
            this.labelTilt.Name = "labelTilt";
            this.labelTilt.Size = new System.Drawing.Size(21, 13);
            this.labelTilt.TabIndex = 5;
            this.labelTilt.Text = "Tilt";
            // 
            // labelPan
            // 
            this.labelPan.AutoSize = true;
            this.labelPan.Location = new System.Drawing.Point(5, 22);
            this.labelPan.Name = "labelPan";
            this.labelPan.Size = new System.Drawing.Size(26, 13);
            this.labelPan.TabIndex = 4;
            this.labelPan.Text = "Pan";
            // 
            // txtTimeCalibration
            // 
            this.txtTimeCalibration.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTimeCalibration.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeCalibration.Location = new System.Drawing.Point(271, 603);
            this.txtTimeCalibration.Name = "txtTimeCalibration";
            this.txtTimeCalibration.Size = new System.Drawing.Size(684, 38);
            this.txtTimeCalibration.TabIndex = 6;
            // 
            // panelFlowRhs
            // 
            this.panelFlowRhs.Controls.Add(this.groupBoxCaptured);
            this.panelFlowRhs.Controls.Add(this.groupBoxFiltered);
            this.panelFlowRhs.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFlowRhs.Location = new System.Drawing.Point(271, 0);
            this.panelFlowRhs.Name = "panelFlowRhs";
            this.panelFlowRhs.Size = new System.Drawing.Size(684, 571);
            this.panelFlowRhs.TabIndex = 7;
            // 
            // groupBoxCaptured
            // 
            this.groupBoxCaptured.Controls.Add(this.imageBoxCaptured);
            this.groupBoxCaptured.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxCaptured.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCaptured.Name = "groupBoxCaptured";
            this.groupBoxCaptured.Size = new System.Drawing.Size(577, 261);
            this.groupBoxCaptured.TabIndex = 3;
            this.groupBoxCaptured.TabStop = false;
            this.groupBoxCaptured.Text = "Captured";
            // 
            // imageBoxCaptured
            // 
            this.imageBoxCaptured.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxCaptured.Location = new System.Drawing.Point(3, 16);
            this.imageBoxCaptured.Name = "imageBoxCaptured";
            this.imageBoxCaptured.Size = new System.Drawing.Size(571, 242);
            this.imageBoxCaptured.TabIndex = 6;
            this.imageBoxCaptured.TabStop = false;
            // 
            // groupBoxFiltered
            // 
            this.groupBoxFiltered.Controls.Add(this.imageBoxFiltered);
            this.groupBoxFiltered.Location = new System.Drawing.Point(3, 270);
            this.groupBoxFiltered.Name = "groupBoxFiltered";
            this.groupBoxFiltered.Size = new System.Drawing.Size(574, 276);
            this.groupBoxFiltered.TabIndex = 4;
            this.groupBoxFiltered.TabStop = false;
            this.groupBoxFiltered.Text = "Filtered";
            // 
            // imageBoxFiltered
            // 
            this.imageBoxFiltered.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxFiltered.Location = new System.Drawing.Point(3, 16);
            this.imageBoxFiltered.Name = "imageBoxFiltered";
            this.imageBoxFiltered.Size = new System.Drawing.Size(568, 257);
            this.imageBoxFiltered.TabIndex = 7;
            this.imageBoxFiltered.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 126);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(52, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Clear Log";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // PanTiltControl
            // 
            this.Controls.Add(this.panelFlowRhs);
            this.Controls.Add(this.txtTimeCalibration);
            this.Controls.Add(this.groupBoxControls);
            this.Name = "PanTiltControl";
            this.Size = new System.Drawing.Size(955, 641);
            this.Load += new System.EventHandler(this.PanTiltControl_Load);
            this.groupBoxControls.ResumeLayout(false);
            this.panelScreen.ResumeLayout(false);
            this.panelScreen.PerformLayout();
            this.groupBoxView.ResumeLayout(false);
            this.groupBoxCalibration.ResumeLayout(false);
            this.groupBoxControllers.ResumeLayout(false);
            this.groupBoxControllers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditMotionSettle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditServoSettle)).EndInit();
            this.groupBoxReticle.ResumeLayout(false);
            this.groupBoxReticle.PerformLayout();
            this.groupBoxMoveTo.ResumeLayout(false);
            this.groupBoxMoveTo.PerformLayout();
            this.panelFlowRhs.ResumeLayout(false);
            this.groupBoxCaptured.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxCaptured)).EndInit();
            this.groupBoxFiltered.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFiltered)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.GroupBox groupBoxReticle;
        private System.Windows.Forms.Button btnPaintReticle;
        private System.Windows.Forms.TextBox txtReticleY;
        private System.Windows.Forms.TextBox txtReticleX;
        private System.Windows.Forms.Label labelReticleX;
        private System.Windows.Forms.Label labelReticleY;
        private System.Windows.Forms.GroupBox groupBoxControllers;
        private System.Windows.Forms.CheckBox chkBoxFaceTracker;
        private System.Windows.Forms.CheckBox chkBoxColourTracking;
        private System.Windows.Forms.Panel panelScreen;
        private System.Windows.Forms.TextBox txtScreen;
        private System.Windows.Forms.GroupBox groupBoxCalibration;
        private System.Windows.Forms.Button btnInterpolate;
        private System.Windows.Forms.Button btnToCsv;
        private System.Windows.Forms.Button btnCalibrate;
        private System.Windows.Forms.Label labelServoSettle;
        private System.Windows.Forms.NumericUpDown spinEditServoSettle;
        private System.Windows.Forms.CheckBox chkBoxMotionTracking;
        private System.Windows.Forms.TextBox txtTimeCalibration;
        private System.Windows.Forms.FlowLayoutPanel panelFlowRhs;
        private System.Windows.Forms.GroupBox groupBoxCaptured;
        private Emgu.CV.UI.ImageBox imageBoxCaptured;
        private System.Windows.Forms.GroupBox groupBoxFiltered;
        private Emgu.CV.UI.ImageBox imageBoxFiltered;
        private System.Windows.Forms.GroupBox groupBoxView;
        private UserControls.SliderControl sliderSize;
        private System.Windows.Forms.NumericUpDown spinEditMotionSettle;
        private System.Windows.Forms.Label labelMotoinSettle;
        private System.Windows.Forms.CheckBox chkMultimode;
        private System.Windows.Forms.TextBox btnMultimodeCommand;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
