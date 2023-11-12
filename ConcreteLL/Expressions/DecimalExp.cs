namespace ConcreteLL.Expressions
{
    public class DecimalExp : AbsExpression
    {
        public double Value { get; set; }

        public DecimalExp(double value)
        {
            Value = value;
        }

        public override object Evaluate()
            => Value;

        public override string ToString()
            => $"{Value}";
    }
}
