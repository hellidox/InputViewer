using System;

[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class CommentAttribute : Attribute
{
	public CommentAttribute(string Comment)
	{
		this.comment = Comment;
	}

	private string comment;
}
