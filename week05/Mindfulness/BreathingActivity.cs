
public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", 
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { }

    public void Run()
    {
        DisplayStartingMessage();
        for (int i = 0; i < _duration; i += 6)
        {
            Console.Write("\nBreathe in.... ");
            ShowCountDown(4);
            Console.Write("Now Breathe out.... ");
            ShowCountDown(6);
        }
        DisplayEndingMessage();
    }
}
