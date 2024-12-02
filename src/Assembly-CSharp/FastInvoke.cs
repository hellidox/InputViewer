using System;
using System.Linq.Expressions;
using System.Reflection;

public static class FastInvoke
{
	public static Func<T, object> BuildUntypedGetter<T>(MemberInfo memberInfo)
	{
		ParameterExpression exInstance = Expression.Parameter(memberInfo.DeclaringType, "t");
		return Expression.Lambda<Func<T, object>>(Expression.Convert(Expression.MakeMemberAccess(exInstance, memberInfo), typeof(object)), new ParameterExpression[] { exInstance }).Compile();
	}

	public static Action<T, object> BuildUntypedSetter<T>(MemberInfo memberInfo)
	{
		ParameterExpression exInstance = Expression.Parameter(memberInfo.DeclaringType, "t");
		Expression expression = Expression.MakeMemberAccess(exInstance, memberInfo);
		ParameterExpression exValue = Expression.Parameter(typeof(object), "p");
		UnaryExpression exConvertedValue = Expression.Convert(exValue, memberInfo.GetUnderlyingType());
		return Expression.Lambda<Action<T, object>>(Expression.Assign(expression, exConvertedValue), new ParameterExpression[] { exInstance, exValue }).Compile();
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
		FieldInfo field = memberInfo as FieldInfo;
		if (field == null)
		{
			PropertyInfo property = memberInfo as PropertyInfo;
			return property != null && (property.GetGetMethod() ?? property.SetMethod).IsStatic;
		}
		return field.IsStatic;
	}

	public static Action<T> BuildStaticUntypedSetter<T>(MemberInfo memberInfo)
	{
		Type declaringType = memberInfo.DeclaringType;
		if (!FastInvoke.IsStaticMember(memberInfo))
		{
			throw new ArgumentException("Member must be static.");
		}
		ParameterExpression exValue = Expression.Parameter(typeof(T), "p");
		UnaryExpression exConvertedValue = Expression.Convert(exValue, memberInfo.GetUnderlyingType());
		return Expression.Lambda<Action<T>>(Expression.Assign(Expression.MakeMemberAccess(null, memberInfo), exConvertedValue), new ParameterExpression[] { exValue }).Compile();
	}
}
