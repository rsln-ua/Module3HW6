const string successMessage = "Successful";
const string failMessage = "Not successful";

void StateHandler (State state) {
    if (state == State.Ok) Console.WriteLine(successMessage);
    else Console.WriteLine(failMessage);
}

var messageBox = new MessageBox();
messageBox.StateHandler += StateHandler;

var tcs = new TaskCompletionSource();

messageBox.StateHandler += (_) => {
    tcs.SetResult();
};

messageBox.Open();
await tcs.Task;