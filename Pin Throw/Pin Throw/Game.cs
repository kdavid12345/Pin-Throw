using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Pin_Throw
{
    public partial class Game : Form
    {
        string difficulty;
        bool sound;
        int pinsLeft;
        int rotation;
        bool playing = true;
        bool gameOver = false;
        bool win = false;
        bool stop = false;
        Random random;
        SoundPlayer click;
        SoundPlayer endgame;

        Bitmap MainCanvas;
        Pen MainPen;
        Graphics MainGraphics;
        Graphics g;

        Thread game;

        List<int> angleOfPinsOnCircle;

        public Game(string difficulty, bool sound)
        {
            this.difficulty = difficulty;
            this.sound = sound;
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            random = new Random();
            click = new SoundPlayer("click.wav");
            endgame = new SoundPlayer();
            TGameStatus.Start();
            angleOfPinsOnCircle = new List<int>();
            SetupDifficulty();

            MainCanvas = new Bitmap(800, 900);
            MainGraphics = Graphics.FromImage(MainCanvas);
            g = CreateGraphics();
            MainPen = new Pen(Color.Black, 2);
            MainGraphics.Clear(Color.White);

            game = new Thread(Play);
            game.IsBackground = true;
            game.Start();
        }

        private void SetupDifficulty()
        {
            switch (difficulty)
            {
                case "Easy":
                    pinsLeft = 3 + random.Next(2);
                    rotation = 1;
                    break;
                case "Medium":
                    angleOfPinsOnCircle.Add(random.Next(90));
                    angleOfPinsOnCircle.Add(random.Next(90, 250));
                    pinsLeft = 5 + random.Next(3);
                    rotation = 2;
                    break;
                case "Hard":
                    angleOfPinsOnCircle.Add(random.Next(150));
                    angleOfPinsOnCircle.Add(random.Next(150, 320));
                    pinsLeft = 6 + random.Next(4);
                    rotation = 3;
                    break;
            }
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Play()
        {
            Point middlepoint = new Point(MainCanvas.Width / 2, MainCanvas.Height / 2 - 200);
            int radius = 85;
            Rectangle bigCircle = new Rectangle(middlepoint.X - radius, middlepoint.Y - radius, 2 * radius, 2 * radius);
            while (playing)
            {
                if (gameOver)
                {
                    if (win)
                    {
                        MainGraphics.Clear(Color.Green);
                        button1.BackColor = Color.Green;
                        button2.BackColor = Color.Green;
                        button1.FlatAppearance.MouseOverBackColor = Color.Green;
                        button1.FlatAppearance.MouseDownBackColor = Color.Green;
                        button2.FlatAppearance.MouseOverBackColor = Color.Green;
                        button2.FlatAppearance.MouseDownBackColor = Color.Green;
                        endgame.SoundLocation = "win.wav";
                    }
                    else
                    {
                        MainGraphics.Clear(Color.Red);
                        button1.BackColor = Color.Red;
                        button2.BackColor = Color.Red;
                        button1.FlatAppearance.MouseOverBackColor = Color.Red;
                        button1.FlatAppearance.MouseDownBackColor = Color.Red;
                        button2.FlatAppearance.MouseOverBackColor = Color.Red;
                        button2.FlatAppearance.MouseDownBackColor = Color.Red;
                        endgame.SoundLocation = "fail.wav";
                    }
                    stop = true;
                }
                else
                {
                    MainGraphics.Clear(Color.White);
                    button1.BackColor = Color.White;
                    button2.BackColor = Color.White;
                    button1.FlatAppearance.MouseOverBackColor = Color.White;
                    button1.FlatAppearance.MouseDownBackColor = Color.White;
                    button2.FlatAppearance.MouseOverBackColor = Color.White;
                    button2.FlatAppearance.MouseDownBackColor = Color.White;
                }

                MainGraphics.FillEllipse(Brushes.Black, bigCircle);

                for (int i = pinsLeft; i > 0; i--)
                {
                    MainGraphics.FillEllipse(Brushes.Black, new Rectangle(middlepoint.X - 22, 460 + i * 50, 35, 35));
                }

                for (int i = 0; i < angleOfPinsOnCircle.Count; i++)
                {
                    PointF pointOnCircle = PointOnCircle(radius + 130, angleOfPinsOnCircle[i], middlepoint);
                    RectangleF littleCircle = new RectangleF(0, 0, 35, 35);
                    littleCircle.X = pointOnCircle.X - (littleCircle.Width / 2);
                    littleCircle.Y = pointOnCircle.Y - (littleCircle.Height / 2);
                    MainGraphics.FillEllipse(Brushes.Black, littleCircle);
                    MainGraphics.DrawLine(MainPen, middlepoint, pointOnCircle);

                    for (int j = 0; j < angleOfPinsOnCircle.Count; j++)
                    {
                        if (j != i && Math.Abs(angleOfPinsOnCircle[i] - angleOfPinsOnCircle[j]) < 10)
                        {
                            gameOver = true;
                            break;
                        }
                    }
                    if (gameOver)
                    {
                        break;
                    }

                    if (angleOfPinsOnCircle[i] == 360)
                    {
                        angleOfPinsOnCircle[i] = 1;
                    }
                    else if (angleOfPinsOnCircle[i] == 0)
                    {
                        angleOfPinsOnCircle[i] = 359;
                    }
                    else
                    {
                        angleOfPinsOnCircle[i] += rotation;
                    }
                }

                MainGraphics.DrawString(String.Format("{0,2}", pinsLeft),
                        new Font("Courier New", 50F, FontStyle.Regular, GraphicsUnit.Point),
                        (gameOver) ? ((win) ? Brushes.Green : Brushes.Red) : Brushes.White,
                        (pinsLeft > 9) ? middlepoint.X - 50 : middlepoint.X - 72, middlepoint.Y - 32);

                if (!gameOver && pinsLeft == 0)
                {
                    win = true;
                    gameOver = true;
                }

                g.DrawImage(MainCanvas, 0, 0);

                if (stop)
                {
                    playing = false;
                }
            }
        }

        private PointF PointOnCircle(int radius, int angle, Point middlepoint)
        {
            float x = (float)(middlepoint.X + radius * Math.Cos(angle * Math.PI / 180F));
            float y = (float)(middlepoint.Y + radius * Math.Sin(angle * Math.PI / 180F));
            return new PointF(x, y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!gameOver && pinsLeft > 0)
            {
                pinsLeft--;
                angleOfPinsOnCircle.Add(90);
                if (difficulty == "Hard")
                {
                    angleOfPinsOnCircle.Add(270);
                    rotation *= -1;
                }
                else if (difficulty == "Medium")
                {
                    rotation *= -1;
                }
                if (sound)
                    click.Play();
            }
        }

        private void TGameStatus_Tick(object sender, EventArgs e)
        {
            if (!playing)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                LFill.Visible = true;
                LGameOver.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                LFill.SendToBack();
                if (win)
                {
                    LGameOver.Text = "Siker!";
                    LFill.BackColor = Color.Green;
                    if (sound)
                        endgame.Play();
                }
                else
                {
                    LGameOver.Text = "Vége!";
                    LFill.BackColor = Color.Red;
                    if (sound)
                        endgame.Play();
                }
                TGameStatus.Stop();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LFill.Visible = false;
            LGameOver.Visible = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Visible = false;
            button4.Visible = false;
            playing = true;
            gameOver = false;
            win = false;
            stop = false;
            click.Dispose();
            endgame.Dispose();
            endgame = new SoundPlayer();
            click = new SoundPlayer("click.wav");
            angleOfPinsOnCircle.Clear();
            SetupDifficulty();
            button1.Focus();
            game = new Thread(Play);
            game.IsBackground = true;
            game.Start();
            TGameStatus.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LFill.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            this.Close();
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                button1_Click(new object(), EventArgs.Empty);
            }
        }
    }
}
