double e = 2.7182818284590452353602874713527;
double x = 2.444, y = 0.869 * Math.Pow(10, -2), z =-0.13*Math.Pow(10, 3);
var h = ((Math.Pow(x, y - 1) + Math.Pow(e, y - 1)
    / (1 + x * (Math.Abs(y - Math.Tan(z)) * (1 + Math.Abs(y - x)) + (Math.Pow(Math.Abs(x - y), 2) / 2) - (Math.Pow(Math.Abs(y - x), 2) / 3)))));
Console.WriteLine(h);