using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace casino
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer(Properties.Resources.dealing);

       
        Random randGen = new Random();
       
        List<int> spaids = new List<int>(new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11,
            2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11,
            2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11,
            2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 });



        //int y = randGen.Next(0, spaids.Count);
        int total = 0;
        int dealertotal = 0;

        public Form1()
        {
            InitializeComponent();
        }





        private void hitButton_Click(object sender, EventArgs e)
        {
            int card = randGen.Next(0, spaids.Count);
            total = total + Convert.ToInt16(spaids[card]);


            if (total < 21)
            {
                outputLabel.Text += $"\n{spaids[card]}";
            }
            else if (total == 21)
            {

                textLabel.Text = "blackjack";
                outputLabel.Text += $"\n{spaids[card]}";
                Thread.Sleep(1000);
                Reset();
            }
           
        
            else if (total > 21)
            {
                
                textLabel.Text = "You lose";
                outputLabel.Text += $"\n{spaids[card]}";
                Thread.Sleep(1000);
                Reset();
            }
            spaids.RemoveAt(card);
        }
            
        

        private void standbutton_Click(object sender, EventArgs e)
        {
            int card = randGen.Next(0, spaids.Count);
            dealerLabel.Text += $"\n{spaids[card]}";
            dealertotal = dealertotal + Convert.ToInt16(spaids[card]);
            spaids.RemoveAt(card);



            while (dealertotal < 16)
            {
                card = randGen.Next(0, spaids.Count);
                dealerLabel.Text += $"\n{spaids[card]}";
                dealertotal = dealertotal + Convert.ToInt16(spaids[card]);
                spaids.RemoveAt(card);

            }

            Text = dealertotal.ToString();


            if (total < dealertotal && dealertotal < 22)
            {

                textLabel.Text = "You lose";

                Reset();
            }

            if (dealertotal > 21)
            {

                textLabel.Text = "You win";

                Reset();

            }
            if (dealertotal > 16 && dealertotal < 22)
            {
                if (dealertotal > total)
                {

                    textLabel.Text = "You lose";

                    Reset();

                }
                else if (dealertotal < total)
                {

                    textLabel.Text = "You win";

                    Reset();

                }
                else
                {
                    Reset();
                    textLabel.Text = "Tie";



                }
            }

        }

        private void DealButton_Click(object sender, EventArgs e)
        {
            player.Play();
           
           
            int card = randGen.Next(0, spaids.Count);
            outputLabel.Text += $"\n{spaids[card]}";
            total = total + Convert.ToInt16(spaids[card]);
            spaids.RemoveAt(card);
            Thread.Sleep(1000);

            player.Play();
            card = randGen.Next(0, spaids.Count);
            outputLabel.Text += $"\n{spaids[card]}";
            total = total + Convert.ToInt16(spaids[card]);
            spaids.RemoveAt(card);
            player.Play();

            card = randGen.Next(0, spaids.Count);
            dealerLabel.Text += $"\n{spaids[card]}";
            dealertotal = dealertotal + Convert.ToInt16(spaids[card]);
            spaids.RemoveAt(card);


            if (total == 21)
            {
                Reset();
                textLabel.Text = "blackjack";


            }



        }

        private void Reset()
        {
            Thread.Sleep(1000);
            outputLabel.Text = "Your hand";
            dealerLabel.Text = "Dealers cards";
            dealertotal = 0;
            total = 0;
            spaids.Clear();
            spaids = new List<int>(new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11,
            2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11,
            2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11,
            2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 });

        }
    }
}
