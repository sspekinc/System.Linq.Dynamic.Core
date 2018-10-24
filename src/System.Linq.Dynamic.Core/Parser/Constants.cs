﻿using System.Linq.Expressions;

namespace System.Linq.Dynamic.Core.Parser
{
    internal static class Constants
    {
        public static readonly Expression TrueLiteral = Expression.Constant(true);
        public static readonly Expression FalseLiteral = Expression.Constant(false);
        public static readonly Expression NullLiteral = Expression.Constant(null);
    }
    
    public class WrappedObj<TValue>
    {
        public TValue Value { get; set; }
        public WrappedObj(TValue value)
        {
            this.Value = value;
        }
    }
}
