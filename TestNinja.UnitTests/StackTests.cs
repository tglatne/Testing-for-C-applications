using NUnit.Framework;
using System.Runtime.Remoting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    internal class StackTests
    {
        [Test]
        public void Push_ArgIsNull_ThrowsArgNullException()
        {
            var stack = new Stack<string>();

            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_ValidArg_AddTheObjectToStack()
        {
            var stack = new Stack<string>();

            stack.Push("a");

            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            var stack = new Stack<string>();

            Assert.That(stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Pop_EmptyStack_ThrowInvalidOperationException()
        {
            var stack = new Stack<string>();

            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_StackWithAFewObjects_ReturnTheTopObject()
        {
            var stack = new Stack<string>();

            stack.Push("a");
            stack.Push("b");

            var result = stack.Pop();

            Assert.That(result, Is.EqualTo("b"));
        }

        [Test]
        public void Pop_StackWithAFewObjects_RemoveTheTopObject()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");

            stack.Pop();

            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Peek_EmptyStack_ThrowInvalidOperationException()
        {
            var stack = new Stack<string>();

            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_StackWithFewObjects_ReturnTheTopObject()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");

            var result = stack.Peek();

            Assert.That(result, Is.EqualTo("b"));
        }

        [Test]
        public void Peek_StackWithFewObjects_DoesNotRmoveTheObjectOnTop()
        {
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");

            stack.Peek();

            Assert.That(stack.Count, Is.EqualTo(2));
        }
    }
}
