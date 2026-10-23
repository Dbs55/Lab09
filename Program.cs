// for (int room = 5; room <= 20; room += 5) { System.Console.WriteLine($"Кабинет {room}"); }
// int totalWeeks = 3;
// for (int week = 1; week <= totalWeeks; week++) { for (int day = 1; day <= 5; day++) { System.Console.WriteLine($"Неделя{week}, день {day}"); }
//  System.Console.WriteLine("^_^"); }
int count = 0;
for (int ticket = 1; ticket <= 30; ticket++)
{
    if (ticket == 4 || ticket == 12 || ticket == 19) { count++; continue; }
    System.Console.WriteLine($"Первый доступный билет: {ticket}, Билетов было пропущено: {count}");
    break;
}