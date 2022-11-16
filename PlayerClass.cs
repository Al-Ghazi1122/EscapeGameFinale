using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Quiz
{
    internal class PlayerClass
    {
        public string UserName { get; }
        private int NumOfLogins { get; set; }
        private string Password { get; set; }
        private decimal Score { get; set; }

        public PlayerClass(string name, string password, int numOflogins = 1, decimal score = 0)
        {
            UserName = name;
            Password = password;
            NumOfLogins = numOflogins;
            Score = score;

        }
        public bool checkPasssword(string inPassword)
        {
            if (inPassword == Password)
            { return true; }
            else
            { return false; }
        }
        public void updateScore(int scoreIncrease)
        {
            Score = Score + scoreIncrease;
        }
        public void updateScore(decimal scoreIncrease)
        { 
            Score = Score + scoreIncrease;
        }
        public void updateLogins()
        {
            NumOfLogins++;
        }
        public string getPlayerDetails()
        {
            return (UserName + "has log in" + NumOfLogins.ToString() + " and has a score of " + Score);
        }
    }
}
