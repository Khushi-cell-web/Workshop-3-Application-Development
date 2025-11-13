namespace Task2;

internal class NullOperators
{
    public void PerformNullChecks()
    {
        // Declare variable as null
        string username = null;

        // Check using ternary operator
        string ternaryResult = (username == null) ? "Username is not available" : username;
        Console.WriteLine("Ternary Operator Result: " + ternaryResult);

        // Check using null-coalescing operator
        string coalescingResult = username ?? "Username is not available";
        Console.WriteLine("Null-Coalescing Operator Result: " + coalescingResult);

        // Assign value using null-coalescing assignment
        username ??= "DefaultUser";
        Console.WriteLine("After Null-Coalescing Assignment, username = " + username);
    }
}