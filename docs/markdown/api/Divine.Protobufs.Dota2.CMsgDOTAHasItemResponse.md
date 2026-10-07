# <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemResponse"></a> Class CMsgDOTAHasItemResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAHasItemResponse : IMessage<CMsgDOTAHasItemResponse>, IEquatable<CMsgDOTAHasItemResponse>, IDeepCloneable<CMsgDOTAHasItemResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAHasItemResponse](Divine.Protobufs.Dota2.CMsgDOTAHasItemResponse.md)

#### Implements

IMessage<CMsgDOTAHasItemResponse\>, 
[IEquatable<CMsgDOTAHasItemResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAHasItemResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTAHasItemResponse\>\(CMsgDOTAHasItemResponse, params CMsgDOTAHasItemResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemResponse__ctor"></a> CMsgDOTAHasItemResponse\(\)

```csharp
public CMsgDOTAHasItemResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTAHasItemResponse_"></a> CMsgDOTAHasItemResponse\(CMsgDOTAHasItemResponse\)

```csharp
public CMsgDOTAHasItemResponse(CMsgDOTAHasItemResponse other)
```

#### Parameters

`other` [CMsgDOTAHasItemResponse](Divine.Protobufs.Dota2.CMsgDOTAHasItemResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemResponse_HasItemFieldNumber"></a> HasItemFieldNumber

```csharp
public const int HasItemFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemResponse_HasHasItem"></a> HasHasItem

```csharp
public bool HasHasItem { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemResponse_HasItem"></a> HasItem

```csharp
public bool HasItem { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAHasItemResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAHasItemResponse](Divine.Protobufs.Dota2.CMsgDOTAHasItemResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemResponse_ClearHasItem"></a> ClearHasItem\(\)

```csharp
public void ClearHasItem()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAHasItemResponse Clone()
```

#### Returns

 [CMsgDOTAHasItemResponse](Divine.Protobufs.Dota2.CMsgDOTAHasItemResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTAHasItemResponse_"></a> Equals\(CMsgDOTAHasItemResponse\)

```csharp
public bool Equals(CMsgDOTAHasItemResponse other)
```

#### Parameters

`other` [CMsgDOTAHasItemResponse](Divine.Protobufs.Dota2.CMsgDOTAHasItemResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAHasItemResponse_"></a> MergeFrom\(CMsgDOTAHasItemResponse\)

```csharp
public void MergeFrom(CMsgDOTAHasItemResponse other)
```

#### Parameters

`other` [CMsgDOTAHasItemResponse](Divine.Protobufs.Dota2.CMsgDOTAHasItemResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

