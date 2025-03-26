namespace BlazorApp1.Client.Services;

public class CounterService
{
    private int currentCount = 0;

    public int CurrentCount => this.currentCount;

    public void IncrementCount()
    {
        this.currentCount++;
    }
}
