using Antlr4.Runtime;
using AntlrCSharp;

var text = File.ReadAllText("example1.json");
                
var inputStream = new AntlrInputStream(text);
var lexer = new JSONLexer(inputStream);
var commonTokenStream = new CommonTokenStream(lexer);
var parser = new JSONParser(commonTokenStream);

var context = parser.json();                
var visitor = new BasicVisitor();
visitor.Visit(context);

//foreach(var line in visitor.) // 
//{
//    Console.WriteLine("{0} has said {1}", line.Person, line.Text);
//}
