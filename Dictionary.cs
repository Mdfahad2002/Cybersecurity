// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//Dictionary

/*
Create a dictionary for file types. e.g.
.txt = Text File
.doc = Word File
.xls = Excel File
.pdf = Portable data format

*/

public class DictionaryDemo
{
    public static void Main()
    {
        // Creating  dictionary

        Dictionary<string, string> fileType = new Dictionary<string, string> ();

        // Adding key-values in the dictionary
        fileType.Add(".txt","Text File");
        fileType.Add(".doc","Word File");
        fileType.Add(".pdf","Portable Document Format");
        fileType.Add(".xls","Excel file");
        fileType.Add(".jpeg","Joint Photographic Expert Group");
        fileType.Add(".rtf","Rich Text Format");
        
        

       //Retriving all the key-value pairs
       foreach(KeyValuePair<string,string>kv in fileType)
       Console.WriteLine(kv.Key+":+kv.Value");

       fileType.Add(".xlxs","Excel File");

       //Retriving all the key-value pairs
       Console.WriteLine("\n- - - - - - - - - - - - - - - - - - ");
       foreach(KeyValuePair<string,string>kv in fileType)
       Console.WriteLine(kv.Key+":+kv.Value");

       //Adding duplicate key
       //Handling exception using try and catch block
        try
        {
        fileType.Add(".doc","This is another entry for a word file");
        //     fileType.Add(".txt","Notepad/Wordpad etc");
        }
        catch
        {
            Console.WriteLine(" Can not add duplicate key in a dictionary");
        }

       Console.WriteLine("\n- - - - - - - - - - - - - - - - - - ");
       foreach(KeyValuePair<string,string>kv in fileType)
       Console.WriteLine(kv.Key+":+kv.Value");

       Dictionary<string,string>.KeyCollection keys=fileType.Keys;

       Dictionary<string,string>.ValueCollection values=fileType.Values;
       
        Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
        Console.WriteLine(" Key value pairs in the dictionary  ");
        foreach(string key in keys)
        Console.WriteLine(key);

         Console.WriteLine("- - - - - - - - - - - - - - - - - - ");
        Console.WriteLine(" Values in the dictionary:");
        foreach(string val in values)
        Console.WriteLine(val);
       // foreach(KeyValuePair <string, string> kv in fileType)
        //Console.WriteLine(kv.Key+ " : "+ kv.Value);

    }
}

//Accept input from user:file extension e.g. .txt, .doc
//Code shows the file type
//value = dictionary[key]
   