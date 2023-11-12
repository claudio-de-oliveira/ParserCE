namespace ConcreteLL.Expressions
{
    public class TrueExp : AbsExpression
    {

        public override object Evaluate()
            => true;

        public override string ToString()
            => "true";
    }
}
