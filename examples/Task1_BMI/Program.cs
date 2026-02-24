Console.Write("Введите ваш вес (в кг): ");
double weight = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите ваш рост (в метрах, например 1,75): ");
double height = Convert.ToDouble(Console.ReadLine());

double bmi = weight / (height * height);

string category;
string rec;

if (bmi < 18.5)
{
    category = "Недостаточный вес";
    rec = "Рекомендуется увеличить калорийность питания и проконсультироваться с врачом.";
}
else if (bmi >= 18.5 && bmi < 25)
{
    category = "Нормальный вес";
    rec = "Отлично! Поддерживайте текущий образ жизни.";
}
else if (bmi >= 25 && bmi < 30)
{
    category = "Избыточный вес";
    rec = "Рекомендуется увеличить физическую активность и скорректировать питание.";
}
else
{
    category = "Ожирение";
    rec = "Настоятельно рекомендуется проконсультироваться с врачом и разработать план снижения веса.";
}

Console.WriteLine($"Ваш вес: {weight} кг");
Console.WriteLine($"Ваш рост: {height} м");
Console.WriteLine($"ИМТ: {bmi:F2}");
Console.WriteLine($"Категория: {category}");
Console.WriteLine($"Рекомендация: {rec}");