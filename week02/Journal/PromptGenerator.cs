public class PromptGenerator
{
    private List<string>prompts = new List<string>()
        { 
          "What is one thing you got better at today?",
          "Three things I love about my body and why.",
          "What's somthing you are greatful for today and why.",
          "What is one goal you have for the next week?",
          "Whats somthing that makes you afraid? Will you ever do /conquore it?",
          "Whats one thing standing between you and your goals?",
          "What challenge from today made you strong?",
          "Whats somthing you can let go of to feel more peace?",

          "Whats one thing your younger self would be proud of?",
          "What art did you create or enjoy today?"
        };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}
