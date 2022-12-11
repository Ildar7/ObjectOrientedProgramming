﻿using System.Collections.Generic;

namespace CommandExecutor
{
    public static class OperatorContainer
    {
        public static List<Operator> operators = new List<Operator>();
        static OperatorContainer()
        {
            operators.Add(new Operator('E'));
            operators.Add(new Operator('M'));
            operators.Add(new Operator('D'));
            operators.Add(new Operator('A'));
            operators.Add(new Operator(','));
            operators.Add(new Operator('('));
            operators.Add(new Operator(')'));
        }
        public static Operator FindOperator(char s)
        {
            foreach (Operator op in operators)
            {
                if (op.symbolOperator == s)
                {
                    return op;
                }
            }
            return null;
        }
    }
}
