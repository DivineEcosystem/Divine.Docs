# <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelectionResponse"></a> Class CMsgGCToClientRequestLaneSelectionResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientRequestLaneSelectionResponse : IMessage<CMsgGCToClientRequestLaneSelectionResponse>, IEquatable<CMsgGCToClientRequestLaneSelectionResponse>, IDeepCloneable<CMsgGCToClientRequestLaneSelectionResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientRequestLaneSelectionResponse](Divine.Protobufs.Dota2.CMsgGCToClientRequestLaneSelectionResponse.md)

#### Implements

IMessage<CMsgGCToClientRequestLaneSelectionResponse\>, 
[IEquatable<CMsgGCToClientRequestLaneSelectionResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientRequestLaneSelectionResponse\>, 
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
[EnumerableExtensions.In<CMsgGCToClientRequestLaneSelectionResponse\>\(CMsgGCToClientRequestLaneSelectionResponse, params CMsgGCToClientRequestLaneSelectionResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelectionResponse__ctor"></a> CMsgGCToClientRequestLaneSelectionResponse\(\)

```csharp
public CMsgGCToClientRequestLaneSelectionResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelectionResponse__ctor_Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelectionResponse_"></a> CMsgGCToClientRequestLaneSelectionResponse\(CMsgGCToClientRequestLaneSelectionResponse\)

```csharp
public CMsgGCToClientRequestLaneSelectionResponse(CMsgGCToClientRequestLaneSelectionResponse other)
```

#### Parameters

`other` [CMsgGCToClientRequestLaneSelectionResponse](Divine.Protobufs.Dota2.CMsgGCToClientRequestLaneSelectionResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelectionResponse_HighPriorityDisabledFieldNumber"></a> HighPriorityDisabledFieldNumber

```csharp
public const int HighPriorityDisabledFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelectionResponse_LaneSelectionFlagsFieldNumber"></a> LaneSelectionFlagsFieldNumber

```csharp
public const int LaneSelectionFlagsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelectionResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelectionResponse_HasHighPriorityDisabled"></a> HasHighPriorityDisabled

```csharp
public bool HasHighPriorityDisabled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelectionResponse_HasLaneSelectionFlags"></a> HasLaneSelectionFlags

```csharp
public bool HasLaneSelectionFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelectionResponse_HighPriorityDisabled"></a> HighPriorityDisabled

```csharp
public bool HighPriorityDisabled { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelectionResponse_LaneSelectionFlags"></a> LaneSelectionFlags

```csharp
public uint LaneSelectionFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelectionResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientRequestLaneSelectionResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientRequestLaneSelectionResponse](Divine.Protobufs.Dota2.CMsgGCToClientRequestLaneSelectionResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelectionResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelectionResponse_ClearHighPriorityDisabled"></a> ClearHighPriorityDisabled\(\)

```csharp
public void ClearHighPriorityDisabled()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelectionResponse_ClearLaneSelectionFlags"></a> ClearLaneSelectionFlags\(\)

```csharp
public void ClearLaneSelectionFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelectionResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientRequestLaneSelectionResponse Clone()
```

#### Returns

 [CMsgGCToClientRequestLaneSelectionResponse](Divine.Protobufs.Dota2.CMsgGCToClientRequestLaneSelectionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelectionResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelectionResponse_Equals_Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelectionResponse_"></a> Equals\(CMsgGCToClientRequestLaneSelectionResponse\)

```csharp
public bool Equals(CMsgGCToClientRequestLaneSelectionResponse other)
```

#### Parameters

`other` [CMsgGCToClientRequestLaneSelectionResponse](Divine.Protobufs.Dota2.CMsgGCToClientRequestLaneSelectionResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelectionResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelectionResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelectionResponse_"></a> MergeFrom\(CMsgGCToClientRequestLaneSelectionResponse\)

```csharp
public void MergeFrom(CMsgGCToClientRequestLaneSelectionResponse other)
```

#### Parameters

`other` [CMsgGCToClientRequestLaneSelectionResponse](Divine.Protobufs.Dota2.CMsgGCToClientRequestLaneSelectionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelectionResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelectionResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRequestLaneSelectionResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

