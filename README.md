# JSON-in-VB.NET
This example demonstrates how to serialize and deserialize VB.NET objects in JSON format

![](https://raw.githubusercontent.com/dominicklee/JSON-in-VB.NET/master/screenshot.jpg)

##Usage##

The example code uses Newtonsoft JSON. This example involves the following:

1. Start a new project in Visual Basic 2008.
2. Copy the Newtonsoft DLL to your project folder and add it as a reference.
3. Write `Imports Newtonsoft.Json` in your main code.
4. Create a new Class and write the constructor with the variables you want.
5. Declare a new instance of your Class and set your variables.
6. Serialize the object with `JsonConvert.SerializeObject(yourObject)`
7. Deserialize JSON with:
 `Dim result As yourObject = JsonConvert.DeserializeObject(Of yourObject)(JSONstring)`

##Source##

Special thanks to the Newtonsoft JSON library. Original code here: [https://github.com/JamesNK/Newtonsoft.Json](https://github.com/JamesNK/Newtonsoft.Json "https://github.com/JamesNK/Newtonsoft.Json")