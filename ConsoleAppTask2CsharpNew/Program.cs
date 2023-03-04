namespace ConsoleAppTask2CsharpNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //    int remainder = 0;
            //L1:
            //    Console.Write("4 reqemli ededi daxil edin: ");
            //    string strNum = Console.ReadLine();
            //    if (!int.TryParse(strNum, out int num))
            //    {
            //        goto L1;
            //    }
            //    int numDigit = (int)Math.Log10(num) + 1;
            //    if (numDigit != 4)
            //    {
            //        goto L1;
            //    }
            //    while (num > 0)
            //    {
            //        remainder += (num % 10);
            //        num = num / 10;
            //    }
            //    Console.WriteLine($"Netice: {remainder}");
            #endregion
            #region Task2
            //    int remainder = 0;
            //L1:
            //    Console.Write("6 reqemli ededi daxil edin: ");
            //    string strNum = Console.ReadLine();
            //    if (!int.TryParse(strNum, out int num))
            //    {
            //        goto L1;
            //    }
            //    int numDigit = (int)Math.Log10(num) + 1;
            //    int power = (int)Math.Pow(10, (numDigit - 3));
            //    if (numDigit != 6)
            //    {
            //        goto L1;
            //    }
            //    int firstNum = num / power;
            //    while (firstNum > 0)
            //    {
            //        remainder += (firstNum % 10);
            //        firstNum = firstNum / 10;
            //    }
            //    Console.WriteLine($"Netice: {remainder}");
            #endregion
            #region Task3
            //    int remainder = 0;
            //L1:
            //    Console.Write("9 reqemli ededi daxil edin: ");
            //    string strNum = Console.ReadLine();
            //    if (!int.TryParse(strNum, out int num))
            //    {
            //        goto L1;
            //    }
            //    int numDigit = (int)Math.Log10(num) + 1;
            //    if (numDigit != 9)
            //    {
            //        goto L1;
            //    }
            //    int firstNum = num / 1000;
            //    int lastNum = firstNum % 1000;
            //    while (lastNum > 0)
            //    {
            //        remainder += (lastNum % 10);
            //        lastNum = lastNum / 10;
            //    }
            //    Console.WriteLine($"Netice: {remainder}");
            #endregion
            #region Task4
            //L1:
            //    Console.Write("5 reqemli ededi daxil edin: ");
            //    string strNum = Console.ReadLine();
            //    if (!int.TryParse(strNum, out int num))
            //    {
            //        goto L1;
            //    }
            //    int numDigit = (int)Math.Log10(num) + 1;
            //    if (numDigit != 5)
            //    {
            //        goto L1;
            //    }
            //    int power = (int)Math.Pow(10, (numDigit - 1));
            //    int firstNum = num / power;
            //    int lastNum = num % 10;
            //    int sum1 = firstNum + lastNum;
            //    int sum2 = sum1 * sum1;
            //    Console.WriteLine($"Netice: {sum2}");
            #endregion
            #region Task5
            //L1:
            //    Console.Write("6 reqemli ededi daxil edin: ");
            //    string strNum = Console.ReadLine();
            //    if (!int.TryParse(strNum, out int num))
            //    {
            //        goto L1;
            //    }
            //    int numDigit = (int)Math.Log10(num) + 1;
            //    if (numDigit != 6)
            //    {
            //        goto L1;
            //    }
            //    int power = (int)Math.Pow(10, (numDigit - 1));
            //    int firstNum = num / power;
            //    int secondNum = num % power;
            //    int lastNum = secondNum * 10 + firstNum;
            //    Console.WriteLine($"Netice: {lastNum}");
            #endregion
            #region Task6
            //L1:
            //    Console.Write("8 reqemli ededi daxil edin: ");
            //    string strNum = Console.ReadLine();
            //    if (!int.TryParse(strNum, out int num))
            //    {
            //        goto L1;
            //    }
            //    int numDigit = (int)Math.Log10(num) + 1;
            //    if (numDigit != 8)
            //    {
            //        goto L1;
            //    }
            //    int power = (int)Math.Pow(10, (numDigit - 1));
            //    int firstNum = num % power;
            //    int lastNum = firstNum / 10;
            //    Console.WriteLine($"Netice: {lastNum}");
            #endregion
            #region Task7
            //    int remainder = 0;
            //    int newRemainder = remainder;
            //L1:
            //    Console.Write("4 reqemli ededi daxil edin: ");
            //    string strNum = Console.ReadLine();
            //    if (!int.TryParse(strNum, out int num))
            //    {
            //        goto L1;
            //    }
            //    int numDigit = (int)Math.Log10(num) + 1;
            //    if (numDigit != 4)
            //    {
            //        goto L1;
            //    }
            //    while (num > 0)
            //    {
            //        remainder = num % 10;
            //        num /= 10;
            //        newRemainder = newRemainder * 10 + remainder;
            //    }
            //    int power = (int)Math.Pow(10, numDigit);
            //    int lastNum = (power * 8 + newRemainder) * 10 + 8;
            //    Console.WriteLine($"Netice: {lastNum}");
            #endregion
            #region Task8
            //L1:
            //    Console.Write("En azi 4 reqemli ededi daxil edin: ");
            //    string strNum = Console.ReadLine();
            //    if (!int.TryParse(strNum, out int num))
            //    {
            //        goto L1;
            //    }
            //    int numDigit = (int)Math.Log10(num) + 1;
            //    if (numDigit !< 4)
            //    {
            //        goto L1;
            //    }
            //    int firstNum = num % 1000;
            //    int secondNum = firstNum / 100;
            //    int thirdNum = firstNum % 10;
            //    int lastNum = secondNum + thirdNum;
            //    Console.WriteLine($"Netice: {lastNum}");
            #endregion
            #region Task9
            //    int num, remainder;
            //L1:
            //    Console.Write("9 reqemli ededi daxil edin: ");
            //    string strNum = Console.ReadLine();
            //    if (!int.TryParse(strNum, out num))
            //    {
            //        goto L1;
            //    }
            //    int numDigit = (int)Math.Log10(num) + 1;
            //    if (numDigit!= 9)
            //    {
            //        goto L1;
            //    }
            //    int newNum = 0;
            //    while (num > 0)
            //    {
            //        remainder = num % 10;
            //        num /= 10;
            //        newNum = newNum * 10 + remainder;
            //    }
            //    num = newNum;
            //    newNum = 0;
            //    bool next = true;

            //    while (num > 0)
            //    {
            //        remainder = num % 10;
            //        num /= 10;
            //        if (next==false)
            //        {
            //            next = !next;
            //            continue;
            //        }
            //        next = !next;
            //        newNum = newNum * 10 + remainder;
            //    }
            //    Console.WriteLine($"Netice: {newNum}");
            #endregion
            #region Task10
            //     int num, num1, num2, sum, newNum1, newNum2, remainder;
            //L1:
            //    Console.Write("9 reqemli ededi daxil edin: ");
            //    string strNum = Console.ReadLine();
            //    if (!int.TryParse(strNum, out num))
            //    {
            //        goto L1;
            //    }
            //    int numDigit = (int)Math.Log10(num) + 1;
            //    if (numDigit!= 9)
            //    {
            //        goto L1;
            //    }
            //    int newNum = 0;
            //    while (num > 0)
            //    {
            //        remainder = num % 10;
            //        num /= 10;
            //        newNum = newNum * 10 + remainder;
            //    }
            //    num1 = newNum;
            //    num2 = newNum;
            //    newNum1 = 0;
            //    newNum2 = 0;
            //    bool next = true;

            //    while (num1 > 0)
            //    {
            //        remainder = num1 % 10;
            //        num1 /= 10;
            //        if (next==false)
            //        {
            //            next = !next;
            //            continue;
            //        }
            //        next = !next;
            //        newNum1 = newNum1 * 10 + remainder;
            //    }
            //      while (num2 > 0)
            //    {
            //        remainder = num2 % 10;
            //        num2 /= 10;
            //        if (next==false)
            //        {
            //            next = !next;
            //            continue;
            //        }
            //        next = !next;
            //        newNum2 = newNum2 * 10 + remainder;
            //    }
            //      sum = newNum1 + newNum2;
            //    Console.WriteLine($"Netice: {sum}");
            #endregion
            #region Task10beta
            //    int num, num1, num2, sum, newNum1, newNum2, remainder;
            //L1:
            //    Console.Write("9 reqemli ededi daxil edin: ");
            //    string strNum = Console.ReadLine();
            //    if (!int.TryParse(strNum, out num))
            //    {
            //        goto L1;
            //    }
            //    int numDigit = (int)Math.Log10(num) + 1;
            //    if (numDigit != 9)
            //    {
            //        goto L1;
            //    }
            //    int newNum = 0;
            //    while (num > 0)
            //    {
            //        remainder = num % 10;
            //        num /= 10;
            //        newNum = newNum * 10 + remainder;
            //    }
            //    num1 = newNum;
            //    num2 = newNum;
            //    newNum1 = 0;
            //    newNum2 = 0;
            //    bool next = true;

            //    while (num1 > 0)
            //    {
            //        remainder = num1 % 10;
            //        num1 /= 10;
            //        if (next == false)
            //        {
            //            newNum2 = newNum2 * 10 + remainder;
            //            next = !next;
            //            continue;
            //        }
            //        next = !next;
            //        newNum1 = newNum1 * 10 + remainder;
            //    }
            //    sum = newNum1 + newNum2;
            //    Console.WriteLine($"Netice: {sum}");
            #endregion
            #region Task11
            //    int remainder = 0;
            //    double newNum;
            //    double percent;
            //L1:
            //    Console.Write("8 reqemli ededi daxil edin: ");
            //    string strNum = Console.ReadLine();
            //    if (!int.TryParse(strNum, out int num))
            //    {
            //        goto L1;
            //    }
            //    int numDigit = (int)Math.Log10(num) + 1;
            //    if (numDigit != 8)
            //    {
            //        goto L1;
            //    }
            //    while (num > 0)
            //    {
            //        remainder += (num % 100);
            //        num = num / 100;
            //    }
            //    newNum = remainder * 100 + 99;
            //    percent = newNum * 82 / 100;
            //    Console.WriteLine($"Netice: {percent}");
            #endregion
            #region Task12
            //    int remainder1 = 0;
            //    int remainder2 = 1;
            //    int newNum, lastNum1, lastNum2;
            //L1:
            //    Console.Write("5 reqemli 1-ci ededi daxil edin: ");
            //    string strNum1 = Console.ReadLine();
            //    if (!int.TryParse(strNum1, out int num1))
            //    {
            //        goto L1;
            //    }
            //    int numDigit1 = (int)Math.Log10(num1) + 1;
            //    if (numDigit1 != 5)
            //    {
            //        goto L1;
            //    }
            //L2:
            //    Console.Write("5 reqemli 2-ci ededi daxil edin: ");
            //    string strNum2 = Console.ReadLine();
            //    if (!int.TryParse(strNum2, out int num2))
            //    {
            //        goto L2;
            //    }
            //    int numDigit2 = (int)Math.Log10(num2) + 1;
            //    if (numDigit2 != 5)
            //    {
            //        goto L2;
            //    }
            //    lastNum1 = num1 % 10;
            //    while (num1 > 0)
            //    {
            //        remainder1 += (num1 % 10);
            //        num1 = num1 / 10;
            //    }
            //    while (num2 > 0)
            //    {
            //        remainder2 *= (num2 % 10);
            //        num2 = num2 / 10;
            //    }
            //    newNum = remainder1 + remainder2;
            //    lastNum2 = (newNum * 10) + lastNum1;
            //    Console.WriteLine($"Netice: {lastNum2}");
            #endregion
            #region Task13
        //    int firstNum, secondNum, thirdNum, sum;
        //    double perSum;
        //L1:
        //    Console.Write("5 reqemli 1-ci ededi daxil edin: ");
        //    string strNum1 = Console.ReadLine();
        //    if (!int.TryParse(strNum1, out int num1))
        //    {
        //        goto L1;
        //    }
        //    int numDigit1 = (int)Math.Log10(num1) + 1;
        //    if (numDigit1 != 5)
        //    {
        //        goto L1;
        //    }
        //L2:
        //    Console.Write("5 reqemli 2-ci ededi daxil edin: ");
        //    string strNum2 = Console.ReadLine();
        //    if (!int.TryParse(strNum2, out int num2))
        //    {
        //        goto L2;
        //    }
        //    int numDigit2 = (int)Math.Log10(num2) + 1;
        //    if (numDigit2 != 5)
        //    {
        //        goto L2;
        //    }
        //L3:
        //    Console.Write("5 reqemli 3-cu ededi daxil edin: ");
        //    string strNum3 = Console.ReadLine();
        //    if (!int.TryParse(strNum3, out int num3))
        //    {
        //        goto L3;
        //    }
        //    int numDigit3 = (int)Math.Log10(num3) + 1;
        //    if (numDigit3 != 5)
        //    {
        //        goto L3;
        //    }
        //    firstNum = (num1 / 10000) * 10 + (num1 % 10);
        //    secondNum = (num2 / 10000) * 10 + (num2 % 10);
        //    thirdNum = (num3 / 10000) * 10 + (num3 % 10);
        //    sum = firstNum + secondNum + thirdNum;
        //    perSum = sum + (sum / 2);
        //    Console.WriteLine($"Netice: {perSum}");
            #endregion
            #region Task14
            //    int sum, result1, newNum, result2;
            //    int remainder = 1;
            //    double perResult2, perLast;
            //L1:
            //    Console.Write("6 reqemli 1-ci ededi daxil edin: ");
            //    string strNum1 = Console.ReadLine();
            //    if (!int.TryParse(strNum1, out int num1))
            //    {
            //        goto L1;
            //    }
            //    int numDigit1 = (int)Math.Log10(num1) + 1;
            //    if (numDigit1 != 6)
            //    {
            //        goto L1;
            //    }
            //L2:
            //    Console.Write("6 reqemli 2-ci ededi daxil edin: ");
            //    string strNum2 = Console.ReadLine();
            //    if (!int.TryParse(strNum2, out int num2))
            //    {
            //        goto L2;
            //    }
            //    int numDigit2 = (int)Math.Log10(num2) + 1;
            //    if (numDigit2 != 6)
            //    {
            //        goto L2;
            //    }
            //L3:
            //    Console.Write("6 reqemli 3-cu ededi daxil edin: ");
            //    string strNum3 = Console.ReadLine();
            //    if (!int.TryParse(strNum3, out int num3))
            //    {
            //        goto L3;
            //    }
            //    int numDigit3 = (int)Math.Log10(num3) + 1;
            //    if (numDigit3 != 6)
            //    {
            //        goto L3;
            //    }
            //L4:
            //    Console.Write("7 reqemli ededi daxil edin: ");
            //    string strNum4 = Console.ReadLine();
            //    if (!int.TryParse(strNum4, out int num4))
            //    {
            //        goto L4;
            //    }
            //    int numDigit4 = (int)Math.Log10(num4) + 1;
            //    if (numDigit4 != 7)
            //    {
            //        goto L4;
            //    }
            //    sum = num1 / 1000 + num2 / 1000 + num3 / 1000;
            //    result1 = num4 % 10000 + sum;
            //    newNum = num4 / 10000;
            //    while (newNum > 0)
            //    {
            //        remainder *= (newNum % 10);
            //        newNum = newNum / 10;
            //    }
            //    result2 = result1 - remainder;
            //    perResult2 = (result2 * 60 / 100) * 100 + 60;
            //    perLast = perResult2 * 82 / 100;
            //    Console.WriteLine($"Netice: {perLast}");
            #endregion
            #region Task15
            //    int sum1, sum2, result1, result2, result3, result4, result6, newNum5, firstNum, secondNum,lastNum;
            //    int remainder1 = 0;
            //    int remainder2 = 0;
            //    int remainder3 = 0;
            //    int result5 = 0;
            //    int newRemainder = 0;
            //L1:
            //    Console.Write("3 reqemli 1-ci ededi daxil edin: ");
            //    string strNum1 = Console.ReadLine();
            //    if (!int.TryParse(strNum1, out int num1))
            //    {
            //        goto L1;
            //    }
            //    int numDigit1 = (int)Math.Log10(num1) + 1;
            //    if (numDigit1 != 3)
            //    {
            //        goto L1;
            //    }
            //L2:
            //    Console.Write("3 reqemli 2-ci ededi daxil edin: ");
            //    string strNum2 = Console.ReadLine();
            //    if (!int.TryParse(strNum2, out int num2))
            //    {
            //        goto L2;
            //    }
            //    int numDigit2 = (int)Math.Log10(num2) + 1;
            //    if (numDigit2 != 3)
            //    {
            //        goto L2;
            //    }
            //L3:
            //    Console.Write("6 reqemli 1-ci ededi daxil edin: ");
            //    string strNum3 = Console.ReadLine();
            //    if (!int.TryParse(strNum3, out int num3))
            //    {
            //        goto L3;
            //    }
            //    int numDigit3 = (int)Math.Log10(num3) + 1;
            //    if (numDigit3 != 6)
            //    {
            //        goto L3;
            //    }
            //L4:
            //    Console.Write("6 reqemli 2-ci ededi daxil edin: ");
            //    string strNum4 = Console.ReadLine();
            //    if (!int.TryParse(strNum4, out int num4))
            //    {
            //        goto L4;
            //    }
            //    int numDigit4 = (int)Math.Log10(num4) + 1;
            //    if (numDigit4 != 6)
            //    {
            //        goto L4;
            //    }
            //L5:
            //    Console.Write("7 reqemli ededi daxil edin: ");
            //    string strNum5 = Console.ReadLine();
            //    if (!int.TryParse(strNum5, out int num5))
            //    {
            //        goto L5;
            //    }
            //    int numDigit5 = (int)Math.Log10(num5) + 1;
            //    if (numDigit5 != 7)
            //    {
            //        goto L5;
            //    }
            //    sum1 = (num1 + num2) % 100;
            //    sum2 = sum1 * sum1;
            //    result1 = (num1 * 1000 + num2) + sum2;
            //    result2 = result1 - (num5 % 100000);
            //    result3 = result2 + ((num3 + num4) % 1000);
            //    newNum5 = num5;
            //    while (num5 > 0)
            //    {
            //        remainder1 += (num5 % 10);
            //        num5 = num5 / 10;
            //    }
            //    while (remainder1 > 0)
            //    {
            //        remainder2 = (remainder1 % 10);
            //        remainder1 = remainder1 / 10;
            //        newRemainder = newRemainder * 10 + remainder2;
            //    }
            //    result4 = (result3 + newRemainder) * 100 + 11;
            //    bool next = true;
            //    while (newNum5 > 0)
            //    {
            //        remainder3 = newNum5 % 10;
            //        newNum5 /= 10;
            //        if (next == false)
            //        {
            //            next = !next;
            //            continue;
            //        }
            //        next = !next;
            //        result5 = result5 * 10 + remainder3;
            //    }
            //    result6 = result4 - result5;
            //    firstNum = result6 / 10;
            //    secondNum = result6 % 10;
            //    lastNum = (firstNum * 100 + 88) * 10 + secondNum ;
            //    Console.WriteLine($"Netice: {lastNum}");
            #endregion
        }
    }
}