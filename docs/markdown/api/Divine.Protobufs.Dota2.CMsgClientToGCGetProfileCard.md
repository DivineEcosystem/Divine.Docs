# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileCard"></a> Class CMsgClientToGCGetProfileCard

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetProfileCard : IMessage<CMsgClientToGCGetProfileCard>, IEquatable<CMsgClientToGCGetProfileCard>, IDeepCloneable<CMsgClientToGCGetProfileCard>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetProfileCard](Divine.Protobufs.Dota2.CMsgClientToGCGetProfileCard.md)

#### Implements

IMessage<CMsgClientToGCGetProfileCard\>, 
[IEquatable<CMsgClientToGCGetProfileCard\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetProfileCard\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetProfileCard\>\(CMsgClientToGCGetProfileCard, params CMsgClientToGCGetProfileCard\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileCard__ctor"></a> CMsgClientToGCGetProfileCard\(\)

```csharp
public CMsgClientToGCGetProfileCard()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileCard__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetProfileCard_"></a> CMsgClientToGCGetProfileCard\(CMsgClientToGCGetProfileCard\)

```csharp
public CMsgClientToGCGetProfileCard(CMsgClientToGCGetProfileCard other)
```

#### Parameters

`other` [CMsgClientToGCGetProfileCard](Divine.Protobufs.Dota2.CMsgClientToGCGetProfileCard.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileCard_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileCard_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileCard_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileCard_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileCard_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetProfileCard> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetProfileCard](Divine.Protobufs.Dota2.CMsgClientToGCGetProfileCard.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileCard_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileCard_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileCard_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetProfileCard Clone()
```

#### Returns

 [CMsgClientToGCGetProfileCard](Divine.Protobufs.Dota2.CMsgClientToGCGetProfileCard.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileCard_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileCard_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetProfileCard_"></a> Equals\(CMsgClientToGCGetProfileCard\)

```csharp
public bool Equals(CMsgClientToGCGetProfileCard other)
```

#### Parameters

`other` [CMsgClientToGCGetProfileCard](Divine.Protobufs.Dota2.CMsgClientToGCGetProfileCard.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileCard_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileCard_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetProfileCard_"></a> MergeFrom\(CMsgClientToGCGetProfileCard\)

```csharp
public void MergeFrom(CMsgClientToGCGetProfileCard other)
```

#### Parameters

`other` [CMsgClientToGCGetProfileCard](Divine.Protobufs.Dota2.CMsgClientToGCGetProfileCard.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileCard_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileCard_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileCard_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

