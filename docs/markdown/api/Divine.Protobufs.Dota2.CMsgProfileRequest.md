# <a id="Divine_Protobufs_Dota2_CMsgProfileRequest"></a> Class CMsgProfileRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgProfileRequest : IMessage<CMsgProfileRequest>, IEquatable<CMsgProfileRequest>, IDeepCloneable<CMsgProfileRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgProfileRequest](Divine.Protobufs.Dota2.CMsgProfileRequest.md)

#### Implements

IMessage<CMsgProfileRequest\>, 
[IEquatable<CMsgProfileRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgProfileRequest\>, 
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
[EnumerableExtensions.In<CMsgProfileRequest\>\(CMsgProfileRequest, params CMsgProfileRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgProfileRequest__ctor"></a> CMsgProfileRequest\(\)

```csharp
public CMsgProfileRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgProfileRequest__ctor_Divine_Protobufs_Dota2_CMsgProfileRequest_"></a> CMsgProfileRequest\(CMsgProfileRequest\)

```csharp
public CMsgProfileRequest(CMsgProfileRequest other)
```

#### Parameters

`other` [CMsgProfileRequest](Divine.Protobufs.Dota2.CMsgProfileRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgProfileRequest_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgProfileRequest_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgProfileRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgProfileRequest_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProfileRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgProfileRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgProfileRequest](Divine.Protobufs.Dota2.CMsgProfileRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgProfileRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProfileRequest_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgProfileRequest_Clone"></a> Clone\(\)

```csharp
public CMsgProfileRequest Clone()
```

#### Returns

 [CMsgProfileRequest](Divine.Protobufs.Dota2.CMsgProfileRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgProfileRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProfileRequest_Equals_Divine_Protobufs_Dota2_CMsgProfileRequest_"></a> Equals\(CMsgProfileRequest\)

```csharp
public bool Equals(CMsgProfileRequest other)
```

#### Parameters

`other` [CMsgProfileRequest](Divine.Protobufs.Dota2.CMsgProfileRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProfileRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProfileRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgProfileRequest_"></a> MergeFrom\(CMsgProfileRequest\)

```csharp
public void MergeFrom(CMsgProfileRequest other)
```

#### Parameters

`other` [CMsgProfileRequest](Divine.Protobufs.Dota2.CMsgProfileRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgProfileRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgProfileRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgProfileRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

