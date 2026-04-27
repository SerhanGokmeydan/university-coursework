//************************************************************************************************************************
//*******************                          STUDENT NAME: SERHAN GÖKMEYDAN                       **********************
//*******************                          STUDENT NUMBER: B241202003                           **********************
//*******************       I swear that I didn't get this project done to any AI tools             **********************
//************************************************************************************************************************

#include <iostream>
#include <fstream>
#include <cstdlib>
#include <string>
#include <ctime>

using namespace std;

// Structure to hold coordinates
struct Point
{
    int row;
    int col;
};

// Function prototypes
// Menu
void writeBoardToFile();
void readBoardFromFile();

// Logical
char **createBoard(int size);
void fillBoard(char **board, int size, int qCount, int oCount);
void saveBoard(char **board, int size, const string &filename);
Point *createList(char **board, int size, int count, char type);
Point *computeReachablePoints(char **board, int size, Point *qList, int qCount, int &rCount);
void printResults(char **board, int size, Point *qList, int qCount, Point *oList, int oCount, Point *rList, int rCount);

int main()
{
    // Initialize random number based on current time
    srand(time(0));

    // Variable to store user choice
    char choice;

    // Main program loop: keeps showing the menu until user selects '3'
    do
    {
        cout << "-------------------------------------------------------" << endl;
        cout << "Please select an option (1, 2, 3):" << endl;
        cout << "1. Create board." << endl;
        cout << "2. Show output." << endl;
        cout << "3. Terminate program." << endl;
        cout << "Your choice: ";
        cin >> choice;
        cout << "-------------------------------------------------------" << endl;

        switch (choice)
        {
        case '1':
            writeBoardToFile();
            break;
        case '2':
            readBoardFromFile();
            break;
        case '3':
            return 0;
        default:
            cout << "Unavailable choice! Please select 1 to 3.";
            break;
        }
    } while (choice != '3');

    return 0;
}

void writeBoardToFile()
{
    // Setup parameters
    // Random board size between 5 and 30
    int size = rand() % 26 + 5;

    // Random number of queens and abstacles
    int qCount = rand() % (size * 2) + 1;
    int oCount = rand() % (size - qCount + 1);

    // Initialize board (Dynamic Allocation)
    char **board = createBoard(size);

    // Fill the board with queens and obstacles
    fillBoard(board, size, qCount, oCount);

    // Save the board to input.txt file
    saveBoard(board, size, "input.txt");

    cout << "The file of 'input.txt' for N = " << size << ", q = " << qCount << ", x = " << oCount << " was created successfully." << endl;

    // Clear Memory (Deallocate)
    for (int i = 0; i < size; i++)
    {
        delete[] board[i];
    }

    delete[] board;
}

char **createBoard(int size)
{
    // Allocates array of pointers (rows)
    char **board = new char *[size];

    for (int i = 0; i < size; i++)
    {
        // Allocates array of pointers (columns)
        board[i] = new char[size];
    }

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            board[i][j] = '0';
        }
    }

    return board;
}

// Places 'Q' and 'X' randomly on the board, ensuring no overlaps
void fillBoard(char **board, int size, int qCount, int oCount)
{
    int placedQ = 0;
    int placedO = 0;

    // Keep picking random spots untill we find an empty '0' spot
    while (placedQ < qCount)
    {
        int row = rand() % size;
        int col = rand() % size;

        if (board[row][col] == '0')
        {
            board[row][col] = 'Q';
            placedQ++;
        }
    }

    // Keep picking random spots untill we find an empty '0' spot
    while (placedO < oCount)
    {
        int row = rand() % size;
        int col = rand() % size;

        if (board[row][col] == '0')
        {
            board[row][col] = 'X';
            placedO++;
        }
    }
}

void saveBoard(char **board, int size, const string &filename)
{
    // Write output board into input.txt
    ofstream File("input.txt");

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            File << board[i][j];
        }
        File << endl;
    }

    File.close();
}

void readBoardFromFile()
{
    // Read input.txt file
    ifstream File("input.txt");

    // If there is no input.txt file, throw an error
    if (!File)
    {
        cout << "Sorry! The input.txt file couldn't be found." << endl;
        return;
    }

    string line;

    // If the file is empty, throw an error
    if (!getline(File, line))
    {
        cout << "Sorry! The input.exe file is empty." << endl;
        return;
    }

    int size = line.length();
    int qCount = 0; // Queen count
    int oCount = 0; // Obstacle count
    int rCount = 0; // Reachable count

    // Clear and reset the cursor
    File.clear();
    File.seekg(0, ios::beg);

    // Create new board with the data from file
    char **board = createBoard(size);

    // Parse the file
    for (int i = 0; i < size; i++)
    {
        getline(File, line);
        for (int j = 0; j < size; j++)
        {
            board[i][j] = line[j];

            // Count how many Q and X in board
            if (line[j] == 'Q')
            {
                qCount++;
            }
            if (line[j] == 'X')
            {
                oCount++;
            }
        }
    }

    File.close();

    // Create dynamic lists for queens and obstacles
    Point *qList = createList(board, size, qCount, 'Q');
    Point *oList = createList(board, size, oCount, 'X');

    // Calculate reachable points
    Point *rList = computeReachablePoints(board, size, qList, qCount, rCount);

    // Display the output
    printResults(board, size, qList, qCount, oList, oCount, rList, rCount);

    // Clear memory (Deallocate)
    for (int i = 0; i < size; i++)
    {
        delete[] board[i];
    }
    delete[] board;
    delete[] qList;
    delete[] oList;
    delete[] rList;
}

