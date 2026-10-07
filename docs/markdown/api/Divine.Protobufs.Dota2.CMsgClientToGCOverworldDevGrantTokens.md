# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokens"></a> Class CMsgClientToGCOverworldDevGrantTokens

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverworldDevGrantTokens : IMessage<CMsgClientToGCOverworldDevGrantTokens>, IEquatable<CMsgClientToGCOverworldDevGrantTokens>, IDeepCloneable<CMsgClientToGCOverworldDevGrantTokens>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverworldDevGrantTokens](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevGrantTokens.md)

#### Implements

IMessage<CMsgClientToGCOverworldDevGrantTokens\>, 
[IEquatable<CMsgClientToGCOverworldDevGrantTokens\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverworldDevGrantTokens\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverworldDevGrantTokens\>\(CMsgClientToGCOverworldDevGrantTokens, params CMsgClientToGCOverworldDevGrantTokens\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokens__ctor"></a> CMsgClientToGCOverworldDevGrantTokens\(\)

```csharp
public CMsgClientToGCOverworldDevGrantTokens()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokens__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokens_"></a> CMsgClientToGCOverworldDevGrantTokens\(CMsgClientToGCOverworldDevGrantTokens\)

```csharp
public CMsgClientToGCOverworldDevGrantTokens(CMsgClientToGCOverworldDevGrantTokens other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevGrantTokens](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevGrantTokens.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokens_OverworldIdFieldNumber"></a> OverworldIdFieldNumber

```csharp
public const int OverworldIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokens_TokenQuantityFieldNumber"></a> TokenQuantityFieldNumber

```csharp
public const int TokenQuantityFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokens_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokens_HasOverworldId"></a> HasOverworldId

```csharp
public bool HasOverworldId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokens_OverworldId"></a> OverworldId

```csharp
public uint OverworldId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokens_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverworldDevGrantTokens> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverworldDevGrantTokens](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevGrantTokens.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokens_TokenQuantity"></a> TokenQuantity

```csharp
public CMsgOverworldTokenQuantity TokenQuantity { get; set; }
```

#### Property Value

 [CMsgOverworldTokenQuantity](Divine.Protobufs.Dota2.CMsgOverworldTokenQuantity.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokens_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokens_ClearOverworldId"></a> ClearOverworldId\(\)

```csharp
public void ClearOverworldId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokens_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverworldDevGrantTokens Clone()
```

#### Returns

 [CMsgClientToGCOverworldDevGrantTokens](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevGrantTokens.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokens_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokens_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokens_"></a> Equals\(CMsgClientToGCOverworldDevGrantTokens\)

```csharp
public bool Equals(CMsgClientToGCOverworldDevGrantTokens other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevGrantTokens](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevGrantTokens.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokens_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokens_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokens_"></a> MergeFrom\(CMsgClientToGCOverworldDevGrantTokens\)

```csharp
public void MergeFrom(CMsgClientToGCOverworldDevGrantTokens other)
```

#### Parameters

`other` [CMsgClientToGCOverworldDevGrantTokens](Divine.Protobufs.Dota2.CMsgClientToGCOverworldDevGrantTokens.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokens_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokens_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverworldDevGrantTokens_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

