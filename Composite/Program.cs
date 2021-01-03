using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Folder sudoFolder = new Folder("sudo");
            sudoFolder.addFile(new File("sudo.A", 5));
            sudoFolder.addFile(new File("sudo.B", 8));
            sudoFolder.addFile(new File("sudo.C", 6));

            Folder userFolder = new Folder("user");
            userFolder.addFile(new File("user.dung", 15));
            userFolder.addFile(new File("user.abc", 12));
            userFolder.addFile(sudoFolder);

            Folder rootFolder = new Folder("root");
            rootFolder.addFile(new File("imgboot.b", 15));
            rootFolder.addFile(new File("boot.b", 8));
            rootFolder.addFile(userFolder);

            Console.WriteLine("Size root folder: " + rootFolder.getSize());
        }
    }
}
