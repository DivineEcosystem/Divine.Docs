# <a id="Divine_Protobufs_Dota2_CMsgTeamFanfare"></a> Class CMsgTeamFanfare

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTeamFanfare : IMessage<CMsgTeamFanfare>, IEquatable<CMsgTeamFanfare>, IDeepCloneable<CMsgTeamFanfare>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTeamFanfare](Divine.Protobufs.Dota2.CMsgTeamFanfare.md)

#### Implements

IMessage<CMsgTeamFanfare\>, 
[IEquatable<CMsgTeamFanfare\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTeamFanfare\>, 
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
[EnumerableExtensions.In<CMsgTeamFanfare\>\(CMsgTeamFanfare, params CMsgTeamFanfare\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanfare__ctor"></a> CMsgTeamFanfare\(\)

```csharp
public CMsgTeamFanfare()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanfare__ctor_Divine_Protobufs_Dota2_CMsgTeamFanfare_"></a> CMsgTeamFanfare\(CMsgTeamFanfare\)

```csharp
public CMsgTeamFanfare(CMsgTeamFanfare other)
```

#### Parameters

`other` [CMsgTeamFanfare](Divine.Protobufs.Dota2.CMsgTeamFanfare.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanfare_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanfare_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanfare_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanfare_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanfare_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTeamFanfare> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTeamFanfare](Divine.Protobufs.Dota2.CMsgTeamFanfare.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanfare_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanfare_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanfare_Clone"></a> Clone\(\)

```csharp
public CMsgTeamFanfare Clone()
```

#### Returns

 [CMsgTeamFanfare](Divine.Protobufs.Dota2.CMsgTeamFanfare.md)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanfare_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanfare_Equals_Divine_Protobufs_Dota2_CMsgTeamFanfare_"></a> Equals\(CMsgTeamFanfare\)

```csharp
public bool Equals(CMsgTeamFanfare other)
```

#### Parameters

`other` [CMsgTeamFanfare](Divine.Protobufs.Dota2.CMsgTeamFanfare.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanfare_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanfare_MergeFrom_Divine_Protobufs_Dota2_CMsgTeamFanfare_"></a> MergeFrom\(CMsgTeamFanfare\)

```csharp
public void MergeFrom(CMsgTeamFanfare other)
```

#### Parameters

`other` [CMsgTeamFanfare](Divine.Protobufs.Dota2.CMsgTeamFanfare.md)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanfare_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanfare_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanfare_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

