namespace OrangeTreeSim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            OrangeTree træ1 = new OrangeTree();
            // Træ er 0 år = 0 appelsiner
            Console.WriteLine($"Age: {træ1.Age},Oranges: {træ1.NumOranges}");
            
            træ1.OneYearPasses();
            // Træ er 1 år = 0 appelsiner
            Console.WriteLine($"Age: {træ1.Age},Oranges: {træ1.NumOranges}");

            træ1.OneYearPasses();
            // Træ er 2 år = 5 appelsiner
            Console.WriteLine($"Age: {træ1.Age},Oranges: {træ1.NumOranges}");

            træ1.OneYearPasses();
            // Træ er 3 år = 10 appelsiner
            Console.WriteLine($"Age: {træ1.Age},Oranges: {træ1.NumOranges}");
            
            træ1.OneYearPasses();           
            // Træ er 4 år = 15 appelsiner
            Console.WriteLine($"Age: {træ1.Age},Oranges: {træ1.NumOranges}");

            træ1.EatOrange(10);
            // Træ er 4 år men har fået spist 10 appelsiner. Så har kun 5 appelsiner tilbage
            Console.WriteLine($"Age: {træ1.Age},Oranges: {træ1.NumOranges}");



            Console.ReadLine();
        }
    }
}