
using Memento;

TextEditor editor = new TextEditor();
TextHistory history = new TextHistory();

editor.SetText("Hello");
history.SaveState(editor.Save());

editor.SetText("Hello, World!");
history.SaveState(editor.Save());

editor.SetText("Hello, World! How are you?");

Console.WriteLine("Current Text: " + editor.GetText());

editor.Restore(history.Undo());
Console.WriteLine("After Undo 1: " + editor.GetText());

editor.Restore(history.Undo());
Console.WriteLine("After Undo 2: " + editor.GetText());