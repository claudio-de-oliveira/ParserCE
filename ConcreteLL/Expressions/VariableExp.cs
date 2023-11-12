using ConcreteLL.Data;

namespace ConcreteLL.Expressions
{
    public class VariableExp : AbsExpression
    {
        public Data.Variable Variable { get; set; }

        public VariableExp(Data.Variable variable)
        {
            Variable = variable;
        }

        public override object Evaluate()
        {
            if (string.Compare(Variable.DataType, "string", true) == 0)
            {
                if (Variable.Value is string str)
                    return str;
                else if (Variable.Value is object[] arr)
                    return arr.ToList().Select((x) => (string)x).ToArray();
            }
            else if (string.Compare(Variable.DataType, "Date", true) == 0)
            {
                if (Variable.Value is string str)
                    return DateTime.Parse(str);
                else if (Variable.Value is object[] arr)
                    return arr.ToList().Select((x) => DateTime.Parse((string)x));
            }
            else if (string.Compare(Variable.DataType, "Time", true) == 0)
            {
                if (Variable.Value is string str)
                    return DateTime.Parse(str);
                else if (Variable.Value is object[] arr)
                    return arr.ToList().Select((x) => DateTime.Parse((string)x));
            }
            else if (string.Compare(Variable.DataType, "boolean", true) == 0)
            {
                if (Variable.Value is bool b)
                    return b;
                else if (Variable.Value is object[] arr)
                    return arr.ToList().Select((x) => bool.Parse((string)x)).ToArray();
            }
            else if (string.Compare(Variable.DataType, "Integer", true) == 0)
            {
                if (Variable.Value is long b)
                    return b;
                else if (Variable.Value is object[] arr)
                    return arr.ToList().Select((x) => (long)x).ToArray();
            }
            else if (string.Compare(Variable.DataType, "Decimal", true) == 0)
            {
                if (Variable.Value is double b)
                    return b;
                else if (Variable.Value is object[] arr)
                    return arr.ToList().Select((x) => (double)x).ToArray();
            }

            throw new Exception();
        }

        public override string ToString()
            => $"{Variable.Name}: {Variable.Value}";
    }
}
