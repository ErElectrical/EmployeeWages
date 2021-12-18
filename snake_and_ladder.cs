class program
{
    public int sum = 0;
    public int count = 0;
    public int random()
    {
        Random random = new Random();
        int check = random.Next(1, 7);
        count++;
        return check;

    }
    public  void game_methology()
    {
        while (sum == 100)
        {
            int opt = random();
            if (opt == 0)
            {
                sum += 0;
                Console.WriteLine("no play");
            }
            else if (opt == 3 || opt == 6)
            {
                if (sum - opt < 0)
                {
                    sum = 0;
                }
                else
                {
                    sum -= opt;
                    Console.WriteLine("snake bite ");



                }
            }
            else if (opt == 2 || opt == 4 || opt == 5)
            {
                if (sum + opt > 100)
                {
                    sum += 0;
                }
                else
                {
                    sum += opt;
                    Console.WriteLine("ladder achieve");



                }
            }
        }
        Console.WriteLine("user won in ---  " + count + " trial ");      

        
    }


    

}
