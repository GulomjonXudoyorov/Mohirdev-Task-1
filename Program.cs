//1-task

// Console.Write("Radiusni kiriting: ");
// double radius = Convert.ToDouble(Console.ReadLine());


// double pi = Math.PI;


// double S = pi * Math.Pow(radius, 2);
// double L = 2 * pi * radius;


// Console.WriteLine($"S = {S:F13}");
// Console.WriteLine($"L = {L:F13}");


//2-task

// Console.Write("Qiymatni kiriting: ");
// double qiymat = Convert.ToDouble(Console.ReadLine());

// double kurs = 12400;
// double result = qiymat*kurs;
// Console.WriteLine($"Natija: {result} so'm");

//3-task 

Console.Write("Tug'ilgan yilingiz:");
int yearOftheBirth = Convert.ToInt32(Console.ReadLine());
int calculate = DateTime.Now.Year - yearOftheBirth;
int result = calculate * 365;
Console.WriteLine($"Sizning yoshingiz kunlarda: {result}");