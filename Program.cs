var operacao = args[0];
var n1 = Convert.ToDouble(args[1]);
var n2 = Convert.ToDouble(args[2]);

if (operacao == "Somar")
{
    Console.WriteLine(n1+n2);
}

if(operacao == "Subtrair")
{
    Console.WriteLine(n1-n2);
}