// ________________________________________________________________________________________________________________________________
// Даны натуральные числа а, b. Вычислить произведение a · b, используя в программе лишь операции +, -, =, <>.
// Console.Write("Введите число 'a': ");
// int number_a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 'b': ");
// int number_b = Convert.ToInt32(Console.ReadLine());

// // для проверки

// Console.WriteLine($"'{number_a}' умножить на '{number_b}' будет '{number_a * number_b}'");


// int courant = 0;
// int number_a_2 = 0;

// while(courant < number_b)
// {
//     number_a_2 += number_a;
//     courant++;
// }
// Console.WriteLine($"'{number_a}' умножить на '{number_b}' будет '{number_a_2}'");

// ________________________________________________________________________________________________________________________________

// Дано целое число а и натуральное (целое неотрицательное) число n. Вычислить a в степени n.
// Другими словами, необходимо составить программу, при исполнении которой значения переменных а и n не меняются,
// а значение некоторой другой переменной (например, b) становится равным an.
// (При этом разрешается использовать и другие переменные.)

// Console.Write("Введите число 'a': ");
// int number_a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 'b': ");
// int number_b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"'{number_a}' степени '{number_b}' будет '{Math.Pow(number_a, number_b)}'");

// // или

// int courant = 0;
// int number_a_2 = 1;

// while(courant < number_b)
// {
//     number_a_2 = number_a_2 * number_a;
//     courant += 1;
// }
    
// Console.WriteLine($"'{number_a}' степени '{number_b}' будет '{number_a_2}'");


// ________________________________________________________________________________________________________________________________


// Решить предыдущую задачу, не используя дополнительных переменных
// (и предполагая, что значениями целых переменных могут быть произвольные целые числа).

// Console.Write("Введите число 'a': ");
// int number_a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 'b': ");
// int number_b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"'a' равно '{number_a}' и 'b' равно '{number_b}'");

// number_a = number_a + number_b; // a = a+b
// number_b = number_a - number_b; // b = a+b - b(a)
// number_a = number_a - number_b; // a = a+b - b(a)

// Console.WriteLine($"теперь:\n'a' равно '{number_a}' и 'b' равно '{number_b}'");

// ________________________________________________________________________________________________________________________________

// Даны две целые переменные a, b. Составить фрагмент программы, после исполнения которого значения
// переменных поменялись бы местами (новое значение a равно старому значению b и наоборот).

// Console.Write("Введите число 'a': ");
// int number_a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 'b': ");
// int number_b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"'a' равно '{number_a}' и 'b' равно '{number_b}'");

// int temp = number_a; // временная переменная, записываем
// number_a = number_b;
// number_b = temp;

// Console.WriteLine($"теперь:\n'a' равно '{number_a}' и 'b' равно '{number_b}'");

// ________________________________________________________________________________________________________________________________

// Даны два действительных числа а и Ь. Получить их сумму, разность и произведение.

// Console.Write("Введите число 'a': "); // запрашиваем число
// int number_a = Convert.ToInt32(Console.ReadLine()); // получаем от пользователя число


// Console.Write("Введите число 'b': "); // запрашиваем число
// int number_b = Convert.ToInt32(Console.ReadLine()); // получаем от пользователя число

// int result_1 = number_a + number_b;  // получаем сумму
// int result_2 = number_a - number_b;  // получаем разность
// int result_3 = number_a * number_b;  // получаем произведение

// Console.WriteLine($"Сумма чисел {number_a} и {number_b} равна '{result_1}'");
// Console.WriteLine($"Разность чисел {number_a} и {number_b} равна '{result_2}'");
// Console.WriteLine($"Произведение чисел {number_a} и {number_b} равна '{result_3}'");


// ________________________________________________________________________________________________________________________________