using static System.Console;
static int CalculateScore(int[] numbers)
{
    int score = 0;

    foreach (int number in numbers)
    {
        if (number == 8)
            score += 5;

        if (number % 2 == 0)
            score += 1;
        else
            score += 3;
    }

    return score;
}

int[] example1 = [1, 2, 3, 4, 5];
int[] example2 = [15, 25, 35];
int[] example3 = [8, 8];

WriteLine(CalculateScore(example1));
WriteLine(CalculateScore(example2));
WriteLine(CalculateScore(example3));

ReadLine();

