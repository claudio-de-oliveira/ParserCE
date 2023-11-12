namespace ConcreteLL.Expressions
{
    public class SelectExp : AbsExpression
    {
        public List<SelectionItemExp> SelectionItems { get; set; }

        public SelectExp(List<SelectionItemExp> selectionItems)
        {
            SelectionItems = selectionItems;
        }

        public override object Evaluate()
        {
            throw new NotImplementedException();
        }
    }

    public class SelectionItemExp : AbsExpression
    {
        public VariableExp Variable { get; set; }
        public List<AbsExpression> Options { get; set; }

        public SelectionItemExp(VariableExp variable, List<AbsExpression> options)
        {
            Variable = variable;
            Options = options;
        }

        public override object Evaluate()
        {
            throw new NotImplementedException();
        }
    }
}
