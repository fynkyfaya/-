int[] Sort(int[] arr) {
    int temperance;
    for (var write = 0; write < arr.Length; write++) {
        for (var sort = 0; sort < arr.Length - 1; sort++) {
            if (arr[sort] < arr[sort + 1]) {
                temperance = arr[sort + 1];
                arr[sort + 1] = arr[sort];
                arr[sort] = temperance;
            }
        }
    }
    return arr;
}

void PrintArray(int[] arr) {
    foreach (var element in arr) {
        Console.Write($"{element} ");
    }
    Console.WriteLine();
}

var random = new Random();

var firstArray = new int[20];
for (var i = 0; i < firstArray.Length; i++) firstArray[i] = random.Next(1, 10);
PrintArray(firstArray);
PrintArray(Sort(firstArray));

var secondArray = new int[20];
for (var i = 0; i < secondArray.Length; i++) secondArray[i] = random.Next(1, 100);
PrintArray(secondArray);
PrintArray(Sort(secondArray));