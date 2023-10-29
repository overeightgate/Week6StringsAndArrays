string hello = "hello, world!";

int stringLength = hello.Length;

//string stringTrimmed = hello.Trim();
hello = hello.Trim();
int wordCounter = 1;

for (int i = 0; i < hello.Length; i++)
{
    if (char.IsWhiteSpace(hello[i]))
    { 
       wordCounter++;
    }
}

Console.WriteLine(stringLength);