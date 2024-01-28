//Task 2

int rows = 8;
int columns = 8;

int[,] chess_board = new int[rows, columns];
 
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        chess_board[i, j] = 0;
    }
} 
//

//Placing the knight in a random location.
Random random = new Random();

int queen_row = random.Next(0, 7);
int queen_column = random.Next(0, 7);

//

// Algorithm to show the knight strokes on the chess board.
for (int i = -7; i <= 7; i++)
{
    if (queen_row + i >= 0 && queen_row + i <= 7)
    {
        chess_board[queen_row + i, queen_column] = 1;
    }
    if (queen_column + i >= 0 && queen_column + i <= 7)
    {
        chess_board[queen_row, queen_column + i] = 1;
    }
}

int mm = queen_row;
int kk = queen_column;

while (mm + 1 >= 0 && mm + 1 <= 7 && kk + 1 >= 0 && kk + 1 <= 7)
{
    chess_board[mm + 1, kk + 1] = 1;
    mm = mm + 1;
    kk = kk + 1;
}
mm = queen_row;
kk = queen_column;

while (mm - 1 >= 0 && mm - 1 <= 7 && kk - 1 >= 0 && kk - 1 <= 7)
{
    chess_board[mm - 1, kk - 1] = 1;
    
    mm = mm - 1;
    kk = kk - 1;
}
mm = queen_row;
kk = queen_column;

while (mm + 1 >= 0 && mm + 1 <= 7 && kk - 1 >= 0 && kk - 1 <= 7)
{
    chess_board[mm + 1, kk - 1] = 1;
    mm = mm + 1;
    kk = kk - 1;
}
mm = queen_row;
kk = queen_column;

while (mm - 1 >= 0 && mm - 1 <= 7 && kk + 1 >= 0 && kk + 1 <= 7)
{
    chess_board[mm - 1, kk + 1] = 1;
    
    mm = mm - 1;
    kk = kk + 1;
}
chess_board[queen_row, queen_column] = 9;

//

//Visualizing the chess board in the console.
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(chess_board[i, j] + " ");
    }
    Console.WriteLine();
}
