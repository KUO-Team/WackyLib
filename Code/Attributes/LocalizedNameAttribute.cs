using System;

namespace WackyLib.Attributes;

[AttributeUsage( AttributeTargets.Field | AttributeTargets.Property )]
public class LocalizedNameAttribute( string key ) : Attribute
{
	public string Value { get; private set; } = key;
}
