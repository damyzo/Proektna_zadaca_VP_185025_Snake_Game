using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        private  static string filePath = @"../../SaveScore.txt";
        private string[] lines = File.ReadAllLines(filePath);
        //Lista za snake
        private List<Circle> Snake = new List<Circle>();
        //Objekt od tip Circle za snake food
        private Circle food = new Circle();
        int foodCount = 1;
        

        public Form1()
        {
            InitializeComponent();
            Settings.StartGame = true;
            //Settings za snake default vrednost
            new Settings();

            //Setiranje na brzina i zapocnuvanje na tajmerot
            gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();

            //Zapocnuvanje na nova igra
            StartGame();

        }

       

        private void StartGame()
        {
            
            lblHighScore.Text = lines[0];
            lblGameOver.Visible = false;
            lblStartGame.Visible = false;
            

            //Settings za snake default vrednost
            new Settings();
            Settings.Score = 0;

            //Nov objekt od tip Circle koj kje se koristi kako glava na Snake
            //Kreiranje na nov igrach

            //Brishenje na listata
            Snake.Clear();
            Circle head = new Circle();
            head.x = 10;
            head.y = 5;
            Snake.Add(head);
            Circle tale = new Circle();
            tale.x = 20;
            tale.y = 15;
            Snake.Add(tale);

            lblScore.Text = Settings.Score.ToString();
            GenerateFood();
        }


        
        private void GenerateFood()
        {
            //Kreiranje na Food

            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;

            Random random = new Random();
            
            food = new Circle();
            food.x = random.Next(0, maxXPos);
            food.y = random.Next(0, maxYPos);
            
           
            
            
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            if(Settings.StartGame)
            {   //Proverka za pocetok
                if(Input.keyPressed(Keys.S))
                {
                    StartGame();
                    Settings.StartGame = false;
                }
            }
            else if(Settings.GameOver)
            {
                //Proverka za kraj na igrata
                if (Input.keyPressed(Keys.Enter)){
                    StartGame();
                }
            }
            else
            {
                if(Input.keyPressed(Keys.Right) && Settings.direction != Direction.Left)
                {
                    Settings.direction = Direction.Right;
                }
                else if (Input.keyPressed(Keys.Left) && Settings.direction != Direction.Right)
                {
                    Settings.direction = Direction.Left;
                }
                else if (Input.keyPressed(Keys.Up) && Settings.direction != Direction.Down)
                {
                    Settings.direction = Direction.Up;
                }
                else if (Input.keyPressed(Keys.Down) && Settings.direction != Direction.Up)
                {
                    Settings.direction = Direction.Down;
                }

                movePlayer();
            }

            pbCanvas.Invalidate();
        }

        private void movePlayer()
        {
           for(int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch(Settings.direction)
                    {
                        case Direction.Right:
                            Snake[i].x++;
                            break;
                        case Direction.Left:
                            Snake[i].x--;
                            break;
                        case Direction.Up:
                            Snake[i].y--;
                            break;
                        case Direction.Down:
                            Snake[i].y++;
                            break;
                    }

                    int maxXPos = pbCanvas.Size.Width / Settings.Width;
                    int maxYPos = pbCanvas.Size.Height / Settings.Height;

                    // Detekcija na sudir so dzid
                    if (Snake[i].x < 0 || Snake[i].y < 0 || Snake[i].x >= maxXPos || Snake[i].y >= maxYPos) 
                    {
                        Die();
                    }

                    

                    // Detekcija so food
                    if(Snake[0].x == food.x && Snake[0].y == food.y)
                    {
                       Eat();
                    }
                }
                else
                {
                    Snake[i].x = Snake[i - 1].x;
                    Snake[i].y = Snake[i - 1].y;
                }
            }
            for(int i=1; i < Snake.Count; i++)
             {
                 if (Snake[0].x == Snake[i].x && Snake[0].y == Snake[i].y )
                 {
                     Die();
                 }
             }
        }
        private void Eat()
        {
            
            
            if(foodCount%4 != 0)
            {
                Circle food = new Circle();
                food.x = Snake[Snake.Count - 1].x;
                food.y = Snake[Snake.Count - 1].y;

                Snake.Add(food);

                Settings.Score += Settings.Points;
                lblScore.Text = Settings.Score.ToString();

                GenerateFood();
            }
            else
            {
                Circle food = new Circle();
                food.x = Snake[Snake.Count - 1].x;
                food.y = Snake[Snake.Count - 1].y;

                Snake.Add(food);

                Circle food1 = new Circle();
                food1.x = Snake[Snake.Count - 1].x;
                food1.y = Snake[Snake.Count - 1].y;

                Snake.Add(food1);

                Circle food2 = new Circle();
                food2.x = Snake[Snake.Count - 1].x;
                food2.y = Snake[Snake.Count - 1].y;

                Snake.Add(food2);

                Settings.Score += 3;
                lblScore.Text = Settings.Score.ToString();
                GenerateFood();

            }
            foodCount++;


        }

        private void Die()
        {
            foodCount = 1;
            int v = Int32.Parse(lines[0]);
            Settings.HighScore = v;
            if(Settings.Score > Settings.HighScore)
            {
                Settings.HighScore = Settings.Score;
                lblHighScore.Text = Settings.HighScore.ToString();
                lines[0] = Settings.HighScore.ToString();
                File.WriteAllLines(filePath, lines);
            }
            
            Settings.GameOver = true;
        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if(Settings.StartGame)
            {
                string startGame = "Press S to strart !";
                lblStartGame.Text = startGame;
                lblStartGame.Visible = true;
                
                                
                    
            }
            else if(!Settings.GameOver)
            {
                Brush snakeColor;

                //Cranje na Snake
                for(int i = 0; i< Snake.Count; i++)
                {
                    if(i == 0)
                    {
                        snakeColor = Brushes.Black;
                    }
                    else
                    {
                        snakeColor = Brushes.Green;
                    }

                    
                    canvas.FillEllipse(snakeColor, new Rectangle(
                        Snake[i].x * Settings.Width,
                        Snake[i].y * Settings.Height,
                        Settings.Width,
                        Settings.Height
                        ));
                    if(foodCount % 4 != 0)
                    {
                       canvas.FillEllipse(Brushes.Red,
                       new Rectangle(
                       food.x * Settings.Width, food.y * Settings.Height, Settings.Width, Settings.Height));
                    }
                    else
                    {
                        canvas.FillEllipse(Brushes.Orange,
                        new Rectangle(
                        food.x * Settings.Width - 5, food.y * Settings.Height - 5, Settings.Width + 5, Settings.Height + 5));
                       
                    }
                    

                }
            }
            else
            {
                string gameOver = "Game over \nYour score is: " + Settings.Score + "\n Press Enter to try again";
                lblGameOver.Text = gameOver;
                lblGameOver.Visible = true;

                
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.changeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.changeState(e.KeyCode, false);
        }

        
    }
}
