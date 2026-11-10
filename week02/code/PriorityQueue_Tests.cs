
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add three items with different priorities.
    // The item with the highest priority is added last.
    // Expected Result: High, Medium, Low.
    // Defect(s) Found: The last item is not checked
    // when searching for the highest priority.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        // Step 1: Add items with different priorities.
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 3);
        priorityQueue.Enqueue("High", 5);

        // Step 2: Verify highest priority comes first.
        Assert.AreEqual("High", priorityQueue.Dequeue());
        Assert.AreEqual("Medium", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add items with the same priority.
    // Expected Result: First, Second, Third.
    // Defect(s) Found: The queue uses >= instead of >,
    // causing later items to be selected first.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        // Step 1: Add items with equal priorities.
        priorityQueue.Enqueue("First", 5);
        priorityQueue.Enqueue("Second", 5);
        priorityQueue.Enqueue("Third", 5);

        // Step 2: Verify FIFO order.
        Assert.AreEqual("First", priorityQueue.Dequeue());
        Assert.AreEqual("Second", priorityQueue.Dequeue());
        Assert.AreEqual("Third", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Remove all items and then dequeue again.
    // Expected Result: Each item is removed after dequeue.
    // An empty queue throws InvalidOperationException.
    // Defect(s) Found: Dequeue returns an item without
    // removing it from the queue.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        // Step 1: Add two items.
        priorityQueue.Enqueue("First", 2);
        priorityQueue.Enqueue("Second", 1);

        // Step 2: Verify items are removed in order.
        Assert.AreEqual("First", priorityQueue.Dequeue());
        Assert.AreEqual("Second", priorityQueue.Dequeue());

        // Step 3: Verify the queue is empty.
        var exception = Assert.ThrowsException<InvalidOperationException>(
            () => priorityQueue.Dequeue()
        );

        Assert.AreEqual("The queue is empty.", exception.Message);
    }
}
