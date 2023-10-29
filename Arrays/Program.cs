string[] fruit = { "apples", "bananas", "oranges", };

int fruitArrayLength = fruit.Length;

Console.WriteLine($"There are {fruitArrayLength} in your array.");

//for ( int i = 0; i < fruitArrayLength; i++ )
//{
//    Console.WriteLine(fruit[i] );
//}

//foreach( string element in fruit )
//{
//    Console.WriteLine( element );
//}   

for ( int i = 0; i < fruitArrayLength; i++ )
{
    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0]));
}

foreach( string element in fruit )
{
    Console.WriteLine( element );
} 