// Visokosna();
// PrimeNumbers();
DniMeseci(2007, 8);


void DniMeseci(int year, int month)
{
    int outputDays = 0;
    if (month < 8){
        if(month % 2 == 0 && month!= 2){
            outputDays = 30;
        } else if (month % 2 == 1)
        {
            outputDays = 31;
        } else {
            if(Visokosna(year)) {outputDays = 29;} else  {outputDays = 28;}
        }
    } else if (month > 7 && month< 13)
    {
        if(month % 2 == 0){
            outputDays = 31;
        } else if (month % 2 == 1)
        {
            outputDays = 30;
        }
    } else Console.WriteLine($"Nevalidna godina");
    Console.WriteLine($"{month} mesec vuv {year} godina ima {outputDays} dni");
    
}

static void PrimeNumbers() 
    {
        Console.WriteLine($"Molq vuvedete cqlo polojitelno chislo:");
        int n = int.Parse(Console.ReadLine());
        
        bool[] numbers = new bool[n];
        for (var i = 0; i < numbers.Length; i++)
        {
            numbers[i] = true;
        }
        
        for (var i = 2; i < numbers.Length; i++)
        {
            for (var j = i+1; j < numbers.Length; j++)
            {
                if(j % i == 0){
                    numbers[j] = false;
                }
            }
        }

        Console.WriteLine($"Prime numbers: {numbers}");
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i]) { Console.WriteLine($"{i}");}
        }
    }


bool Visokosna(int year)
{
    // int year = 0;
    // while (year != 99999)
    // {
        // Console.WriteLine($"Molq vuvedete godina:");
        
        // year = int.Parse(Console.ReadLine());

        // string output = "ne e visokosna";
        // if (year % 4 == 0) {
        //     output = "e visokosna";
        //     if (year % 100 == 0) {
        //         output = "ne e visokosna";
        //         if (year % 400 == 0) 
        //         {
        //             output = "e visokosna";
        //         }
        //     } 
            
        // }

        // Console.WriteLine($"Godinata {year} {output}!");

        bool output = false;
        if (year % 4 == 0) {
            output = true;
            if (year % 100 == 0) {
                output = false;
                if (year % 400 == 0) 
                {
                    output = true;
                }
            } 
            
        }

        return output;

    // }
}

