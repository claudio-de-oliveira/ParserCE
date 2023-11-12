namespace ConcreteLL.Expressions
{
    public class IntegerExp : AbsExpression
    {
        public long Value { get; set; }

        public IntegerExp(long value)
        {
            Value = value;
        }

        public override object Evaluate()
            => Value;

        public override string ToString()
            => $"{Value}";
    }
}
