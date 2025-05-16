using CorebrainCS;

Console.WriteLine("Hello, World!");

var corebrain = new CorebrainCS.CorebrainCS("../.venv/Scripts/python.exe", "../corebrain/corebrain/cli", false);

Console.WriteLine(corebrain.Version());