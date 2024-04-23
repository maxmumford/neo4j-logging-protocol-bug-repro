// See https://aka.ms/new-console-template for more information

using neo4j_logging_test;
using Neo4j.Driver;

Console.WriteLine("Hello, World!");

using var driver = GraphDatabase.Driver("neo4j+s://localhost:7687", AuthTokens.Basic("neo4j", "change me"),
    o => { o.WithLogger(new Neo4jGraphDriverLogger()); });
var session = driver.AsyncSession(session =>
{
    session.WithDatabase("flowwgraph");
});
await session.ExecuteReadAsync(async tx =>
{
    var result = await tx.RunAsync("match (n) return count(y)");
    Console.Write(result);
});