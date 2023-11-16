internal static class CSharp12
{
    public static void Run()
    {
        // Collection expressions are a unified syntax:

        int[] x1 = [1, 2, 3, 4];
        int[] x2 = [];
        //WriteByteArray([1, 2, 3]);
        List<int> x4 = [1, 2, 3, 4];
        //Span<DateTime> dates = [GetDate(0), GetDate(1)];
        //WriteByteSpan([1, 2, 3]);


        // New spread operator

        int[] numbers1 = [1, 2, 3];
        int[] numbers2 = [4, 5, 6];
        int[] moreNumbers = [.. numbers1, .. numbers2, 7, 8, 9];
        // moreNumbers contains [1, 2, 3, 4, 5, 6, 7, 8, ,9];
    }


    //Primary constructors on any class or struct
    public class BankAccount(string accountID, string owner)
    {
        public string AccountID { get; } = accountID;
        public string Owner { get; } = owner;

        public override string ToString() => $"Account ID: {AccountID}, Owner: {Owner}";
    }
}
