using CorebrainCS;

Console.WriteLine("Hello, World!");

// For now it only works on windows
var corebrain = new CorebrainCS.CorebrainCS("../.venv/Scripts/python.exe", "../corebrain/corebrain/cli", false);

// Console.WriteLine(corebrain.Help());
// Console.WriteLine(corebrain.Version());
// Console.WriteLine(corebrain.Configure());
// Console.WriteLine(corebrain.ListConfigs());
// Console.WriteLine(corebrain.RemoveConfig());
// Console.WriteLine(corebrain.ShowSchema());
// Console.WriteLine(corebrain.ExtractSchema());
// Console.WriteLine(corebrain.ExtractSchemaToDefaultFile());
Console.WriteLine(corebrain.ConfigID());