# <a id="Divine_Protobufs_Dota2_CMsgBingoTokens"></a> Class CMsgBingoTokens

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgBingoTokens : IMessage<CMsgBingoTokens>, IEquatable<CMsgBingoTokens>, IDeepCloneable<CMsgBingoTokens>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgBingoTokens](Divine.Protobufs.Dota2.CMsgBingoTokens.md)

#### Implements

IMessage<CMsgBingoTokens\>, 
[IEquatable<CMsgBingoTokens\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgBingoTokens\>, 
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
[EnumerableExtensions.In<CMsgBingoTokens\>\(CMsgBingoTokens, params CMsgBingoTokens\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgBingoTokens__ctor"></a> CMsgBingoTokens\(\)

```csharp
public CMsgBingoTokens()
```

### <a id="Divine_Protobufs_Dota2_CMsgBingoTokens__ctor_Divine_Protobufs_Dota2_CMsgBingoTokens_"></a> CMsgBingoTokens\(CMsgBingoTokens\)

```csharp
public CMsgBingoTokens(CMsgBingoTokens other)
```

#### Parameters

`other` [CMsgBingoTokens](Divine.Protobufs.Dota2.CMsgBingoTokens.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgBingoTokens_TokenCountFieldNumber"></a> TokenCountFieldNumber

```csharp
public const int TokenCountFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgBingoTokens_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgBingoTokens_HasTokenCount"></a> HasTokenCount

```csharp
public bool HasTokenCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBingoTokens_Parser"></a> Parser

```csharp
public static MessageParser<CMsgBingoTokens> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgBingoTokens](Divine.Protobufs.Dota2.CMsgBingoTokens.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgBingoTokens_TokenCount"></a> TokenCount

```csharp
public uint TokenCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgBingoTokens_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBingoTokens_ClearTokenCount"></a> ClearTokenCount\(\)

```csharp
public void ClearTokenCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgBingoTokens_Clone"></a> Clone\(\)

```csharp
public CMsgBingoTokens Clone()
```

#### Returns

 [CMsgBingoTokens](Divine.Protobufs.Dota2.CMsgBingoTokens.md)

### <a id="Divine_Protobufs_Dota2_CMsgBingoTokens_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBingoTokens_Equals_Divine_Protobufs_Dota2_CMsgBingoTokens_"></a> Equals\(CMsgBingoTokens\)

```csharp
public bool Equals(CMsgBingoTokens other)
```

#### Parameters

`other` [CMsgBingoTokens](Divine.Protobufs.Dota2.CMsgBingoTokens.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgBingoTokens_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgBingoTokens_MergeFrom_Divine_Protobufs_Dota2_CMsgBingoTokens_"></a> MergeFrom\(CMsgBingoTokens\)

```csharp
public void MergeFrom(CMsgBingoTokens other)
```

#### Parameters

`other` [CMsgBingoTokens](Divine.Protobufs.Dota2.CMsgBingoTokens.md)

### <a id="Divine_Protobufs_Dota2_CMsgBingoTokens_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgBingoTokens_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgBingoTokens_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

