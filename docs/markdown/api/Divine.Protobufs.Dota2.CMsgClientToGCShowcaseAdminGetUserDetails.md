# <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetails"></a> Class CMsgClientToGCShowcaseAdminGetUserDetails

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCShowcaseAdminGetUserDetails : IMessage<CMsgClientToGCShowcaseAdminGetUserDetails>, IEquatable<CMsgClientToGCShowcaseAdminGetUserDetails>, IDeepCloneable<CMsgClientToGCShowcaseAdminGetUserDetails>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCShowcaseAdminGetUserDetails](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminGetUserDetails.md)

#### Implements

IMessage<CMsgClientToGCShowcaseAdminGetUserDetails\>, 
[IEquatable<CMsgClientToGCShowcaseAdminGetUserDetails\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCShowcaseAdminGetUserDetails\>, 
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
[EnumerableExtensions.In<CMsgClientToGCShowcaseAdminGetUserDetails\>\(CMsgClientToGCShowcaseAdminGetUserDetails, params CMsgClientToGCShowcaseAdminGetUserDetails\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetails__ctor"></a> CMsgClientToGCShowcaseAdminGetUserDetails\(\)

```csharp
public CMsgClientToGCShowcaseAdminGetUserDetails()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetails__ctor_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetails_"></a> CMsgClientToGCShowcaseAdminGetUserDetails\(CMsgClientToGCShowcaseAdminGetUserDetails\)

```csharp
public CMsgClientToGCShowcaseAdminGetUserDetails(CMsgClientToGCShowcaseAdminGetUserDetails other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseAdminGetUserDetails](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminGetUserDetails.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetails_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetails_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetails_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetails_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetails_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCShowcaseAdminGetUserDetails> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCShowcaseAdminGetUserDetails](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminGetUserDetails.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetails_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetails_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetails_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCShowcaseAdminGetUserDetails Clone()
```

#### Returns

 [CMsgClientToGCShowcaseAdminGetUserDetails](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminGetUserDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetails_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetails_Equals_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetails_"></a> Equals\(CMsgClientToGCShowcaseAdminGetUserDetails\)

```csharp
public bool Equals(CMsgClientToGCShowcaseAdminGetUserDetails other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseAdminGetUserDetails](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminGetUserDetails.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetails_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetails_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetails_"></a> MergeFrom\(CMsgClientToGCShowcaseAdminGetUserDetails\)

```csharp
public void MergeFrom(CMsgClientToGCShowcaseAdminGetUserDetails other)
```

#### Parameters

`other` [CMsgClientToGCShowcaseAdminGetUserDetails](Divine.Protobufs.Dota2.CMsgClientToGCShowcaseAdminGetUserDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetails_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetails_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCShowcaseAdminGetUserDetails_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

