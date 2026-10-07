# <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitLobbyMVPVote"></a> Class CMsgDOTASubmitLobbyMVPVote

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTASubmitLobbyMVPVote : IMessage<CMsgDOTASubmitLobbyMVPVote>, IEquatable<CMsgDOTASubmitLobbyMVPVote>, IDeepCloneable<CMsgDOTASubmitLobbyMVPVote>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTASubmitLobbyMVPVote](Divine.Protobufs.Dota2.CMsgDOTASubmitLobbyMVPVote.md)

#### Implements

IMessage<CMsgDOTASubmitLobbyMVPVote\>, 
[IEquatable<CMsgDOTASubmitLobbyMVPVote\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTASubmitLobbyMVPVote\>, 
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
[EnumerableExtensions.In<CMsgDOTASubmitLobbyMVPVote\>\(CMsgDOTASubmitLobbyMVPVote, params CMsgDOTASubmitLobbyMVPVote\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitLobbyMVPVote__ctor"></a> CMsgDOTASubmitLobbyMVPVote\(\)

```csharp
public CMsgDOTASubmitLobbyMVPVote()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitLobbyMVPVote__ctor_Divine_Protobufs_Dota2_CMsgDOTASubmitLobbyMVPVote_"></a> CMsgDOTASubmitLobbyMVPVote\(CMsgDOTASubmitLobbyMVPVote\)

```csharp
public CMsgDOTASubmitLobbyMVPVote(CMsgDOTASubmitLobbyMVPVote other)
```

#### Parameters

`other` [CMsgDOTASubmitLobbyMVPVote](Divine.Protobufs.Dota2.CMsgDOTASubmitLobbyMVPVote.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitLobbyMVPVote_TargetAccountIdFieldNumber"></a> TargetAccountIdFieldNumber

```csharp
public const int TargetAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitLobbyMVPVote_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitLobbyMVPVote_HasTargetAccountId"></a> HasTargetAccountId

```csharp
public bool HasTargetAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitLobbyMVPVote_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTASubmitLobbyMVPVote> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTASubmitLobbyMVPVote](Divine.Protobufs.Dota2.CMsgDOTASubmitLobbyMVPVote.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitLobbyMVPVote_TargetAccountId"></a> TargetAccountId

```csharp
public uint TargetAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitLobbyMVPVote_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitLobbyMVPVote_ClearTargetAccountId"></a> ClearTargetAccountId\(\)

```csharp
public void ClearTargetAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitLobbyMVPVote_Clone"></a> Clone\(\)

```csharp
public CMsgDOTASubmitLobbyMVPVote Clone()
```

#### Returns

 [CMsgDOTASubmitLobbyMVPVote](Divine.Protobufs.Dota2.CMsgDOTASubmitLobbyMVPVote.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitLobbyMVPVote_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitLobbyMVPVote_Equals_Divine_Protobufs_Dota2_CMsgDOTASubmitLobbyMVPVote_"></a> Equals\(CMsgDOTASubmitLobbyMVPVote\)

```csharp
public bool Equals(CMsgDOTASubmitLobbyMVPVote other)
```

#### Parameters

`other` [CMsgDOTASubmitLobbyMVPVote](Divine.Protobufs.Dota2.CMsgDOTASubmitLobbyMVPVote.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitLobbyMVPVote_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitLobbyMVPVote_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTASubmitLobbyMVPVote_"></a> MergeFrom\(CMsgDOTASubmitLobbyMVPVote\)

```csharp
public void MergeFrom(CMsgDOTASubmitLobbyMVPVote other)
```

#### Parameters

`other` [CMsgDOTASubmitLobbyMVPVote](Divine.Protobufs.Dota2.CMsgDOTASubmitLobbyMVPVote.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitLobbyMVPVote_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitLobbyMVPVote_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitLobbyMVPVote_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

