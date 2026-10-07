# <a id="Divine_Protobufs_Dota2_CMsgGCToClientOverwatchCasesAvailable"></a> Class CMsgGCToClientOverwatchCasesAvailable

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientOverwatchCasesAvailable : IMessage<CMsgGCToClientOverwatchCasesAvailable>, IEquatable<CMsgGCToClientOverwatchCasesAvailable>, IDeepCloneable<CMsgGCToClientOverwatchCasesAvailable>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientOverwatchCasesAvailable](Divine.Protobufs.Dota2.CMsgGCToClientOverwatchCasesAvailable.md)

#### Implements

IMessage<CMsgGCToClientOverwatchCasesAvailable\>, 
[IEquatable<CMsgGCToClientOverwatchCasesAvailable\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientOverwatchCasesAvailable\>, 
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
[EnumerableExtensions.In<CMsgGCToClientOverwatchCasesAvailable\>\(CMsgGCToClientOverwatchCasesAvailable, params CMsgGCToClientOverwatchCasesAvailable\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientOverwatchCasesAvailable__ctor"></a> CMsgGCToClientOverwatchCasesAvailable\(\)

```csharp
public CMsgGCToClientOverwatchCasesAvailable()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientOverwatchCasesAvailable__ctor_Divine_Protobufs_Dota2_CMsgGCToClientOverwatchCasesAvailable_"></a> CMsgGCToClientOverwatchCasesAvailable\(CMsgGCToClientOverwatchCasesAvailable\)

```csharp
public CMsgGCToClientOverwatchCasesAvailable(CMsgGCToClientOverwatchCasesAvailable other)
```

#### Parameters

`other` [CMsgGCToClientOverwatchCasesAvailable](Divine.Protobufs.Dota2.CMsgGCToClientOverwatchCasesAvailable.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientOverwatchCasesAvailable_ExpireTimeFieldNumber"></a> ExpireTimeFieldNumber

```csharp
public const int ExpireTimeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientOverwatchCasesAvailable_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientOverwatchCasesAvailable_ExpireTime"></a> ExpireTime

```csharp
public uint ExpireTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientOverwatchCasesAvailable_HasExpireTime"></a> HasExpireTime

```csharp
public bool HasExpireTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientOverwatchCasesAvailable_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientOverwatchCasesAvailable> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientOverwatchCasesAvailable](Divine.Protobufs.Dota2.CMsgGCToClientOverwatchCasesAvailable.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientOverwatchCasesAvailable_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientOverwatchCasesAvailable_ClearExpireTime"></a> ClearExpireTime\(\)

```csharp
public void ClearExpireTime()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientOverwatchCasesAvailable_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientOverwatchCasesAvailable Clone()
```

#### Returns

 [CMsgGCToClientOverwatchCasesAvailable](Divine.Protobufs.Dota2.CMsgGCToClientOverwatchCasesAvailable.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientOverwatchCasesAvailable_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientOverwatchCasesAvailable_Equals_Divine_Protobufs_Dota2_CMsgGCToClientOverwatchCasesAvailable_"></a> Equals\(CMsgGCToClientOverwatchCasesAvailable\)

```csharp
public bool Equals(CMsgGCToClientOverwatchCasesAvailable other)
```

#### Parameters

`other` [CMsgGCToClientOverwatchCasesAvailable](Divine.Protobufs.Dota2.CMsgGCToClientOverwatchCasesAvailable.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientOverwatchCasesAvailable_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientOverwatchCasesAvailable_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientOverwatchCasesAvailable_"></a> MergeFrom\(CMsgGCToClientOverwatchCasesAvailable\)

```csharp
public void MergeFrom(CMsgGCToClientOverwatchCasesAvailable other)
```

#### Parameters

`other` [CMsgGCToClientOverwatchCasesAvailable](Divine.Protobufs.Dota2.CMsgGCToClientOverwatchCasesAvailable.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientOverwatchCasesAvailable_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientOverwatchCasesAvailable_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientOverwatchCasesAvailable_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

