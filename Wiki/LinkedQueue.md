Implementation of the a Queue using a Linked list of nodes.

**Interfaces:** `IQueue<T>`
  
# Methods

## Enqueue(T)
Adds an element at the end of the Queue.
```C#
MyLinkedQueue.Enqueue("So i'm the last here huh?");
```
  
Time complexity: **O(1)**.
  

## Dequeue()
Removes an element fron the front of the Queue.
```C# 
Console.WriteLine(MyLinkedQueue.Dequeue()); //Prints: So i'm the last here huh? 
```


Time complexity: **O(1)**.
  
## Peek()
Shows the value at the front of the Queue without removing it.
``` C#
Console.WriteLine(MyLinkedQueue.Peek()); //So i'm the last here huh?
``` 
Time complexity: **O(1)**.
  

## TryPeek(out T ReturnValue)
  
Returns a ``boolean`` value that indicates if is there an element in the Queue, and returns that object if is present without removing it.
> :warning: If there is no element in the Queue, the returned ***boolean*** value will be *false* and the ReturnValue parameter will be the `default` of the T type.
``` C#
if(MyLinkedQueue.TryPeek(string ReturnValue))
{
    Console.WriteLine(ReturnValue); //Prints: So i'm the last here huh?
}
```
Time complexity: **O(1)**;

## TryDequeue(out T ReturnValue)
  
Returns a `boolean` value that indicates if is there an element in the Queue, and returns that object if is present removing it from the Queue.  
> :warning: If there is no element in the Queue, the returned ***boolean*** value will be *false* and the ReturnValue parameter will be the `default` of the T type.
``` C#
if(MyLinkedQueue.TryDequeue(string ReturnValue))
{
    Console.WriteLine(ReturnValue); //Prints: So i'm the last here huh?
}
```
Time complexity: **O(1)**.
  
## IsEmpty()
  
Returns a `boolean` value that indicates if the Queue is empty or not.
  
Time complexity: **O(1)**.