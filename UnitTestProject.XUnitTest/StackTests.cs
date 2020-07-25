using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitProject.XUnitTest
{
    public class StackTests
    {
        [Fact]
        public void Push_ArgIsNull_ThrowArgNullException()
        {
            var stack = new Stack<string>();
            Assert.Throws<ArgumentNullException>(() => stack.Push(null));
        }

        [Fact]
        public void Push_ValidArg_AddTheObjectToStack()
        {
            var stack = new Stack<string>();
            stack.Push("a");

            Assert.Equal(1 , stack.Count);
        }

        [Fact]
        public void Pop_EmptyStack_ThrowInvalidOperationException()
        {
            var stack = new Stack<string>();
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Fact]
        public void PopStackWithFewObjects_ReturnObjectOntheTop()
        {
            // Arrange
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            // Act 
            var result = stack.Pop();
            // Assert 
            Assert.Equal("c", result);
        }
        [Fact]
        public void PopStackWithFewObjects_RemoveObjectOntheTop()
        {
            // Arrange
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            // Act 
            var result = stack.Pop();
            // Assert 
            Assert.Equal(2, stack.Count);
        }
        [Fact]
        public void Peek_EmptyStack_ThrowInvalidOperationException()
        {
            var stack = new Stack<string>();
            Assert.Throws<InvalidOperationException>(() => stack.Peek());
        }
        [Fact]
        public void Peek_StackWithObjects_ReturnObjectOntheTop()
        {
            // Arrange
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            // Act 
            var result = stack.Peek();
            // Assert 
            Assert.Equal("c", result);
        }
        [Fact]
        public void Peek_StackWithObjects_DoesNotRemoveObjectOnTopOfStack()
        {
            // Arrange
            var stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            // Act 
            var result = stack.Peek();
            // Assert 
            Assert.Equal(3, stack.Count);
        }
    }
}
