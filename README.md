# introduction-to-programming

Work with numbers: hints

1. Count of the total number of digits in a number: 
```
int digit = Convert.ToInt32(Math.Floor(Math.Log10(number) + 1));
```

2. Save a string to a number:
```
isNumber = int.TryParse(numberInString, out int number);
```

3. Reverse number:
```
for(int i = 0; i < countOfDigit; i++)
{
    array[i] = number % 10;

    Console.Write(array[i]);
    number /= 10;
}
```
