﻿using System;

namespace CodeGen
{
    class Program
    {
        static void Main(string[] args)
        {
            var gen = new CodeGenerator();
            var tree = new CodeTree()
                .Add(new CodeNode("using System;"))
                .Add(new CodeNode(""))
                .Add(new CodeBlock("namespace MyNamespace")
                    .Add(new CodeBlock("class MyClass")
                        .Add(new CodeBlock("static void Main(string[] args)")
                            .Add(new CodeNode(@"Console.WriteLine(""Hello world"");")))));
            Console.WriteLine(gen.Generate(tree));
        }
    }
}
