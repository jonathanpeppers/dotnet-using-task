namespace MyTasks;

using Microsoft.Build.Framework;

public class MyTask : Microsoft.Build.Utilities.Task
{
    public override bool Execute()
    {
        Log.LogMessage(MessageImportance.High, "Assembly: " + GetType().Assembly.GetName());
        return true;
    }
}
