namespace ClassLibrary1
{
    public class ArithmaticClass
    {
        public float z_func1(int arg1, int arg2, int arg3)
        {
            var a = (float)arg1;
            var x = (float)arg2;
            var y = (float)arg3;
            return 2 + ((((5 + a) / y) / ((3 * a) / (x - a))) * a) + ((2 * x + 5 * x - 3 * a) / (8 * x + 3 * a)) + 2 * y;
        }
        public float z_func2(int arg1, int arg2, int arg3)
        {
            var a = (float)arg1;
            var x = (float)arg2;
            var y = (float)arg3;

            return (6 * y) - ((2 + (3 * a)) / ((10 * x) + (3 * a))) + 4 + (((a * 2) / y) / ((3 * a) / x)) * y;
        }
    }
}
