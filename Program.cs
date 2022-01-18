using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Player{
        public String name;
        public int age;
        public String favGame;
        private int energy;
        private bool win;
        private int coins;

        public Player (String _name, int _age, String _favGame){
            name = _name;
            age = _age;
            favGame = _favGame;
            energy = 100;
            win = false;
            coins = 0;
        }
        public void Play(){
            if(energy > 0){
                Console.WriteLine(name+" Plays "+favGame);
                energy = energy -25;
                Random gen = new Random();
                int probability = gen.Next(1,3);
                if(probability == 1){
                    win = true;
                    coins = coins + 10;
                    Console.WriteLine(name+" of age "+age+" won the match!! in "+favGame+" and earned "+coins+" coins with energy "+energy);
                    }else
                    {
                        win = false;
                        if(coins > 5){
                        coins = coins - 5;
                        }
                    Console.WriteLine(name+" of age "+age+" lost the match!! in "+favGame+" and earned "+coins+" coins with energy "+energy);
                    }                     
            }else
            {
                Console.WriteLine("Energy is not sufficient to play the "+favGame);
            }

        }
        public void Rest(){
            Console.WriteLine("Player "+name+" is taking rest");
            if(win == true){
            energy = energy + 50;}
            else{
                energy = energy + 25;
            }

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player("Arun", 20, "Temple run");
            p1.Play();
            p1.Play();
            p1.Rest();
            p1.Play();
            Player p2 = new Player("Balu", 25, "Candy Crush");
            p2.Play();
            p2.Play();
            p2.Play();
            p2.Play();
            p2.Rest();
            p2.Play();
            p2.Play();
            p2.Play();

            Console.ReadKey();
    }

}
}
