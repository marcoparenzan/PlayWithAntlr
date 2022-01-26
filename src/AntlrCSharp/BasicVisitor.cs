using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using AntlrCSharp;

namespace AntlrCSharp
{
    public class BasicVisitor : IJSONVisitor<object>
    {
        public object Visit(IParseTree tree)
        {
            Console.WriteLine($"TREE={tree}");
            return tree;
        }

        public object VisitArr([NotNull] JSONParser.ArrContext context)
        {
            Console.WriteLine($"ARR={context}");
            return context;
        }

        public object VisitChildren(IRuleNode node)
        {
            Console.WriteLine($"CHILDREN={node}");
            return node;
        }

        public object VisitErrorNode(IErrorNode node)
        {
            Console.WriteLine($"ERRORNODE={node}");
            return node;
        }

        public object VisitJson([NotNull] JSONParser.JsonContext context)
        {
            Console.WriteLine($"JSON={context}");
            return context;
        }

        public object VisitObj([NotNull] JSONParser.ObjContext context)
        {
            Console.WriteLine($"OBJ={context}");
            return context;
        }

        public object VisitPair([NotNull] JSONParser.PairContext context)
        {
            Console.WriteLine($"PAIR={context}");
            return context;
        }

        public object VisitTerminal(ITerminalNode node)
        {
            Console.WriteLine($"TERMINAL={node}");
            return node ;
        }

        public object VisitValue([NotNull] JSONParser.ValueContext context)
        {
            Console.WriteLine($"VALUE={context}");
            return context;
        }
    }
}