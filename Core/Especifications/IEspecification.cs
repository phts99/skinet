using System.Linq.Expressions;

namespace Core.Especifications
{
    public interface IEspecification<T>
    {
        Expression<Func<T, bool>> Criteria {get; }
        List<Expression<Func<T, object>>> Includes {get; }
    }
}