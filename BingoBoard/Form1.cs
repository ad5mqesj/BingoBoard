using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ini;
using System.IO;

namespace BingoBoard
{
	public partial class Form1 : Form
	{
		private bool[,] cellState;
		private int ballsSoFar = 0;
		private string lastBall = "";
		private int lastRow = 0, lastCol = 0;
		private Timer nextBallTimer;
		private int remainingTime = 0;
		private IniFile ini;
		private int gameNum = 1;
		private int maxGames = 9;
		private List<Image> boardImages;
		private int imageIndex;
		private Timer nextImageTimer = null;
		private char[] rowTitles = { 'B', 'I', 'N', 'G', 'O' };
        private int defaulttimeout = 12;
        private int timeout = 12;
        private int lastClickTime = 0;
        bool random = false;
        Random rndNum = new Random();
        bool [] selected = new bool [75];

        public Form1()
		{
			InitializeComponent();
			cellState = new bool[5, 15];
			nextBallTimer = new Timer();
			nextBallTimer.Tick += new EventHandler(TimerEventProcessor);
			nextBallTimer.Interval = 1000;

			int height = Screen.PrimaryScreen.Bounds.Height;
			int width = Screen.PrimaryScreen.Bounds.Width - 40;

			this.WindowState = FormWindowState.Maximized;
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.ColumnHeadersVisible = false;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.ScrollBars = ScrollBars.None;
			dataGridView1.ColumnCount = 16;
			dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
			int cellWidth = width / 16;
			dataGridView1.Width = width - 10;
			dataGridView1.Height = cellWidth * 5;
			dataGridView1.DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Bold);
			dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridView1.DefaultCellStyle.BackColor = Color.Gray;
			dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Purple;
			dataGridView1.MultiSelect = false;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
			dataGridView1.AllowDrop = false;

			dataGridView1.DefaultCellStyle.ForeColor = Color.White;
			dataGridView1.DefaultCellStyle.Font = new Font("Ariel", 18);
			dataGridView1.Columns[0].Width = cellWidth;

			for (int i = 0; i < rowTitles.Length; i++)
			{
				DataGridViewRow tempRow = new DataGridViewRow();
				DataGridViewCell cell0 = new DataGridViewTextBoxCell();
				cell0.Value = String.Format("{0}", rowTitles[i]);
				cell0.Style.BackColor = Color.White;
				cell0.Style.ForeColor = Color.Blue;
				cell0.Style.Font = new Font("Ariel", 32, FontStyle.Bold);

				tempRow.Cells.Add(cell0);
				for (int j = 1; j < 16; j++)
				{
					cellState[i, j - 1] = false;
					dataGridView1.Columns[j].Width = cellWidth;
					DataGridViewCell celln = new DataGridViewTextBoxCell();
					celln.Value = String.Format("{0}", j + 15 * i);
					tempRow.Cells.Add(celln);
				}
				tempRow.Height = cellWidth;
				dataGridView1.Rows.Add(tempRow);
			}
			dataGridView1.Rows[4].Frozen = true;

			numBallsLabel.Top = dataGridView1.Height + dataGridView1.Location.Y + 20;
			label2.Top = numBallsLabel.Top;
			timer.Top = numBallsLabel.Top;
			timer.Left = dataGridView1.Right - 44;
			label2.Left = timer.Left - (184 + 24);
			label4.Top = label2.Top + 46;
			lastBallLabel.Top = label4.Top;
			lastBallLabel.Left = dataGridView1.Right - 62;
			label4.Left = dataGridView1.Right - 199;

