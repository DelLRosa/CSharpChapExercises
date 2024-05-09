   string alice = @"Alice was beginning to get very tired of sitting by her sister on the
   bank, and of having nothing to do: once or twice she had peeped into the
   book her sister was reading, but it had no pictures or conversations in
   it, 'and what is the use of a book,' thought Alice 'without pictures or
   conversation?'";
   
   Console.WriteLine(alice);
   Console.WriteLine("What sentence would you like to look for in the sentence above?");
   string? searchTerm = Console.ReadLine();
   string compSearchTerm = searchTerm.ToLower();
   string compAlice = alice.ToLower();
   string[] aliceArr = compAlice.Split(' ');
 
// foreach (var word in aliceArr)
// {
//     System.Console.WriteLine(word);
// }

    int index= compAlice.IndexOf(compSearchTerm, 0);
   if (compAlice.IndexOf(compSearchTerm, 0) != -1)
   {
    System.Console.WriteLine(index);
      Console.WriteLine("true");
   }
   else 
   {
      Console.WriteLine("false");
   }




