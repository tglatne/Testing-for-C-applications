using System;
using TestNinja.Mocking;


namespace TestNinja.UnitTests
{
    internal class MockFileReader : IFileReader
    {
        public string Read(string path)
        {
            return "";
        }
    }
}
