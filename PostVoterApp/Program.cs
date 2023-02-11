using PostVoterApp;

var post1 = new PostControl(title: "Hello World", description: "This is  beautiful world !!");

post1.UpVote();
post1.UpVote();
post1.UpVote();
post1.UpVote();
post1.UpVote();

Console.WriteLine(post1.GetVotes());
post1.DownVote();
post1.DownVote();
Console.WriteLine(post1.Title);
Console.WriteLine(post1.Description);
Console.WriteLine(post1.CreatedAt);
Console.WriteLine(post1.GetVotes());
