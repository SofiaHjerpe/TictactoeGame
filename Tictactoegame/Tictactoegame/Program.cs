using System.Data;
char player = 'X';

char[,] board = new char[3, 3];
Initialize(board);
bool gameWon = false;

//The Game plays until winner/draw


while (gameWon == false)
{
    Console.Clear();
    Print(board);

    Console.Write("Please enter row: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please enter column: ");
    int col = Convert.ToInt32(Console.ReadLine());

        board[row, col] = player;

    //Check if we won

    if (gameWon == false)
    {
        if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2] || player == board[1, 0] && player == board[1, 1] && player == board[1, 2] || player == board[2, 0] && player == board[2, 1] && player == board[2, 2])
        {
            Console.WriteLine(player + " has won the game!:)");
            gameWon = true;
        }

        else if (player == board[0, 0] && player == board[1, 1] && player == board[2, 2] || player == board[0, 2] && player == board[1, 1] && player == board[2, 0])
        {
            Console.WriteLine(player + " has won the game!:)");
            gameWon = true;
        }
        else if (player == board[0, 0] && player == board[1, 0] && player == board[2, 0] || player == board[0, 1] && player == board[1, 1] && player == board[2, 1] || player == board[0, 2] && player == board[1, 2] && player == board[2, 2])
        {
            Console.WriteLine(player + " has won the game!:)");
            gameWon = true;
        }
        else
        {
            gameWon = false;
        }
    }


    player = ChangeTurn(player);

}



 
static char ChangeTurn(char currentPlayer)
{
    if (currentPlayer == 'X')
    {
        return 'O';
    }
    else
    {
        return 'X';
    }
}
   

    

static void Initialize(char[,] board)
{
    for (int row = 0; row < 3; row++)
    {
        for (int col = 0; col < 3; col++)
        {
            board[row, col] = ' ';
        }

    }
    }


    static void Print(char[,] board)
    {
        Console.WriteLine(" | 0 | 1 | 2 |");
        for (int row = 0; row < 3; row++)
        {
            Console.Write(row + "| ");
            for (int col = 0; col < 3; col++)
            {
                Console.Write(board[row, col]);
                Console.Write(" | ");
            }
            Console.WriteLine();

        }


    }
