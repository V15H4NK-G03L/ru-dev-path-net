using StackExchange.Redis;

// TODO for Coding Challenge Start here on starting-point branch
var muxer = ConnectionMultiplexer.Connect("localhost:6379");
IDatabase db = muxer.GetDatabase();

Console.WriteLine();
Console.WriteLine(db.Ping());

string? ans = db.StringGet("test");
Console.WriteLine(ans);

db.StringSet("dotnet","dotnet_testing");
ans = db.StringGet("dotnet");
Console.WriteLine(ans);

ans = db.StringGet("hi");
Console.WriteLine(ans);
ans = db.StringGet("12");
Console.WriteLine(ans);

// end programming challenge