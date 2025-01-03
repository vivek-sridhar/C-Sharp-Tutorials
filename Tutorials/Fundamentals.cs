// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello!");
//Console.WriteLine("What do you want to do?");
//Console.WriteLine("[S]ee all TODOs");
//Console.WriteLine("[A]dd TODO");
//Console.WriteLine("[R]emove a TODO");
//Console.WriteLine("[E]xit");

//string input = Console.ReadLine();

//switch (input.ToUpper())
//{
//    case "s":   //for both s and S; break statement breaks the flow
//    case "S":
//        Console.WriteLine("Here are the all the TODOs:");
//        break;
//    case "a": case "A":   //for both a and A
//        Console.WriteLine(" - TODO added.");
//        break;
//    case "R":
//        Console.WriteLine(" - removed");
//        break;
//    case "E":
//        Console.WriteLine("Exiting...");
//        break;
//    default:
//        Console.WriteLine("Invalid choice. Try again or press [E] to exit.");
//        break;
//}

//string class = "First";  //To use class keyword as variable name add @ before it
//string @class = "Second";  //Like this

//int a, b;
//a = 7; b = 6;

//Console.WriteLine("Sum is " + (a + b));
//Console.WriteLine("Difference is " + (a - b));
//Console.WriteLine("Product is " + a * b);
//Console.WriteLine("Quotient is " + a / b + " and remainder is " + a % b);

//Console.WriteLine($"a is {a} and b is {b}"); //a is 7 and b is 6
//Console.WriteLine($"a is {a++} and b is {--b}"); //a is 7 and b is 5

//PrintSelectedOption(a++, --b);  //Prints "a is 7 and b is 5"
//Console.WriteLine(Add(a, b));   //Prints 13

//void PrintSelectedOption(int num1, int num2)
//{
//    Console.WriteLine("a is " + num1 + " and b is " + num2);
//}
//int Add(int num1, int num2)
//{
//    return num1 + num2;
//}

//methods
//Console.Write("Enter word to determine long or short string: ");
//var userString = Console.ReadLine();
//IsWordLessThan10Char(userString);
//
//void IsWordLessThan10Char(string userString)
//{
//    Console.Write(userString + " is of length " + userString.Length + ". Hence, it is a ");
//    if (userString.Length > 10)
//    {
//        Console.WriteLine("Long string.");
//    }
//    else
//    {
//        Console.WriteLine("Short string.");
//    }
//}
//var word = "ABC";
//Console.WriteLine(word);

//int.parse()
//Console.Write("Enter a number: ");
//string userInput = Console.ReadLine();
//int number = int.Parse(userInput);
//Console.WriteLine("Number you entered is " + number);

//string interpolation
//int a = 4, b = 5, c = 6;
//Console.WriteLine("a is " + a + ", b is " + b + ", and c is " + c);
//Console.WriteLine($"a is {a}, b is {b}, and c is {c}");     //string interpolation
//Console.WriteLine($"a is {a}, b is {b}, and c is {c}");     //ctrl+. > Convert to interpolated string [string part of line 84]

//switch-case
//Console.Write("Enter points from 0 to 10 for a grade: ");
//var points = Console.ReadLine();
//Console.WriteLine(ConvertPointsToGrade(int.Parse(points)));

//char ConvertPointsToGrade(int points)
//{
//	switch (points)
//	{
//		case 10: case 9:
//			return 'A';
//		case 8: case 7: case 6:
//			return 'B';
//		case 5: case 4: case 3:
//			return 'C';
//		case 2: case 1:
//			return 'D';
//		case 0:
//			return 'E';
//		default:
//			return '!';			
//	}
//}

//while loops
//int SumOfNumbersBetween(int num1, int num2)
//{
//    int sum = 0;
//    while (num1 <= num2)
//    {
//        sum += num1;
//        num1++;
//    }
//    return sum;
//}

//Console.WriteLine(SumOfNumbersBetween(3,5));

//do-while loop
//string RepeatCharacter(char letter, int count)
//{
//    string word = "";
//    int counter = 0;
//    do
//    {
//        counter++;
//        word = word + letter;
//    } while (counter < count);
//    return word;
//}
//Console.WriteLine(RepeatCharacter('X',3));

//For loop
//int factorial = 1, number = 5;

//for (int i = 1; i <= number; i++)
//{
//    factorial *= i;
//}
//Console.WriteLine(factorial);

//Console.Write("Enter a number: ");
//string userInput = Console.ReadLine();
//bool isInt = userInput.All(char.IsDigit);   //****** New to Learn ******
//Console.WriteLine(isInt);

