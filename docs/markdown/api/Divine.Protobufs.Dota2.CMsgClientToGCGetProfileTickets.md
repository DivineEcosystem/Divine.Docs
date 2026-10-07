# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileTickets"></a> Class CMsgClientToGCGetProfileTickets

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetProfileTickets : IMessage<CMsgClientToGCGetProfileTickets>, IEquatable<CMsgClientToGCGetProfileTickets>, IDeepCloneable<CMsgClientToGCGetProfileTickets>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetProfileTickets](Divine.Protobufs.Dota2.CMsgClientToGCGetProfileTickets.md)

#### Implements

IMessage<CMsgClientToGCGetProfileTickets\>, 
[IEquatable<CMsgClientToGCGetProfileTickets\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetProfileTickets\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetProfileTickets\>\(CMsgClientToGCGetProfileTickets, params CMsgClientToGCGetProfileTickets\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileTickets__ctor"></a> CMsgClientToGCGetProfileTickets\(\)

```csharp
public CMsgClientToGCGetProfileTickets()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileTickets__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetProfileTickets_"></a> CMsgClientToGCGetProfileTickets\(CMsgClientToGCGetProfileTickets\)

```csharp
public CMsgClientToGCGetProfileTickets(CMsgClientToGCGetProfileTickets other)
```

#### Parameters

`other` [CMsgClientToGCGetProfileTickets](Divine.Protobufs.Dota2.CMsgClientToGCGetProfileTickets.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileTickets_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileTickets_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileTickets_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileTickets_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileTickets_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetProfileTickets> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetProfileTickets](Divine.Protobufs.Dota2.CMsgClientToGCGetProfileTickets.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileTickets_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileTickets_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileTickets_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetProfileTickets Clone()
```

#### Returns

 [CMsgClientToGCGetProfileTickets](Divine.Protobufs.Dota2.CMsgClientToGCGetProfileTickets.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileTickets_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileTickets_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetProfileTickets_"></a> Equals\(CMsgClientToGCGetProfileTickets\)

```csharp
public bool Equals(CMsgClientToGCGetProfileTickets other)
```

#### Parameters

`other` [CMsgClientToGCGetProfileTickets](Divine.Protobufs.Dota2.CMsgClientToGCGetProfileTickets.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileTickets_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileTickets_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetProfileTickets_"></a> MergeFrom\(CMsgClientToGCGetProfileTickets\)

```csharp
public void MergeFrom(CMsgClientToGCGetProfileTickets other)
```

#### Parameters

`other` [CMsgClientToGCGetProfileTickets](Divine.Protobufs.Dota2.CMsgClientToGCGetProfileTickets.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileTickets_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileTickets_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetProfileTickets_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

