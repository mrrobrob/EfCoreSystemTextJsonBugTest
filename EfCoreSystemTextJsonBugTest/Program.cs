// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

var thing = System.Text.Json.JsonSerializer.Serialize("testing");
Console.WriteLine(thing);