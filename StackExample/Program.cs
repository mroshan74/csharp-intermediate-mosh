using StackExample;

var s = new Stack();
s.PushItem(1);
s.PushItem("text");
s.PushItem(new DateTime().Date);
s.PopItem();
s.PopItem();
s.PopItem();
s.PopItem();