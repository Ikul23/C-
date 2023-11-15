using System;

class Program
{
    static void Main()
    {
        // Исходные данные
        int distance = 10000;  // Начальное расстояние между друзьями
        int firstFriendSpeed = 1;  // Скорость первого друга
        int secondFriendSpeed = 2;  // Скорость второго друга
        int dogSpeed = 5;  // Скорость собаки
        int count = 0;  // Счетчик пройденных интервалов времени

        // Цикл продолжается, пока расстояние между друзьями больше 10
        while (distance > 10)
        {
            // Рассчитываем время, которое нужно первому другу и второму другу
            double timeToReachFirstFriend = (double)distance / (firstFriendSpeed + dogSpeed);
            double timeToReachSecondFriend = (double)distance / (secondFriendSpeed + dogSpeed);

            // Используем время второго друга (можно также использовать время первого друга)
            double timeToReach = timeToReachSecondFriend;

            // Округляем время вверх и добавляем его к общему времени
            int roundedTimeToReach = (int)Math.Ceiling(timeToReach);
            count += roundedTimeToReach;

            // Обновляем расстояние в зависимости от времени, которое затратил второй друг и собака
            distance -= (secondFriendSpeed + dogSpeed) * roundedTimeToReach;
        }

        // Выводим результат - количество пройденных интервалов времени
        Console.WriteLine(count);
    }
}
