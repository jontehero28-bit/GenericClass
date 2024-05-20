while (true)
{
    Console.WriteLine("Hej välkommen till Task Planner Som hanterar två stycken tasks som du behöver göra!");
    Console.WriteLine("Skriv två stycken tasks och när du gör klart en av de du kan radera en av de.");
    Console.WriteLine("Skriv en task");

    List<string> Task = new();     //skapar listan med Task yo

    string Chore1 = Console.ReadLine();
    Task.Add(Chore1);                    // Skriv en input och lägg till det i task lista yo

    Console.WriteLine("skriv något mer");
    string Chore2 = Console.ReadLine();
    Task.Add(Chore2);                      //kollar om det finns en ny input och lägg till det i task lista yo

    Console.WriteLine("Vilken task vill du ta bort? 1 - första, 2 - sista");
    string ChoreCompleted = Console.ReadLine(); //Frågar användaren vilken input man ska ta bort yo

    if (ChoreCompleted == "1")
    {
        Queue<string> TaskQueue = new(Task); //skapar en Queue av listan task
        TaskQueue.Dequeue();                 //så den ska ta bort den med lägst index. Den första man lägger till ska ha lägst index yo
        foreach (var item in TaskQueue)
        {
            Console.WriteLine(item);         //skriver ut alla items i TaskQueue yo
        }
        
    }

    else
    {
        Stack<string> TaskStack = new(Task);    //skapar en lista TaskStack av listan Task. Precis som jag gjorde föra gången yo
        TaskStack.Pop();                        //tar bort översta i stack Taskstack

        foreach (var item in TaskStack)         //den senaste tas bort yo.
        {
            Console.WriteLine(item);  //skriv ut that
        }
        
    }
    
    Console.WriteLine("vill du köra programmet en gång till? Skriv Y/N");
    string Question = Console.ReadLine();     //frågar användaren om input sparar den i string question  yoo
    if (Question.ToUpper() == "Y")
    {
        Console.Clear();    //om string question = Y så clearar den konsolen yo
    }
    

    else
    {
        return;   //Om No så avslutar programmet  yoo
        
    }
    //kollar input av Y/N yo
}
//while loop för hela programmet. yo
//la till yoos i slutet av kommentarer för att
//du skulle säga yo i huvudet och känna sig yngre:) yo
