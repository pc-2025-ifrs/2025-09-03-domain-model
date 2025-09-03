// See https://aka.ms/new-console-template for more information
using Steam.Model;
using static Steam.Model.Game;

Console.WriteLine("Hello, World!");

var sadSocket = new Developer
{
    Id = Guid.NewGuid(),
    Name = "Sad Socket"
};

var review1 = new Review
{
    Id = Guid.NewGuid(),
    Recommended = true
};


// full qualified name
// var _9kings = new Steam.Model.Game
var _9kings = new Game
{
    Id = Guid.NewGuid(),
    Title = "9 Kings",
    Developer = sadSocket
};

_9kings.Reviews.Add(review1);
_9kings.Reviews.Add(new Review
{
    Id = Guid.NewGuid(),
    Recommended = false,
    Description = "Sei lá, tô nerfando"
});

_9kings.AddReview(Recommend.YES, "O jogo é legal");

Console.WriteLine(_9kings);
Console.WriteLine(_9kings.Id);
Console.WriteLine(_9kings.Title);

foreach (var review in _9kings.Reviews)
{
    Console.WriteLine(review);
}

// Programação Orientada a Objetos
// OOP (Object Oriented Programming)
// Alan Kay, formação: major: Math minor: Biology
// A -> B -> C -> D
// Graph Navigation/Traversal
Console.WriteLine(_9kings.Developer.Name);