static void ArrayExamples()
{
    // Methods and properties of Arrays.

    var numbers = new[] { 3, 7, 9, 2, 14 };

    // Length of array
    Console.WriteLine("Length of the array is: " + numbers.Length);

    // IndexOf method
    int index = Array.IndexOf(numbers, 12);
    Console.WriteLine(index);

    // Clear Method => This sets the element which are selected to default value
    Array.Clear(numbers, 0, 2);
    Console.WriteLine("Effect of Clear()");
    foreach (var num in numbers) Console.WriteLine(num);

    // Copy method

    int[] destinationArray = new int[3];
    Array.Copy(numbers, destinationArray, 3);
    Console.WriteLine("Effect of Copy()");
    foreach (var num in destinationArray) Console.WriteLine(num);

    //Sort Method

    Array.Sort(numbers);
    Console.WriteLine("Effect of Sort()");
    foreach (var num in numbers) Console.WriteLine(num);

    // Reverse Method

    Array.Reverse(numbers);
    Console.WriteLine("Effect of Reverse()");
    foreach (var num in numbers) Console.WriteLine(num);
}

static void ListExamples()
{
    var numbers = new List<int>() { 1,2,3,4};
    numbers.Add(5);
    numbers.AddRange(new int[4] {6, 4 ,7,8});
    numbers.Remove(1);


    foreach (var num in numbers) Console.Write(num + " ");
    Console.WriteLine();
    Console.WriteLine("The index of 4 is: " + numbers.IndexOf(4)); // Gives the first occourance
    Console.WriteLine("Last index of 4: " + numbers.LastIndexOf(4));

    for(int i=0; i<numbers.Count; i++)
    {
        if(numbers[i] == 4)
            numbers.Remove(numbers[i]);
    }

    Console.WriteLine("Count: " + numbers.Count);
    Console.WriteLine(numbers.Contains(4));
    //Console.WriteLine(numbers.Contains(50));
}


//ArrayExamples();

ListExamples();