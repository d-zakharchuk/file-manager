using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileManagerTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BlankTest()
        {
            Assert.AreEqual(0, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(IOException))]
        public void WhenDriveIsNotReady_ShouldThrowIOException()
        { /*To pass this test:
            plug in any USB device and choose to safety unmount it, but do not plug out it and then run this test
            for cd or floppy drives, leave the drive empty
            */
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                var drive = d.VolumeLabel;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(System.IO.DirectoryNotFoundException))]
        public void CreatingConFolder_ShouldThrowDirectoryNotFoundException()
        {
            string path = @"D:\";
            string folder = "con";
            if (!Directory.Exists(path + '\\' + folder))
                Directory.CreateDirectory(path + '\\' + folder);
        }

        [TestMethod]
        public void CreatingFile_CorrectFilenameExpected()
        {
            string path = @"D:\";
            string filename = "123.txt";
            string expectedFile = path + filename;
            FileStream MyFile = null;
            if (!File.Exists(path + '\\' + filename))
                MyFile = File.Create(path + '\\' + filename);
            Assert.AreEqual(expectedFile, MyFile.Name);
        }
    }
}
