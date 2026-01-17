using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add 4 elements and dequeue the one with max priority
    // Expected Result: A queue with out "IamNum03" since it is the one with max priority.
    // Defect(s) Found: the limit on the for loop was incorrect, I removed the -1.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("IamNum01", 2);
        priorityQueue.Enqueue("IamNum02", 1);
        priorityQueue.Enqueue("IamNum03", 5);
        priorityQueue.Enqueue("IamNum04", 0);
        // Console.WriteLine($"Items {priorityQueue}");
        var res = priorityQueue.Dequeue();
        // Console.WriteLine($"Dequeued: {res}");
        Assert.AreEqual(res, "IamNum03", "Dequeue the item with max priority");
    }

    [TestMethod]
    // Scenario: Add 5 items and delete 4 of them, two of the item have the same priority, and the first one of the list should be deleted first.
    // Expected Result: "IamNum03 IamNum01 IamNum04 IamNum05"
    // Defect(s) Found: Item was not been deleted, condion assigne the correct priority.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("IamNum01", 2);
        priorityQueue.Enqueue("IamNum02", 0);
        priorityQueue.Enqueue("IamNum04", 1);
        priorityQueue.Enqueue("IamNum03", 9);
        priorityQueue.Enqueue("IamNum05", 1);
        var testRes = "";
        for (int i = 1; i < 5; i++)
        {
            var res = priorityQueue.Dequeue();
            testRes = testRes + " " + res;
            Console.WriteLine($"Dequeued: {testRes}");
        }
        Assert.AreEqual(testRes, " IamNum03 IamNum01 IamNum04 IamNum05", "Items deleted by priority.");
    }

    // Add more test cases as needed below.
}