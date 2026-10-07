# <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsRequest"></a> Class CMsgDOTAMatchmakingStatsRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAMatchmakingStatsRequest : IMessage<CMsgDOTAMatchmakingStatsRequest>, IEquatable<CMsgDOTAMatchmakingStatsRequest>, IDeepCloneable<CMsgDOTAMatchmakingStatsRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAMatchmakingStatsRequest](Divine.Protobufs.Dota2.CMsgDOTAMatchmakingStatsRequest.md)

#### Implements

IMessage<CMsgDOTAMatchmakingStatsRequest\>, 
[IEquatable<CMsgDOTAMatchmakingStatsRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAMatchmakingStatsRequest\>, 
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
[EnumerableExtensions.In<CMsgDOTAMatchmakingStatsRequest\>\(CMsgDOTAMatchmakingStatsRequest, params CMsgDOTAMatchmakingStatsRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsRequest__ctor"></a> CMsgDOTAMatchmakingStatsRequest\(\)

```csharp
public CMsgDOTAMatchmakingStatsRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsRequest__ctor_Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsRequest_"></a> CMsgDOTAMatchmakingStatsRequest\(CMsgDOTAMatchmakingStatsRequest\)

```csharp
public CMsgDOTAMatchmakingStatsRequest(CMsgDOTAMatchmakingStatsRequest other)
```

#### Parameters

`other` [CMsgDOTAMatchmakingStatsRequest](Divine.Protobufs.Dota2.CMsgDOTAMatchmakingStatsRequest.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAMatchmakingStatsRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAMatchmakingStatsRequest](Divine.Protobufs.Dota2.CMsgDOTAMatchmakingStatsRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsRequest_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAMatchmakingStatsRequest Clone()
```

#### Returns

 [CMsgDOTAMatchmakingStatsRequest](Divine.Protobufs.Dota2.CMsgDOTAMatchmakingStatsRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsRequest_Equals_Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsRequest_"></a> Equals\(CMsgDOTAMatchmakingStatsRequest\)

```csharp
public bool Equals(CMsgDOTAMatchmakingStatsRequest other)
```

#### Parameters

`other` [CMsgDOTAMatchmakingStatsRequest](Divine.Protobufs.Dota2.CMsgDOTAMatchmakingStatsRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsRequest_"></a> MergeFrom\(CMsgDOTAMatchmakingStatsRequest\)

```csharp
public void MergeFrom(CMsgDOTAMatchmakingStatsRequest other)
```

#### Parameters

`other` [CMsgDOTAMatchmakingStatsRequest](Divine.Protobufs.Dota2.CMsgDOTAMatchmakingStatsRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMatchmakingStatsRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

