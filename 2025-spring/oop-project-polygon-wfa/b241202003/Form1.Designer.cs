//***************************************************************************
//************** STUDENT NAME: SERHAN GÖKMEYDAN *****************************
//************** STUDENT NUMBER: B241202003     *****************************
//***************************************************************************

namespace b241202003;

partial class Form1
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        btnLoadFile = new System.Windows.Forms.Button();
        btnSaveFile = new System.Windows.Forms.Button();
        btnDraw = new System.Windows.Forms.Button();
        btnRotate = new System.Windows.Forms.Button();
        btnReset = new System.Windows.Forms.Button();
        lblCenter = new System.Windows.Forms.Label();
        tbxX = new System.Windows.Forms.TextBox();
        tbxY = new System.Windows.Forms.TextBox();
        lblLength = new System.Windows.Forms.Label();
        tbxLength = new System.Windows.Forms.TextBox();
        lblRed = new System.Windows.Forms.Label();
        trackRed = new System.Windows.Forms.TrackBar();
        lblGreen = new System.Windows.Forms.Label();
        trackGreen = new System.Windows.Forms.TrackBar();
        trackBlue = new System.Windows.Forms.TrackBar();
        lblBlue = new System.Windows.Forms.Label();
        lblEdge = new System.Windows.Forms.Label();
        tbxEdge = new System.Windows.Forms.TextBox();
        checkCCW = new System.Windows.Forms.CheckBox();
        trackSpinInterval = new System.Windows.Forms.TrackBar();
        lblSpinInterval = new System.Windows.Forms.Label();
        lblRedValue = new System.Windows.Forms.Label();
        lblGreenValue = new System.Windows.Forms.Label();
        lblBlueValue = new System.Windows.Forms.Label();
        lblSpinIntervalValue = new System.Windows.Forms.Label();
        tbxAngle = new System.Windows.Forms.TextBox();
        lblAngle = new System.Windows.Forms.Label();
        timer1 = new System.Windows.Forms.Timer(components);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)trackRed).BeginInit();
        ((System.ComponentModel.ISupportInitialize)trackGreen).BeginInit();
        ((System.ComponentModel.ISupportInitialize)trackBlue).BeginInit();
        ((System.ComponentModel.ISupportInitialize)trackSpinInterval).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.Location = new System.Drawing.Point(32, 42);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(516, 516);
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // btnLoadFile
        // 
        btnLoadFile.Location = new System.Drawing.Point(32, 581);
        btnLoadFile.Name = "btnLoadFile";
        btnLoadFile.Size = new System.Drawing.Size(250, 50);
        btnLoadFile.TabIndex = 1;
        btnLoadFile.Text = "Load From File";
        btnLoadFile.UseVisualStyleBackColor = true;
        btnLoadFile.Click += btnLoadFile_Click;
        // 
        // btnSaveFile
        // 
        btnSaveFile.Location = new System.Drawing.Point(298, 581);
        btnSaveFile.Name = "btnSaveFile";
        btnSaveFile.Size = new System.Drawing.Size(250, 50);
        btnSaveFile.TabIndex = 2;
        btnSaveFile.Text = "Save To File";
        btnSaveFile.UseVisualStyleBackColor = true;
        btnSaveFile.Click += btnSaveFile_Click;
        // 
        // btnDraw
        // 
        btnDraw.Location = new System.Drawing.Point(572, 42);
        btnDraw.Name = "btnDraw";
        btnDraw.Size = new System.Drawing.Size(250, 50);
        btnDraw.TabIndex = 3;
        btnDraw.Text = "Draw";
        btnDraw.UseVisualStyleBackColor = true;
        btnDraw.Click += btnDraw_Click;
        // 
        // btnRotate
        // 
        btnRotate.Location = new System.Drawing.Point(572, 98);
        btnRotate.Name = "btnRotate";
        btnRotate.Size = new System.Drawing.Size(250, 50);
        btnRotate.TabIndex = 4;
        btnRotate.Text = "Rotate";
        btnRotate.UseVisualStyleBackColor = true;
        btnRotate.Click += btnRotate_Click;
        // 
        // btnReset
        // 
        btnReset.Location = new System.Drawing.Point(572, 154);
        btnReset.Name = "btnReset";
        btnReset.Size = new System.Drawing.Size(250, 50);
        btnReset.TabIndex = 5;
        btnReset.Text = "Reset";
        btnReset.UseVisualStyleBackColor = true;
        btnReset.Click += btnReset_Click;
        // 
        // lblCenter
        // 
        lblCenter.Location = new System.Drawing.Point(574, 221);
        lblCenter.Name = "lblCenter";
        lblCenter.Size = new System.Drawing.Size(100, 23);
        lblCenter.TabIndex = 6;
        lblCenter.Text = "Center (x,y)";
        lblCenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // tbxX
        // 
        tbxX.Location = new System.Drawing.Point(680, 221);
        tbxX.Name = "tbxX";
        tbxX.PlaceholderText = "X";
        tbxX.Size = new System.Drawing.Size(60, 23);
        tbxX.TabIndex = 7;
        tbxX.Text = "0";
        tbxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // tbxY
        // 
        tbxY.Location = new System.Drawing.Point(764, 221);
        tbxY.Name = "tbxY";
        tbxY.PlaceholderText = "Y";
        tbxY.Size = new System.Drawing.Size(60, 23);
        tbxY.TabIndex = 8;
        tbxY.Text = "0";
        tbxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // lblLength
        // 
        lblLength.Location = new System.Drawing.Point(574, 266);
        lblLength.Name = "lblLength";
        lblLength.Size = new System.Drawing.Size(100, 23);
        lblLength.TabIndex = 9;
        lblLength.Text = "Length";
        lblLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // tbxLength
        // 
        tbxLength.Location = new System.Drawing.Point(680, 267);
        tbxLength.Name = "tbxLength";
        tbxLength.Size = new System.Drawing.Size(144, 23);
        tbxLength.TabIndex = 10;
        tbxLength.Text = "4";
        tbxLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // lblRed
        // 
        lblRed.Location = new System.Drawing.Point(574, 312);
        lblRed.Name = "lblRed";
        lblRed.Size = new System.Drawing.Size(100, 45);
        lblRed.TabIndex = 11;
        lblRed.Text = "Red";
        lblRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // trackRed
        // 
        trackRed.Location = new System.Drawing.Point(680, 312);
        trackRed.Maximum = 255;
        trackRed.Name = "trackRed";
        trackRed.Size = new System.Drawing.Size(144, 45);
        trackRed.TabIndex = 12;
        trackRed.Scroll += TrackBarScroll;
        // 
        // lblGreen
        // 
        lblGreen.Location = new System.Drawing.Point(574, 363);
        lblGreen.Name = "lblGreen";
        lblGreen.Size = new System.Drawing.Size(100, 45);
        lblGreen.TabIndex = 13;
        lblGreen.Text = "Green";
        lblGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // trackGreen
        // 
        trackGreen.Location = new System.Drawing.Point(680, 363);
        trackGreen.Maximum = 255;
        trackGreen.Name = "trackGreen";
        trackGreen.Size = new System.Drawing.Size(144, 45);
        trackGreen.TabIndex = 14;
        trackGreen.Scroll += TrackBarScroll;
        // 
        // trackBlue
        // 
        trackBlue.Cursor = System.Windows.Forms.Cursors.Default;
        trackBlue.Location = new System.Drawing.Point(680, 414);
        trackBlue.Maximum = 255;
        trackBlue.Name = "trackBlue";
        trackBlue.RightToLeft = System.Windows.Forms.RightToLeft.No;
        trackBlue.Size = new System.Drawing.Size(144, 45);
        trackBlue.TabIndex = 15;
        trackBlue.Scroll += TrackBarScroll;
        // 
        // lblBlue
        // 
        lblBlue.Location = new System.Drawing.Point(574, 414);
        lblBlue.Name = "lblBlue";
        lblBlue.Size = new System.Drawing.Size(100, 45);
        lblBlue.TabIndex = 16;
        lblBlue.Text = "Blue";
        lblBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblEdge
        // 
        lblEdge.Location = new System.Drawing.Point(574, 473);
        lblEdge.Name = "lblEdge";
        lblEdge.Size = new System.Drawing.Size(100, 23);
        lblEdge.TabIndex = 17;
        lblEdge.Text = "Edge";
        lblEdge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // tbxEdge
        // 
        tbxEdge.Location = new System.Drawing.Point(680, 474);
        tbxEdge.Name = "tbxEdge";
        tbxEdge.Size = new System.Drawing.Size(60, 23);
        tbxEdge.TabIndex = 18;
        tbxEdge.Text = "5";
        tbxEdge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // checkCCW
        // 
        checkCCW.Location = new System.Drawing.Point(746, 474);
        checkCCW.Name = "checkCCW";
        checkCCW.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        checkCCW.Size = new System.Drawing.Size(78, 24);
        checkCCW.TabIndex = 19;
        checkCCW.Text = "CCW";
        checkCCW.UseVisualStyleBackColor = true;
        // 
        // trackSpinInterval
        // 
        trackSpinInterval.Location = new System.Drawing.Point(680, 581);
        trackSpinInterval.Name = "trackSpinInterval";
        trackSpinInterval.Size = new System.Drawing.Size(144, 45);
        trackSpinInterval.TabIndex = 20;
        trackSpinInterval.Scroll += TrackBarScroll;
        // 
        // lblSpinInterval
        // 
        lblSpinInterval.Location = new System.Drawing.Point(574, 581);
        lblSpinInterval.Name = "lblSpinInterval";
        lblSpinInterval.Size = new System.Drawing.Size(100, 23);
        lblSpinInterval.TabIndex = 21;
        lblSpinInterval.Text = "Spin Interval";
        lblSpinInterval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblRedValue
        // 
        lblRedValue.AutoSize = true;
        lblRedValue.Location = new System.Drawing.Point(687, 294);
        lblRedValue.Name = "lblRedValue";
        lblRedValue.Size = new System.Drawing.Size(13, 15);
        lblRedValue.TabIndex = 22;
        lblRedValue.Text = "0";
        // 
        // lblGreenValue
        // 
        lblGreenValue.AutoSize = true;
        lblGreenValue.Location = new System.Drawing.Point(687, 345);
        lblGreenValue.Name = "lblGreenValue";
        lblGreenValue.Size = new System.Drawing.Size(13, 15);
        lblGreenValue.TabIndex = 23;
        lblGreenValue.Text = "0";
        lblGreenValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // lblBlueValue
        // 
        lblBlueValue.AutoSize = true;
        lblBlueValue.Location = new System.Drawing.Point(687, 396);
        lblBlueValue.Name = "lblBlueValue";
        lblBlueValue.Size = new System.Drawing.Size(13, 15);
        lblBlueValue.TabIndex = 24;
        lblBlueValue.Text = "0";
        // 
        // lblSpinIntervalValue
        // 
        lblSpinIntervalValue.AutoSize = true;
        lblSpinIntervalValue.Location = new System.Drawing.Point(687, 564);
        lblSpinIntervalValue.Name = "lblSpinIntervalValue";
        lblSpinIntervalValue.Size = new System.Drawing.Size(13, 15);
        lblSpinIntervalValue.TabIndex = 25;
        lblSpinIntervalValue.Text = "0";
        // 
        // tbxAngle
        // 
        tbxAngle.Location = new System.Drawing.Point(680, 522);
        tbxAngle.Name = "tbxAngle";
        tbxAngle.Size = new System.Drawing.Size(142, 23);
        tbxAngle.TabIndex = 26;
        tbxAngle.Text = "0";
        tbxAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // lblAngle
        // 
        lblAngle.Location = new System.Drawing.Point(574, 522);
        lblAngle.Name = "lblAngle";
        lblAngle.Size = new System.Drawing.Size(100, 23);
        lblAngle.TabIndex = 27;
        lblAngle.Text = "Angle";
        lblAngle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // timer1
        // 
        timer1.Tick += timer1_Tick;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(855, 677);
        Controls.Add(lblAngle);
        Controls.Add(tbxAngle);
        Controls.Add(lblSpinIntervalValue);
        Controls.Add(lblBlueValue);
        Controls.Add(lblGreenValue);
        Controls.Add(lblRedValue);
        Controls.Add(lblSpinInterval);
        Controls.Add(trackSpinInterval);
        Controls.Add(checkCCW);
        Controls.Add(tbxEdge);
        Controls.Add(lblEdge);
        Controls.Add(lblBlue);
        Controls.Add(trackBlue);
        Controls.Add(trackGreen);
        Controls.Add(lblGreen);
        Controls.Add(trackRed);
        Controls.Add(lblRed);
        Controls.Add(tbxLength);
        Controls.Add(lblLength);
        Controls.Add(tbxY);
        Controls.Add(tbxX);
        Controls.Add(lblCenter);
        Controls.Add(btnReset);
        Controls.Add(btnRotate);
        Controls.Add(btnDraw);
        Controls.Add(btnSaveFile);
        Controls.Add(btnLoadFile);
        Controls.Add(pictureBox1);
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)trackRed).EndInit();
        ((System.ComponentModel.ISupportInitialize)trackGreen).EndInit();
        ((System.ComponentModel.ISupportInitialize)trackBlue).EndInit();
        ((System.ComponentModel.ISupportInitialize)trackSpinInterval).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Timer timer1;

    private System.Windows.Forms.TextBox tbxAngle;
    private System.Windows.Forms.Label lblRedValue;
    private System.Windows.Forms.Label lblGreenValue;
    private System.Windows.Forms.Label lblBlueValue;
    private System.Windows.Forms.Label lblSpinIntervalValue;

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button btnLoadFile;
    private System.Windows.Forms.Button btnSaveFile;
    private System.Windows.Forms.Button btnDraw;
    private System.Windows.Forms.Button btnRotate;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.Label lblCenter;
    private System.Windows.Forms.TextBox tbxX;
    private System.Windows.Forms.TextBox tbxY;
    private System.Windows.Forms.Label lblLength;
    private System.Windows.Forms.TextBox tbxLength;
    private System.Windows.Forms.Label lblRed;
    private System.Windows.Forms.TrackBar trackRed;
    private System.Windows.Forms.Label lblGreen;
    private System.Windows.Forms.TrackBar trackGreen;
    private System.Windows.Forms.TrackBar trackBlue;
    private System.Windows.Forms.Label lblBlue;
    private System.Windows.Forms.Label lblEdge;
    private System.Windows.Forms.TextBox tbxEdge;
    private System.Windows.Forms.CheckBox checkCCW;
    private System.Windows.Forms.TrackBar trackSpinInterval;
    private System.Windows.Forms.Label lblAngle;
    private System.Windows.Forms.Label lblSpinInterval;

    #endregion
}