// // double score = 1200;
// // if (score >= 500)
// // {
// //     Console.WriteLine("Новичок");
// // }
// // else if (score >= 2000){
// //     Console.WriteLine("Боец");
// //     }else
// // {
// //     Console.WriteLine("Бонусный уровень закрыт");
// // }
// // Console.WriteLine("Игра продолжается");

// // // // int movieNumber = int.Parse(Console.ReadLine());
// // // // string movieGenre;
// // // // switch (movieNumber)
// // // // {
// // // //     case 1:
// // // //         movieGenre = "Боевик";
// // // //         break;
// // // //     case 2:
// // // //         movieGenre = "Комедия";
// // // //         break;
// // // //     default:
// // // //         movieGenre = "Неизвестный жанр";
// // // //         break;
// // // // }
// // // // Console.WriteLine(movieGenre);

// // // using System.IO.Pipelines;
// // // using System.Runtime.InteropServices;

// // int score = 3200;
// // int recordScore = 3000;
// // string result = (score > recordScore) ?
// // "Новый рекорд!" : "Обычный результат!";
// // // if (score > recordScore)
// // //     result = "Новый рекорд";
// // // else
// // //     result = "Обычный результат";
// //  Console.WriteLine(result);

// // Вариант 8

// using System.IO.Pipelines;
// using System.Security.Cryptography.X509Certificates;
// Console.WriteLine(".");
// string tip;
// string treul;
// int str1 = int.Parse(Console.ReadLine());
// int str2 = int.Parse(Console.ReadLine());
// int str3 = int.Parse(Console.ReadLine());
// if (str1 + str2 > str3 || str2 + str3 > str1 || str1 + str3 > str2)
// {
//     treul = "Треугольник существует";
// }
// else
// {
//     treul = "Треугольник не существует";
// }
// if ((str1 - str2==0) && (str1-str3==0) && (str2-str3==0))
// {
//     tip = "Равносторонний";
// }
// else if (str1 == str2 || str2 == str3 || str3 == str1)
// {
//     tip = "Равнобедренный";
// }
// else if ((str1 - str2!=0) && (str1-str3!=0) && (str2-str3!=0))
// {
//     tip = "Разносторонний";
// }
// else
// {
//     tip = "Треугольник не существует";
// }
// Console.WriteLine(treul);
// Console.WriteLine(tip);

// Вариант 2
// 1номер
// using System.Collections;

// double distance = double.Parse(Console.ReadLine());
// if (distance > 30)
// {
//     Console.WriteLine("Требуется согласование маршрута");
// }
// else
// {
//     Console.WriteLine("Согласование маршрута не требуется");
// }

// // номер2
// double rating = double.Parse(Console.ReadLine());
// if (rating >= 4.5)
// {
//     Console.WriteLine("Водитель высшей категории");
// }
// else
// {
//     Console.WriteLine("Обычный водитель");
// }

// //номер3
// double distant = double.Parse(Console.ReadLine());
// if (distant <= 2)
// {
//     Console.WriteLine("Минимальный тариф");
// }
// if (distant > 2 & distant <= 10)
// {
//     Console.WriteLine("Стандартный тариф");
// }
// if (distant > 10 & distant <= 30)
// {
//     Console.WriteLine("Загородный тариф");
// }
// if (distant > 30)
// {
//     Console.WriteLine("Требуется индивидуальный расчёт");
// }

//номер4

int distance = int.Parse(Console.ReadLine());
switch (distance)
{
    if (distance >= 1 & distance <= 3) {
        case 1:
        Console.WriteLine("Эконом");
        break;

    case 2:
        Console.WriteLine("Комфорт");
        break;

    case 3:
        Console.WriteLine("Бизнес");
        break;
    }
}
//1