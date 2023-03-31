// decimal to binary
Console.WriteLine("O'nlik sanoq sistemasidagi sonni kiriting");
int decimalNumber = Convert.ToInt32(Console.ReadLine());

string binaryNumber = Convert.ToString(decimalNumber, 2);

Console.WriteLine(binaryNumber);

//binary to decimal
Console.Write("Ikkilik sanoq sistemasidagi sonni kiriting: ");
string binary = Console.ReadLine();

int decimalNum = Convert.ToInt32(binary, 2);
Console.WriteLine("Number: " + decimalNum);
