using Task2_Threads;

var classSync = new Sync();
var classAsync = new Async();

classSync.TestSync();
await classAsync.TestAsync();




