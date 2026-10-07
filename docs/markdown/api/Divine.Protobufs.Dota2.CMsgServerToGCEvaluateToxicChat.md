# <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat"></a> Class CMsgServerToGCEvaluateToxicChat

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCEvaluateToxicChat : IMessage<CMsgServerToGCEvaluateToxicChat>, IEquatable<CMsgServerToGCEvaluateToxicChat>, IDeepCloneable<CMsgServerToGCEvaluateToxicChat>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCEvaluateToxicChat](Divine.Protobufs.Dota2.CMsgServerToGCEvaluateToxicChat.md)

#### Implements

IMessage<CMsgServerToGCEvaluateToxicChat\>, 
[IEquatable<CMsgServerToGCEvaluateToxicChat\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCEvaluateToxicChat\>, 
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
[EnumerableExtensions.In<CMsgServerToGCEvaluateToxicChat\>\(CMsgServerToGCEvaluateToxicChat, params CMsgServerToGCEvaluateToxicChat\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat__ctor"></a> CMsgServerToGCEvaluateToxicChat\(\)

```csharp
public CMsgServerToGCEvaluateToxicChat()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat__ctor_Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat_"></a> CMsgServerToGCEvaluateToxicChat\(CMsgServerToGCEvaluateToxicChat\)

```csharp
public CMsgServerToGCEvaluateToxicChat(CMsgServerToGCEvaluateToxicChat other)
```

#### Parameters

`other` [CMsgServerToGCEvaluateToxicChat](Divine.Protobufs.Dota2.CMsgServerToGCEvaluateToxicChat.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat_LineFieldNumber"></a> LineFieldNumber

```csharp
public const int LineFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat_ReporterAccountIdFieldNumber"></a> ReporterAccountIdFieldNumber

```csharp
public const int ReporterAccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat_TargetAccountIdFieldNumber"></a> TargetAccountIdFieldNumber

```csharp
public const int TargetAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat_TimestampFieldNumber"></a> TimestampFieldNumber

```csharp
public const int TimestampFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat_HasReporterAccountId"></a> HasReporterAccountId

```csharp
public bool HasReporterAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat_HasTargetAccountId"></a> HasTargetAccountId

```csharp
public bool HasTargetAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat_Line"></a> Line

```csharp
public RepeatedField<string> Line { get; }
```

#### Property Value

 RepeatedField<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCEvaluateToxicChat> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCEvaluateToxicChat](Divine.Protobufs.Dota2.CMsgServerToGCEvaluateToxicChat.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat_ReporterAccountId"></a> ReporterAccountId

```csharp
public uint ReporterAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat_TargetAccountId"></a> TargetAccountId

```csharp
public uint TargetAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat_Timestamp"></a> Timestamp

```csharp
public RepeatedField<uint> Timestamp { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat_ClearReporterAccountId"></a> ClearReporterAccountId\(\)

```csharp
public void ClearReporterAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat_ClearTargetAccountId"></a> ClearTargetAccountId\(\)

```csharp
public void ClearTargetAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCEvaluateToxicChat Clone()
```

#### Returns

 [CMsgServerToGCEvaluateToxicChat](Divine.Protobufs.Dota2.CMsgServerToGCEvaluateToxicChat.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat_Equals_Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat_"></a> Equals\(CMsgServerToGCEvaluateToxicChat\)

```csharp
public bool Equals(CMsgServerToGCEvaluateToxicChat other)
```

#### Parameters

`other` [CMsgServerToGCEvaluateToxicChat](Divine.Protobufs.Dota2.CMsgServerToGCEvaluateToxicChat.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat_"></a> MergeFrom\(CMsgServerToGCEvaluateToxicChat\)

```csharp
public void MergeFrom(CMsgServerToGCEvaluateToxicChat other)
```

#### Parameters

`other` [CMsgServerToGCEvaluateToxicChat](Divine.Protobufs.Dota2.CMsgServerToGCEvaluateToxicChat.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCEvaluateToxicChat_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