			CurrentGame.Top = numBallsLabel.Top + 46;
			label3.Top = CurrentGame.Top + 46;
			prize.Top = label3.Top;
			gameTitle.Top = CurrentGame.Top;
			clearBoard.Top = height - 72;
			next.Top = prize.Top + 74;
			previous.Top = prize.Top + 74;
			quit.Top = height - 72;
			Picture.Top = numBallsLabel.Top;
			Picture.Left = (dataGridView1.Right - dataGridView1.Left) / 2 + 50;
            remainingTime = timeout;
            timer.Text = remainingTime.ToString();
            LoadGame();
		}


		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
            int r = e.RowIndex;
            int c = e.ColumnIndex;
            clickCell(r, c);
        }

        void clickCell (int r, int c)
        {
            if (r > 4 || r < 0 || c < 1 || c > 16)
                return;

            if (nextBallTimer.Enabled && (r != lastRow || c != lastCol))
                return;
            if (lastClickTime == remainingTime)
                return;

            if (!cellState[r, c - 1])
            {
                DataGridViewCellStyle CellStyle = new DataGridViewCellStyle();
                CellStyle.BackColor = Color.White;
                CellStyle.ForeColor = Color.Blue;
                CellStyle.Font = new Font("Ariel", 28);
                dataGridView1.Rows[r].Cells[c].Style = CellStyle;
                ballsSoFar++;
                numBallsLabel.Text = String.Format("# of balls : {0}", ballsSoFar);
                remainingTime = timeout;
                timer.Text = remainingTime.ToString();
                nextBallTimer.Start();
                lastClickTime = remainingTime;
                lastBall = string.Format("{0}{1}", rowTitles[r], c + 15 * r);
                lastBallLabel.Text = lastBall;
            }
            else
            {
                DataGridViewCellStyle CellStyle = new DataGridViewCellStyle();
                CellStyle.BackColor = Color.Gray;
                CellStyle.ForeColor = Color.White;
                CellStyle.Font = new Font("Ariel", 18);
                dataGridView1.Rows[r].Cells[c].Style = CellStyle;
                nextBallTimer.Stop();
                ballsSoFar--;
                numBallsLabel.Text = String.Format("# of balls : {0}", ballsSoFar);
                remainingTime = timeout;
                timer.Text = remainingTime.ToString();
                lastClickTime = 0;
            }
            cellState[r, c - 1] = !cellState[r, c - 1];
            lastCol = c;
            lastRow = r;
        }
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
		{
			remainingTime--;
			timer.Text = remainingTime.ToString();
            if (remainingTime == 0)
            {
                nextBallTimer.Stop();
                if (random)
                {
                    int next = 0;
                    bool newRnd = false;
                    while ( !newRnd)
                    {
                       next  = rndNum.Next(1, 75);
                        newRnd = !selected[next - 1];
                    }
                    if (newRnd)
                    {
                        selected[next - 1] = newRnd;
                        int c = (next % 15);
                        int r = next / 15;
                        if (r > 4 || r < 0 || c < 1 || c > 16)
                        {
                            remainingTime = timeout;
                            timer.Text = remainingTime.ToString();
                            nextBallTimer.Start();
                            lastClickTime = remainingTime;
                        }
                        clickCell(r, c);
                    }

                }
            }
		}

		private void clearBoard_Click(object sender, EventArgs e)
		{
			if (nextBallTimer.Enabled)
				return;
			BoardClear();
		}

		private void quit_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}

		private void next_Click(object sender, EventArgs e)
		{
			if (nextBallTimer.Enabled)
				return;
			gameNum++;
			if (gameNum > maxGames) gameNum = 1;
            LoadGame();
            BoardClear();
		}

		private void previous_Click(object sender, EventArgs e)
		{
			if (nextBallTimer.Enabled)
				return;
			gameNum--;
			if (gameNum < 1) gameNum = maxGames;
      LoadGame();
      BoardClear();
		}

		private void LoadGame()
		{
			string workingDir = Environment.CurrentDirectory;
			string configFile = String.Format("{0}\\Games\\{1}\\config.ini", workingDir, gameNum);
			string test = String.Format("{0}\\Games\\{1}", workingDir, gameNum.ToString());

			ini = new IniFile(configFile);
			string iniGameNum = ini.IniReadValue("Game", "number");
			int readNum;
			Int32.TryParse(iniGameNum, out readNum);
			if (readNum != gameNum)
			{
				MessageBox.Show("Configuration Error", "BingoBoard", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
				return;
			}
			string color = ini.IniReadValue("Game", "Sheet");
			string pattern = ini.IniReadValue("Game", "Title");
			string prizeVal = ini.IniReadValue("Game", "prize");
            string timeoutval = ini.IniReadValue("Game", "timeout");
            if (!string.IsNullOrEmpty(timeoutval))
            {
                int.TryParse(timeoutval, out timeout);
            }
            else
            {
                timeout = defaulttimeout;
            }
            string randomVal = ini.IniReadValue("Game", "random");
            this.random = randomVal.ToLower().Contains("true");
			gameTitle.Text = pattern + " - " + color;
			prize.Text = string.Format("$ {0}", prizeVal);
			LoadImages();
		}

		private void LoadImages()
		{
			if (nextImageTimer != null)
				nextImageTimer.Stop();
			imageIndex = 0;
			boardImages = new List<Image>();
			string configDir = String.Format("{0}\\Games\\{1}", Environment.CurrentDirectory, gameNum);
			IEnumerable<string> files = Directory.EnumerateFiles(configDir, "*.png", SearchOption.AllDirectories);
			foreach (string curFile in files)
			{
				boardImages.Add(Image.FromFile(curFile));
			}
			Picture.Image = boardImages[imageIndex++];
			if (boardImages.Count > 1)
			{
				nextImageTimer = new Timer();
				nextImageTimer.Tick += new EventHandler(ImageTimerEventProcessor);
				nextImageTimer.Interval = 1000;
				nextImageTimer.Start();
			}
		}

		private void ImageTimerEventProcessor(Object myObject, EventArgs myEventArgs)
		{
			Picture.Image = boardImages[imageIndex++];
			if (imageIndex == boardImages.Count) imageIndex = 0;
		}

		private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected == true)
				{
					e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);
					using (Pen p = new Pen(Color.Blue, 4))
					{
						Rectangle rect = e.CellBounds;
						rect.Width -= 2;
						rect.Height -= 2;
						e.Graphics.DrawRectangle(p, rect);
					}
					e.Handled = true;
				}
			}
		}

        private void start_Click(object sender, EventArgs e)
        {
            remainingTime = timeout;
            lastClickTime = remainingTime;

            nextBallTimer.Start();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            remainingTime = timeout;
            nextBallTimer.Stop();
        }

        private void BoardClear()
		{
			for (int i = 0; i < 5; i++)
			{
				for (int j = 1; j < 16; j++)
				{
					cellState[i, j - 1] = false;
					DataGridViewCellStyle CellStyle = new DataGridViewCellStyle();
					CellStyle.BackColor = Color.Gray;
					CellStyle.ForeColor = Color.White;
					CellStyle.Font = new Font("Ariel", 18);
					dataGridView1.Rows[i].Cells[j].Style = CellStyle;
				}
			}
			ballsSoFar = 0;
			numBallsLabel.Text = String.Format("# of balls : {0}", ballsSoFar);
			remainingTime = timeout;
			timer.Text = remainingTime.ToString();
			lastBallLabel.Text = "";
			lastClickTime = 0;
            for (int i = 0; i < 75; i++)
            {
                selected[i] = false;
            }
		}
	}
}
