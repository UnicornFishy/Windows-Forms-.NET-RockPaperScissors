using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    public partial class RockPaperScissorsApp : Form
    {
        // Declerck, M. Rock Image. 2022. Unpublished. Vega BCIS YR1. images created by Maxime Declerck.
        // Declerck, M. Paper Image. 2022. Unpublished. Vega BCIS YR1. images created by Maxime Declerck.
        // Declerck, M. Scissors Image. 2022. Unpublished. Vega BCIS YR1. images created by Maxime Declerck.
        public RockPaperScissorsApp()
       {
            InitializeComponent();

            
         }
        // to make the best of three system.
        //The buttons are a repeat of code so comments in the first button apply to the second and third as well.
        bool gameOnePlayed = false;
        bool gameTwoPlayed = false;
        bool gameThreePlayed = false;
        bool gameFourPlayed = false;

        int playerWins = 0;
        int computerWins = 0;
        int tieGames = 0;


        public void rockBt_Click(object sender, EventArgs e)
       {
            //This button is the code for when a player chooses rock
            // Rock paper scissors game code
            string playerP;
            string computer;
            int randomComputerChoice;


            playerP = ("Rock");
            computer = (" ");

           // random to decide what ai picks
            Random random = new Random();
            randomComputerChoice = random.Next(1, 4);

            switch (randomComputerChoice)
            {
                case 1:
                    computer = ("Rock");
                    break;
                case 2:
                    computer = ("Paper");
                    break;
                case 3:
                    computer = ("Scissors");
                    break;
            }

            //to display what the player and pc picked
            playerOptionLbl.Text = ("Player choice:" + playerP);
            computerOptionLbl.Text = ("Computer choice:" + computer);

            //to decide who won the round
            switch (playerP)
            {
                case "Rock":
                    if (computer == "Rock")
                    {
                        if (gameOnePlayed == false)
                        {
                            gameOnePlayed = true;
                            gameOneWinnerLbl.Text = ("Game 1 Winner: It's a draw");
                            gameTwoWinnerLbl.Visible = true;//to make the next winner label visible
                        }
                        else if (gameTwoPlayed == false)
                        {
                            gameThreeWinnerLbl.Visible = true; //to make the next winner label visible
                            gameTwoPlayed = true;
                            gameTwoWinnerLbl.Text = ("Game 2 Winner: It's a draw");
                        }
                        else if (gameThreePlayed == false)
                        {
                            
                            gameThreePlayed = true;
                            gameThreeWinnerLbl.Text = ("Game 3 Winner: It's a draw");
                        }
                        else if (gameThreePlayed == true)
                        { //tie  breaker game
                            gameFourPlayed = true;
                            gameFourWinnerLbl.Text = ("Game 4 Tie breaker: It's a draw");
                        }
                        tieGames++;//to add to who wins rounds
                    }
                    else if (computer == "Paper")
                    {
                        if (gameOnePlayed == false)
                        {
                            gameOnePlayed = true;
                            gameOneWinnerLbl.Text = ("Game 1 Winner: Computer Wins");
                            gameTwoWinnerLbl.Visible = true;//to make the next winner label visible
                        }
                        else if (gameTwoPlayed == false)
                        {
                            gameThreeWinnerLbl.Visible = true;//to make the next winner label visible
                            gameTwoPlayed = true;
                            gameTwoWinnerLbl.Text = ("Game 2 Winner: Computer Wins");
                        }
                        else if (gameThreePlayed == false)
                        {
                            
                            gameThreePlayed = true;
                            gameThreeWinnerLbl.Text = ("Game 3 Winner: Computer Wins");
                        }
                        else if (gameThreePlayed == true)
                        { //tie  breaker game
                            gameFourPlayed = true;
                            gameFourWinnerLbl.Text = ("Game 4 Tie breaker: Computer Wins");
                        }
                        computerWins++;//to add to who wins rounds
                    }
                    else if (computer == "Scissors")
                    {
                        if (gameOnePlayed == false)
                        {
                            gameOnePlayed = true;//to make the next winner label visible
                            gameOneWinnerLbl.Text = ("Game 1 Winner: Player Wins");
                            gameTwoWinnerLbl.Visible = true;
                        }
                        else if (gameTwoPlayed == false)
                        {
                            gameThreeWinnerLbl.Visible = true;//to make the next winner label visible
                            gameTwoPlayed = true;
                            gameTwoWinnerLbl.Text = ("Game 2 Winner: Player Wins");
                        }
                        else if (gameThreePlayed == false)
                        {
                            
                            gameThreePlayed = true;
                            gameThreeWinnerLbl.Text = ("Game 3 Winner: Player Wins");
                        }
                        else if (gameThreePlayed == true)
                        { //tie  breaker game
                            gameFourPlayed = true;
                            gameFourWinnerLbl.Text = ("Game 4 Tie breaker: Player Wins");
                        }
                        playerWins++;//to add to who wins rounds
                    }
                    break;
                case "Paper":
                    if (computer == "Rock")
                    {
                        if (gameOnePlayed == false)
                        {
                            gameOnePlayed = true;
                            gameOneWinnerLbl.Text = ("Game 1 Winner: Player Wins");
                            gameTwoWinnerLbl.Visible = true;//to make the next winner label visible

                        }
                        else if (gameTwoPlayed == false)
                        {
                            gameThreeWinnerLbl.Visible = true;//to make the next winner label visible
                            gameTwoPlayed = true;
                            gameTwoWinnerLbl.Text = ("Game 2 Winner: Player Wins");
                        }
                        else if (gameThreePlayed == false)
                        {
                            
                            gameThreePlayed = true;
                            gameThreeWinnerLbl.Text = ("Game 3 Winner: Player Wins");
                        }
                        else if (gameThreePlayed == true)
                        { //tie  breaker game
                            gameFourPlayed = true;
                            gameFourWinnerLbl.Text = ("Game 4 Tie breaker:: Player Wins");
                        }
                        playerWins++;//to add to who wins rounds
                    }
                    else if (computer == "Paper")
                    {
                        if (gameOnePlayed == false)
                        {
                            gameOnePlayed = true;
                            gameOneWinnerLbl.Text = ("Game 1 Winner: It's a draw");
                            gameTwoWinnerLbl.Visible = true;//to make the next winner label visible
                        }
                        else if (gameTwoPlayed == false)
                        {
                            gameThreeWinnerLbl.Visible = true;//to make the next winner label visible
                            gameTwoPlayed = true;
                            gameTwoWinnerLbl.Text = ("Game 2 Winner: It's a draw");
                        }
                        else if (gameThreePlayed == false)
                        {
                            
                            gameThreePlayed = true;
                            gameThreeWinnerLbl.Text = ("Game 3 Winner: It's a draw");
                        }
                        else if (gameThreePlayed == true)
                        { //tie  breaker game
                            gameFourPlayed = true;
                            gameFourWinnerLbl.Text = ("Game 4 Tie breaker: It's a draw");
                        }
                        tieGames++;//to add to who wins rounds  
                    }
                    else if (computer == "Scissors")
                    {
                        if (gameOnePlayed == false)
                        {
                            gameOnePlayed = true;
                            gameOneWinnerLbl.Text = ("Game 1 Winner: Computer Wins");
                            gameTwoWinnerLbl.Visible = true;//to make the next winner label visible
                        }
                        else if (gameTwoPlayed == false)
                        {
                            gameThreeWinnerLbl.Visible = true;//to make the next winner label visible
                            gameTwoPlayed = true;
                            gameTwoWinnerLbl.Text = ("Game 2 Winner: Computer Wins");
                        }
                        else if (gameThreePlayed == false)
                        {
                            
                            gameThreePlayed = true;
                            gameThreeWinnerLbl.Text = ("Game 3 Winner: Computer Wins");
                        }
                        else if (gameThreePlayed == true)
                        { //tie  breaker game
                            gameFourPlayed = true;
                            gameFourWinnerLbl.Text = ("Game 4 Tie breaker: Computer Wins");
                        }
                        computerWins++;//to add to who wins rounds
                    }
                    break;
                case "Scissors":
                    if (computer == "Rock")
                    {
                        if (gameOnePlayed == false)
                        {
                            gameOnePlayed = true;
                            gameOneWinnerLbl.Text = ("Game 1 Winner: Computer Wins");
                            gameTwoWinnerLbl.Visible = true;//to make the next winner label visible
                        }
                        else if (gameTwoPlayed == false)
                        {
                            gameThreeWinnerLbl.Visible = true;//to make the next winner label visible
                            gameTwoPlayed = true;
                            gameTwoWinnerLbl.Text = ("Game 2 Winner: Computer Wins");
                        }
                        else if (gameThreePlayed == false)
                        {
                            
                            gameThreePlayed = true;
                            gameThreeWinnerLbl.Text = ("Game 3 Winner: Computer Wins");
                        }
                        else if (gameThreePlayed == true)
                        { //tie  breaker game
                            gameFourPlayed = true;
                            gameFourWinnerLbl.Text = ("Game 4 Tie breaker: Computer Wins");
                        }
                        computerWins++;//to add to who wins rounds
                    }
                    else if (computer == "Paper")
                    {

                        if (gameOnePlayed == false)
                        {
                            gameOnePlayed = true;
                            gameOneWinnerLbl.Text = ("Game 1 Winner: Player Wins");
                            gameTwoWinnerLbl.Visible = true;//to make the next winner label visible
                        }
                        else if (gameTwoPlayed == false)
                        {
                            gameThreeWinnerLbl.Visible = true;//to make the next winner label visible
                            gameTwoPlayed = true;
                            gameTwoWinnerLbl.Text = ("Game 2 Winner: Player Wins");
                        }
                        else if (gameThreePlayed == false)
                        {
                            
                            gameThreePlayed = true;
                            gameThreeWinnerLbl.Text = ("Game 3 Winner: Player Wins");
                        }
                        else if (gameThreePlayed == true)
                        { //tie  breaker game
                            gameFourPlayed = true;
                            gameFourWinnerLbl.Text = ("Game 4 Tie breaker: Player Wins");
                        }
                        playerWins++;//to add to who wins rounds
                    }
                    else if (computer == "Scissors")
                    {
                        if (gameOnePlayed == false)
                        {
                            gameOnePlayed = true;
                            gameOneWinnerLbl.Text = ("Game 1 Winner: It's a draw");
                            gameTwoWinnerLbl.Visible = true;//to make the next winner label visible
                        }
                        else if (gameTwoPlayed == false)
                        {
                            gameThreeWinnerLbl.Visible = true;//to make the next winner label visible
                            gameTwoPlayed = true;
                            gameTwoWinnerLbl.Text = ("Game 2 Winner: It's a draw");
                        }
                        else if (gameThreePlayed == false)
                        {
                            
                            gameThreePlayed = true;
                            gameThreeWinnerLbl.Text = ("Game 3 Winner: It's a draw");
                        }
                        else if (gameThreePlayed == true)
                        { //tie  breaker game
                            gameFourPlayed = true;
                            gameFourWinnerLbl.Text = ("Game 4 Tie breaker: It's a draw");
                        }
                        tieGames++;//to add to who wins rounds
                    }
                    break;

            }
            
            //To Calculate the overall winner
            if (gameThreePlayed == true)
            {
                if (playerWins >= 2)
                {
                    overallWinnerLBL.Text = ("Overal Winner: Player Wins");
                }
                else if (computerWins >= 2)
                {
                    overallWinnerLBL.Text = ("Overal Winner: Computer Wins");
                }
                else if (playerWins != 2 && computerWins != 2)
                {
                    overallWinnerLBL.Text = ("Overal Winner: Time for a tie breaker ");
                    gameFourWinnerLbl.Visible = true;
                }
            }
          //game over label text code
            if (overallWinnerLBL.Text == ("Overal Winner: Player Wins"))
            {
                gameOverLbl.Visible = true;
                gameOverLbl.Text = ("Easy Win GG! Game Over");

            }
            else if (overallWinnerLBL.Text == ("Overal Winner: Computer Wins"))
            {
                gameOverLbl.Visible = true;
                gameOverLbl.Text = ("Unlucky Champ GG! Game Over");
            }

            /**Tie breaker game
            if (gameThreePlayed ==true & overallWinnerLBL.Text == ("Overal Winner: Time for a tie breaker"))
            {

                gameFourWinnerLbl.Visible = true;

            }**/
            //incase after 4 games no one wins
            if (gameFourPlayed == true)
            {
                if (overallWinnerLBL.Text == "Overal Winner: Time for a tie breaker")
                {
                    gameOverLbl.Text = ("It's a tie, you're too evenly matched !");
                }

            }

        }
        public void paperBt_Click(object sender, EventArgs e)
        {
           
            
            //if the player picks paper
            // Rock paper scissors game code
            string playerP;
            string computer;
            int randomComputerChoice;

            playerP = ("Paper");
            computer = (" ");

            //random to decide what ai picks
            Random random = new Random();
            randomComputerChoice = random.Next(1, 4);

            switch (randomComputerChoice)
            {
                case 1:
                    computer = ("Rock");
                    break;
                case 2:
                    computer = ("Paper");
                    break;
                case 3:
                    computer = ("Scissors");
                    break;
            }

            // to display what ai and player pick
            playerOptionLbl.Text = ("Player choice:" + playerP);
            computerOptionLbl.Text = ("Computer choice:" + computer);

            // to decide who wins
            switch (playerP)
            {
                case "Rock":
                    if (computer == "Rock")
                    {
                        if (gameOnePlayed == false)
                        {
                            gameOnePlayed = true;
                            gameOneWinnerLbl.Text = ("Game 1 Winner: It's a draw");
                            gameTwoWinnerLbl.Visible = true;//to make the next winner label visible
                        }
                        else if (gameTwoPlayed == false)
                        {
                            gameThreeWinnerLbl.Visible = true;//to make the next winner label visible
                            gameTwoPlayed = true;
                            gameTwoWinnerLbl.Text = ("Game 2 Winner: It's a draw");
                        }
                        else if (gameThreePlayed == false)
                        {
                            
                            gameThreePlayed = true;
                            gameThreeWinnerLbl.Text = ("Game 3 Winner: It's a draw");
                        }
                        else if (gameThreePlayed == true)
                        { //tie  breaker game
                            gameFourPlayed = true;
                            gameFourWinnerLbl.Text = ("Game 4 Tie breaker: It's a draw");
                        }
                        tieGames++;//to add to who wins rounds
                    }
                    else if (computer == "Paper")
                    {
                        if (gameOnePlayed == false)
                        {
                            gameOnePlayed = true;
                            gameOneWinnerLbl.Text = ("Game 1 Winner: Computer Wins");
                            gameTwoWinnerLbl.Visible = true;//to make the next winner label visible
                        }
                        else if (gameTwoPlayed == false)
                        {
                            gameThreeWinnerLbl.Visible = true;//to make the next winner label visible
                            gameTwoPlayed = true;
                            gameTwoWinnerLbl.Text = ("Game 2 Winner: Computer Wins");
                        }
                        else if (gameThreePlayed == false)
                        {
                            
                            gameThreePlayed = true;
                            gameThreeWinnerLbl.Text = ("Game 3 Winner: Computer Wins");
                        }
                        else if (gameThreePlayed == true)
                        { //tie  breaker game
                            gameFourPlayed = true;
                            gameFourWinnerLbl.Text = ("Game 4 Tie breaker: Computer Wins");
                        }
                        computerWins++;//to add to who wins rounds

                    }
                    else if (computer == "Scissors")
                    {
                        if (gameOnePlayed == false)
                        {
                            gameOnePlayed = true;
                            gameOneWinnerLbl.Text = ("Game 1 Winner: Player Wins");
                            gameTwoWinnerLbl.Visible = true;//to make the next winner label visible
                        }
                        else if (gameTwoPlayed == false)
                        {
                            gameThreeWinnerLbl.Visible = true;//to make the next winner label visible
                            gameTwoPlayed = true;
                            gameTwoWinnerLbl.Text = ("Game 2 Winner: Player Wins");
                        }
                        else if (gameThreePlayed == false)
                        {
                            
                            gameThreePlayed = true;
                            gameThreeWinnerLbl.Text = ("Game 3 Winner: Player Wins");
                        }
                        else if (gameThreePlayed == true)
                        { //tie  breaker game
                            gameFourPlayed = true;
                            gameFourWinnerLbl.Text = ("Game 4 Tie breaker: Player Wins");
                        }
                        playerWins++;//to add to who wins rounds

                    }
                    break;
                case "Paper":
                    if (computer == "Rock")
                    {
                        if (gameOnePlayed == false)
                        {
                            gameOnePlayed = true;
                            gameOneWinnerLbl.Text = ("Game 1 Winner: Player Wins");
                            gameTwoWinnerLbl.Visible = true;//to make the next winner label visible
                        }
                        else if (gameTwoPlayed == false)
                        {
                            gameThreeWinnerLbl.Visible = true;//to make the next winner label visible
                            gameTwoPlayed = true;
                            gameTwoWinnerLbl.Text = ("Game 2 Winner: Player Wins");
                        }
                        else if (gameThreePlayed == false)
                        {
                            
                            gameThreePlayed = true;
                            gameThreeWinnerLbl.Text = ("Game 3 Winner: Player Wins");
                        }
                        else if (gameThreePlayed == true)
                        { //tie  breaker game
                            gameFourPlayed = true;
                            gameFourWinnerLbl.Text = ("Game 4 Tie breaker: Player Wins");
                        }
                        playerWins++;//to add to who wins rounds
                    }
                    else if (computer == "Paper")
                    {
                        if (gameOnePlayed == false)
                        {
                            gameOnePlayed = true;
                            gameOneWinnerLbl.Text = ("Game 1 Winner: It's a draw");
                            gameTwoWinnerLbl.Visible = true;//to make the next winner label visible
                        }
                        else if (gameTwoPlayed == false)
                        {
                            gameThreeWinnerLbl.Visible = true;//to make the next winner label visible
                            gameTwoPlayed = true;
                            gameTwoWinnerLbl.Text = ("Game 2 Winner: It's a draw");
                        }
                        else if (gameThreePlayed == false)
                        {
                            
                            gameThreePlayed = true;
                            gameThreeWinnerLbl.Text = ("Game 3 Winner: It's a draw");
                        }
                        else if (gameThreePlayed == true)
                        { //tie  breaker game
                            gameFourPlayed = true;
                            gameFourWinnerLbl.Text = ("Game 4 Tie breaker: It's a draw");
                        }
                        tieGames++;//to add to who wins rounds

                    }
                    else if (computer == "Scissors")
                    {
                        if (gameOnePlayed == false)
                        {
                            gameOnePlayed = true;
                            gameOneWinnerLbl.Text = ("Game 1 Winner: Computer Wins");
                            gameTwoWinnerLbl.Visible = true;//to make the next winner label visible
                        }
                        else if (gameTwoPlayed == false)
                        {
                            gameThreeWinnerLbl.Visible = true;//to make the next winner label visible
                            gameTwoPlayed = true;
                            gameTwoWinnerLbl.Text = ("Game 2 Winner: Computer Wins");
                        }
                        else if (gameThreePlayed == false)
                        {
                            
                            gameThreePlayed = true;
                            gameThreeWinnerLbl.Text = ("Game 3 Winner: Computer Wins");
                        }
                        else if (gameThreePlayed == true)
                        { //tie  breaker game
                            gameFourPlayed = true;
                            gameFourWinnerLbl.Text = ("Game 4 Tie breaker: Computer Wins");
                        }
                        computerWins++;//to add to who wins rounds

                    }
                    break;
                case "Scissors":
                    if (computer == "Rock")
                    {
                        if (gameOnePlayed == false)
                        {
                            gameOnePlayed = true;
                            gameOneWinnerLbl.Text = ("Game 1 Winner: Computer Wins");
                            gameTwoWinnerLbl.Visible = true;//to make the next winner label visible
                        }
                        else if (gameTwoPlayed == false)
                        {
                            gameThreeWinnerLbl.Visible = true;//to make the next winner label visible
                            gameTwoPlayed = true;
                            gameTwoWinnerLbl.Text = ("Game 2 Winner: Computer Wins");
                        }
                        else if (gameThreePlayed == false)
                        {
                            
                            gameThreePlayed = true;
                            gameThreeWinnerLbl.Text = ("Game 3 Winner: Computer Wins");
                        }
                        else if (gameThreePlayed == true)
                        { //tie  breaker game
                            gameFourPlayed = true;
                            gameFourWinnerLbl.Text = ("Game 4 Tie breaker: Computer Wins");
                        }
                        computerWins++;//to add to who wins rounds

                    }
                    else if (computer == "Paper")
                    {

                        if (gameOnePlayed == false)
                        {
                            gameOnePlayed = true;
                            gameOneWinnerLbl.Text = ("Game 1 Winner: Player Wins");
                            gameTwoWinnerLbl.Visible = true;//to make the next winner label visible
                        }
                        else if (gameTwoPlayed == false)
                        {
                            gameTwoWinnerLbl.Visible = true;//to make the next winner label visible
                            gameTwoPlayed = true;
                            gameTwoWinnerLbl.Text = ("Game 2 Winner: Player Wins");
                            gameThreeWinnerLbl.Visible = true;
                        }
                        else if (gameThreePlayed == false)
                        {
                            
                            gameThreePlayed = true;
                            gameThreeWinnerLbl.Text = ("Game 3 Winner: Player Wins");
                        }
                        else if (gameThreePlayed == true)
                        { //tie  breaker game
                            gameFourPlayed = true;
                            gameFourWinnerLbl.Text = ("Game 4 Tie breaker: player Wins");
                        }
                        playerWins++;//to add to who wins rounds
                    }
                    else if (computer == "Scissors")
                    {
                        if (gameOnePlayed == false)
                        {
                            gameOnePlayed = true;
                            gameOneWinnerLbl.Text = ("Game 1 Winner: It's a draw");
                            gameTwoWinnerLbl.Visible = true;//to make the next winner label visible
                        }
                        else if (gameTwoPlayed == false)
                        {
                            gameThreeWinnerLbl.Visible = true;//to make the next winner label visible
                            gameTwoPlayed = true;
                            gameTwoWinnerLbl.Text = ("Game 2 Winner: It's a draw");
                        }
                        else if (gameThreePlayed == false)
                        {
                            
                            gameThreePlayed = true;
                            gameThreeWinnerLbl.Text = ("Game 3 Winner: It's a draw");
                        }
                        else if (gameThreePlayed == true)
                        { //tie  breaker game
                            gameFourPlayed = true;
                            gameFourWinnerLbl.Text = ("Game 4 Tie breaker: It's a draw");
                        }
                        tieGames++;//to add to who wins rounds

                    }
                    break;
                    
                   

            }
            //To Calculate the overall winner
            if (gameThreePlayed == true)
            {
                if (playerWins >= 2)
                {
                    overallWinnerLBL.Text = ("Overal Winner: Player Wins");
                }
                else if (computerWins >= 2)
                {
                    overallWinnerLBL.Text = ("Overal Winner: Computer Wins");
                }
                else if (playerWins != 2 && computerWins != 2)
                {
                    overallWinnerLBL.Text = ("Overal Winner: Time for a tie breaker");
                    gameFourWinnerLbl.Visible = true;
                }
            }

            if (gameFourPlayed == true)
            {
                gameOverLbl.Visible = true;

            }
           
            //game over label text code
            if (overallWinnerLBL.Text == ("Overal Winner: Player Wins"))
            {
                gameOverLbl.Visible = true;
                gameOverLbl.Text = ("Easy Win GG! Game Over");

            }
            else if (overallWinnerLBL.Text == ("Overal Winner: Computer Wins"))
            {
                gameOverLbl.Visible = true;
                gameOverLbl.Text = ("Unlucky Champ GG! Game Over");
            }

            /**Tie breaker game
            if (gameThreePlayed == true & overallWinnerLBL.Text == ("Overal Winner: Time for a tie breaker"))
            {

                gameFourWinnerLbl.Visible = true;

            }**/
            //incase after 4 games no one wins
            if (gameFourPlayed == true)
            {
                if (overallWinnerLBL.Text == "Overal Winner: Time for a tie breaker")
                {
                    gameOverLbl.Text = ("It's a tie, you're too evenly matched !");
                }

            }
        }
        public void scissorsBt_Click(object sender, EventArgs e)
        {
            // Rock paper scissors game code
            string playerP;
            string computer;
            int randomComputerChoice;

            playerP = ("Scissors");
            computer = (" ");

            // random to decide what ai picks
            Random random = new Random();
            randomComputerChoice = random.Next(1, 4);

            switch (randomComputerChoice)
            {
                case 1:
                    computer = ("Rock");
                    break;
                case 2:
                    computer = ("Paper");
                    break;
                case 3:
                    computer = ("Scissors");
                    break;
            }

            // to display what ai and player pick
            playerOptionLbl.Text = ("Player choice:" + playerP);
            computerOptionLbl.Text = ("Computer choice:" + computer);

            // to deicde who wins
            switch (playerP)
            {
                case "Rock":
                    if (computer == "Rock")
                    {
                        if (gameOnePlayed == false)
                        {
                            gameOnePlayed = true;
                            gameOneWinnerLbl.Text = ("Game 1 Winner: It's a draw");
                            gameTwoWinnerLbl.Visible = true;//to make the next winner label visible
                        }
                        else if (gameTwoPlayed == false)
                        {
                            gameThreeWinnerLbl.Visible = true;//to make the next winner label visible
                            gameTwoPlayed = true;
                            gameTwoWinnerLbl.Text = ("Game 2 Winner: It's a draw");
                        }
                        else if (gameThreePlayed == false)
                        {
                            gameThreePlayed = true;
                            gameThreeWinnerLbl.Text = ("Game 3 Winner: It's a draw");
                        }
                        else if (gameThreePlayed == true)
                        { //tie  breaker game
                            gameFourPlayed = true;
                            gameFourWinnerLbl.Text = ("Game 4 Tie breaker: It's a draw");
                        }
                        tieGames++;//to add to who wins rounds
                    }
                    else if (computer == "Paper")
                    {
                        if (gameOnePlayed == false)
                        {
                            gameOnePlayed = true;
                            gameOneWinnerLbl.Text = ("Game 1 Winner: Computer Wins");
                            gameTwoWinnerLbl.Visible = true;//to make the next winner label visible
                        }
                        else if (gameTwoPlayed == false)
                        {
                            gameThreeWinnerLbl.Visible = true;//to make the next winner label visible
                            gameTwoPlayed = true;
                            gameTwoWinnerLbl.Text = ("Game 2 Winner: Computer Wins");
                        }
                        else if (gameThreePlayed == false)
                        {
                            gameThreePlayed = true;
                            gameThreeWinnerLbl.Text = ("Game 3 Winner: Computer Wins");
                        }
                        else if (gameThreePlayed == true)
                        { //tie  breaker game
                            gameFourPlayed = true;
                            gameFourWinnerLbl.Text = ("Game 4 Tie breaker: Computer Wins");
                        }
                        computerWins++;//to add to who wins rounds

                    }
                    else if (computer == "Scissors")
                    {
                        if (gameOnePlayed == false)
                        {
                            gameOnePlayed = true;
                            gameOneWinnerLbl.Text = ("Game 1 Winner: Player Wins");
                            gameTwoWinnerLbl.Visible = true;//to make the next winner label visible
                        }
                        else if (gameTwoPlayed == false)
                        {
                            gameThreeWinnerLbl.Visible = true;//to make the next winner label visible
                            gameTwoPlayed = true;
                            gameTwoWinnerLbl.Text = ("Game 2 Winner: Player Wins");
                        }
                        else if (gameThreePlayed == false)
                        {
                            gameThreePlayed = true;
                            gameThreeWinnerLbl.Text = ("Game 3 Winner: Player Wins");
                        }
                        else if (gameThreePlayed == true)
                        { //tie  breaker game
                            gameFourPlayed = true;
                            gameFourWinnerLbl.Text = ("Game 4 Tie breaker: Player Wins");
                        }
                        playerWins++;//to add to who wins rounds

                    }
                    break;
                case "Paper":
                    if (computer == "Rock")
                    {
                        if (gameOnePlayed == false)
                        {
                            gameOnePlayed = true;
                            gameOneWinnerLbl.Text = ("Game 1 Winner: Player Wins");
                            gameTwoWinnerLbl.Visible = true;//to make the next winner label visible
                        }
                        else if (gameTwoPlayed == false)
                        {
                            gameThreeWinnerLbl.Visible = true;//to make the next winner label visible
                            gameTwoPlayed = true;
                            gameTwoWinnerLbl.Text = ("Game 2 Winner: Player Wins");
                        }
                        else if (gameThreePlayed == false)
                        {
                            gameThreePlayed = true;
                            gameThreeWinnerLbl.Text = ("Game 3 Winner: Player Wins");
                        }
                        else if (gameThreePlayed == true)
                        { //tie  breaker game
                            gameFourPlayed = true;
                            gameFourWinnerLbl.Text = ("Game 4 Tie breaker: Player Wins");
                        }
                        playerWins++;//to add to who wins rounds

                    }
                    else if (computer == "Paper")
                    {
                        if (gameOnePlayed == false)
                        {
                            gameOnePlayed = true;
                            gameOneWinnerLbl.Text = ("Game 1 Winner: It's a draw");
                            gameTwoWinnerLbl.Visible = true;//to make the next winner label visible
                        }
                        else if (gameTwoPlayed == false)
                        {
                            gameThreeWinnerLbl.Visible = true;//to make the next winner label visible
                            gameTwoPlayed = true;
                            gameTwoWinnerLbl.Text = ("Game 2 Winner: It's a draw");
                        }
                        else if (gameThreePlayed == false)
                        {
                            gameThreePlayed = true;
                            gameThreeWinnerLbl.Text = ("Game 3 Winner: It's a draw");
                        }
                        else if (gameThreePlayed == true)
                        { //tie  breaker game
                            gameFourPlayed = true;
                            gameFourWinnerLbl.Text = ("Game 4 Tie breaker: It's a draw");
                        }
                        tieGames++;//to add to who wins rounds

                    }
                    else if (computer == "Scissors")
                    {
                        if (gameOnePlayed == false)
                        {
                            gameOnePlayed = true;
                            gameOneWinnerLbl.Text = ("Game 1 Winner: Computer Wins");
                            gameTwoWinnerLbl.Visible = true;//to make the next winner label visible
                        }
                        else if (gameTwoPlayed == false)
                        {
                            gameThreeWinnerLbl.Visible = true;//to make the next winner label visible
                            gameTwoPlayed = true;
                            gameTwoWinnerLbl.Text = ("Game 2 Winner: Computer Wins");
                        }
                        else if (gameThreePlayed == false)
                        {
                            gameThreePlayed = true;
                            gameThreeWinnerLbl.Text = ("Game 3 Winner: Computer Wins");
                        }
                        else if (gameThreePlayed == true)
                        { //tie  breaker game
                            gameFourPlayed = true;
                            gameFourWinnerLbl.Text = ("Game 4 Tie breaker: Computer Wins");
                        }
                        computerWins++;//to add to who wins rounds

                    }
                    break;
                case "Scissors":
                    if (computer == "Rock")
                    {
                        if (gameOnePlayed == false)
                        {
                            gameOnePlayed = true;
                            gameOneWinnerLbl.Text = ("Game 1 Winner: Computer Wins");
                            gameTwoWinnerLbl.Visible = true;//to make the next winner label visible
                        }
                        else if (gameTwoPlayed == false)
                        {
                            gameThreeWinnerLbl.Visible = true;//to make the next winner label visible
                            gameTwoPlayed = true;
                            gameTwoWinnerLbl.Text = ("Game 2 Winner: Computer Wins");
                        }
                        else if (gameThreePlayed == false)
                        {
                            gameThreePlayed = true;
                            gameThreeWinnerLbl.Text = ("Game 3 Winner: Computer Wins");
                        }
                        else if (gameThreePlayed == true)
                        { //tie  breaker game
                            gameFourPlayed = true;
                            gameFourWinnerLbl.Text = ("Game 4 Tie breaker: Computer Wins");
                        } 
                        computerWins++; //to add to who wins rounds

                    }
                    else if (computer == "Paper")
                    {

                        if (gameOnePlayed == false)
                        {
                            gameOnePlayed = true;
                            gameOneWinnerLbl.Text = ("Game 1 Winner: Player Wins");
                            gameTwoWinnerLbl.Visible = true;//to make the next winner label visible
                        }
                        else if (gameTwoPlayed == false)
                        {
                            gameThreeWinnerLbl.Visible = true;//to make the next winner label visible
                            gameTwoPlayed = true;
                            gameTwoWinnerLbl.Text = ("Game 2 Winner: Player Wins");
                        }
                        else if (gameThreePlayed == false)
                        {
                            gameThreePlayed = true;
                            gameThreeWinnerLbl.Text = ("Game 3 Winner: Player Wins");
                        }
                        else if (gameThreePlayed == true)
                        { //tie  breaker game
                            gameFourPlayed = true;
                            gameFourWinnerLbl.Text = ("Game 4 Tie breaker: Player Wins");
                        } 
                        playerWins++;//to add to who wins rounds

                    }
                    else if (computer == "Scissors")
                    {
                        if (gameOnePlayed == false)
                        {
                            gameOnePlayed = true;
                            gameOneWinnerLbl.Text = ("Game 1 Winner: It's a draw");
                            gameTwoWinnerLbl.Visible = true;//to make the next winner label visible
                        }
                        else if (gameTwoPlayed == false)
                        {
                            gameThreeWinnerLbl.Visible = true;//to make the next winner label visible0
                            gameTwoPlayed = true;
                            gameTwoWinnerLbl.Text = ("Game 2 Winner: It's a draw");
                        }
                        else if (gameThreePlayed == false)
                        {
                            gameThreePlayed = true;
                            gameThreeWinnerLbl.Text = ("Game 3 Winner: It's a draw");
                        }
                        else if (gameThreePlayed == true)
                        { //tie  breaker game
                            gameFourPlayed = true;
                            gameFourWinnerLbl.Text = ("Game 4 Tie breaker: It's a draw");
                        }
                        tieGames++;//to add to who wins rounds
                    }
                    break;

            }

            //To Calculate the overall winner
            if (gameThreePlayed == true)
            {
                if (playerWins >= 2)
                {
                    overallWinnerLBL.Text = ("Overal Winner: Player Wins");
                }
                else if (computerWins >= 2)
                {
                    overallWinnerLBL.Text = ("Overal Winner: Computer Wins");
                }
                else if (playerWins != 2 && computerWins != 2)
                {
                    overallWinnerLBL.Text = ("Overal Winner: Time for a tie breaker");
                    gameFourWinnerLbl.Visible = true;
                }
            }

            if (gameFourPlayed == true)
            {
                gameOverLbl.Visible = true;

            }
            
            //game over label text code
            if (overallWinnerLBL.Text == ("Overal Winner: Player Wins"))
            {
                gameOverLbl.Visible = true;
                gameOverLbl.Text = ("Easy Win GG! Game Over");

            }
            else if (overallWinnerLBL.Text == ("Overal Winner: Computer Wins"))
            {
                gameOverLbl.Visible = true;
                gameOverLbl.Text = ("Unlucky Champ GG! Game Over");
            }
           
            //incase no one wins
            if (gameFourPlayed == true)
            { if(overallWinnerLBL.Text == "Overal Winner: Time for a tie breaker")
                {
                    gameOverLbl.Text = ("It's a tie, you're too evenly matched !");
                }
                
            }
        }
        public void playAgainBt_Click(object sender, EventArgs e)
        {
            // To reset the game to its original state
            gameOneWinnerLbl.Text = ("Game 1 Winner: ");
            gameTwoWinnerLbl.Text = ("Game 2 Winner: ");
            gameThreeWinnerLbl.Text = ("Game 3 Winner: ");
            gameFourWinnerLbl.Text = ("Game 4 Winner:");
            overallWinnerLBL.Text = ("Overal Winner: ");
            playerOptionLbl.Text = ("Player choice:");
            computerOptionLbl.Text = ("Computer choice");
            gameOverLbl.Text = (" ");
            gameOnePlayed = false;
            gameTwoPlayed = false;
            gameThreePlayed = false;
            gameFourPlayed = false;
            gameFourWinnerLbl.Visible = false;
            gameOverLbl.Visible=false;
            gameTwoWinnerLbl.Visible=false;
            gameThreeWinnerLbl.Visible=false;
            playerWins = 0;
            computerWins = 0;
            tieGames = 0;
            
        }

        private void exitBt_Click(object sender, EventArgs e)
        {
            //to close the form
            this.Close();
            
        }

    }


}
