# <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsResponse"></a> Class CMsgGCItemEditorReservationsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCItemEditorReservationsResponse : IMessage<CMsgGCItemEditorReservationsResponse>, IEquatable<CMsgGCItemEditorReservationsResponse>, IDeepCloneable<CMsgGCItemEditorReservationsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCItemEditorReservationsResponse](Divine.Protobufs.Dota2.CMsgGCItemEditorReservationsResponse.md)

#### Implements

IMessage<CMsgGCItemEditorReservationsResponse\>, 
[IEquatable<CMsgGCItemEditorReservationsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCItemEditorReservationsResponse\>, 
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
[EnumerableExtensions.In<CMsgGCItemEditorReservationsResponse\>\(CMsgGCItemEditorReservationsResponse, params CMsgGCItemEditorReservationsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsResponse__ctor"></a> CMsgGCItemEditorReservationsResponse\(\)

```csharp
public CMsgGCItemEditorReservationsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsResponse__ctor_Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsResponse_"></a> CMsgGCItemEditorReservationsResponse\(CMsgGCItemEditorReservationsResponse\)

```csharp
public CMsgGCItemEditorReservationsResponse(CMsgGCItemEditorReservationsResponse other)
```

#### Parameters

`other` [CMsgGCItemEditorReservationsResponse](Divine.Protobufs.Dota2.CMsgGCItemEditorReservationsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsResponse_ReservationsFieldNumber"></a> ReservationsFieldNumber

```csharp
public const int ReservationsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCItemEditorReservationsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCItemEditorReservationsResponse](Divine.Protobufs.Dota2.CMsgGCItemEditorReservationsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsResponse_Reservations"></a> Reservations

```csharp
public RepeatedField<CMsgGCItemEditorReservation> Reservations { get; }
```

#### Property Value

 RepeatedField<[CMsgGCItemEditorReservation](Divine.Protobufs.Dota2.CMsgGCItemEditorReservation.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCItemEditorReservationsResponse Clone()
```

#### Returns

 [CMsgGCItemEditorReservationsResponse](Divine.Protobufs.Dota2.CMsgGCItemEditorReservationsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsResponse_Equals_Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsResponse_"></a> Equals\(CMsgGCItemEditorReservationsResponse\)

```csharp
public bool Equals(CMsgGCItemEditorReservationsResponse other)
```

#### Parameters

`other` [CMsgGCItemEditorReservationsResponse](Divine.Protobufs.Dota2.CMsgGCItemEditorReservationsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsResponse_"></a> MergeFrom\(CMsgGCItemEditorReservationsResponse\)

```csharp
public void MergeFrom(CMsgGCItemEditorReservationsResponse other)
```

#### Parameters

`other` [CMsgGCItemEditorReservationsResponse](Divine.Protobufs.Dota2.CMsgGCItemEditorReservationsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

