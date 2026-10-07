# <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReleaseReservationResponse"></a> Class CMsgGCItemEditorReleaseReservationResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCItemEditorReleaseReservationResponse : IMessage<CMsgGCItemEditorReleaseReservationResponse>, IEquatable<CMsgGCItemEditorReleaseReservationResponse>, IDeepCloneable<CMsgGCItemEditorReleaseReservationResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCItemEditorReleaseReservationResponse](Divine.Protobufs.Dota2.CMsgGCItemEditorReleaseReservationResponse.md)

#### Implements

IMessage<CMsgGCItemEditorReleaseReservationResponse\>, 
[IEquatable<CMsgGCItemEditorReleaseReservationResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCItemEditorReleaseReservationResponse\>, 
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
[EnumerableExtensions.In<CMsgGCItemEditorReleaseReservationResponse\>\(CMsgGCItemEditorReleaseReservationResponse, params CMsgGCItemEditorReleaseReservationResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReleaseReservationResponse__ctor"></a> CMsgGCItemEditorReleaseReservationResponse\(\)

```csharp
public CMsgGCItemEditorReleaseReservationResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReleaseReservationResponse__ctor_Divine_Protobufs_Dota2_CMsgGCItemEditorReleaseReservationResponse_"></a> CMsgGCItemEditorReleaseReservationResponse\(CMsgGCItemEditorReleaseReservationResponse\)

```csharp
public CMsgGCItemEditorReleaseReservationResponse(CMsgGCItemEditorReleaseReservationResponse other)
```

#### Parameters

`other` [CMsgGCItemEditorReleaseReservationResponse](Divine.Protobufs.Dota2.CMsgGCItemEditorReleaseReservationResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReleaseReservationResponse_DefIndexFieldNumber"></a> DefIndexFieldNumber

```csharp
public const int DefIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReleaseReservationResponse_ReleasedFieldNumber"></a> ReleasedFieldNumber

```csharp
public const int ReleasedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReleaseReservationResponse_DefIndex"></a> DefIndex

```csharp
public uint DefIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReleaseReservationResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReleaseReservationResponse_HasDefIndex"></a> HasDefIndex

```csharp
public bool HasDefIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReleaseReservationResponse_HasReleased"></a> HasReleased

```csharp
public bool HasReleased { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReleaseReservationResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCItemEditorReleaseReservationResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCItemEditorReleaseReservationResponse](Divine.Protobufs.Dota2.CMsgGCItemEditorReleaseReservationResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReleaseReservationResponse_Released"></a> Released

```csharp
public bool Released { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReleaseReservationResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReleaseReservationResponse_ClearDefIndex"></a> ClearDefIndex\(\)

```csharp
public void ClearDefIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReleaseReservationResponse_ClearReleased"></a> ClearReleased\(\)

```csharp
public void ClearReleased()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReleaseReservationResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCItemEditorReleaseReservationResponse Clone()
```

#### Returns

 [CMsgGCItemEditorReleaseReservationResponse](Divine.Protobufs.Dota2.CMsgGCItemEditorReleaseReservationResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReleaseReservationResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReleaseReservationResponse_Equals_Divine_Protobufs_Dota2_CMsgGCItemEditorReleaseReservationResponse_"></a> Equals\(CMsgGCItemEditorReleaseReservationResponse\)

```csharp
public bool Equals(CMsgGCItemEditorReleaseReservationResponse other)
```

#### Parameters

`other` [CMsgGCItemEditorReleaseReservationResponse](Divine.Protobufs.Dota2.CMsgGCItemEditorReleaseReservationResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReleaseReservationResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReleaseReservationResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCItemEditorReleaseReservationResponse_"></a> MergeFrom\(CMsgGCItemEditorReleaseReservationResponse\)

```csharp
public void MergeFrom(CMsgGCItemEditorReleaseReservationResponse other)
```

#### Parameters

`other` [CMsgGCItemEditorReleaseReservationResponse](Divine.Protobufs.Dota2.CMsgGCItemEditorReleaseReservationResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReleaseReservationResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReleaseReservationResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReleaseReservationResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

