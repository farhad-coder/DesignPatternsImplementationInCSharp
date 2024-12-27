
using StrategyProject;

List<int> numbers = new List<int> { 9, 8, 4, 6, 5, 7 };

SortContext context = new SortContext();

context.SetSortStrategy(new BubbleSort());
context.Sort(numbers);

for (int i = 0; i < numbers.Count; i++)
{

}


context.SetSortStrategy(new QuickSort());
context.Sort(numbers);

context.SetSortStrategy(new InsertionSort());
context.Sort(numbers);
