# <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContracts"></a> Class CMsgServerToGCGetGuildContracts

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCGetGuildContracts : IMessage<CMsgServerToGCGetGuildContracts>, IEquatable<CMsgServerToGCGetGuildContracts>, IDeepCloneable<CMsgServerToGCGetGuildContracts>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCGetGuildContracts](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContracts.md)

#### Implements

IMessage<CMsgServerToGCGetGuildContracts\>, 
[IEquatable<CMsgServerToGCGetGuildContracts\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCGetGuildContracts\>, 
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
[EnumerableExtensions.In<CMsgServerToGCGetGuildContracts\>\(CMsgServerToGCGetGuildContracts, params CMsgServerToGCGetGuildContracts\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContracts__ctor"></a> CMsgServerToGCGetGuildContracts\(\)

```csharp
public CMsgServerToGCGetGuildContracts()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContracts__ctor_Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContracts_"></a> CMsgServerToGCGetGuildContracts\(CMsgServerToGCGetGuildContracts\)

```csharp
public CMsgServerToGCGetGuildContracts(CMsgServerToGCGetGuildContracts other)
```

#### Parameters

`other` [CMsgServerToGCGetGuildContracts](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContracts.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContracts_AccountIdsFieldNumber"></a> AccountIdsFieldNumber

```csharp
public const int AccountIdsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContracts_AccountIds"></a> AccountIds

```csharp
public RepeatedField<uint> AccountIds { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContracts_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContracts_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCGetGuildContracts> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCGetGuildContracts](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContracts.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContracts_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContracts_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCGetGuildContracts Clone()
```

#### Returns

 [CMsgServerToGCGetGuildContracts](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContracts.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContracts_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContracts_Equals_Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContracts_"></a> Equals\(CMsgServerToGCGetGuildContracts\)

```csharp
public bool Equals(CMsgServerToGCGetGuildContracts other)
```

#### Parameters

`other` [CMsgServerToGCGetGuildContracts](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContracts.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContracts_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContracts_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContracts_"></a> MergeFrom\(CMsgServerToGCGetGuildContracts\)

```csharp
public void MergeFrom(CMsgServerToGCGetGuildContracts other)
```

#### Parameters

`other` [CMsgServerToGCGetGuildContracts](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContracts.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContracts_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContracts_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContracts_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

