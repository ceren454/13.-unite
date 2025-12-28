using System;

class UsingExceptions
{
    static void Main()
    {
        Console.WriteLine("Calling DoesNotThrowException");
        DoesNotThrowException();

        Console.WriteLine("\nCalling ThrowExceptionWithCatch");
        ThrowExceptionWithCatch();

        Console.WriteLine("\nCalling ThrowExceptionWithoutCatch");

        try
        {
            ThrowExceptionWithoutCatch();
        }
        catch
        {
            Console.WriteLine(
                "Caught exception from ThrowExceptionWithoutCatch in Main");
        }

        Console.WriteLine("\nCalling ThrowExceptionCatchRethrow");

        try
        {
            ThrowExceptionCatchRethrow();
        }
        catch
        {
            Console.WriteLine(
                "Caught exception from ThrowExceptionCatchRethrow in Main");
        }
    }

    static void DoesNotThrowException()
    {
        try
        {
            Console.WriteLine("In DoesNotThrowException");
        }
        catch
        {
            Console.WriteLine("This catch never executes");
        }
        finally
        {
            Console.WriteLine("finally executed in DoesNotThrowException");
        }

        Console.WriteLine("End of DoesNotThrowException");
    }

    static void ThrowExceptionWithCatch()
    {
        try
        {
            Console.WriteLine("In ThrowExceptionWithCatch");
            throw new Exception("Exception in ThrowExceptionWithCatch");
        }
        catch (Exception exceptionParameter)
        {
            Console.WriteLine($"Message: {exceptionParameter.Message}");
        }
        finally
        {
            Console.WriteLine(
                "finally executed in ThrowExceptionWithCatch");
        }

        Console.WriteLine("End of ThrowExceptionWithCatch");
    }

    static void ThrowExceptionWithoutCatch()
    {
        try
        {
            Console.WriteLine("In ThrowExceptionWithoutCatch");
            throw new Exception("Exception in ThrowExceptionWithoutCatch");
        }
        finally
        {
            Console.WriteLine(
                "finally executed in ThrowExceptionWithoutCatch");
        }

        Console.WriteLine("End of ThrowExceptionWithoutCatch");
    }

    static void ThrowExceptionCatchRethrow()
    {
        try
        {
            Console.WriteLine("In ThrowExceptionCatchRethrow");
            throw new Exception("Exception in ThrowExceptionCatchRethrow");
        }
        catch (Exception exceptionParameter)
        {
            Console.WriteLine("Message: " + exceptionParameter.Message);
            throw;
        }
        finally
        {
            Console.WriteLine(
                "finally executed in ThrowExceptionCatchRethrow");
        }

        Console.WriteLine("End of ThrowExceptionCatchRethrow");
    }
}