//nested loops
//for (int r = 0; r < 3; r++)
//{
//    for (int c = 0; c < 5; c++)
//    {
//        Console.Write($"R{r + 1}C{c + 1} ");
//    }
//    Console.WriteLine("");
//}

//arrays
//int[] numbers = new int[5];     // declare new array of count 5

//Console.Write("numbers array is [");
//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = i;
//    if (i == numbers.Length - 1)
//    {
//        Console.Write(numbers[i]);
//    }
//    else
//    {
//        Console.Write(numbers[i] + ", ");
//    }

//}
//Console.WriteLine("]");

//Console.WriteLine("numbers array element second from last is " + numbers[^2]);
//Console.WriteLine("numbers array element fourth from last is " + numbers[^4]);

//int[] newArray = new int[5] {31, 28, 31, 30, 31};   // declare and initialize new array of count 5

//string[] words = new string[] {"one", "two","three"};
//bool isPresent = false;
//for (int i = 0; i < words.Length; i++)
//{
//    if (words[i] == "three")
//    {
//        isPresent = true;
//        break;
//    }
//}
//Console.WriteLine(isPresent);

//char[,] charArray = new char[,]     // multi-dimensional array (array of 2 dimensions)
//                            {
//                                {'A', 'B', 'C' },
//                                {'D', 'E', 'F' }
//                            };
//var rows = charArray.GetLength(0);  // gets number of {} inside {}
//var columns = charArray.GetLength(1);   // gets number of elements inside each {}
//Console.WriteLine("rows count: " + rows);
//Console.WriteLine($"columns count: {columns}"); //string interpolation
//Console.WriteLine(charArray[0,0]);
//Console.WriteLine("index (i dont expect it to work): " + charArray.GetLength(3)); // Index out of bounds exception

// For-each Loops
//var words = new[] { "one", "two", "three", "four" };

//foreach (var word in words)
//{
//    Console.Write(word + " ");
//}

// List - size can be changed
//List<string> words = new List<string>();
//var wordArray = new[] { "One", "Two", "Three", "Four", "Five" };
//words.AddRange(wordArray);  // Add array items to list
//words.AddRange(new[] { "1", "2", "3", "4", "5" });  // instead of declaring new variable - directly create add array into AddRange method
//Console.WriteLine(words.Count); // 0
//words.Add("One");
//Console.WriteLine(words.Count); // 1
////words.Add("Two", "Three");  // Error: Will accept only one argument
//words.Add("Two");
//foreach (var item in words)
//{
//    Console.Write(item + " ");  // One Two
//}
//Console.WriteLine();
//Console.WriteLine("Index of 3: " + words.IndexOf("3")); //Index of 3: 7
//Console.WriteLine("Index of 'seven': " + words.IndexOf("seven")); //Index of 'seven': -1
//Console.WriteLine(words.Contains("one")); // False - case sensitive
//words.Remove("one");
//Console.WriteLine(words.Count); // 2 - did not remove because did not match "one"
//words.Remove("One");
//Console.WriteLine(words.Count); // 1
//words.Clear();
//Console.WriteLine(words.Count); // 0


// out keyword - used to return multiple values in functions - not commonly used
//var numberArray = new int[] { 1, -2, 3, -4, 5 };
//int plusCount, minusCount;
//var plusList = PositiveNumbers(numberArray, out minusCount, out plusCount);
//foreach (var num in plusList)
//{
//    Console.Write(num + " ");   // 1 3 5
//}
//Console.WriteLine();
//Console.WriteLine("Number of positive numbers is " + plusCount);    // Number of positive numbers is 3
//Console.WriteLine("Number of negative numbers is " + minusCount);   // Number of negative numbers is 2
//List<int> PositiveNumbers(int[] numArray, out int negativeNumCount, out int positiveNumCount) // negativeNumCount=minusCount, positiveNumCount=plusCount
//{
//    var positiveList = new List<int>();
//    negativeNumCount = 0;
//    positiveNumCount = 0;
//    foreach (var number in numArray)
//    {
//        if (number > 0)
//        {
//            positiveList.Add(number);
//            positiveNumCount++;
//        }
//        else
//        {
//            negativeNumCount++;
//        }
//    }
//    return positiveList;    //Dont need to return negativeNumCount, positiveNumCount - they modify minusCount, plusCount
//}

//Try Parse method
//Console.Write("Enter a number: ");
//var number = Console.ReadLine();
////Console.WriteLine("Number is " + int.Parse(number); // error if word is produced - "One" instead of "1"
//bool isNumber = int.TryParse(number, out int num);

//if (isNumber)
//{
//    Console.WriteLine("Number is " + num);
//}
//else
//{
//    Console.WriteLine(number + " is not a parse-able number");
//}
//Console.ReadKey();
