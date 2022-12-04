using _6.HashTable;

var mapDemo = new MapDemo();
var datas = mapDemo.FindFirstRepeatingCharacter("A Green Apple");
//Console.WriteLine(datas);

//Console.WriteLine(mapDemo.hash("123456"));

var hashTable = new HashTableRefactoring();
hashTable.Put(6, "A");
hashTable.Put(8, "B");  
hashTable.Put(11, "C");
//hashTable.Put(6, "A+");
hashTable.Remove(6);


Console.WriteLine(hashTable);
//var getValue = hashTable.Get(11);
//Console.WriteLine(getValue);

/* 
 * dictionary example
 *
    Dictionary<int, string> data = new Dictionary<int, string>();
    data.Add(1, "Dip");
    data.Add(2, "Sayara");
    data.Add(3, "Antor"); 
    data.Add(4, "hello");
    data.Add(5, null);
    data.Remove(1);
    var value = data[2];

    Console.WriteLine(data.ContainsKey(2)); // 0(1)
    Console.WriteLine(data.ContainsValue("Antor"));// O(n)
    Console.WriteLine(value);

    foreach (var item in data)
    {
        Console.WriteLine(item.Value);
    }
*/

/*
 * Set Example 
 * 
    var set = new HashSet<int>();
    int[] numbers = { 1, 2, 3, 3, 4, 4, 1, 5, };

    foreach (int number in numbers)
    {
        set.Add(number);
    }

    foreach (int item in set)
    {
        Console.WriteLine(item);
    }
*/





