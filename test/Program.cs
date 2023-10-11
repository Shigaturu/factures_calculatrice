using System.Text.RegularExpressions;

bool done2 = false;
while (!done2)
{
    try
    {
        Console.WriteLine("Saisir l'opération ");
        string operation = Console.ReadLine();

        MatchCollection operatorMatches = Regex.Matches(operation, @"[\+\-\*\/]");
        string[] operators = new string[operatorMatches.Count];

        MatchCollection matches = Regex.Matches(operation, @"\d+");
        int[] numbers = new int[matches.Count];

        for (int i = 0; i < matches.Count; i++)
        {
            numbers[i] = int.Parse(matches[i].Value);
        }

        for (int i = 0; i < operatorMatches.Count; i++)
        {
            operators[i] = operatorMatches[i].Value;
        }

        int[] numbersInt = numbers.ToArray();



        int result = numbersInt[0];

        for (int i = 0; i < operators.Length; i++)
        {
            int nextNumber = numbersInt[i + 1];
            string currentOperator = operators[i];

            switch (currentOperator)
            {
                case "+":
                    result += nextNumber;
                    break;
                case "-":
                    result -= nextNumber;
                    break;
                case "*":
                    result *= nextNumber;
                    break;
                case "/":
                    if (nextNumber != 0)
                        result /= nextNumber;
                    else
                    {
                        Console.WriteLine("Division par zéro n'est pas autorisée.");
                        
                    }
                    break;
                default:
                    Console.WriteLine("Opérateur non pris en charge.");
                     
                    break;
            }
        }

        Console.WriteLine("Le résultat de l'opération est : " + result);
        done2 = true;
        

    }
    catch
    {
        Console.WriteLine("Saisie incorrecte");
    }
}
