namespace dogRace
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.raceTrackPictureBox = new System.Windows.Forms.PictureBox();
            this.bettingParlor = new System.Windows.Forms.GroupBox();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.bettorsName = new System.Windows.Forms.Label();
            this.betDo = new System.Windows.Forms.Button();
            this.amountBet = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dogBet = new System.Windows.Forms.NumericUpDown();
            this.startRace = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrackPictureBox)).BeginInit();
            this.bettingParlor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogBet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 149);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 211);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // raceTrackPictureBox
            // 
            this.raceTrackPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("raceTrackPictureBox.Image")));
            this.raceTrackPictureBox.Location = new System.Drawing.Point(12, 12);
            this.raceTrackPictureBox.Name = "raceTrackPictureBox";
            this.raceTrackPictureBox.Size = new System.Drawing.Size(661, 238);
            this.raceTrackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.raceTrackPictureBox.TabIndex = 4;
            this.raceTrackPictureBox.TabStop = false;
            // 
            // bettingParlor
            // 
            this.bettingParlor.Controls.Add(this.startRace);
            this.bettingParlor.Controls.Add(this.dogBet);
            this.bettingParlor.Controls.Add(this.label2);
            this.bettingParlor.Controls.Add(this.amountBet);
            this.bettingParlor.Controls.Add(this.betDo);
            this.bettingParlor.Controls.Add(this.bettorsName);
            this.bettingParlor.Controls.Add(this.alBetLabel);
            this.bettingParlor.Controls.Add(this.bobBetLabel);
            this.bettingParlor.Controls.Add(this.joeBetLabel);
            this.bettingParlor.Controls.Add(this.label1);
            this.bettingParlor.Controls.Add(this.alRadioButton);
            this.bettingParlor.Controls.Add(this.bobRadioButton);
            this.bettingParlor.Controls.Add(this.joeRadioButton);
            this.bettingParlor.Controls.Add(this.minimumBetLabel);
            this.bettingParlor.Location = new System.Drawing.Point(12, 271);
            this.bettingParlor.Name = "bettingParlor";
            this.bettingParlor.Size = new System.Drawing.Size(661, 199);
            this.bettingParlor.TabIndex = 5;
            this.bettingParlor.TabStop = false;
            this.bettingParlor.Text = "Betting Parlor";
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(10, 25);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(129, 13);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "Minimun Bet: 5 bucks";
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoEllipsis = true;
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Location = new System.Drawing.Point(13, 64);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(42, 17);
            this.joeRadioButton.TabIndex = 1;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "Joe";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(13, 87);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(44, 17);
            this.bobRadioButton.TabIndex = 2;
            this.bobRadioButton.TabStop = true;
            this.bobRadioButton.Text = "Bob";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(13, 110);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(34, 17);
            this.alRadioButton.TabIndex = 3;
            this.alRadioButton.TabStop = true;
            this.alRadioButton.Text = "Al";
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bets";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBetLabel.Location = new System.Drawing.Point(133, 64);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(250, 15);
            this.joeBetLabel.TabIndex = 5;
            this.joeBetLabel.Text = "Joe hasn\'t placed a bet";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBetLabel.Location = new System.Drawing.Point(133, 87);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(250, 15);
            this.bobBetLabel.TabIndex = 6;
            this.bobBetLabel.Text = "Bob hasn\'t placed a bet";
            // 
            // alBetLabel
            // 
            this.alBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alBetLabel.Location = new System.Drawing.Point(133, 110);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(250, 15);
            this.alBetLabel.TabIndex = 7;
            this.alBetLabel.Text = "Al hasn\'t placed a bet";
            // 
            // bettorsName
            // 
            this.bettorsName.AutoSize = true;
            this.bettorsName.Location = new System.Drawing.Point(13, 156);
            this.bettorsName.Name = "bettorsName";
            this.bettorsName.Size = new System.Drawing.Size(33, 13);
            this.bettorsName.TabIndex = 8;
            this.bettorsName.Text = "name";
            // 
            // betDo
            // 
            this.betDo.Location = new System.Drawing.Point(67, 151);
            this.betDo.Name = "betDo";
            this.betDo.Size = new System.Drawing.Size(75, 23);
            this.betDo.TabIndex = 9;
            this.betDo.Text = "Bets";
            this.betDo.UseVisualStyleBackColor = true;
            this.betDo.Click += new System.EventHandler(this.betDo_Click);
            // 
            // amountBet
            // 
            this.amountBet.Location = new System.Drawing.Point(160, 154);
            this.amountBet.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.amountBet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.amountBet.Name = "amountBet";
            this.amountBet.Size = new System.Drawing.Size(54, 20);
            this.amountBet.TabIndex = 10;
            this.amountBet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "bucks on dog number";
            // 
            // dogBet
            // 
            this.dogBet.Location = new System.Drawing.Point(346, 154);
            this.dogBet.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogBet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogBet.Name = "dogBet";
            this.dogBet.Size = new System.Drawing.Size(60, 20);
            this.dogBet.TabIndex = 12;
            this.dogBet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // startRace
            // 
            this.startRace.Location = new System.Drawing.Point(446, 34);
            this.startRace.Name = "startRace";
            this.startRace.Size = new System.Drawing.Size(200, 102);
            this.startRace.TabIndex = 13;
            this.startRace.Text = "Race!";
            this.startRace.UseVisualStyleBackColor = true;
            this.startRace.Click += new System.EventHandler(this.startRace_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 482);
            this.Controls.Add(this.bettingParlor);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.raceTrackPictureBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrackPictureBox)).EndInit();
            this.bettingParlor.ResumeLayout(false);
            this.bettingParlor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogBet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox raceTrackPictureBox;
        private System.Windows.Forms.GroupBox bettingParlor;
        private System.Windows.Forms.Button startRace;
        private System.Windows.Forms.NumericUpDown dogBet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown amountBet;
        private System.Windows.Forms.Button betDo;
        private System.Windows.Forms.Label bettorsName;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

