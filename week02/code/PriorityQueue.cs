public class PriorityQueue
{
    private List<PriorityItem> _queue = new();

    /// <summary>
    /// Add a new value to the queue with an associated priority.  The
    /// node is always added to the back of the queue regardless of 
    /// the priority.
    /// </summary>
    /// <param name="value">The value</param>
    /// <param name="priority">The priority</param>
    public void Enqueue(string value, int priority)
    {
        var newNode = new PriorityItem(value, priority);
        _queue.Add(newNode);
    }

    
public string Dequeue()
{
    // Step 1: Check if the queue is empty.
    if (_queue.Count == 0)
    {
        throw new InvalidOperationException("The queue is empty.");
    }

    // Step 2: Assume the first item has the highest priority.
    int highPriorityIndex = 0;

    // Step 3: Search through all remaining items.
    for (int index = 1; index < _queue.Count; index++)
    {
        // Step 4: Update only when a higher priority is found.
        // Using > preserves FIFO order for equal priorities.
        if (_queue[index].Priority > _queue[highPriorityIndex].Priority)
        {
            highPriorityIndex = index;
        }
    }

    // Step 5: Save the value of the highest-priority item.
    string value = _queue[highPriorityIndex].Value;

    // Step 6: Remove the selected item from the queue.
    _queue.RemoveAt(highPriorityIndex);

    // Step 7: Return the selected value.
    return value;
}


    // DO NOT MODIFY THE CODE IN THIS METHOD
    // The graders rely on this method to check if you fixed all the bugs, so changes to it will cause you to lose points.
    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}

internal class PriorityItem
{
    internal string Value { get; set; }
    internal int Priority { get; set; }

    internal PriorityItem(string value, int priority)
    {
        Value = value;
        Priority = priority;
    }

    // DO NOT MODIFY THE CODE IN THIS METHOD
    // The graders rely on this method to check if you fixed all the bugs, so changes to it will cause you to lose points.
    public override string ToString()
    {
        return $"{Value} (Pri:{Priority})";
    }
}