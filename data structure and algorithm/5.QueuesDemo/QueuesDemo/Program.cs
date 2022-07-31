using QueuesDemo;


var ArrayQueue = new ArrayQueue(5);
ArrayQueue.Enqueue(10);
ArrayQueue.Enqueue(20);
ArrayQueue.Enqueue(30);
ArrayQueue.Enqueue(40);

ArrayQueue.Dequeue();
ArrayQueue.Dequeue();

ArrayQueue.Enqueue(50);
ArrayQueue.Enqueue(60);
ArrayQueue.Enqueue(70);
ArrayQueue.Dequeue();

ArrayQueue.Enqueue(100);
//ArrayQueue.Dequeue();
//ArrayQueue.Enqueue(120);

//ArrayQueue.Print();

var QueueWithTwoStack = new QueueWithTwoStack();
QueueWithTwoStack.Enqueue(10);
QueueWithTwoStack.Enqueue(20);
QueueWithTwoStack.Enqueue(30);

var first = QueueWithTwoStack.Dequeue();
var second = QueueWithTwoStack.Dequeue();

QueueWithTwoStack.Enqueue(50);
QueueWithTwoStack.Enqueue(60);


var third = QueueWithTwoStack.Dequeue();

//Console.WriteLine(first);

//QueueWithTwoStack.PrintStack1();

//QueueWithTwoStack.PrintStack2();

var prirityQ = new PrirityQueues();
prirityQ.Insert(5);
prirityQ.Insert(3);
prirityQ.Insert(6);
prirityQ.Insert(2);

//var data = prirityQ.Remove();
//Console.WriteLine("Pririty Remove item: "+data);

// if want tor remove all item fromt he queue
//while (!prirityQ.IsEmpty())
//{
//    Console.WriteLine(prirityQ.Remove());
//}

prirityQ.Print();







