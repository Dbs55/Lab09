// for (int room = 5; room <= 20; room += 5) { System.Console.WriteLine($"Кабинет {room}"); }
// int totalWeeks = 3;
// for (int week = 1; week <= totalWeeks; week++) { for (int day = 1; day <= 5; day++) { System.Console.WriteLine($"Неделя{week}, день {day}"); }
//  System.Console.WriteLine("^_^"); }
// int count = 0;
// for (int ticket = 1; ticket <= 30; ticket++)
// {
//     if (ticket == 4 || ticket == 12 || ticket == 19) { count++; continue; }
//     System.Console.WriteLine($"Первый доступный билет: {ticket}, Билетов было пропущено: {count}");
//     break;
// }
//Вариант А

// for (int N = 77; N != 0; N--) {
//     if (N % 2==1){System.Console.WriteLine(N);}}

//Вариант Б

// for (int N = 110; N >= 0; N = N - 10) { System.Console.WriteLine(N); }

// 2
// int M = 3;
// for (int N = 37; N >= 0; N = N - M) {System.Console.WriteLine(N); }

// 5
for (int C = 1; C!=100; C++)
{
    if(C % 3 == 0 && C % 5 ==0) { System.Console.WriteLine(C); break; }
}