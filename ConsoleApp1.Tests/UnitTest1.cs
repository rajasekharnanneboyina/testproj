using NUnit.Framework;
using System;
using System.IO;

namespace ConsoleApp1.Tests
{
    public class Tests
    {
        Program p;
        FileTextReverser r;
        [SetUp]
        public void Setup()
        {
            p = new Program();
            r = new FileTextReverser();
        }
        [Test]
        public void startProcesswithNull()
        {
            try
            {
                p.startProcess(null);
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void startProcesswithEmptyString()
        {
            try
            {
                p.startProcess("");
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void ReverseFileContentsWithNull()
        {
            try
            {
               string text = r.ReverseFileContents(null);
                Assert.Null(text);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [Test]
        public void ReverseFileContentsWithEmptyString()
        {
            try
            {
                string text = r.ReverseFileContents("");
                Assert.Null(text);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]

        public void ReverseFileContentsWithEmptyTextFile()
        {
            try
            {
                string dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
                string file = dir + "/" + "TestTextFileTestEmpty.txt";
                string text=r.ReverseFileContents(file);
                Assert.Null(text);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]

        public void ReverseFileContentsWithCorrectFilePath()
        {
            try
            {

                string dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
                string file = dir + "/" + "TestTextFileTestHello.txt";
                string text = r.ReverseFileContents(file);
                Assert.IsNotNull(text);
                Assert.True(text == "olleH");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}