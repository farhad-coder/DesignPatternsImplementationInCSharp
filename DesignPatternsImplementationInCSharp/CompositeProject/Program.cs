
using CompositeProject;

CompositeProject.Directory root = new CompositeProject.Directory("Root");
root.Add(new CompositeProject.File("File1.txt"));
root.Add(new CompositeProject.File("File2.txt"));

CompositeProject.Directory subDir  = new CompositeProject.Directory("SubDirectory");
subDir.Add(new CompositeProject.File("File3.txt"));
subDir.Add(new CompositeProject.File("File4.txt"));

root.Add(subDir);
root.Add(new CompositeProject.File("File5.txt"));
root.Display(1);