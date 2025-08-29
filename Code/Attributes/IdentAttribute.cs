using System;

namespace WackyLib.Attributes;

[AttributeUsage( AttributeTargets.Field )]
public class IdentAttribute( string ident ) : Attribute
{
	public string Value { get; private set; } = ident;
}
