using Task2_SyncAsync;

var classSync = new Sync();
var classAsync = new Async();

classSync.TestSync();
await classAsync.TestAsync();




