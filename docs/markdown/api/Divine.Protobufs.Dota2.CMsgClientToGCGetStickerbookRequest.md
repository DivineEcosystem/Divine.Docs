# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookRequest"></a> Class CMsgClientToGCGetStickerbookRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetStickerbookRequest : IMessage<CMsgClientToGCGetStickerbookRequest>, IEquatable<CMsgClientToGCGetStickerbookRequest>, IDeepCloneable<CMsgClientToGCGetStickerbookRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetStickerbookRequest](Divine.Protobufs.Dota2.CMsgClientToGCGetStickerbookRequest.md)

#### Implements

IMessage<CMsgClientToGCGetStickerbookRequest\>, 
[IEquatable<CMsgClientToGCGetStickerbookRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetStickerbookRequest\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetStickerbookRequest\>\(CMsgClientToGCGetStickerbookRequest, params CMsgClientToGCGetStickerbookRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookRequest__ctor"></a> CMsgClientToGCGetStickerbookRequest\(\)

```csharp
public CMsgClientToGCGetStickerbookRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookRequest__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookRequest_"></a> CMsgClientToGCGetStickerbookRequest\(CMsgClientToGCGetStickerbookRequest\)

```csharp
public CMsgClientToGCGetStickerbookRequest(CMsgClientToGCGetStickerbookRequest other)
```

#### Parameters

`other` [CMsgClientToGCGetStickerbookRequest](Divine.Protobufs.Dota2.CMsgClientToGCGetStickerbookRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookRequest_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookRequest_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookRequest_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetStickerbookRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetStickerbookRequest](Divine.Protobufs.Dota2.CMsgClientToGCGetStickerbookRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookRequest_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookRequest_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetStickerbookRequest Clone()
```

#### Returns

 [CMsgClientToGCGetStickerbookRequest](Divine.Protobufs.Dota2.CMsgClientToGCGetStickerbookRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookRequest_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookRequest_"></a> Equals\(CMsgClientToGCGetStickerbookRequest\)

```csharp
public bool Equals(CMsgClientToGCGetStickerbookRequest other)
```

#### Parameters

`other` [CMsgClientToGCGetStickerbookRequest](Divine.Protobufs.Dota2.CMsgClientToGCGetStickerbookRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookRequest_"></a> MergeFrom\(CMsgClientToGCGetStickerbookRequest\)

```csharp
public void MergeFrom(CMsgClientToGCGetStickerbookRequest other)
```

#### Parameters

`other` [CMsgClientToGCGetStickerbookRequest](Divine.Protobufs.Dota2.CMsgClientToGCGetStickerbookRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetStickerbookRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

