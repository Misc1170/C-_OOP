int x = -7, y = 0;

Console.Write("Введите число X: ");
string numberForX = Console.ReadLine();
int checkX = Convert.ToInt32(numberForX);

Console.Write("Введите число Y: ");
string numberForY = Console.ReadLine();
int checkY = Convert.ToInt32(numberForY);

bool isInRange = false;

if (
    checkX > x 
    && checkX < 0 
    && checkY == y
    )
{
    isInRange = true;
}

Console.WriteLine(isInRange);
