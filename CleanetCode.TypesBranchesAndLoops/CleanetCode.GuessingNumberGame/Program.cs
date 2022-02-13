const int minNumber = 0;  // так называемые магичиские цифры.
            const int maxNumber = 10; // так называемые магичиские цифры.

            

            Console.WriteLine("Добро пожаловать в игру 'Угадай число'");
            Console.WriteLine("Как вас зовут?");
            string? userName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(userName))  // если имя окажеться пустым или будет содержать пробел, то порисвоется значение по "умолчанию" 
            {                                         // если имя окажеться пустым или будет содержать пробел, то порисвоется значение по "умолчанию" 
                userName = "Unknow";                  // если имя окажеться пустым или будет содержать пробел, то порисвоется значение по "умолчанию" 
            }                                         
            Console.WriteLine(
                $"Привет {userName}. " +
                $"Я загадал тебе число от {minNumber} до {maxNumber}. " +
                $"Попробуй отгадать");
            Random rnd = new Random();
            int secretNumber = rnd.Next(minNumber, maxNumber);
            bool isWin = false;
            int count=1; // число ходов. Минимальное число ходов 1. Так как с первого раза угаданно число. Это минимальное число.

            int userNumber;           // нет необходимости в цыкле проверять каждый раз.
            bool isIntNumber = false; // нет необходимости в цыкле проверять каждый раз.
            while (!isWin)
            {
                do
                {
                    Console.WriteLine($"Введи число от {minNumber} до  {maxNumber}");
                    string? userInput = Console.ReadLine();
                    isIntNumber = int.TryParse(userInput, out userNumber);

                    if (!isIntNumber)
                    {
                        Console.WriteLine($"Вы ввели {userInput}. Нужно ввести число от {minNumber}  до  {maxNumber}");
                    }
                }
                while (!isIntNumber);

                if (userNumber > secretNumber)
                {
                    count++;
                    Console.WriteLine($"Ваше число ({userNumber}) больше, чем загаданное");
                }
                else if (userNumber < secretNumber)
                {
                    count++;
                    Console.WriteLine($"Ваше число ({userNumber}) меньше, чем загаданное");
                }
                else
                {
                    isWin = true;
                    Console.WriteLine($"{userName}, вы победили!   Затратив {count} ходов");
                }
            }
