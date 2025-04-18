// ─ │ ┌ ┐└ ┘├ ┤┬ ┴ ┼


int[,] array = new int [20,20];
array[1,2]=1;
array[5,6]=0;
desenhar(array);

void desenhar(int[,] tabulerio)
{
    Console.WriteLine("┌──┬──┬──┬──┬──┬──┬──┬──┬──┬──┬──┬──┬──┬──┬──┬──┬──┬──┬──┬──┐");
    for(int l = 0; l<20; l++)
    {
        for(int c = 0; c<20; c++)
        {
            
            if(tabulerio[l,c] == 0)
            {
                Console.Write("│  ");
            }
            else 
            {
                Console.Write("│██");
            }
            if(c==19)
            {
                Console.Write("│"); 
            }
        }

        Console.WriteLine();
        if(l<19)
        {
            Console.WriteLine("├──┼──┼──┼──┼──┼──┼──┼──┼──┼──┼──┼──┼──┼──┼──┼──┼──┼──┼──┼──┤");
        }
    }

    Console.WriteLine("└──┴──┴──┴──┴──┴──┴──┴──┴──┴──┴──┴──┴──┴──┴──┴──┴──┴──┴──┴──┘");

}

