using UnityEngine;
using System.Collections;

public class Timer
{
    private static MonoBehaviour behaviour;
    public delegate void Task();

    public static void Schedule(MonoBehaviour _behaviour, float delay, Task task)
    {
        behaviour = _behaviour;
        behaviour.StartCoroutine(DoTask(task, delay));
    }

    private static IEnumerator DoTask(Task task, float delay)
    {
        if (delay == 0) yield return 0;
        else yield return new WaitForSeconds(delay);
        task();
    }
}
