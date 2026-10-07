# <a id="Divine_Protobufs_Dota2_CMsgOverworldTokenCount"></a> Class CMsgOverworldTokenCount

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgOverworldTokenCount : IMessage<CMsgOverworldTokenCount>, IEquatable<CMsgOverworldTokenCount>, IDeepCloneable<CMsgOverworldTokenCount>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgOverworldTokenCount](Divine.Protobufs.Dota2.CMsgOverworldTokenCount.md)

#### Implements

IMessage<CMsgOverworldTokenCount\>, 
[IEquatable<CMsgOverworldTokenCount\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgOverworldTokenCount\>, 
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
[EnumerableExtensions.In<CMsgOverworldTokenCount\>\(CMsgOverworldTokenCount, params CMsgOverworldTokenCount\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgOverworldTokenCount__ctor"></a> CMsgOverworldTokenCount\(\)

```csharp
public CMsgOverworldTokenCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldTokenCount__ctor_Divine_Protobufs_Dota2_CMsgOverworldTokenCount_"></a> CMsgOverworldTokenCount\(CMsgOverworldTokenCount\)

```csharp
public CMsgOverworldTokenCount(CMsgOverworldTokenCount other)
```

#### Parameters

`other` [CMsgOverworldTokenCount](Divine.Protobufs.Dota2.CMsgOverworldTokenCount.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgOverworldTokenCount_TokenCountFieldNumber"></a> TokenCountFieldNumber

```csharp
public const int TokenCountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldTokenCount_TokenIdFieldNumber"></a> TokenIdFieldNumber

```csharp
public const int TokenIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgOverworldTokenCount_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgOverworldTokenCount_HasTokenCount"></a> HasTokenCount

```csharp
public bool HasTokenCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldTokenCount_HasTokenId"></a> HasTokenId

```csharp
public bool HasTokenId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldTokenCount_Parser"></a> Parser

```csharp
public static MessageParser<CMsgOverworldTokenCount> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgOverworldTokenCount](Divine.Protobufs.Dota2.CMsgOverworldTokenCount.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgOverworldTokenCount_TokenCount"></a> TokenCount

```csharp
public uint TokenCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldTokenCount_TokenId"></a> TokenId

```csharp
public uint TokenId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgOverworldTokenCount_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldTokenCount_ClearTokenCount"></a> ClearTokenCount\(\)

```csharp
public void ClearTokenCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldTokenCount_ClearTokenId"></a> ClearTokenId\(\)

```csharp
public void ClearTokenId()
```

### <a id="Divine_Protobufs_Dota2_CMsgOverworldTokenCount_Clone"></a> Clone\(\)

```csharp
public CMsgOverworldTokenCount Clone()
```

#### Returns

 [CMsgOverworldTokenCount](Divine.Protobufs.Dota2.CMsgOverworldTokenCount.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldTokenCount_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldTokenCount_Equals_Divine_Protobufs_Dota2_CMsgOverworldTokenCount_"></a> Equals\(CMsgOverworldTokenCount\)

```csharp
public bool Equals(CMsgOverworldTokenCount other)
```

#### Parameters

`other` [CMsgOverworldTokenCount](Divine.Protobufs.Dota2.CMsgOverworldTokenCount.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldTokenCount_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldTokenCount_MergeFrom_Divine_Protobufs_Dota2_CMsgOverworldTokenCount_"></a> MergeFrom\(CMsgOverworldTokenCount\)

```csharp
public void MergeFrom(CMsgOverworldTokenCount other)
```

#### Parameters

`other` [CMsgOverworldTokenCount](Divine.Protobufs.Dota2.CMsgOverworldTokenCount.md)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldTokenCount_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgOverworldTokenCount_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgOverworldTokenCount_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

