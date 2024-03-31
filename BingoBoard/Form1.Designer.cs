namespace BingoBoard
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.clearBoard = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Label();
            this.numBallsLabel = new System.Windows.Forms.Label();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.CurrentGame = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.quit = new System.Windows.Forms.Button();
            this.gameTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prize = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lastBallLabel = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(15, 89);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(1542, 554);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(709, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Limon Lions Club Bingo";
            // 
            // clearBoard
            // 
            this.clearBoard.Location = new System.Drawing.Point(171, 1097);
            this.clearBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearBoard.Name = "clearBoard";
            this.clearBoard.Size = new System.Drawing.Size(112, 35);
            this.clearBoard.TabIndex = 3;
            this.clearBoard.Text = "Clear";
            this.clearBoard.UseVisualStyleBackColor = true;
            this.clearBoard.Click += new System.EventHandler(this.clearBoard_Click);
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.Location = new System.Drawing.Point(1491, 665);
            this.timer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(64, 46);
            this.timer.TabIndex = 3;
            this.timer.Text = "14";
            // 
            // numBallsLabel
            // 
            this.numBallsLabel.AutoSize = true;
            this.numBallsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBallsLabel.Location = new System.Drawing.Point(18, 665);
            this.numBallsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numBallsLabel.Name = "numBallsLabel";
            this.numBallsLabel.Size = new System.Drawing.Size(235, 46);
            this.numBallsLabel.TabIndex = 4;
            this.numBallsLabel.Text = "# of balls : 0";
            // 
            // Picture
            // 
            this.Picture.Location = new System.Drawing.Point(820, 665);
            this.Picture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(302, 369);
            this.Picture.TabIndex = 5;
            this.Picture.TabStop = false;
            // 
            // CurrentGame
            // 
            this.CurrentGame.AutoSize = true;
            this.CurrentGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentGame.Location = new System.Drawing.Point(18, 726);
            this.CurrentGame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentGame.Name = "CurrentGame";
            this.CurrentGame.Size = new System.Drawing.Size(304, 46);
            this.CurrentGame.TabIndex = 6;
            this.CurrentGame.Text = "Current Game : ";
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(171, 908);
            this.next.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(112, 35);
            this.next.TabIndex = 2;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // previous
            // 
            this.previous.Location = new System.Drawing.Point(15, 908);
            this.previous.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(112, 35);
            this.previous.TabIndex = 1;
            this.previous.Text = "Previous";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1179, 665);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 46);
            this.label2.TabIndex = 9;
            this.label2.Text = "Next Draw in :";
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(15, 1097);
            this.quit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(112, 35);
            this.quit.TabIndex = 6;
            this.quit.Text = "Exit";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // gameTitle
            // 
            this.gameTitle.AutoSize = true;
            this.gameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle.Location = new System.Drawing.Point(308, 726);
            this.gameTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(366, 46);
            this.gameTitle.TabIndex = 11;
            this.gameTitle.Text = "Small Kite - Orange";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 794);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 46);
            this.label3.TabIndex = 12;
            this.label3.Text = "Current Prize : ";
            // 
            // prize
            // 
            this.prize.AutoSize = true;
            this.prize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prize.Location = new System.Drawing.Point(308, 794);
            this.prize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prize.Name = "prize";
            this.prize.Size = new System.Drawing.Size(163, 46);
            this.prize.TabIndex = 13;
            this.prize.Text = "$187.50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1256, 726);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 46);
            this.label4.TabIndex = 14;
            this.label4.Text = "Last Ball :";
            // 
            // lastBallLabel
            // 
            this.lastBallLabel.AutoSize = true;
            this.lastBallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastBallLabel.Location = new System.Drawing.Point(1464, 726);
            this.lastBallLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastBallLabel.Name = "lastBallLabel";
            this.lastBallLabel.Size = new System.Drawing.Size(0, 46);
            this.lastBallLabel.TabIndex = 15;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(344, 908);
            this.start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(112, 35);
            this.start.TabIndex = 4;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Visible = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(344, 1097);
            this.stop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(112, 35);
            this.stop.TabIndex = 5;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Visible = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1690, 1140);
            this.Controls.Add(this.lastBallLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gameTitle);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.start);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.next);
            this.Controls.Add(this.CurrentGame);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.numBallsLabel);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.clearBoard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Bingo Board";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearBoard;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Label numBallsLabel;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Label CurrentGame;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Label gameTitle;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label prize;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lastBallLabel;
    }
}

