# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildMembership"></a> Class CMsgClientToGCRequestGuildMembership

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestGuildMembership : IMessage<CMsgClientToGCRequestGuildMembership>, IEquatable<CMsgClientToGCRequestGuildMembership>, IDeepCloneable<CMsgClientToGCRequestGuildMembership>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestGuildMembership](Divine.Protobufs.Dota2.CMsgClientToGCRequestGuildMembership.md)

#### Implements

IMessage<CMsgClientToGCRequestGuildMembership\>, 
[IEquatable<CMsgClientToGCRequestGuildMembership\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestGuildMembership\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestGuildMembership\>\(CMsgClientToGCRequestGuildMembership, params CMsgClientToGCRequestGuildMembership\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildMembership__ctor"></a> CMsgClientToGCRequestGuildMembership\(\)

```csharp
public CMsgClientToGCRequestGuildMembership()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildMembership__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildMembership_"></a> CMsgClientToGCRequestGuildMembership\(CMsgClientToGCRequestGuildMembership\)

```csharp
public CMsgClientToGCRequestGuildMembership(CMsgClientToGCRequestGuildMembership other)
```

#### Parameters

`other` [CMsgClientToGCRequestGuildMembership](Divine.Protobufs.Dota2.CMsgClientToGCRequestGuildMembership.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildMembership_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildMembership_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestGuildMembership> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestGuildMembership](Divine.Protobufs.Dota2.CMsgClientToGCRequestGuildMembership.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildMembership_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildMembership_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestGuildMembership Clone()
```

#### Returns

 [CMsgClientToGCRequestGuildMembership](Divine.Protobufs.Dota2.CMsgClientToGCRequestGuildMembership.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildMembership_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildMembership_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildMembership_"></a> Equals\(CMsgClientToGCRequestGuildMembership\)

```csharp
public bool Equals(CMsgClientToGCRequestGuildMembership other)
```

#### Parameters

`other` [CMsgClientToGCRequestGuildMembership](Divine.Protobufs.Dota2.CMsgClientToGCRequestGuildMembership.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildMembership_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildMembership_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildMembership_"></a> MergeFrom\(CMsgClientToGCRequestGuildMembership\)

```csharp
public void MergeFrom(CMsgClientToGCRequestGuildMembership other)
```

#### Parameters

`other` [CMsgClientToGCRequestGuildMembership](Divine.Protobufs.Dota2.CMsgClientToGCRequestGuildMembership.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildMembership_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildMembership_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestGuildMembership_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

