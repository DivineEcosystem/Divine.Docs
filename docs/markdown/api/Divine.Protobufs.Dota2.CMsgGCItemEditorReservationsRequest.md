# <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsRequest"></a> Class CMsgGCItemEditorReservationsRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCItemEditorReservationsRequest : IMessage<CMsgGCItemEditorReservationsRequest>, IEquatable<CMsgGCItemEditorReservationsRequest>, IDeepCloneable<CMsgGCItemEditorReservationsRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCItemEditorReservationsRequest](Divine.Protobufs.Dota2.CMsgGCItemEditorReservationsRequest.md)

#### Implements

IMessage<CMsgGCItemEditorReservationsRequest\>, 
[IEquatable<CMsgGCItemEditorReservationsRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCItemEditorReservationsRequest\>, 
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
[EnumerableExtensions.In<CMsgGCItemEditorReservationsRequest\>\(CMsgGCItemEditorReservationsRequest, params CMsgGCItemEditorReservationsRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsRequest__ctor"></a> CMsgGCItemEditorReservationsRequest\(\)

```csharp
public CMsgGCItemEditorReservationsRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsRequest__ctor_Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsRequest_"></a> CMsgGCItemEditorReservationsRequest\(CMsgGCItemEditorReservationsRequest\)

```csharp
public CMsgGCItemEditorReservationsRequest(CMsgGCItemEditorReservationsRequest other)
```

#### Parameters

`other` [CMsgGCItemEditorReservationsRequest](Divine.Protobufs.Dota2.CMsgGCItemEditorReservationsRequest.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCItemEditorReservationsRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCItemEditorReservationsRequest](Divine.Protobufs.Dota2.CMsgGCItemEditorReservationsRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsRequest_Clone"></a> Clone\(\)

```csharp
public CMsgGCItemEditorReservationsRequest Clone()
```

#### Returns

 [CMsgGCItemEditorReservationsRequest](Divine.Protobufs.Dota2.CMsgGCItemEditorReservationsRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsRequest_Equals_Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsRequest_"></a> Equals\(CMsgGCItemEditorReservationsRequest\)

```csharp
public bool Equals(CMsgGCItemEditorReservationsRequest other)
```

#### Parameters

`other` [CMsgGCItemEditorReservationsRequest](Divine.Protobufs.Dota2.CMsgGCItemEditorReservationsRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsRequest_"></a> MergeFrom\(CMsgGCItemEditorReservationsRequest\)

```csharp
public void MergeFrom(CMsgGCItemEditorReservationsRequest other)
```

#### Parameters

`other` [CMsgGCItemEditorReservationsRequest](Divine.Protobufs.Dota2.CMsgGCItemEditorReservationsRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReservationsRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

