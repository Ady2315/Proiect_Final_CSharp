using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_FInal
{
    public partial class InGame : Form
    {
        Int16 x = 579, y = 519, xMos = 300;
        Point pozCopil, pozMos, pozCadou;
        int LeftWindow, RightWindow;
        sbyte CharacterSpeed = 20, SantaSpeed = 10;
        bool MoveLeft = false, MoveRight = false;
        sbyte SantaDirection = 1;
        int vitezaCadou = 5;
        int scor = 0, pierdute = 0;

        internal Meniu Meniu;

        private void InGame_Load(object sender, EventArgs e)
        {
            LeftWindow = 1;
            RightWindow = RightWindowObject(KidCharacter.Size.Width, 15);
        }

        private void InGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) MoveLeft = false;
            if (e.KeyData == Keys.Right) MoveRight = false;
        }

        private void InGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Meniu.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CharacterMovement();
            SantaMovement();
        }

        public InGame()
        {
            InitializeComponent();

            pozCopil.Y = DownWindowObject(KidCharacter.Size.Height, KidCharacter.Size.Height / 4);
            DoubleBuffered = true;
            Santa.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);

            pozCadou.X = 300;
            pozCadou.Y = 105;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pozCadou.Y += vitezaCadou;
            if (pozCadou.Y >= DownWindowObject(pictureBoxCadou.Size.Height, 10))
            {
                pozCadou.Y = 105;
                pozCadou.X = pozMos.X;
                pierdute++;
                labelPierdute.Text = "PIERDUTE\n" + pierdute + "/3";

                if (pierdute == 3)
                {
                    timer1.Stop();
                    timer2.Stop();
                    MessageBox.Show("Ai pierdut!\nAi strans " + scor + " cadouri");
                    Meniu.UpdatePlayerHighScore(scor);
                    this.Dispose();
                    Meniu.Show();
                }
            }
            if (pictureBoxCadou.Bounds.IntersectsWith(KidCharacter.Bounds))
            {
                pozCadou.Y = 105;
                pozCadou.X = pozMos.X;
                scor++;
                labelScor.Text = "SCOR\n" + scor;

                if (scor % 5 == 0)
                {
                    vitezaCadou++;
                    SantaSpeed++;
                }
            }
            pictureBoxCadou.Invalidate();
            pictureBoxCadou.Location = pozCadou;
        }

        private void InGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) MoveLeft = true;
            if (e.KeyData == Keys.Right) MoveRight = true;
        }

        private void CharacterMovement()
        {
            if (MoveLeft) x -= CharacterSpeed;
            if (MoveRight) x += CharacterSpeed;

            if (x <= LeftWindow) x = (Int16)LeftWindow;
            if (x >= RightWindow) x = (Int16)RightWindow;
            pozCopil.X = x;
            KidCharacter.Invalidate();
            KidCharacter.Location = pozCopil;
        }

        private void SantaMovement()
        {
            xMos += (Int16) (SantaSpeed * SantaDirection);
            pozMos.X = xMos;
            Santa.Invalidate();
            Santa.Location = pozMos;
            if (Santa.Location.X >= RightWindowObject(Santa.Size.Width, 20) || Santa.Location.X <= 1)
            {
                SantaDirection *= -1;
                Santa.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
        }

        private int RightWindowObject(int obiectWidth, int diff)
        {
            return this.Size.Width - obiectWidth - diff;
        }
        private int DownWindowObject(int obiectHeight, int diff)
        {
            return this.Size.Height - obiectHeight - diff;
        }
    }
}
