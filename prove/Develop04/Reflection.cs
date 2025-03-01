public class Reflection : Mindfulness
{
    private int _timer;
    private string _reflectionDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    private string[] _reflectionPrompts =
    [
"Think of a time when you stood up for someone else.",
"Think of a time when you did something really difficult.",
"Think of a time when you helped someone in need.",
"Think of a time when you did something truly selfless."];
    private string[] _reflectionQuestions =
    [
"Why was this experience meaningful to you?",
"Have you ever done anything like this before?",
"How did you get started?",
"How did you feel when it was complete?",
"What made this time different than other times when you were not as successful?",
"What is your favorite thing about this experience?",
"What could you learn from this experience that applies to other situations?",
"What did you learn about yourself through this experience?",
"How can you keep this experience in mind in the future?"
    ];

    public Reflection(string activityName) : base(activityName)
    {
        base._description = _reflectionDescription;
    }

    public void ReflectionActivity()
    {
        base.StartingMessage();
        _timer = base._duration;
        Random random = new Random();
        int randInt = random.Next(0, _reflectionPrompts.Length - 1);
        string prompt = _reflectionPrompts[randInt];

        Console.WriteLine(prompt);
        Console.WriteLine("Press Enter to Continue: ");
        Console.ReadKey();

        while (_timer > 0)
        {
            //Add in logic to not repeat questions
            randInt = random.Next(0, _reflectionQuestions.Length - 1);
            Console.WriteLine();
            Console.WriteLine(_reflectionQuestions[randInt]);
            base.WaitAnimation(30);
            _timer = _timer - 10;
        }
        base.EndingMessage();
        Console.WriteLine();


    }
}