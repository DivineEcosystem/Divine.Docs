# <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuild"></a> Class CMsgClientToGCLeaveGuild

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCLeaveGuild : IMessage<CMsgClientToGCLeaveGuild>, IEquatable<CMsgClientToGCLeaveGuild>, IDeepCloneable<CMsgClientToGCLeaveGuild>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCLeaveGuild](Divine.Protobufs.Dota2.CMsgClientToGCLeaveGuild.md)

#### Implements

IMessage<CMsgClientToGCLeaveGuild\>, 
[IEquatable<CMsgClientToGCLeaveGuild\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCLeaveGuild\>, 
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
[EnumerableExtensions.In<CMsgClientToGCLeaveGuild\>\(CMsgClientToGCLeaveGuild, params CMsgClientToGCLeaveGuild\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuild__ctor"></a> CMsgClientToGCLeaveGuild\(\)

```csharp
public CMsgClientToGCLeaveGuild()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuild__ctor_Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuild_"></a> CMsgClientToGCLeaveGuild\(CMsgClientToGCLeaveGuild\)

```csharp
public CMsgClientToGCLeaveGuild(CMsgClientToGCLeaveGuild other)
```

#### Parameters

`other` [CMsgClientToGCLeaveGuild](Divine.Protobufs.Dota2.CMsgClientToGCLeaveGuild.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuild_GuildIdFieldNumber"></a> GuildIdFieldNumber

```csharp
public const int GuildIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuild_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuild_GuildId"></a> GuildId

```csharp
public uint GuildId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuild_HasGuildId"></a> HasGuildId

```csharp
public bool HasGuildId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuild_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCLeaveGuild> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCLeaveGuild](Divine.Protobufs.Dota2.CMsgClientToGCLeaveGuild.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuild_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuild_ClearGuildId"></a> ClearGuildId\(\)

```csharp
public void ClearGuildId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuild_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCLeaveGuild Clone()
```

#### Returns

 [CMsgClientToGCLeaveGuild](Divine.Protobufs.Dota2.CMsgClientToGCLeaveGuild.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuild_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuild_Equals_Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuild_"></a> Equals\(CMsgClientToGCLeaveGuild\)

```csharp
public bool Equals(CMsgClientToGCLeaveGuild other)
```

#### Parameters

`other` [CMsgClientToGCLeaveGuild](Divine.Protobufs.Dota2.CMsgClientToGCLeaveGuild.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuild_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuild_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuild_"></a> MergeFrom\(CMsgClientToGCLeaveGuild\)

```csharp
public void MergeFrom(CMsgClientToGCLeaveGuild other)
```

#### Parameters

`other` [CMsgClientToGCLeaveGuild](Divine.Protobufs.Dota2.CMsgClientToGCLeaveGuild.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuild_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuild_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuild_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

