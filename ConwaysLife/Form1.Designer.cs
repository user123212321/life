
namespace ConwaysLife
{
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CellTimer = new System.Windows.Forms.Timer(this.components);
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.buttonPauseResume = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelInitialCellPercentage = new System.Windows.Forms.Label();
            this.numericUpDownInitialCellPercentage = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInitialCellPercentage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(12, 530);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(101, 25);
            this.labelSpeed.TabIndex = 0;
            this.labelSpeed.Text = "Speed (ms)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 500);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // CellTimer
            // 
            this.CellTimer.Enabled = true;
            this.CellTimer.Interval = 500;
            this.CellTimer.Tick += new System.EventHandler(this.CellTimer_Tick);
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(119, 530);
            this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(80, 31);
            this.numericUpDownSpeed.TabIndex = 3;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownSpeed.ValueChanged += new System.EventHandler(this.numericUpDownSpeed_ValueChanged);
            // 
            // buttonPauseResume
            // 
            this.buttonPauseResume.Location = new System.Drawing.Point(782, 525);
            this.buttonPauseResume.Name = "buttonPauseResume";
            this.buttonPauseResume.Size = new System.Drawing.Size(112, 34);
            this.buttonPauseResume.TabIndex = 4;
            this.buttonPauseResume.Text = "Pause";
            this.buttonPauseResume.UseVisualStyleBackColor = true;
            this.buttonPauseResume.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonPauseResume_MouseClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(900, 525);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(112, 34);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonReset_MouseClick);
            // 
            // labelInitialCellPercentage
            // 
            this.labelInitialCellPercentage.AutoSize = true;
            this.labelInitialCellPercentage.Location = new System.Drawing.Point(224, 530);
            this.labelInitialCellPercentage.Name = "labelInitialCellPercentage";
            this.labelInitialCellPercentage.Size = new System.Drawing.Size(107, 25);
            this.labelInitialCellPercentage.TabIndex = 0;
            this.labelInitialCellPercentage.Text = "Initial Cell %";
            // 
            // numericUpDownInitialCellPercentage
            // 
            this.numericUpDownInitialCellPercentage.Location = new System.Drawing.Point(337, 530);
            this.numericUpDownInitialCellPercentage.Name = "numericUpDownInitialCellPercentage";
            this.numericUpDownInitialCellPercentage.Size = new System.Drawing.Size(72, 31);
            this.numericUpDownInitialCellPercentage.TabIndex = 6;
            this.numericUpDownInitialCellPercentage.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1023, 564);
            this.Controls.Add(this.numericUpDownInitialCellPercentage);
            this.Controls.Add(this.labelInitialCellPercentage);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonPauseResume);
            this.Controls.Add(this.numericUpDownSpeed);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelSpeed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Conway\'s Game of Life";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInitialCellPercentage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer CellTimer;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Button buttonPauseResume;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelInitialCellPercentage;
        private System.Windows.Forms.NumericUpDown numericUpDownInitialCellPercentage;
    }
}

