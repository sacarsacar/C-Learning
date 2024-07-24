internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\n\t\t\t\tCondtional Operator:\n");
        int temp = 30;

        // Can be also called ShortForm of if else:
        Console.WriteLine((temp >= 20) ? "It's too hot outside!" : "It's cold outside!");

        Console.WriteLine("\n\t\t\t\tMulti_Dimensional Arrays:\n");

        string[,] friends ={
            {"Anup Dhakal ", "Biswash Poudel ", "Santosh Dahal " },
            {"Sujan Karki ", "Surendra Thapa ", "Manjil Khadka "},
            {"Mingtendu Sherpa ","Nigmatendi Sherpa ", "Utshav Dulal "}
                            };

        // Replacing Mingtendu Sherpa with Bigyan Rai (row 2,column 1)
        friends[2, 1] = "Bigyan Rai ";

        //Displaying using foreach loop
        foreach (string sathi in friends)
        {
            Console.WriteLine(sathi);
        }

        Console.WriteLine("\n---------------------------------------------------\n");

        // Displaying Using Nested Loop (like Matrix):

        for (int i = 0; i < friends.GetLength(0); i++)
        {
            for (int j = 0; j < friends.GetLength(1); j++)
            {
                Console.Write(friends[i, j] + " ");
            }
            Console.WriteLine();

        }
        Console.ReadKey();
    }
}