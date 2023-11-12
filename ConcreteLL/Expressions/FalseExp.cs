namespace ConcreteLL.Expressions
{
    public class FalseExp : AbsExpression
    {

        public override object Evaluate()
            => false;

        public override string ToString()
            => "false";
    }
}
