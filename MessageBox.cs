class MessageBox {
    const string windowOpenMessage = "Window is open";
    const string windowCloseMessage = "Window is close";
    const int sleep = 2000;

    public event Action<State> StateHandler;

    public async void Open() {
        Console.WriteLine(windowOpenMessage);
        
        await Task.Delay(sleep);
        
        Console.WriteLine(windowCloseMessage);

        var randomState = new Random().Next() % 2 == 0 ? State.Ok : State.Cancel;
        StateHandler(randomState);
    }
}