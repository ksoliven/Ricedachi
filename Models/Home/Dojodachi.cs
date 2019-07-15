using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Dojodachi.Models
    {
        public class Dachi
        {

            public int Happiness {get; set;}
            public int Fullness {get; set;}
            public int Energy {get; set;}
            public int Meals {get; set;}
            public int Status {get; set;}
            public string message {get; set;}
        
        public Dachi()
        {   
            
            Happiness = 20;
            Fullness = 20;
            Energy = 50;
            Meals = 3;
            message = "You encountered the Ricedachi!";
            Status = 1;
        }
        public void Feed()
        {
            if(Meals > 0)
            {
                Random rand = new Random();
                int prob = rand.Next(4);
                Meals--;
                if(prob == 0)
                {
                    message ="The Ricedachi is being picky and does not want to eat.";
                }
                else
                {
                    int dachFull = rand.Next(5, 11);
                    Fullness += dachFull;
                    message = $"The Ricedachi enjoyed their meal or water and rice. Fullness increased by {dachFull} and Meal decreased by 1.";
                }
            }
            else
            {
                message = "The Ricedachi ran out of water and rice. Sorry! Try Again!";
            }
            Check();
        }            
        public void Play()
        {
            if (Energy > 4)
            {
                Random rand = new Random();
                int prob = rand.Next(4);
                Energy -=5;
                if(prob == 0)
                {
                    message = "The Ricedachi does not feel like playing..maybe next time!";
                }
                else
                {
                int dachHappy = rand.Next(5, 11);
                Happiness += dachHappy;
                message = $"The Ricedachi enjoyed playing with you! Happiness increased by {dachHappy} and Energy decreased by 5";
                }            
            }
            else{
                message ="Ricedachi ran out of energy! Maybe you should plug Ricedachi in an outlet next time!";
            }
        }
    
        public void Work()
        {
            if (Energy > 4)
                {
                    Random rand = new Random();
                    int prob = rand.Next(4);
                    Energy -=5;
                    if(prob == 0){
                        message ="Ricedachi is too lazy and does not want to play";
                    }
                    else
                    {
                    int dachMeals = rand.Next(1, 3);
                    Meals += dachMeals;
                    message = $"The Ricedachi worked really hard. Meals incresed by {dachMeals} and Energy decreased by 5";
                    }
                }
            else{
                message = "Ricedachi ran out of meals and can not work.";
                }
            }

        public void Sleep()
            {
                Energy += 15;
                Fullness -=5;
                Happiness -=5;
                message = $"The Ricedachi takes a well deserved nap! So refreshing! Energy is increased by {Energy}, Fullness decreased by {Fullness} and Happiness decreased by {Happiness}";
            Check();
            }
        public void Check()
        {
        if(Fullness >= 100 && Happiness >= 100)
        {
            message = "Congratulations you won!";
            Status = 2;
        }
        if(Fullness < 1 || Happiness < 1)
        {
            message = "You lose! Try again?";
            Status = 0;
        }
    }
}
}
