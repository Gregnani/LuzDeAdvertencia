Console.Clear();

string temp, press, rpm;

Console.WriteLine("---Simulador de Luz de Advertência---");

Console.WriteLine("[A]tivado, [D]esativado\n");

Console.Write("Sensor de temperatura...:");
temp = Console.ReadLine()!.ToUpper();

Console.Write("Sensor de pressão.......:");
press = Console.ReadLine()!.ToUpper();

Console.Write("Sensor de rotação.......:");
rpm = Console.ReadLine()!.ToUpper();

if (temp == "A" && (press == "A" || rpm == "D")) {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("luz de advertência estará ATIVADA.");

} else {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Luz de advertência estará DESATIVADA.");
}
Console.ResetColor();