
List<double> pentagonNumbers = new();

int topValue = 10000;

for(double n = 1; n <= topValue; n++)
{
    pentagonNumbers.Add(n*(3*n-1)/2);
}

double minValue = 9000000;
bool found = false;
for(int i = 0; i <= pentagonNumbers.Count-2; i++)
{
    for (int j = i+1; j <= pentagonNumbers.Count-1; j++)
    {
        if (i == j)
            continue;
        double upNum = pentagonNumbers[i] + pentagonNumbers[j];
        double downNum = Math.Abs(pentagonNumbers[i] - pentagonNumbers[j]);
        if (pentagonNumbers.Contains(upNum) &&
           pentagonNumbers.Contains(downNum) &&
           downNum < minValue)
        {
            minValue = downNum;
            found = true;
            break;
        }
    }
    if (found)
        break;
}

Console.WriteLine("The value of D is: " + minValue);
