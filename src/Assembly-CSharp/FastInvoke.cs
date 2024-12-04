using System;
using System.Linq.Expressions;
using System.Reflection;

public static class FastInvoke
{
	public static Func<T, object> BuildUntypedGetter<T>(MemberInfo memberInfo)
	{
		ParameterExpression parameterExpression = Expression.Parameter(memberInfo.DeclaringType, "t");
		return Expression.Lambda<Func<T, object>>(Expression.Convert(Expression.MakeMemberAccess(parameterExpression, memberInfo), typeof(object)), new ParameterExpression[] { parameterExpression }).Compile();
	}

	public static Action<T, object> BuildUntypedSetter<T>(MemberInfo memberInfo)
	{
		ParameterExpression parameterExpression = Expression.Parameter(memberInfo.DeclaringType, "t");
		Expression expression = Expression.MakeMemberAccess(parameterExpression, memberInfo);
		ParameterExpression parameterExpression2 = Expression.Parameter(typeof(object), "p");
		UnaryExpression unaryExpression = Expression.Convert(parameterExpression2, memberInfo.GetUnderlyingType());
		return Expression.Lambda<Action<T, object>>(Expression.Assign(expression, unaryExpression), new ParameterExpression[] { parameterExpression, parameterExpression2 }).Compile();
	}

	private static Type GetUnderlyingType(this MemberInfo member)
	{
		MemberTypes memberType = member.MemberType;
		if (memberType <= MemberTypes.Field)
		{
			if (memberType == MemberTypes.Event)
			{
				return ((EventInfo)member).EventHandlerType;
			}
			if (memberType == MemberTypes.Field)
			{
				return ((FieldInfo)member).FieldType;
			}
		}
		else
		{
			if (memberType == MemberTypes.Method)
			{
				return ((MethodInfo)member).ReturnType;
			}
			if (memberType == MemberTypes.Property)
			{
				return ((PropertyInfo)member).PropertyType;
			}
		}
		throw new ArgumentException("Input MemberInfo must be of type EventInfo, FieldInfo, MethodInfo, or PropertyInfo");
	}

	private static bool IsStaticMember(MemberInfo memberInfo)
	{
		FieldInfo fieldInfo = memberInfo as FieldInfo;
		if (fieldInfo == null)
		{
			PropertyInfo propertyInfo = memberInfo as PropertyInfo;
			return propertyInfo != null && (propertyInfo.GetGetMethod() ?? propertyInfo.SetMethod).IsStatic;
		}
		return fieldInfo.IsStatic;
	}

	public static Action<T> BuildStaticUntypedSetter<T>(MemberInfo memberInfo)
	{
		Type declaringType = memberInfo.DeclaringType;
		if (!FastInvoke.IsStaticMember(memberInfo))
		{
			throw new ArgumentException("Member must be static.");
		}
		ParameterExpression parameterExpression = Expression.Parameter(typeof(T), "p");
		UnaryExpression unaryExpression = Expression.Convert(parameterExpression, memberInfo.GetUnderlyingType());
		return Expression.Lambda<Action<T>>(Expression.Assign(Expression.MakeMemberAccess(null, memberInfo), unaryExpression), new ParameterExpression[] { parameterExpression }).Compile();
	}
}
