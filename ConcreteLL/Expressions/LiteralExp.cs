namespace ConcreteLL.Expressions
{
    public class LiteralExp : AbsExpression
    {
        public string Value { get; set; }

        public LiteralExp(string value)
        {
            Value = value;
        }

        public override object Evaluate()
            => Value;

        public override string ToString()
            => $"\"{Value}\"";
    }
}
