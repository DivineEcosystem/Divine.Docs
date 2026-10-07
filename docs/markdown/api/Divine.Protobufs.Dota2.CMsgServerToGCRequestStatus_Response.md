# <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestStatus_Response"></a> Class CMsgServerToGCRequestStatus\_Response

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCRequestStatus_Response : IMessage<CMsgServerToGCRequestStatus_Response>, IEquatable<CMsgServerToGCRequestStatus_Response>, IDeepCloneable<CMsgServerToGCRequestStatus_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCRequestStatus\_Response](Divine.Protobufs.Dota2.CMsgServerToGCRequestStatus\_Response.md)

#### Implements

IMessage<CMsgServerToGCRequestStatus\_Response\>, 
[IEquatable<CMsgServerToGCRequestStatus\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCRequestStatus\_Response\>, 
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
[EnumerableExtensions.In<CMsgServerToGCRequestStatus\_Response\>\(CMsgServerToGCRequestStatus\_Response, params CMsgServerToGCRequestStatus\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestStatus_Response__ctor"></a> CMsgServerToGCRequestStatus\_Response\(\)

```csharp
public CMsgServerToGCRequestStatus_Response()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestStatus_Response__ctor_Divine_Protobufs_Dota2_CMsgServerToGCRequestStatus_Response_"></a> CMsgServerToGCRequestStatus\_Response\(CMsgServerToGCRequestStatus\_Response\)

```csharp
public CMsgServerToGCRequestStatus_Response(CMsgServerToGCRequestStatus_Response other)
```

#### Parameters

`other` [CMsgServerToGCRequestStatus\_Response](Divine.Protobufs.Dota2.CMsgServerToGCRequestStatus\_Response.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestStatus_Response_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestStatus_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestStatus_Response_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestStatus_Response_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCRequestStatus_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCRequestStatus\_Response](Divine.Protobufs.Dota2.CMsgServerToGCRequestStatus\_Response.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestStatus_Response_Response"></a> Response

```csharp
public uint Response { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestStatus_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestStatus_Response_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestStatus_Response_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCRequestStatus_Response Clone()
```

#### Returns

 [CMsgServerToGCRequestStatus\_Response](Divine.Protobufs.Dota2.CMsgServerToGCRequestStatus\_Response.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestStatus_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestStatus_Response_Equals_Divine_Protobufs_Dota2_CMsgServerToGCRequestStatus_Response_"></a> Equals\(CMsgServerToGCRequestStatus\_Response\)

```csharp
public bool Equals(CMsgServerToGCRequestStatus_Response other)
```

#### Parameters

`other` [CMsgServerToGCRequestStatus\_Response](Divine.Protobufs.Dota2.CMsgServerToGCRequestStatus\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestStatus_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestStatus_Response_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCRequestStatus_Response_"></a> MergeFrom\(CMsgServerToGCRequestStatus\_Response\)

```csharp
public void MergeFrom(CMsgServerToGCRequestStatus_Response other)
```

#### Parameters

`other` [CMsgServerToGCRequestStatus\_Response](Divine.Protobufs.Dota2.CMsgServerToGCRequestStatus\_Response.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestStatus_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestStatus_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestStatus_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

