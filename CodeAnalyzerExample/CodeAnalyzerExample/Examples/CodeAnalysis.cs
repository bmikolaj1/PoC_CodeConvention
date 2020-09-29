namespace CodeAnalyzerExample.Examples
{
    public class UnusedParameter
    {
        public UnusedParameter(string test)
        { }
    }

    public interface ITest { }
    public class NamingConvention
    {
        private readonly ITest _test;

        public NamingConvention(ITest test)
        {
            _test = test;
        }
    }

    public class EmptyCatch
    {
        public EmptyCatchFinally()
        {
            try
            { }
            catch (System.Exception)
            { }
            finally { }
        }
    }

    public class IfToReturn
    {
        public bool Test()
        {
            var x = 5;
            var test = x == 5;
            if (test)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class AddBraces
    {
        public void Test()
        {
            var x = 5;
            if (x == 5)
            {
                x += 2;
            }
        }
    }


}
