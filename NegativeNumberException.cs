using System;

public class NegativeNumberException : Exception
{
    public NegativeNumberException()
        : base("Illegal operation for a negative number")
    {
    }

    public NegativeNumberException(string messageValue)
        : base(messageValue)
    {
    }

    public NegativeNumberException(string messageValue, Exception inner)
        : base(messageValue, inner)
    {
    }
}