// Scan the board and create a dynamic array for coordinates of obstacles and queens
Point *createList(char **board, int size, int count, char type)
{
    Point *list = new Point[count];

    int index = 0;
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            if (board[i][j] == type)
            {
                list[index].row = i;
                list[index].col = j;
                index++;
            }
        }
    }
    return list;
}

// Compute all unique squares reachable by queens using ray castin algorithm
Point *computeReachablePoints(char **board, int size, Point *qList, int qCount, int &rCount)
{
    int count = 0;

    // Iterate through every queen
    for (int i = 0; i < qCount; i++)
    {
        int startRow = qList[i].row;
        int startCol = qList[i].col;

        // Check all 8 directions
        // dr = change in row, dc = change in column
        for (int dr = -1; dr <= 1; dr++)
        {
            for (int dc = -1; dc <= 1; dc++)
            {
                // Skip the (0,0) case (the queen's own position)
                if (dr == 0 && dc == 0)
                    continue;

                int currentRow = startRow + dr;
                int currentCol = startCol + dc;

                // Ray Casting: Keep moving in this direction untill we hit an edge
                while (currentRow >= 0 && currentRow < size && currentCol >= 0 && currentCol < size)
                {
                    // Block: Stop if we hit a queen or obstacle
                    if (board[currentRow][currentCol] == 'Q' || board[currentRow][currentCol] == 'X')
                    {
                        break;
                    }

                    // If the cell is empty, mark it '+' and count it
                    // If it is already marked '+', we skip to avoid duplicates
                    if (board[currentRow][currentCol] == '0')
                    {
                        board[currentRow][currentCol] = '+';
                        count++;
                    }

                    // Move to the next cell in the same direction
                    currentRow += dr;
                    currentCol += dc;
                }
            }
        }
    }

    // Allocate memory for the results
    Point *rList = new Point[count];
    rCount = count;

    // Fill the movementArray by scanning the board for '+' marks
    int index = 0;
    for (int i = 0; i < size; i++) // i is row (y)
    {
        for (int j = 0; j < size; j++) // j is column (x)
        {
            if (board[i][j] == '+')
            {
                rList[index].row = i;
                rList[index].col = j;
                index++;
            }
        }
    }

    return rList;
}

// Prints the statics an visualizes the board on the console
void printResults(char **board, int size, Point *qList, int qCount, Point *oList, int oCount, Point *rList, int rCount)
{

    // Print text statistics
    cout << "Board size: " << size << 'x' << size << endl;
    cout << "Number of Queens: " << qCount << endl;
    cout << "Number of Obstacles: " << oCount << endl;

    // Print queen coordinates
    cout << "Queen Positions: ";
    for (int i = 0; i < qCount; i++)
    {
        cout << '(' << qList[i].col << ',' << qList[i].row << ')' << ',';
    }
    cout << endl;

    // Print obstacle coordinates
    cout << "Obstacle Positions: ";
    for (int i = 0; i < oCount; i++)
    {
        cout << '(' << oList[i].col << ',' << oList[i].row << ')' << ',';
    }
    cout << endl;

    // Print reachable squares coordinates
    cout << "Total Reachable Squeares: " << rCount << endl;
    cout << "Reachable Points: ";
    for (int i = 0; i < rCount; i++)
    {
        cout << '(' << rList[i].col << ',' << rList[i].row << ')' << ',';
    }
    cout << endl;

    cout << "-------------------------------------------------------" << endl;

    // Print legend
    cout << "CHESS BOARD" << endl;
    cout << "Q - Queens" << endl;
    cout << "X - Obstacles" << endl;
    cout << "0 - Empty/unreachable Cell" << endl;
    cout << "+ - Possible Movement" << endl;

    cout << "-------------------------------------------------------" << endl;

    // Draw the grid
    for (int i = 0; i < size; i++)
    {
        cout << '|';
        for (int j = 0; j < size; j++)
        {
            cout << board[i][j] << " ";
        }
        cout << '|' << endl;
    }
}