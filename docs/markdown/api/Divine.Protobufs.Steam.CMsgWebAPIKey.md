# <a id="Divine_Protobufs_Steam_CMsgWebAPIKey"></a> Class CMsgWebAPIKey

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgWebAPIKey : IMessage<CMsgWebAPIKey>, IEquatable<CMsgWebAPIKey>, IDeepCloneable<CMsgWebAPIKey>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgWebAPIKey](Divine.Protobufs.Steam.CMsgWebAPIKey.md)

#### Implements

IMessage<CMsgWebAPIKey\>, 
[IEquatable<CMsgWebAPIKey\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgWebAPIKey\>, 
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
[EnumerableExtensions.In<CMsgWebAPIKey\>\(CMsgWebAPIKey, params CMsgWebAPIKey\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey__ctor"></a> CMsgWebAPIKey\(\)

```csharp
public CMsgWebAPIKey()
```

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey__ctor_Divine_Protobufs_Steam_CMsgWebAPIKey_"></a> CMsgWebAPIKey\(CMsgWebAPIKey\)

```csharp
public CMsgWebAPIKey(CMsgWebAPIKey other)
```

#### Parameters

`other` [CMsgWebAPIKey](Divine.Protobufs.Steam.CMsgWebAPIKey.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_DomainFieldNumber"></a> DomainFieldNumber

```csharp
public const int DomainFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_KeyIdFieldNumber"></a> KeyIdFieldNumber

```csharp
public const int KeyIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_PublisherGroupIdFieldNumber"></a> PublisherGroupIdFieldNumber

```csharp
public const int PublisherGroupIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_StatusFieldNumber"></a> StatusFieldNumber

```csharp
public const int StatusFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_Domain"></a> Domain

```csharp
public string Domain { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_HasDomain"></a> HasDomain

```csharp
public bool HasDomain { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_HasKeyId"></a> HasKeyId

```csharp
public bool HasKeyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_HasPublisherGroupId"></a> HasPublisherGroupId

```csharp
public bool HasPublisherGroupId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_HasStatus"></a> HasStatus

```csharp
public bool HasStatus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_KeyId"></a> KeyId

```csharp
public uint KeyId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_Parser"></a> Parser

```csharp
public static MessageParser<CMsgWebAPIKey> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgWebAPIKey](Divine.Protobufs.Steam.CMsgWebAPIKey.md)\>

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_PublisherGroupId"></a> PublisherGroupId

```csharp
public uint PublisherGroupId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_Status"></a> Status

```csharp
public uint Status { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_ClearDomain"></a> ClearDomain\(\)

```csharp
public void ClearDomain()
```

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_ClearKeyId"></a> ClearKeyId\(\)

```csharp
public void ClearKeyId()
```

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_ClearPublisherGroupId"></a> ClearPublisherGroupId\(\)

```csharp
public void ClearPublisherGroupId()
```

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_ClearStatus"></a> ClearStatus\(\)

```csharp
public void ClearStatus()
```

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_Clone"></a> Clone\(\)

```csharp
public CMsgWebAPIKey Clone()
```

#### Returns

 [CMsgWebAPIKey](Divine.Protobufs.Steam.CMsgWebAPIKey.md)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_Equals_Divine_Protobufs_Steam_CMsgWebAPIKey_"></a> Equals\(CMsgWebAPIKey\)

```csharp
public bool Equals(CMsgWebAPIKey other)
```

#### Parameters

`other` [CMsgWebAPIKey](Divine.Protobufs.Steam.CMsgWebAPIKey.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_MergeFrom_Divine_Protobufs_Steam_CMsgWebAPIKey_"></a> MergeFrom\(CMsgWebAPIKey\)

```csharp
public void MergeFrom(CMsgWebAPIKey other)
```

#### Parameters

`other` [CMsgWebAPIKey](Divine.Protobufs.Steam.CMsgWebAPIKey.md)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgWebAPIKey_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

