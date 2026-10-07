# <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Types_Bounty"></a> Class CMsgSignOutBounties.Types.Bounty

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSignOutBounties.Types.Bounty : IMessage<CMsgSignOutBounties.Types.Bounty>, IEquatable<CMsgSignOutBounties.Types.Bounty>, IDeepCloneable<CMsgSignOutBounties.Types.Bounty>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSignOutBounties.Types.Bounty](Divine.Protobufs.Dota2.CMsgSignOutBounties.Types.Bounty.md)

#### Implements

IMessage<CMsgSignOutBounties.Types.Bounty\>, 
[IEquatable<CMsgSignOutBounties.Types.Bounty\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSignOutBounties.Types.Bounty\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<CMsgSignOutBounties.Types.Bounty\>\(CMsgSignOutBounties.Types.Bounty, params CMsgSignOutBounties.Types.Bounty\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Types_Bounty__ctor"></a> Bounty\(\)

```csharp
public Bounty()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Types_Bounty__ctor_Divine_Protobufs_Dota2_CMsgSignOutBounties_Types_Bounty_"></a> Bounty\(Bounty\)

```csharp
public Bounty(CMsgSignOutBounties.Types.Bounty other)
```

#### Parameters

`other` [CMsgSignOutBounties](Divine.Protobufs.Dota2.CMsgSignOutBounties.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutBounties.Types.md).[Bounty](Divine.Protobufs.Dota2.CMsgSignOutBounties.Types.Bounty.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Types_Bounty_CompleterAccountIdFieldNumber"></a> CompleterAccountIdFieldNumber

```csharp
public const int CompleterAccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Types_Bounty_IssuerAccountIdFieldNumber"></a> IssuerAccountIdFieldNumber

```csharp
public const int IssuerAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Types_Bounty_TargetAccountIdFieldNumber"></a> TargetAccountIdFieldNumber

```csharp
public const int TargetAccountIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Types_Bounty_CompleterAccountId"></a> CompleterAccountId

```csharp
public uint CompleterAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Types_Bounty_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Types_Bounty_HasCompleterAccountId"></a> HasCompleterAccountId

```csharp
public bool HasCompleterAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Types_Bounty_HasIssuerAccountId"></a> HasIssuerAccountId

```csharp
public bool HasIssuerAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Types_Bounty_HasTargetAccountId"></a> HasTargetAccountId

```csharp
public bool HasTargetAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Types_Bounty_IssuerAccountId"></a> IssuerAccountId

```csharp
public uint IssuerAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Types_Bounty_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSignOutBounties.Types.Bounty> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSignOutBounties](Divine.Protobufs.Dota2.CMsgSignOutBounties.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutBounties.Types.md).[Bounty](Divine.Protobufs.Dota2.CMsgSignOutBounties.Types.Bounty.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Types_Bounty_TargetAccountId"></a> TargetAccountId

```csharp
public uint TargetAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Types_Bounty_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Types_Bounty_ClearCompleterAccountId"></a> ClearCompleterAccountId\(\)

```csharp
public void ClearCompleterAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Types_Bounty_ClearIssuerAccountId"></a> ClearIssuerAccountId\(\)

```csharp
public void ClearIssuerAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Types_Bounty_ClearTargetAccountId"></a> ClearTargetAccountId\(\)

```csharp
public void ClearTargetAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Types_Bounty_Clone"></a> Clone\(\)

```csharp
public CMsgSignOutBounties.Types.Bounty Clone()
```

#### Returns

 [CMsgSignOutBounties](Divine.Protobufs.Dota2.CMsgSignOutBounties.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutBounties.Types.md).[Bounty](Divine.Protobufs.Dota2.CMsgSignOutBounties.Types.Bounty.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Types_Bounty_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Types_Bounty_Equals_Divine_Protobufs_Dota2_CMsgSignOutBounties_Types_Bounty_"></a> Equals\(Bounty\)

```csharp
public bool Equals(CMsgSignOutBounties.Types.Bounty other)
```

#### Parameters

`other` [CMsgSignOutBounties](Divine.Protobufs.Dota2.CMsgSignOutBounties.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutBounties.Types.md).[Bounty](Divine.Protobufs.Dota2.CMsgSignOutBounties.Types.Bounty.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Types_Bounty_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Types_Bounty_MergeFrom_Divine_Protobufs_Dota2_CMsgSignOutBounties_Types_Bounty_"></a> MergeFrom\(Bounty\)

```csharp
public void MergeFrom(CMsgSignOutBounties.Types.Bounty other)
```

#### Parameters

`other` [CMsgSignOutBounties](Divine.Protobufs.Dota2.CMsgSignOutBounties.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutBounties.Types.md).[Bounty](Divine.Protobufs.Dota2.CMsgSignOutBounties.Types.Bounty.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Types_Bounty_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Types_Bounty_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutBounties_Types_Bounty_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

