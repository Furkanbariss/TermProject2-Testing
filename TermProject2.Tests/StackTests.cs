using System;
using NUnit.Framework;

namespace TermProject2.Tests
{
    [TestFixture]
    /*
     These tests verify the correct behavior of the generic stack implementation.
     The tests check stack initialization, push, pop, and peek operations, as well as exception handling for invalid operations such as popping from an empty stack or pushing a null value.
     */
    public class StackTests
    {
        [Test]
        public void Count_NewStack_IsZero()
        {
            // Arrange
            var stack = new Stack<int>();

            // Act
            var count = stack.Count;

            // Assert
            Assert.That(count, Is.EqualTo(0));
        }

        [Test]
        public void Push_Null_ThrowsArgumentNullException()
        {
            // Arrange
            var stack = new Stack<string>();

            // Act + Assert
            Assert.That(() => stack.Push(null),
                Throws.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void Push_ValidItem_IncreasesCount()
        {
            // Arrange
            var stack = new Stack<int>();

            // Act
            stack.Push(10);

            // Assert
            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Pop_EmptyStack_ThrowsInvalidOperationException()
        {
            // Arrange
            var stack = new Stack<int>();

            // Act + Assert
            Assert.That(() => stack.Pop(),
                Throws.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void Pop_StackHasItems_ReturnsLastItem()
        {
            // Arrange
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);

            // Act
            var result = stack.Pop();

            // Assert
            Assert.That(result, Is.EqualTo(2));
            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Peek_StackHasItems_ReturnsLastItemWithoutRemoving()
        {
            // Arrange
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);

            // Act
            var result = stack.Peek();

            // Assert
            Assert.That(result, Is.EqualTo(2));
            Assert.That(stack.Count, Is.EqualTo(2));
        }
    }
}
