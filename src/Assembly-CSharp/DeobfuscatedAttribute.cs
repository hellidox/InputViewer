using System;

public class DeobfuscatedAttribute : Attribute
{
	public DeobfuscatedAttribute(string originalName, params string[] originalParameters)
	{
		this.OriginalName = originalName;
		this.OriginalParameters = originalParameters;
	}

	public string OriginalName;

	public string[] OriginalParameters;
}
