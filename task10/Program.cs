Console.WriteLine("введите трехзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringnumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("вторая цифра этого числа -> " + stringnumber[1]);