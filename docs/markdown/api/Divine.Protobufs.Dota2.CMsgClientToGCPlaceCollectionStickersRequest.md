# <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersRequest"></a> Class CMsgClientToGCPlaceCollectionStickersRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCPlaceCollectionStickersRequest : IMessage<CMsgClientToGCPlaceCollectionStickersRequest>, IEquatable<CMsgClientToGCPlaceCollectionStickersRequest>, IDeepCloneable<CMsgClientToGCPlaceCollectionStickersRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCPlaceCollectionStickersRequest](Divine.Protobufs.Dota2.CMsgClientToGCPlaceCollectionStickersRequest.md)

#### Implements

IMessage<CMsgClientToGCPlaceCollectionStickersRequest\>, 
[IEquatable<CMsgClientToGCPlaceCollectionStickersRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCPlaceCollectionStickersRequest\>, 
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
[EnumerableExtensions.In<CMsgClientToGCPlaceCollectionStickersRequest\>\(CMsgClientToGCPlaceCollectionStickersRequest, params CMsgClientToGCPlaceCollectionStickersRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersRequest__ctor"></a> CMsgClientToGCPlaceCollectionStickersRequest\(\)

```csharp
public CMsgClientToGCPlaceCollectionStickersRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersRequest__ctor_Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersRequest_"></a> CMsgClientToGCPlaceCollectionStickersRequest\(CMsgClientToGCPlaceCollectionStickersRequest\)

```csharp
public CMsgClientToGCPlaceCollectionStickersRequest(CMsgClientToGCPlaceCollectionStickersRequest other)
```

#### Parameters

`other` [CMsgClientToGCPlaceCollectionStickersRequest](Divine.Protobufs.Dota2.CMsgClientToGCPlaceCollectionStickersRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersRequest_SlotsFieldNumber"></a> SlotsFieldNumber

```csharp
public const int SlotsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCPlaceCollectionStickersRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCPlaceCollectionStickersRequest](Divine.Protobufs.Dota2.CMsgClientToGCPlaceCollectionStickersRequest.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersRequest_Slots"></a> Slots

```csharp
public RepeatedField<CMsgClientToGCPlaceCollectionStickersRequest.Types.Slot> Slots { get; }
```

#### Property Value

 RepeatedField<[CMsgClientToGCPlaceCollectionStickersRequest](Divine.Protobufs.Dota2.CMsgClientToGCPlaceCollectionStickersRequest.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCPlaceCollectionStickersRequest.Types.md).[Slot](Divine.Protobufs.Dota2.CMsgClientToGCPlaceCollectionStickersRequest.Types.Slot.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersRequest_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCPlaceCollectionStickersRequest Clone()
```

#### Returns

 [CMsgClientToGCPlaceCollectionStickersRequest](Divine.Protobufs.Dota2.CMsgClientToGCPlaceCollectionStickersRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersRequest_Equals_Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersRequest_"></a> Equals\(CMsgClientToGCPlaceCollectionStickersRequest\)

```csharp
public bool Equals(CMsgClientToGCPlaceCollectionStickersRequest other)
```

#### Parameters

`other` [CMsgClientToGCPlaceCollectionStickersRequest](Divine.Protobufs.Dota2.CMsgClientToGCPlaceCollectionStickersRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersRequest_"></a> MergeFrom\(CMsgClientToGCPlaceCollectionStickersRequest\)

```csharp
public void MergeFrom(CMsgClientToGCPlaceCollectionStickersRequest other)
```

#### Parameters

`other` [CMsgClientToGCPlaceCollectionStickersRequest](Divine.Protobufs.Dota2.CMsgClientToGCPlaceCollectionStickersRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCPlaceCollectionStickersRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

