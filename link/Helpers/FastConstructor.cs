using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Link.Helpers
{
    public static class FastConstructor<TRes>
    {
        public static readonly bool Exists;
        public static readonly Func<TRes> Create;
        static FastConstructor()
        {
            try
            {
                Create = Expression.Lambda<Func<TRes>>(
                    Expression.MemberInit(
                        Expression.New(
                            typeof(TRes)
                        )
                    )).Compile();
                Exists = true;
            }
            catch
            {
                Create = () => default(TRes);
            }
        }
    }
    public static class FastConstructor<TArg1, TRes>
    {
        public static readonly bool Exists;
        public static readonly Func<TArg1, TRes> Create;
        static FastConstructor()
        {
            try
            {
                Create = Expression.Lambda<Func<TArg1, TRes>>(
                    Expression.MemberInit(
                        Expression.New(
                            typeof(TRes)
                        )
                    ),
                    new[] { typeof(TArg1) }.Select(Expression.Parameter)
                    ).Compile();
                Exists = true;
            }
            catch
            {
                Create = (a1) => default(TRes);
            }
        }
    }
    public static class FastConstructor<TArg1, TArg2, TRes>
    {
        public static readonly bool Exists;
        public static readonly Func<TArg1, TArg2, TRes> Create;
        static FastConstructor()
        {
            try
            {
                Create = Expression.Lambda<Func<TArg1, TArg2, TRes>>(
                    Expression.MemberInit(
                        Expression.New(
                            typeof(TRes)
                        )
                    ),
                    new[] { typeof(TArg1), typeof(TArg2) }.Select(Expression.Parameter)
                    ).Compile();
                Exists = true;
            }
            catch
            {
                Create = (a1, a2) => default(TRes);
            }
        }
    }
    public static class FastConstructor<TArg1, TArg2, TArg3, TRes>
    {
        public static readonly bool Exists;
        public static readonly Func<TArg1, TArg2, TArg3, TRes> Create;
        static FastConstructor()
        {
            try
            {
                Create = Expression.Lambda<Func<TArg1, TArg2, TArg3, TRes>>(
                    Expression.MemberInit(
                        Expression.New(
                            typeof(TRes)
                        )
                    ),
                    new[] { typeof(TArg1), typeof(TArg2), typeof(TArg3) }.Select(Expression.Parameter)
                    ).Compile();
                Exists = true;
            }
            catch
            {
                Create = (a1, a2, a3) => default(TRes);
            }
        }
    }
}
