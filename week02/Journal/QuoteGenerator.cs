public class QuoteGenerator//this is my creative addition
{
    private List<string>quotes = new List<string>()
        { 
          "'I asked God to send me a swordsman/ and God says 'look at your hands''. -Melissa Broder",
          "'Any moment might be our last. Everything is more beautiful because we are doomed. You will never be lovlier than you are now. We will never be here again'.- Homer, The Iliad",
          "'You can choose courage, or you can choose comfort, but you cannot choose both'.-Brene Brown",
          "'Beware the barrenness of a busy life'.-Socrates",
          "'Dont treat people as as bad as they are, treat them as good as you are'.",
          "'The secret to happiness, you see, is not found in seeking more, but in developing the capacity to enjoy less.'- Socretes",
          "'Nothing gold can stay.'- Robbert Frost"
        };

    public string GetRandomQuote()
    {
        Random random = new Random();
        int index = random.Next(quotes.Count);
        return quotes[index];
    }
}