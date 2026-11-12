using HraTetris.Jadro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HraTetris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameBoard deska = new GameBoard();
            BlokT blokT = new BlokT();
            Blok0 blok0 = new Blok0();

            // jen maly test - mel by vyskocit error
            blokT.RotacePo();
            blokT.Move(17, -5);
            if (deska.Fits(blokT))
            {
                deska.PolozBlok(blokT);
            }
            else MessageBox.Show("Tetromin T se nevleze na hraci plochu");

            // zobrazi se v pravo dole
            blok0.Move(18, 4);
            if (deska.Fits(blok0))
            {
                deska.PolozBlok(blok0);
            }
            else MessageBox.Show("Tetromin Square se nevleze na hraci plochu");

            deska.PrintDebug();
        }
    }
}
