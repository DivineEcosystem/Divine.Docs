# <a id="Divine_Protobufs_Dota2_CMsgGuildSummary"></a> Class CMsgGuildSummary

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGuildSummary : IMessage<CMsgGuildSummary>, IEquatable<CMsgGuildSummary>, IDeepCloneable<CMsgGuildSummary>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGuildSummary](Divine.Protobufs.Dota2.CMsgGuildSummary.md)

#### Implements

IMessage<CMsgGuildSummary\>, 
[IEquatable<CMsgGuildSummary\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGuildSummary\>, 
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
[EnumerableExtensions.In<CMsgGuildSummary\>\(CMsgGuildSummary, params CMsgGuildSummary\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary__ctor"></a> CMsgGuildSummary\(\)

```csharp
public CMsgGuildSummary()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary__ctor_Divine_Protobufs_Dota2_CMsgGuildSummary_"></a> CMsgGuildSummary\(CMsgGuildSummary\)

```csharp
public CMsgGuildSummary(CMsgGuildSummary other)
```

#### Parameters

`other` [CMsgGuildSummary](Divine.Protobufs.Dota2.CMsgGuildSummary.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_EventPointsFieldNumber"></a> EventPointsFieldNumber

```csharp
public const int EventPointsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_GuildInfoFieldNumber"></a> GuildInfoFieldNumber

```csharp
public const int GuildInfoFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_MemberCountFieldNumber"></a> MemberCountFieldNumber

```csharp
public const int MemberCountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_EventPoints"></a> EventPoints

```csharp
public RepeatedField<CMsgGuildSummary.Types.EventPoints> EventPoints { get; }
```

#### Property Value

 RepeatedField<[CMsgGuildSummary](Divine.Protobufs.Dota2.CMsgGuildSummary.md).[Types](Divine.Protobufs.Dota2.CMsgGuildSummary.Types.md).[EventPoints](Divine.Protobufs.Dota2.CMsgGuildSummary.Types.EventPoints.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_GuildInfo"></a> GuildInfo

```csharp
public CMsgGuildInfo GuildInfo { get; set; }
```

#### Property Value

 [CMsgGuildInfo](Divine.Protobufs.Dota2.CMsgGuildInfo.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_HasMemberCount"></a> HasMemberCount

```csharp
public bool HasMemberCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_MemberCount"></a> MemberCount

```csharp
public uint MemberCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGuildSummary> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGuildSummary](Divine.Protobufs.Dota2.CMsgGuildSummary.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_ClearMemberCount"></a> ClearMemberCount\(\)

```csharp
public void ClearMemberCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Clone"></a> Clone\(\)

```csharp
public CMsgGuildSummary Clone()
```

#### Returns

 [CMsgGuildSummary](Divine.Protobufs.Dota2.CMsgGuildSummary.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_Equals_Divine_Protobufs_Dota2_CMsgGuildSummary_"></a> Equals\(CMsgGuildSummary\)

```csharp
public bool Equals(CMsgGuildSummary other)
```

#### Parameters

`other` [CMsgGuildSummary](Divine.Protobufs.Dota2.CMsgGuildSummary.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_MergeFrom_Divine_Protobufs_Dota2_CMsgGuildSummary_"></a> MergeFrom\(CMsgGuildSummary\)

```csharp
public void MergeFrom(CMsgGuildSummary other)
```

#### Parameters

`other` [CMsgGuildSummary](Divine.Protobufs.Dota2.CMsgGuildSummary.md)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGuildSummary_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

