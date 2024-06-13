using System;

public class Answer
{
    static string[] AskArr()
    {
        repeat:
        Console.WriteLine("Input a custom Array?(y/n):");
        if( Console.ReadLine()=="y")
        {
            Console.WriteLine("Input Custom Array size:");
            int size = Int32.Parse(Console.ReadLine());
            string[] Arr = new string[size];
            
            for(int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine("Cell "+i+" value:");
                Arr[i] = Console.ReadLine();
            }    
            
            return Arr;
        }
        if( Console.ReadLine()=="n")
        {
            string[] Arr= {"1","hello",".","2345"};
            return Arr;
        }
        else
        {
            Console.WriteLine("unrecognised answer. try again.");
             goto repeat;   
        }
    } 

    static void WriteArr(string[] Arr)
    {
        Console.Write("[");
        for (int i = 0;i<Arr.Length;i++)
        {
            if(i==0)
            {Console.Write(Arr[i]);}
            else
            {Console.Write(", "+Arr[i]);}
        }
        Console.WriteLine("]");   
    }

    static string[] Task1(string[] arr)
    {
        string[] newArr = new string[arr.Length];

        //simple counter and initial filing of all strings
        int i = 0;
        foreach (string line in arr)
        {
            if (line.Length<=3)
            {
                newArr[i]=line;    
                i++;
            }
        }

        //cutting off of all empty cells of the array before returning it
        //c++ snippet
        string[] outArr = new string[i];
        for (int j=0;j<i;j++)
        {
        outArr[j]=newArr[j];
        }
        return outArr;
        
        //c# snippet
        ///Array.Resize(ref newArr, i);
        ///return newArr;
    }


    public static void Main()
    {
        string[] inArray = AskArr();
        Console.Write("Current Array is:  ");
        WriteArr(inArray);

        string[] answ = Task1(inArray);

        Console.Write("Strings of length 3 or less are:  ");
        WriteArr(answ);  
    }
}

