// ─ │ ┌ ┐└ ┘├ ┤┬ ┴ ┼

int[,] array = new int [20,20];
array[15,2]=1;
array[15,3]=1;
array[15,1]=1;

desenhar(array);

for (int i = 0;i<100;i++)
{
    desenhar(array);
    Thread.Sleep(200);
    array=proxGeracao(array);
}

void desenhar(int[,] tabulerio)
{
    string tela = "";
    tela  += "┌──┬──┬──┬──┬──┬──┬──┬──┬──┬──┬──┬──┬──┬──┬──┬──┬──┬──┬──┬──┐\n";
    for(int l = 0; l<20; l++)
    {
        for(int c = 0; c<20; c++)
        {
            if(tabulerio[l,c] == 0)
            {
                tela += "│  ";
            }
            else 
            {
                tela  += "│██";
            }
            if(c==19)
            {
                tela  += "│"; 
            }
        }

        tela  += "\n";
        if(l<19)
        {
            tela  += "├──┼──┼──┼──┼──┼──┼──┼──┼──┼──┼──┼──┼──┼──┼──┼──┼──┼──┼──┼──┤\n";
        }
    }

    tela  += "└──┴──┴──┴──┴──┴──┴──┴──┴──┴──┴──┴──┴──┴──┴──┴──┴──┴──┴──┴──┘\n";
    Console.Clear();
    Console.WriteLine(tela);

} 

int[,] proxGeracao(int[,] tabuleiroAtual)
{
    
    int[,]proxTabuleiro = new int[20,20];

    for(int i=0;i<20;i++)
    {
        for (int j = 0;j<20;j++){
            int quantVizinhos = contarVizinhos(tabuleiroAtual,i,j);
            if(quantVizinhos>3)
            {
                proxTabuleiro[i,j] = 0;
            }
            else if(quantVizinhos==0)
            {
                proxTabuleiro[i,j] = 0;
            }
            else if(tabuleiroAtual[i,j] == 0 && quantVizinhos == 3 )
            {
                proxTabuleiro[i,j] = 1;
            }
            else if (tabuleiroAtual[i,j] == 1 && quantVizinhos <= 3 )
            {
                tabuleiroAtual[i,j] = 1;
            }

        }
    }
    return proxTabuleiro;
}

int contarVizinhos(int[,]tabuleiro,int l,int c)
{
    int cont=0;

    if(l<19 && c<19 && l>0 && c>0 )
    {
       if(tabuleiro[l-1,c]>0) 
       {
        cont++;
       }
       if(tabuleiro[l+1,c]>0) 
       {
        cont++;
       }
       if(tabuleiro[l,c-1]>0) 
       {
        cont++;
       }
       if(tabuleiro[l,c+1]>0) 
       {
        cont++;
       }
       if(tabuleiro[l-1,c-1]>0) 
       {
        cont++;
       }
       if(tabuleiro[l-1,c+1]>0) 
       {
        cont++;
       }
       if(tabuleiro[l+1,c+1]>0) 
       {
        cont++;
       }
       if(tabuleiro[l+1,c-1]>0) 
       {
        cont++;
       }
       return cont;
    }
    
    return 0;
}